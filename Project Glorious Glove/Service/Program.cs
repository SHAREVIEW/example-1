using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace Service
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            var servicesToRun = new ServiceBase[]
            {
                new HelperService()
            };
            ServiceBase.Run(servicesToRun);
        }
    }
}
