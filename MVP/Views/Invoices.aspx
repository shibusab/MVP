<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Invoices.aspx.cs" Inherits="MVP.Views.Invoices" Title="Invoices" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="txtCustomer" runat="server"></asp:TextBox>
    </div>
    <div>
    <asp:GridView ID="gvInvoices" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
