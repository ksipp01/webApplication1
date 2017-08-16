<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileManager.aspx.cs" Inherits="WebApplication1.FileManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Delete"  OnClientClick="return confirm('Are you sure you want to delete this file? All data will be lost')" OnClick="Button1_Click" />
    &nbsp;
        <asp:Button ID="Button2" runat="server" Text=" Save " OnClick="Button2_Click" />
    </form>
</body>
</html>