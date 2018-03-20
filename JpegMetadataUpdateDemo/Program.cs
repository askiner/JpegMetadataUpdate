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

            JpegMetadataUpdateLib.Task task = new JpegMetadataUpdateLib.Task();
            JpegMetadataUpdateLib.IMetadataField fld = MetadataFieldFactory.Create(HeaderType.IPTC, "Record value");

            //Record Version

            //fld.FieldQuery = "/app13/irb/8bimiptc/iptc/Caption";

            task.AddMetadataFieldToQuery(fld);

            using(Process proc = new Process(args[0], task))
            {
                Console.WriteLine("Start processing image {0}", proc.Filename);
                Console.WriteLine("End processing image {0}", proc.Filename);
                Console.WriteLine("Exit processing image {0}", proc.Filename);
            }
        }
    }
}
