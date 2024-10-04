using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Disassembler modified from source posted here:
 * http://www.emmanuel.hp41.eu/ti/ti-74/pc/pgm2b74/programs.htm
 * which referenced the source hosted here:
 * http://www.pisi.com.pl/piotr433/pb1000ee.htm
 * 
 * 
Usage: hd61_dis.com infile.bin [address] [/w] > outfile.txt

The optional starting address can be specified as a hexadecimal number without any prefixes. If omitted, a default value 0000 is assumed.
The optional switch /w selects the 16-bit (word-size) memory access (applicaple for the microprocessor internal 16-bit ROM). If omitted, a default 8-bit (byte-size) memory access is assumed.

 */

namespace HD61700
{
    class Program
    {
        static int Main(string[] args)
        {
            int x;
            uint i;

            if (args == null || args.Length < 2)
            {
                Console.WriteLine("No input file specified.");

                return 1;
            }

            string inputFileName = args[0];

            if (!File.Exists(inputFileName))
            {
                Console.WriteLine($"Input file {inputFileName} was not found.");

                return 2;
            }



            return 0;
        }
    }
 }
