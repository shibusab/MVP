using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using StructureMap;
using StructureMap.Configuration.DSL;
using MVP.Code.Repository;
using MVP.Presenter;
using MVP.Code.Service;
namespace MVP.Code
{
    public class BootStrapper
    {
        public static void ConfigureDependencies()
        {
            // Initialize the registry
            ObjectFactory.Initialize(x =>
            {
                x.AddRegistry<ControllerRegistry>();

            });
        }

        public class ControllerRegistry : Registry
        {
            public ControllerRegistry()
            {
                For<IInvoiceRepository>().Use<InvoiceRepository>();
                For<IInvoicePresenter>().Use<InvoicePresenter>();
                For<IInvoiceService>().Use<InvoiceService>();
            }
        }   
    }
}
