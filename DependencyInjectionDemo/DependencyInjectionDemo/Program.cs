using CommonDataModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace DependencyInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new UnityContainer();
            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            var containerName = Console.ReadLine();
            IUnityContainer container = new UnityContainer().LoadConfiguration(section, containerName);


            var vat = container.Resolve<IVatCalculator>();

            Console.WriteLine(vat.GetVatPercentage());
            Console.ReadLine();
        }
    }
}
