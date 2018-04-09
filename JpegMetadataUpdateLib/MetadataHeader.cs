using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpegMetadataUpdateLib
{
    public interface IMetadataHeader
    {
        bool Supported(string name);
        MetadataField CreateByName(string name);
    }

    public abstract class MetadataHeader : IMetadataHeader
    {
        private static Dictionary<string, MetadataField> SupportedTagsDictionary;

        public bool Supported(string name)
        {
            if (SupportedTagsDictionary.ContainsKey(name.ToUpper()))
            {
                return true;
            }
            return false;
        }

        public MetadataField CreateByName(string name)
        {
            return new MetadataField(SupportedTagsDictionary[name.ToUpper()]);
        }
    }
}
