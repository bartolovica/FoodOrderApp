<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OstaliPizza.aspx.cs" Inherits="Marende.Web.OstaliPizza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>ADP Marende</h1>
            <p>Narudzbe by Vlado</p>
            <hr />
            
            <div class="custom-checkbox"><label><asp:CheckBox ID="kecapCheckBox" runat="server" AutoPostBack="True"/>Kecap</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="majonezaCheckBox" runat="server" AutoPostBack="True"/>Majoneza</label></div>

            <p>&nbsp;</p>

            <h3>Podaci o vlasniku: </h3>
            
            <div class="form-group">
                <label>Ime: </label>
                <asp:TextBox ID="imeTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label>Prezime: </label>
                <asp:TextBox ID="prezimeTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label>Napomena: </label>
                <asp:TextBox ID="napomenaTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <p>&nbsp;</p>
            
            <asp:Button ID="okButton" runat="server" Text="Order" CssClass="btn btn-lg btn-dark" OnClick="okPizzaButton_Click"/>
            <p>&nbsp;</p>
            <asp:Label ID="validationLabel" runat="server" Text=""  Visible="False" CssClass="bg-danger"></asp:Label>
            <hr />

            <h3>Odokativna cijena: <asp:Label ID="totalLabel" runat="server" Text="10 KN"></asp:Label></h3>
        

        </div>
    </form>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
