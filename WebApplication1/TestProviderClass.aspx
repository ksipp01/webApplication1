<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestProviderClass.aspx.cs" Inherits="WebApplication1.TestProviderClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HiddenField runat="server" ID="_repostcheckcode"  />
            <meta http-equiv="refresh" content="20" />
         <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="large" Text="EMPAC Provider Tracker"></asp:Label>

          <br />
         <table style="width: 100%;">
            <tr>
                <td class="auto-style3">MD Here: 
                    <asp:TextBox ID="TextBox67" runat="server" Width="25px"></asp:TextBox>
                </td>
                <td class="auto-style2">MD Responding: 
                    <asp:TextBox ID="TextBox68" runat="server" Width="25px"></asp:TextBox>
                </td>
                </tr>

              <tr>
                 <td class="auto-style3">PA Here:&nbsp; 
                     <asp:TextBox ID="TextBox69" runat="server" Width="25px"></asp:TextBox>
                  </td>
                <td class="auto-style2">PA Responding:&nbsp; 
                    <asp:TextBox ID="TextBox70" runat="server" Width="25px"></asp:TextBox>
                  </td>

            </tr>        
         
        </table>



        <br />
        <br />



        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    
        <br />
    
        <br />
    
    </div>
        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
        <br />
        <br />
        <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
        <br />
        <br />
        <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
        <br />
        <br />
    </form>
</body>
</html>
