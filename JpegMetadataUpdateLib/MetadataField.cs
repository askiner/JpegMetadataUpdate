using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpegMetadataUpdateLib
{
    public enum MetaHeaders { EXIF, IPTC, XMP };

    public class MetadataField
    {
        public string Header { get; set; }
        public string Name { get; set; }
        public string ValueString { get; set; }
        public string ValueInt { get; set; }
        public string FieldQuery { get; set; }
    }
}
