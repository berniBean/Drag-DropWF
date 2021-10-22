using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ArchivoFile : InfoFiles
    {

        public ArchivoFile(IDirectionService DirectionService, IDataFileService DataFileService, ISingleFileService SingleFileService) : base(DirectionService, DataFileService, SingleFileService)
        {
            DirectionService = new Archivo();
            DataFileService = new NombreArchivos();
            SingleFileService = new NombreArchivo();
        }
    }
}
