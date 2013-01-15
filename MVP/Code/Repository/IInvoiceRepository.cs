using System;
using System.Collections.Generic;
using MVP.Code.Domain;
namespace MVP.Code.Repository
{
    public interface IInvoiceRepository
    {
        List<Invoice> FindAll();
    }
}
