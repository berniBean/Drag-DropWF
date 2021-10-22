using DragDrop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class NombreArchivos : IDataFileService
    {
        private DirectoryInfo direction;
        public List<Pdfs> itemPdf { get; set; } = new List<Pdfs>();

        public List<Pdfs> dataFile(string ruta)
        {
            direction = new DirectoryInfo(ruta);

            foreach (var fi in direction.GetFiles())
            {
                Pdfs item = new Pdfs(fi.Name);
                itemPdf.Add(item);
            }

            return itemPdf;
        }

    }
}
