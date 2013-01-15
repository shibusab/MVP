using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using MVP.Presenter;
using StructureMap;
using System.Collections.Generic;
using MVP.Code.Domain;
using MVP.Code.Service;
namespace MVP.Views
{
    public partial class Invoices : System.Web.UI.Page, IInvoiceView 
    {
        private IInvoicePresenter _invoicePresenter;
        protected void Page_Init(object sender, EventArgs e)
        {
            _invoicePresenter = new InvoicePresenter( this, ObjectFactory.GetInstance<IInvoiceService>());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _invoicePresenter.Display();
        }

        #region IInvoiceView Members

        public IEnumerable<Invoice> invoices
        {
            set
            {
                gvInvoices.DataSource = value;
                gvInvoices.DataBind();
            }
        }

        public string Customer
        {
            set { txtCustomer.Text = value; }
        }

        #endregion
    }
}
