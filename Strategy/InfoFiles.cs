using DragDrop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class InfoFiles
    {
        public string[] dir { get; set; }
        private IDirectionService _directionService;
        private IDataFileService _dataFileService;
        private ISingleFileService _singleFileService;

        public InfoFiles(IDirectionService DirectionService, IDataFileService DataFileService, ISingleFileService SingleFileService)
        {
            _directionService = DirectionService;
            _dataFileService = DataFileService;
            _singleFileService = SingleFileService;
        }

        public void performDirection()
        {
            _directionService.fileDirection(dir);
            
        }

        public List<Pdfs> performNameFiles()
        {
            return _dataFileService.dataFile(string.Join(" ", dir));
            
        }

        public FileInfo performSingleFileData()
        {
            return _singleFileService.SingleFileData(string.Join(" ", dir));
        }
    }
}
