using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpegMetadataUpdateLib
{
    //public static class MetadataFactory
    //{
    //    private static Dictionary<string, MetadataField> IPTCSupportedTagsDictionary = 
    //        new Dictionary<string, MetadataField>()
    //    {
    //        { "CAPTION-ABSTRACT", (new MetadataField("Caption-Abstract", null, "/ifd/irb/8bimiptc/iptc/str=Caption") ) }
    //    };

    //    public static bool Supported(string name)
    //    {
    //        if (IPTCSupportedTagsDictionary.ContainsKey(name.ToUpper()))
    //        {
    //            return true;
    //        }
    //        return false;
    //    }

    //    public static MetadataField CreateByName(string name)
    //    {
    //        return new MetadataField(IPTCSupportedTagsDictionary[name.ToUpper()]);
    //    }
    //}

    //public class IPTCMetadataField : MetadataField
    //{
    //    public IPTCMetadataField(string name)
    //    {
    //        Name = name;            
    //    }

    //    public new bool Supported
    //    {
    //        get
    //        {
    //            if (IPTCSupportedTags.Supported(Name))
    //                return true;
    //            else
    //                return false;
    //        }
    //    }

    //    //public static IEnumerable<string> SupportedTags
    //    //{
    //    //    get
    //    //    {
    //    //        return new List<string> {
    //    //            "Record Version",
    //    //            "FixtureIdentifier",
    //    //            "ContentLocationCode"

    //    //        };
    //    //    }
    //    //}

    //    //public static bool Supported(string name)
    //    //{
    //    //    return SupportedTags.Contains(name, StringComparer.OrdinalIgnoreCase);
    //    //}
    //}
}
