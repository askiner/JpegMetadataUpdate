using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpegMetadataUpdateLib
{
    public class MetadataField
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Query { get; set; }

        // public MetadataField() { }

        public MetadataField(MetadataField _field)
        {
            Name = _field.Name;
            Value = _field.Value;
            Query = _field.Query;
        }

        public MetadataField(string _name, string _value, string _query)
        {
            Name = _name;
            Value = _value;
            Query = _query;
        }
    }
}