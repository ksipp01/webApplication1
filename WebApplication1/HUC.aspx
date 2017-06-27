<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HUC.aspx.cs" Inherits="WebApplication1.HUC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EMPAC-Tracker</title>
      <meta http-equiv="refresh" content="20" />
    <style type="text/css">
        #form1 {
            font: normal 14px Verdana, sans-serif;
            margin-left: 50px;
            margin-top: 30px;            
            height: 16px;
            width: 488px;
      
        }
         </style>

    <!-- 
<link rel="apple-touch-icon" sizes="180x180" href="/apple-touch-icon.png"/>
<link rel="icon" type="image/png" sizes="32x32" href="/favicon-32x32.png"/>
<link rel="icon" type="image/png" sizes="16x16" href="/favicon-16x16.png"/>
<link rel="manifest" href="/manifest.json"/>
<link rel="mask-icon" href="/safari-pinned-tab.svg" color="#5bbad5"/>
<meta name="apple-mobile-web-app-title" content="EMPAC - ETA"/>
<meta name="application-name" content="EMPAC - ETA"/>
<meta name="theme-color" content="#ffffff"/>   -->
</head>
<body>

    <form id="form1" runat="server">
        <asp:HiddenField runat="server" ID="_repostcheckcode" />
        <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="X-Large" Text="EMPAC Casualty Response Provider Tracker"></asp:Label>   
               <br />
        <br />
         <table style="width: 100%;">
            <tr>
                <td class="auto-style3">MDs Here</td>
                <td class="auto-style2">MDs Responding</td>
                 <td class="auto-style3">PAs Here</td>
                <td class="auto-style2">PAs Responding</td>

            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox28" runat="server" style="text-align:center" Width="50px" ></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox29" runat="server" style="text-align:center" Width="50px"></asp:TextBox>
                </td>
                 <td class="auto-style3">
                     <asp:TextBox ID="TextBox30" runat="server" style="text-align:center" Width="50px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox31" runat="server" style="text-align:center" Width="50px"></asp:TextBox>
                </td>
            </tr>  
             </table>  
        <br />
            <asp:Label ID="Label2" runat="server" Text="Enroute" BackColor="Lime" Width="32%"></asp:Label>

   
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" OnRowDataBound="RowDataBound">
        </asp:GridView>

   
    <p>
            <asp:Label ID="Label3" runat="server" Text="Here" BackColor="Yellow" Width="32%"></asp:Label>
            <asp:GridView ID="GridView2" runat="server" OnRowDataBound="RowDataBound">
        </asp:GridView>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Done" BackColor="Red" Width="32%"></asp:Label>

   
        </p>
        <p>
            <asp:GridView ID="GridView3" runat="server" OnRowDataBound="RowDataBound">
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display All" />

   
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
        </p>

   
    </form>
    </body>
</html>
