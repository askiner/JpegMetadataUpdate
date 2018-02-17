using System;
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

        public Process(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                throw new ArgumentNullException("filename", "Mandatory parameter is not specify");

            Filename = filename;
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
