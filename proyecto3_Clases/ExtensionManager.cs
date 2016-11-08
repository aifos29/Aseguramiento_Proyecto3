using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_Clases
{
    public class ExtensionManager : IExtensionNanager
    {
        public bool CheckExtension(string FileName)
        {
            //Some complex business logic might goes here. May be DB operation or file system handling  
            return false;
        }
    }
}
