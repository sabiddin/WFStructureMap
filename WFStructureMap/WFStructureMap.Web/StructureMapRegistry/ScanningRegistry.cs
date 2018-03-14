using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WFStructureMap.Web.Implementations;
using WFStructureMap.Web.Interfaces;
using WFStructureMap.Data;
using WFStructureMap.Business;

namespace WFStructureMap.Web.StructureMapRegistry
{
    public class ScanningRegistry : Registry
    {
        public ScanningRegistry()
        {
            // Usually this value should be taken from web.config, but it's hardcoded here for simplicity
            var databaseConnectionString = "testconnectionstring";

            Scan(x =>
            {
                x.Assembly("WFStructureMap.Web");
                x.Assembly("WFStructureMap.Data");
                x.Assembly("WFStructureMap.Business");
                x.IncludeNamespace("WFStructureMap.Web.Interfaces");
                x.IncludeNamespace("WFStructureMap.Web.Implementations");               
                x.WithDefaultConventions();
            });

            Policies.SetAllProperties(y => y.WithAnyTypeFromNamespace("WFStructureMap.Web.Interfaces"));
            Policies.SetAllProperties(y => y.WithAnyTypeFromNamespace("WFStructureMap.Web.Implementations"));
            Policies.SetAllProperties(y => y.WithAnyTypeFromNamespace("WFStructureMap.Data"));
            Policies.SetAllProperties(y=> y.WithAnyTypeFromNamespace("WFStructureMap.Business"));
            //Policies.SetAllProperties(y => y.WithAnyTypeFromNamespace("NetHealth.CommandBus"));
            //Policies.SetAllProperties(y => y.WithAnyTypeFromNamespace("NetHealth.WoundExpert.Common"));
            //Policies.SetAllProperties(y => y.WithAnyTypeFromNamespace("NetHealth.AccessControl.Interfaces"));
            //Policies.SetAllProperties(y => y.WithAnyTypeFromNamespace("NetHealth.FileUtilities.Contracts"));

            // Settings
            
            For<IEmailService>().Use<EmailService>().Ctor<string>("connectionString").Is(databaseConnectionString);
            For<IDataService>().Use<DataService>();
            For<IBusinessService>().Use<BusinessService>();

           // this.Policies.SetAllProperties(y => y.WithAnyTypeFromNamespaceContainingType<EmailService>());
        }
    }
}