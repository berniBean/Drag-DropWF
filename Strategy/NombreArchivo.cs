using DragDrop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class NombreArchivo : ISingleFileService
    {
        private FileInfo direction { get; set; }

        public FileInfo SingleFileData(string ruta)
        {
            direction = new FileInfo(ruta);
           
            return direction;
            
        }
    }
}
