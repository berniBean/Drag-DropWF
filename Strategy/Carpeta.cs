using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Carpeta : IDirectionService
    {
        public DirectoryInfo archivos { get; set; }
        public void fileDirection(string[] dir)
        {
            archivos = new DirectoryInfo(string.Join(" ", dir));            
        }

        public string TypeFile()
        {
            return FileSystemInfoAttributes(archivos);
        }

        private string FileSystemInfoAttributes(FileSystemInfo fsi)
        {
            string entryType = "File";

            // Determine if entry is really a directory
            if ((fsi.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                entryType = "Directory";
            }
            return entryType;
        }
    }
}
