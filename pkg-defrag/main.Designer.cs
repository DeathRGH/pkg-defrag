namespace pkg_defrag
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btn_selectImage = new Button();
			box_imageOffset = new TextBox();
			label_imageOffset = new Label();
			label_chunkSize = new Label();
			box_chunkSize = new TextBox();
			label_padSize = new Label();
			box_padding = new TextBox();
			btn_startExtract = new Button();
			label_imageName = new Label();
			SuspendLayout();
			// 
			// btn_selectImage
			// 
			btn_selectImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btn_selectImage.Location = new Point(12, 12);
			btn_selectImage.Name = "btn_selectImage";
			btn_selectImage.Size = new Size(300, 23);
			btn_selectImage.TabIndex = 0;
			btn_selectImage.Text = "Select Image...";
			btn_selectImage.UseVisualStyleBackColor = true;
			btn_selectImage.Click += btn_selectImage_Click;
			// 
			// box_imageOffset
			// 
			box_imageOffset.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			box_imageOffset.Location = new Point(12, 120);
			box_imageOffset.Name = "box_imageOffset";
			box_imageOffset.Size = new Size(300, 23);
			box_imageOffset.TabIndex = 1;
			box_imageOffset.Text = "0x44D5FB8000";
			// 
			// label_imageOffset
			// 
			label_imageOffset.AutoSize = true;
			label_imageOffset.Location = new Point(12, 102);
			label_imageOffset.Name = "label_imageOffset";
			label_imageOffset.Size = new Size(137, 15);
			label_imageOffset.TabIndex = 2;
			label_imageOffset.Text = "Image Offset (PKG Start):";
			// 
			// label_chunkSize
			// 
			label_chunkSize.AutoSize = true;
			label_chunkSize.Location = new Point(12, 146);
			label_chunkSize.Name = "label_chunkSize";
			label_chunkSize.Size = new Size(68, 15);
			label_chunkSize.TabIndex = 4;
			label_chunkSize.Text = "Chunk Size:";
			// 
			// box_chunkSize
			// 
			box_chunkSize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			box_chunkSize.Location = new Point(12, 164);
			box_chunkSize.Name = "box_chunkSize";
			box_chunkSize.Size = new Size(300, 23);
			box_chunkSize.TabIndex = 3;
			box_chunkSize.Text = "0x28000000";
			// 
			// label_padSize
			// 
			label_padSize.AutoSize = true;
			label_padSize.Location = new Point(12, 190);
			label_padSize.Name = "label_padSize";
			label_padSize.Size = new Size(149, 15);
			label_padSize.TabIndex = 6;
			label_padSize.Text = "Padding Size (data to skip):";
			// 
			// box_padding
			// 
			box_padding.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			box_padding.Location = new Point(12, 208);
			box_padding.Name = "box_padding";
			box_padding.Size = new Size(300, 23);
			box_padding.TabIndex = 5;
			box_padding.Text = "0x6400000";
			// 
			// btn_startExtract
			// 
			btn_startExtract.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btn_startExtract.Location = new Point(12, 269);
			btn_startExtract.Name = "btn_startExtract";
			btn_startExtract.Size = new Size(300, 23);
			btn_startExtract.TabIndex = 7;
			btn_startExtract.Text = "Extract";
			btn_startExtract.UseVisualStyleBackColor = true;
			btn_startExtract.Click += btn_startExtract_Click;
			// 
			// label_imageName
			// 
			label_imageName.AutoSize = true;
			label_imageName.Location = new Point(12, 38);
			label_imageName.Name = "label_imageName";
			label_imageName.Size = new Size(108, 15);
			label_imageName.TabIndex = 8;
			label_imageName.Text = "No image selected!";
			// 
			// main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(324, 308);
			Controls.Add(label_imageName);
			Controls.Add(btn_startExtract);
			Controls.Add(label_padSize);
			Controls.Add(box_padding);
			Controls.Add(label_chunkSize);
			Controls.Add(box_chunkSize);
			Controls.Add(label_imageOffset);
			Controls.Add(box_imageOffset);
			Controls.Add(btn_selectImage);
			Name = "main";
			Text = "PKG Defrag";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_selectImage;
		private TextBox box_imageOffset;
		private Label label_imageOffset;
		private Label label_chunkSize;
		private TextBox box_chunkSize;
		private Label label_padSize;
		private TextBox box_padding;
		private Button btn_startExtract;
		private Label label_imageName;
	}
}
