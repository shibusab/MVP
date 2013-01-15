using System;
using System.Collections.Generic;
using MVP.Code.Domain;
namespace MVP.Code.Service
{
   public interface IInvoiceService
    {
        List<Invoice> GetInvoices();
    }
}
