using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVP.Code.Domain;

namespace MVP.Presenter
{
    public interface IInvoiceView
    {
        IEnumerable<Invoice> invoices {set;}
        string Customer{set;}
    }
}
