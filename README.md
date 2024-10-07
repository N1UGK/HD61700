This project is a disassembler for the HD61700 which is used in the Casio PB-1000.  I needed to create this disassembler to discover how some of the subroutines in ROM worked with the hardware.

I searched for an exisitng disassembler and found some source posted (links below).  However, it was compiled quite awhile ago and did not run on Windows 10.  I used this source as the basis for this disassembler.

Disassembler modified from source posted here:
http://www.emmanuel.hp41.eu/ti/ti-74/pc/pgm2b74/programs.htm

which referenced the source hosted here:
http://www.pisi.com.pl/piotr433/pb1000ee.htm

Usage: HD61700.exe -i infile.bin [-a address] [-w] -o outfile.txt

The optional switch -a starting address can be specified as a hexadecimal number without any prefixes. If omitted, a default value 0000 is assumed.
The optional switch -w selects the 16-bit (word-size) memory access (applicaple for the microprocessor internal 16-bit ROM). If omitted, a default 8-bit (byte-size) memory access is assumed.

I can be contacted ar jbertier@arrl.net
