﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DaveLarson.aspx.cs" Inherits="WebApplication1.DaveLarson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <p>
            Dave Larson - ETA:</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
    </div>

          (Enter estimated minutes to arrival e.g. 20)<br />
        <br />
        <a href="index.aspx">Index</a>
    </form>

</body>
</html>
