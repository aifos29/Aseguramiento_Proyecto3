using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 
namespace Proyecto3_Clases
{
    public class FileChecker
    {
        IExtensionNanager objmanager = null;
        //Default constructor  
        public FileChecker()
        {
            objmanager = new ExtensionManager();
        }
        //parameterized constructor  
        public FileChecker(IExtensionNanager tmpManager)
        {
            objmanager = tmpManager;
        }

        public Boolean CheckFile(String FileName)
        {
            return objmanager.CheckExtension(FileName);
        }
    }


    public class StubExtensionManager : IExtensionNanager
    {
        public bool CheckExtension(string FileName)
        {
            return true;
        }
    }
}

