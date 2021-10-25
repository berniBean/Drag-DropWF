using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ChocoPdfs
    {
        public ChocoPdfs(string name, string fullName)
        {
            _name = name;
            _fullName = fullName;
            
        }
        public ChocoPdfs()
        {

        }
        public string _name { get; set; }
        public string _fullName { get; set; }
        
    }
}
