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

namespace MVP.Code.Domain
{
    public class InvoiceLine
    {
        public double InvoiceLineID { get; set; }
        public double InvoiceID { get; set; }
        public double LineNo { get; set; }
        public double ItemID { get; set; }
        public string ItemDescription { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
