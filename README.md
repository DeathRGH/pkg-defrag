# pkg-defrag

This simple tool allows you to defragment and extract pkg files from PS4 HDD dumps.<br>
It has been field tested as has proven helpful in successfully recovering multiple pkgs from testkits!

# Extracting The User Partition
Use 7zip or a similar tool to extract `12.img` from the dumped HDD image.<br>
This is your user partition.

# Finding PKG Offsets
Scan the extracted but still encryted user partiton with HxD or a similar tool for PKG headers.
```
7F 43 4E 54 00 00 00   .CNT...
```
Make sure you don't use any of the known decryption tools as large PKG files are not encrypted.<br>
They end up getting overwritten with garbage data if you try to decrypt the user partition.

# Chunk Size And Padding
The chunk size can be found fairly easy by looking for a bigger block thats all 00 or other obvious garbage data followed by all 00's.<br>
The start of the PKG to the end of the zero block is the chunk size.<br>
The padding is the size of the garbage data to be skipped (the zero/garbage block).<br>
<br>
Padding sizes found during testing were `0xBA0000` or `0x6400000`.<br>
Once you found the padding and chunk size it will most likely be the same for all pkgs in the dump.

# Contributing
Feel free to open a pull request if you have some good ideas for auto size detection or want to implement header, boundry or other error checks. This was written in 5-10 minutes so its very basic currently.
