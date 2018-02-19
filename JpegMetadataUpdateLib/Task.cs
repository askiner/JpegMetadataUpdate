using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpegMetadataUpdateLib
{
    public enum MetadataAccessType { READ = 1, WRITE, READWRITE };

    public class Task
    {
        private List<MetadataField> queries = new List<MetadataField>();

        public MetadataAccessType AccessType { get; set; }

        public List<MetadataField> Queries
        {
            get
            {
                return queries;
            }
        }

        public void AddMetadataFieldToQuery(MetadataField field)
        {
            queries.Add(field);
        }
    }
}
