using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpegMetadataUpdateLib
{
    public class IPTCHeader: MetadataHeader
    {
        public IPTCHeader()
        {
            SupportedTagsDictionary = new Dictionary<string, MetadataField>();

            SupportedTagsDictionary.Add(
                "CAPTION-ABSTRACT",
                new MetadataField("Caption-Abstract", null, "/ifd/irb/8bimiptc/iptc/str=Caption") );
        }
    }
}
