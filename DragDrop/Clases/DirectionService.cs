using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragDrop.Clases
{

        public class DirectionService
        {
            public List<Pdfs> itemPdf { get; set; } = new List<Pdfs>();
            public List<Pdfs> GetFileName(DirectoryInfo ruta)
            {
                foreach (var fi in ruta.GetFiles())
                {

                    Pdfs item = new Pdfs(fi.Name);

                    itemPdf.Add(item);

                }

                return itemPdf;
            }
        }
    
}
