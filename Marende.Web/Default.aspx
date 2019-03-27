<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Marende.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form2" runat="server">
        <div class ="container">
            <h1>ADP Marende</h1>
            <p>Narudzbe by Vlado</p>
            <hr />
            
            
            <div class="text-center">
                <asp:Button ID="rizzoButton" runat="server" Text="Rizzo" CssClass="btn btn-lg btn-dark" OnClick="rizzoButton_Click"/>

                <asp:Button ID="ostaliButton" runat="server" Text="Ostali" CssClass="btn btn-lg btn-dark" OnClick="ostaliButton_Click"/>
            </div>
           
            <hr />
            
            <div class="text-center">
                <asp:Button ID="sendvicRizzoButton" runat="server" Text="Sendvic" CssClass="btn btn-lg btn-dark" Visible="False" OnClick="rizzoIzbor_Click"/>
            
                <asp:Button ID="sendvicButton" runat="server" Text="Sendvici" CssClass="btn btn-lg btn-dark" Visible="False" OnClick="ostaliIzbor_Click"/>

                <asp:Button ID="salataButton" runat="server" Text="Salata" CssClass="btn btn-lg btn-dark" Visible="False" OnClick="rizzoSalataIzbor_Click"/>

                <asp:Button ID="pizzaButton" runat="server" Text="Pizza" CssClass="btn btn-lg btn-dark" Visible="False" OnClick="ostaliPizzaIzbor_Click"/>
            
            </div>

            <p>&nbsp;</p>

            <asp:Label ID="dataValidationLabel" runat="server" Text=""  Visible="False" CssClass="bg-danger"></asp:Label>

            <hr />

        </div>
    </form>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
