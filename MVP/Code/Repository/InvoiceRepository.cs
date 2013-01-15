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
using System.Collections.Generic;
using MVP.Code.Domain;

namespace MVP.Code.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {

        public List<Invoice> FindAll()
        {
            List<Invoice> invoices = new List<Invoice>();
            
            invoices.Add(new Invoice {InvoiceID=1, CustomerID=1, CustomerName="Customer 1", DiscountAmount=10, InvoiceDate= DateTime.Now, InvoiceNumber="1000", InvoiceTotal=1000} )  ;
            invoices.Add(new Invoice {InvoiceID=2, CustomerID=2, CustomerName = "Customer 2", DiscountAmount = 0, InvoiceDate = DateTime.Now, InvoiceNumber = "11000", InvoiceTotal = 11000 });
            invoices.Add(new Invoice { InvoiceID = 3, CustomerID = 1, CustomerName = "Customer 1", DiscountAmount = 0, InvoiceDate = DateTime.Now, InvoiceNumber = "110001", InvoiceTotal = 110001 });
            invoices.Add(new Invoice { InvoiceID = 4, CustomerID = 2, CustomerName = "Customer 2", DiscountAmount = 0, InvoiceDate = DateTime.Now, InvoiceNumber = "12000", InvoiceTotal = 12000 });

            return invoices;
        }
    }
}
