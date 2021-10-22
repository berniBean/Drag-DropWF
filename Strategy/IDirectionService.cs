using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IDirectionService
    {
        public void fileDirection(string[] dir);
        public string TypeFile();
    }
}
