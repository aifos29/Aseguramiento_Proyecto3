﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_Clases
{
    public interface IServiceProvider
    {
        void extensionService(String fileName);
    }


    public class MockExtensionService : IServiceProvider
    {
        public string ErrorMessage = null;
        public void extensionService(string fileName)
        {
            if (fileName.Split('.')[1] != "json")
            {
                ErrorMessage = "Tipo Incorrecto de Archivo";
            }
        }
    }

    public class ExtensionManager : IServiceProvider
    {
        public void extensionService(string fileName)
        {
            throw new NotImplementedException();
        }
    }

    public class ExtensionAnalyzer
    {
        public IServiceProvider provider = null;
        public ExtensionAnalyzer(IServiceProvider tmpProvider)
        {
            provider = tmpProvider;
        }

        public void ExtensionCheck(string fileName)
        {
            provider.extensionService(fileName);
        }
    }
}
