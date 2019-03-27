<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DownloadFile.aspx.cs" Inherits="Marende.Web.DownloadFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
<form id="form1" runat="server">
    <div class ="container">
        <h1>ADP Marende</h1>
        <p>Narudzbe by Vlado</p>
        <hr />

        <asp:Button ID="downloadButton" runat="server" Text="Download File" CssClass="btn btn-lg btn-dark" OnClick="downloadButton_Click"/>
            
        <p>&nbsp;</p>
        <asp:Label ID="validationLabel" runat="server" Text=""  Visible="False" CssClass="bg-danger"></asp:Label>
        <hr/>
    </div>
</form>
<script src="Scripts/jquery-3.3.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
