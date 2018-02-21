using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpegMetadataUpdateLib
{
    public enum HeaderType { IPTC }

    public static class MetadataFieldFactory
    {
        public static IMetadataField Create(HeaderType headerType, string name)
        {
            if (headerType == HeaderType.IPTC)

                if (IPTCMetadataField.Supported(name)){
                    return new IPTCMetadataField(name);
                }

            throw new NotSupportedException();
        }
    }
}
