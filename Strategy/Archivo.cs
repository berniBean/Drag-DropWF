using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Archivo : IDirectionService
    {
        public FileInfo fileInfo { get; set; }

        public void fileDirection(string[] dir)
        {
            fileInfo = new FileInfo(string.Join(" ", dir));            
        }
    }
}
