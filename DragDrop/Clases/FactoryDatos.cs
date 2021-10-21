using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragDrop
{
    public class FactoryDatos
    {
        private static List<Pdfs> pdfs;

        public static Pdfs CrearCpdfs(string nombre)
        {
            Pdfs pdfs = new Pdfs();
            pdfs._name = nombre;
            return pdfs;
        }


    }
}
