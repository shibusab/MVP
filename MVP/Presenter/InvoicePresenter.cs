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
using MVP.Code.Service;

namespace MVP.Presenter
{
    public class InvoicePresenter : IInvoicePresenter
    {
        IInvoiceView _view;
        IInvoiceService _invoiceService;

        public InvoicePresenter(IInvoiceView view, IInvoiceService invoiceService)
        {
            _view = view;
            _invoiceService = invoiceService;
        }


        public void Display()
        {
            _view.invoices = _invoiceService.GetInvoices();
            _view.Customer = "My Customer";
        }

    }
}
