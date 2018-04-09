using System;
using System.IO;
using System.Windows.Media.Imaging;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpegMetadataUpdateLib
{
    public class Process: IDisposable
    {
        private bool disposed = false;

        public string Filename { get; set; }

        public Process(string filepath, Task task)
        {
            if (string.IsNullOrEmpty(filepath))
                throw new ArgumentNullException("filename", "Mandatory parameter is not specify");

            Filename = filepath;

            // obtain later
            FileAccess accessType = FileAccess.Read;

            if (task.AccessType == MetadataAccessType.WRITE)
                accessType = FileAccess.Write;
            if (task.AccessType == MetadataAccessType.READWRITE)
                accessType = FileAccess.ReadWrite;

            string _orientationQuery = "/Text/Description";

            using (FileStream fileStream = new FileStream(filepath, FileMode.Open, accessType))
            {
                BitmapFrame bitmapFrame = BitmapFrame.Create(fileStream, BitmapCreateOptions.DelayCreation, BitmapCacheOption.None);
                BitmapMetadata bitmapMetadata = bitmapFrame.Metadata as BitmapMetadata;

                // read
                if ((bitmapMetadata != null))
                {
                    foreach (MetadataField fld in task.Queries)
                    {
                        if (bitmapMetadata.ContainsQuery(fld.Query))
                        {
                            object o = bitmapMetadata.GetQuery(fld.Query);

                            if (o != null)
                            {
                                //fld.ValueString = o as string;
                            }
                        }

                    }
                }

            }

        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
