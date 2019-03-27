<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="Marende.Web.Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class ="container">
            <h1>Marende</h1>
            <p>Narudzbe by Vlado</p>
            <hr />
            
            <div class="form-group">
                <label>Tip Kruha: </label>
                <asp:DropDownList ID="tipDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="recalculateTotalCijena">
                    <asp:ListItem Text="Tip Kruha ..." Value="" Selected="True"/>
                    <asp:ListItem Text="Sendvic" Value="Sendvic"/>
                    <asp:ListItem Text="Lepinja" Value="Lepinja"/>
                    <asp:ListItem Text="Bubica" Value="Bubica"/>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label>Velicina sendvica: </label>
                <asp:DropDownList ID="velicinaDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="recalculateTotalCijena">
                    <asp:ListItem Text="Velicina sendvica ..." Value="" Selected="True"/>
                    <asp:ListItem Text="Mali" Value="Mali"/>
                    <asp:ListItem Text="Srednji" Value="Srednji"/>
                    <asp:ListItem Text="Veliki" Value="Veliki"/>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label>Vrsta sendvica: </label>
                <asp:DropDownList ID="osnovnoMaliDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="recalculateTotalCijena">
                    <asp:ListItem Text="Vrsta sendvica ..." Value="" Selected="True"/>
                    <asp:ListItem Text="Sir / Sunka ( 10 KN )" Value="SirSunka"/>
                    <asp:ListItem Text="Piletina ( 20 KN )" Value="Piletina"/>
                    <asp:ListItem Text="Piletina Sir ( 23 KN )" Value="PiletinaSir"/>
                    <asp:ListItem Text="Hamburger ( 24 KN )" Value="Hamburger"/>
                    <asp:ListItem Text="Cheesburger ( 24 KN )" Value="Cheesburger"/>
                    <asp:ListItem Text="Cevapi ( 22 KN )" Value="Cevapi"/>
                    <asp:ListItem Text="Pizza ( 12 KN )" Value="Pizza"/>
                </asp:DropDownList>
                <asp:DropDownList ID="osnovnoSrednjiDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="recalculateTotalCijena">
                    <asp:ListItem Text="Vrsta sendvica ..." Value="" Selected="True"/>
                    <asp:ListItem Text="Sir / Sunka ( 14 KN )" Value="SirSunka"/>
                    <asp:ListItem Text="Piletina ( 20 KN )" Value="Piletina"/>
                    <asp:ListItem Text="Piletina Sir ( 23 KN )" Value="PiletinSir"/>
                    <asp:ListItem Text="Hamburger ( 24 KN )" Value="Hamburger"/>
                    <asp:ListItem Text="Cheesburger ( 24 KN )" Value="Cheesburger"/>
                    <asp:ListItem Text="Cevapi ( 22 KN )" Value="Cevapi"/>
                    <asp:ListItem Text="Pizza ( 12 KN )" Value="Pizza"/>
                </asp:DropDownList>
                <asp:DropDownList ID="osnovnoVelikiDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="recalculateTotalCijena">
                    <asp:ListItem Text="Vrsta sendvica ..." Value="" Selected="True"/>
                    <asp:ListItem Text="Sir / Sunka ( 16 KN )" Value="SirSunka"/>
                    <asp:ListItem Text="Piletina ( 20 KN )" Value="Piletina"/>
                    <asp:ListItem Text="Piletina Sir ( 23 KN )" Value="PiletinSir"/>
                    <asp:ListItem Text="Hamburger ( 24 KN )" Value="Hamburger"/>
                    <asp:ListItem Text="Cheesburger ( 24 KN )" Value="Cheesburger"/>
                    <asp:ListItem Text="Cevapi ( 22 KN )" Value="Cevapi"/>
                    <asp:ListItem Text="Pizza ( 12 KN )" Value="Pizza"/>
                </asp:DropDownList>
            </div>
            
            <div class="custom-checkbox"><label><asp:CheckBox ID="kecapCheckBox" runat="server" AutoPostBack="True"/>Kecap</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="majonezaCheckBox" runat="server" AutoPostBack="True"/>Majoneza</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="tartarCheckBox" runat="server" AutoPostBack="True"/>Tartar</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="sirCheckBox" runat="server" AutoPostBack="True"/>Sir</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="mladiSirCheckBox" runat="server" AutoPostBack="True"/>Mladi sir</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="jajaCheckBox" runat="server" AutoPostBack="True"/>Jaja</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="kupusCheckBox" runat="server" AutoPostBack="True"/>Kupus</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="salataCheckBox" runat="server" AutoPostBack="True"/>Salata</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="pomeCheckBox" runat="server" AutoPostBack="True"/>Pome</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="rukolaCheckBox" runat="server" AutoPostBack="True"/>Rukola</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="krastavciCheckBox" runat="server" AutoPostBack="True"/>Krastavci</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="svjeziKrastavciCheckBox" runat="server" AutoPostBack="True"/>Svjezi Krastavci</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="kapulaCheckBox" runat="server" AutoPostBack="True"/>Kapula</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="kukuruzCheckBox" runat="server" AutoPostBack="True"/>Kukuruz</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="paprikaCheckBox" runat="server" AutoPostBack="True"/>Paprika</label></div>
            
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
            
            <asp:Button ID="okButton" runat="server" Text="Order" CssClass="btn btn-lg btn-dark" OnClick="okButton_Click"/>
            <p>&nbsp;</p>
            <asp:Label ID="validationLabel" runat="server" Text=""  Visible="False" CssClass="bg-danger"></asp:Label>
            <hr />

            <h3>Odokativna cijena: <asp:Label ID="totalLabel" runat="server" Text="0 KN"></asp:Label></h3>


        </div>
    </form>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
