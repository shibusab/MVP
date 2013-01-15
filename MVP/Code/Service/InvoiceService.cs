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
using MVP.Code.Repository;
using System.Collections;
using System.Collections.Generic;
using MVP.Code.Domain;

namespace MVP.Code.Service
{
    public class InvoiceService : IInvoiceService
    {
        IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public List<Invoice> GetInvoices()
        {
           return _invoiceRepository.FindAll();
        }
    }
}
