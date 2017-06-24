<%@ Page Language="C#"  MasterPageFile="~/Master.master" AutoEventWireup="true" CodeBehind="Track.aspx.cs" Inherits="WebApplication1.Track" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
              <style>            table, th, td {
       padding: 2px;
}
           tr{height:8px}
table {
    border-spacing: 0px;
}
table {
    border-collapse: collapse;
}
      
            .auto-style2 {
                width: auto;
            }
             .auto-style3 {
                width: auto;
            }

         
            </style>
    <div>
     <asp:HiddenField runat="server" ID="_repostcheckcode" />
            <meta http-equiv="refresh" content="20" />
          <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="large" Text="EMPAC Provider Tracker"></asp:Label>
        <br />
         <table style="width: 100%;">
            <tr>
                <td class="auto-style3">MD Here: 
                    <asp:TextBox ID="TextBox63" runat="server" Width="25px"></asp:TextBox>
                </td>
                <td class="auto-style2">MD Respond: 
                    <asp:TextBox ID="TextBox64" runat="server" Width="25px"></asp:TextBox>
                </td>
                </tr>

              <tr>
                 <td class="auto-style3">PA Here:&nbsp; 
                     <asp:TextBox ID="TextBox65" runat="server" Width="25px"></asp:TextBox>
                  </td>
                <td class="auto-style2">PA Respond:&nbsp; 
                    <asp:TextBox ID="TextBox66" runat="server" Width="25px"></asp:TextBox>
                  </td>

            </tr>        
         
        </table>


   <div id="placeholder" runat="server">
    <!-- here is where the dinamically created elements will be placed -->
    </div>




    </div>
     </asp:Content>
