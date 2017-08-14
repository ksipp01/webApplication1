<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log.aspx.cs" Inherits="WebApplication1.Log" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
           
    <title></title>
    <style>
      .button {
          margin-right: 40px;
          text-align: center;
      }
          .body {
              width: 90%;
              height: 800px;
           padding: 15px;
           text-align: center;
       }
    </style>

</head>
<body>
    <form id="form1" runat="server">  
    <div class=" body">
        <asp:TextBox ID="TextBox1" runat="server" Height="850px" TextMode="MultiLine" Width="812px"></asp:TextBox>
        <br />
        <br />
                <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" OnClientClick="return confirm('Are you sure you want to clear? All data will be lost')" Text="Clear Log" />
        <asp:Button ID="Button2" runat="server" CssClass="button" Text="Save Log" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" CssClass="button" OnClick="Button3_Click" Text="Send email" />     
                <asp:Button ID="Button4" runat="server" CssClass="button" Text="Main Page" OnClick="Button4_Click" />
       
        </div>
    <asp:HiddenField ID="_repostcheckcode" runat="server" />
        </form>
   
</body>
</html>
