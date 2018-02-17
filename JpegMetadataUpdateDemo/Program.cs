using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JpegMetadataUpdateLib;

namespace JpegMetadataUpdateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** DEMO STARTS *****");

            using(Process proc = new Process("<filename>"))
            {
                Console.WriteLine("Start processing image {0}", proc.Filename);
                Console.WriteLine("End processing image {0}", proc.Filename);
                Console.WriteLine("Exit processing image {0}", proc.Filename);
            }
        }
    }
}
