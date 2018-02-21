using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpegMetadataUpdateLib
{
    public class IPTCMetadataField: IMetadataField
    {
        public string Name { get; set; }

        public IPTCMetadataField(string name)
        {
            Name = name;
        }

        public static IEnumerable<string> SupportedTags
        {
            get
            {
                return new List<string> { "Record Version" };
            }
        }

        public static bool Supported(string name)
        {
            return SupportedTags.Contains(name, StringComparer.OrdinalIgnoreCase);
        }
    }
}
