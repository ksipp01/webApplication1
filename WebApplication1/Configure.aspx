<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Configure.aspx.cs" Inherits="WebApplication1.Configure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Load Configuration" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
