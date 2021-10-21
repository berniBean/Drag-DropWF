using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragDrop.Clases
{
    public class DirFiles
    {
        public DirectoryInfo archivos { get; set; }

        public DirectoryInfo direccionArchivos(string[] dir)
        {
            archivos = new DirectoryInfo(string.Join(" ", dir));

            return archivos;
        }
    }
}
