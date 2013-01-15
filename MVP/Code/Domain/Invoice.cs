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
using System.Collections;
using System.Collections.Generic;

namespace MVP.Code.Domain
{
    public class Invoice
    {
        private List<InvoiceLine> _lines = new List<InvoiceLine>();
        public double InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double CustomerID { get; set; }
        public string CustomerName { get; set; }
        public double InvoiceTotal { get; set; }
        public double DiscountAmount { get; set; }
        public List<InvoiceLine> InvoiceLines { get { return _lines; } set { _lines = value; } }
    }
}
