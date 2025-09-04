using System.Text;

namespace pkg_defrag
{
	public partial class main : Form
	{
		string? imagePath = null;

		public main()
		{
			InitializeComponent();
		}

		private void btn_selectImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				imagePath = ofd.FileName;
				label_imageName.Text = ofd.SafeFileName;
			}
		}

		private void btn_startExtract_Click(object sender, EventArgs e)
		{
			if (imagePath == null)
			{
				MessageBox.Show("Select a image first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			long imgOffset = Convert.ToInt64(box_imageOffset.Text, 16);

			using FileStream imgStream = new FileStream(imagePath, FileMode.Open);

			// read pkg name
			imgStream.Seek(imgOffset, SeekOrigin.Begin);
			imgStream.Seek(0x40, SeekOrigin.Current);
			byte[] nameBytes = new byte[0x24];
			imgStream.Read(nameBytes, 0, 0x24);
			string pkgName = Encoding.ASCII.GetString(nameBytes);

			// read pkg size
			long pkgFileSize = -1;
			imgStream.Seek(imgOffset, SeekOrigin.Begin);
			imgStream.Seek(0x430, SeekOrigin.Current);
			byte[] fileSizeBytes = new byte[8];
			imgStream.Read(fileSizeBytes, 0, 8);
			Array.Reverse(fileSizeBytes);
			pkgFileSize = BitConverter.ToInt64(fileSizeBytes, 0);

			if (pkgFileSize == -1)
			{
				MessageBox.Show("Selected offset does not point to a pkg file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (MessageBox.Show($"Do you want to extract {pkgName} with file size 0x{pkgFileSize:X}?", "Extract", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			SaveFileDialog sfd = new SaveFileDialog();
			sfd.FileName = $"{pkgName}.pkg";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				long bytesLeft = pkgFileSize;
				int copyBufferSize = 0;

				int chunkSize = Convert.ToInt32(box_chunkSize.Text, 16);
				int padding = Convert.ToInt32(box_padding.Text, 16);

				byte[] copyBuffer = new byte[chunkSize];

				using FileStream pkgStream = new FileStream(sfd.FileName, FileMode.Create);

				imgStream.Seek(imgOffset, SeekOrigin.Begin);

				while (bytesLeft > 0)
				{
					if (bytesLeft > chunkSize)
					{
						copyBufferSize = chunkSize;
						bytesLeft -= chunkSize;
					}
					else
					{
						copyBufferSize = (int)bytesLeft;
						bytesLeft -= bytesLeft;
					}

					// copy full chunk size from image to our new pkg file
					imgStream.Read(copyBuffer, 0, copyBufferSize);

					pkgStream.Write(copyBuffer, 0, copyBufferSize);

					// advance only the image stream by the padding
					imgStream.Seek(padding, SeekOrigin.Current);
				}
			}

			MessageBox.Show("Done");
		}
	}
}
