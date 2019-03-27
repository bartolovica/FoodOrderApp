<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RizzoOrders.aspx.cs" Inherits="Marende.Web.RizzoOrders" %>

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
                    <asp:ListItem Text="Sjemenke" Value="Sjemenke"/>
                    <asp:ListItem Text="Bez Sjemenki" Value="BezSjemenki"/>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label>Velicina sendvica: </label>
                <asp:DropDownList ID="velicinaDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="recalculateTotalCijena">
                    <asp:ListItem Text="Velicina sendvica ..." Value="" Selected="True"/>
                    <asp:ListItem Text="Mali" Value="Mali"/>
                    <asp:ListItem Text="Veliki" Value="Veliki"/>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label>Vrsta sendvica: </label>
                <asp:DropDownList ID="osnovnoMaliDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="recalculateTotalCijena">
                    <asp:ListItem Text="Vrsta malog sendvica ..." Value="" Selected="True"/>
                    <asp:ListItem Text="Samo Namaz ( 10 KN )" Value="SamoNamaz"/>
                    <asp:ListItem Text="Sir / Sunka ( 14 KN )" Value="SirSunka"/>
                    <asp:ListItem Text="Sunka ( 14 KN )" Value="Sunka"/>
                    <asp:ListItem Text="Pureca ( 17 KN )" Value="Pureca"/>
                    <asp:ListItem Text="Dimljena ( 17 KN )" Value="Dimljena"/>
                    <asp:ListItem Text="Budola ( 18 KN )" Value="Budola"/>
                    <asp:ListItem Text="Zimska ( 18 KN )" Value="Zimska"/>
                    <asp:ListItem Text="Kulen ( 18 KN )" Value="Kulen"/>
                    <asp:ListItem Text="Prsut ( 18 KN )" Value="Prsut"/>
                    <asp:ListItem Text="Tuna ( 19 KN )" Value="Tuna"/>
                </asp:DropDownList>
                <asp:DropDownList ID="osnovnoVelikiDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="recalculateTotalCijena">
                    <asp:ListItem Text="Vrsta velikog sendvica ..." Value="" Selected="True"/>
                    <asp:ListItem Text="Samo Namaz ( 10 KN )" Value="SamoNamaz"/>
                    <asp:ListItem Text="Sir / Sunka ( 17 KN )" Value="SirSunka"/>
                    <asp:ListItem Text="Sunka ( 17 KN )" Value="Sunka"/>
                    <asp:ListItem Text="Pureca ( 20 KN )" Value="Pureca"/>
                    <asp:ListItem Text="Dimljena ( 20 KN )" Value="Dimljena"/>
                    <asp:ListItem Text="Budola ( 21 KN )" Value="Budola"/>
                    <asp:ListItem Text="Zimska ( 21 KN )" Value="Zimska"/>
                    <asp:ListItem Text="Kulen ( 21 KN )" Value="Kulen"/>
                    <asp:ListItem Text="Prsut ( 21 KN )" Value="Prsut"/>
                    <asp:ListItem Text="Tuna ( 22 KN )" Value="Tuna"/>
                </asp:DropDownList>
            </div>
            
            <div class="custom-checkbox"><label><asp:CheckBox ID="kecapCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Kecap</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="majonezaCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Majoneza</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="tartarCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Tartar</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="tunaPastetaCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Tuna Pasteta</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="tunaKomadiCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Tuna Komadi</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="sirCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Sir</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="mladiSirCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Mladi sir</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="jajaCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Jaja</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="kupusCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Kupus</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="salataCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Salata</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="pomeCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Pome</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="rukolaCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Rukola</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="krastavciCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Krastavci</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="svjeziKrastavciCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Svjezi Krastavci</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="kapulaCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Kapula</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="kukuruzCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Kukuruz</label></div>
            <div class="custom-checkbox"><label><asp:CheckBox ID="paprikaCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="recalculateTotalCijena"/>Paprika</label></div>
            
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
            
            <asp:Button ID="okButton" runat="server" Text="Order" CssClass="btn btn-lg btn-dark" OnClick="okRizzoButton_Click"/>
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
