<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JerodBarnes.aspx.cs" Inherits="WebApplication1.JerodBarnes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <p>
            Jerod Barnes - ETA:</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
    </div>
    <br />
     <a href = "index.aspx" > Index</a>
    </form>
</body>
</html>
