<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestProviderClass.aspx.cs" Inherits="WebApplication1.TestProviderClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

   <style type="text/css">
        #form1 {
            font: normal 14px Verdana, sans-serif;
            margin-left: 5px;
            margin-top: 5x;            
            height: 1185px;
            width: 800px;
      
        }
        .auto-style1 {
            width: 130px;
             height: 20px;
             
        }
       </style> 





    <title></title>
</head>
<body>
 
    <form id="form1" runat="server">
   
    
        <asp:HiddenField runat="server" ID="_repostcheckcode"  />
            <meta http-equiv="refresh" content="20" />
         <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="large" Text="EMPAC Provider Tracker"></asp:Label>
              <hr /> 
          <br />

        <div style="float:left; width:50%;">
         
            <!-- all MD stuff here-->
                       MD Respond:&nbsp;  <asp:TextBox ID="TextBox68" runat="server" Width="20px"></asp:TextBox><br />
            MD Here:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:TextBox ID="TextBox67" runat="server" Width="20px"></asp:TextBox>
    </div>
             <div style="float:right; width:50%; ">
<!-- all PS stuff here-->
        PA Respond:&nbsp;  <asp:TextBox ID="TextBox70" runat="server" Width="20px"></asp:TextBox><br />
     PA Here:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox69" runat="server" Width="20px"></asp:TextBox>      
            </div>

             <hr /> 
            <br />
            <br />
        <asp:Label ID="Label2" runat="server" Text="MD Enroute" BackColor="Lime" Font-Underline="True"></asp:Label> <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder><br />
                      <asp:Label ID="Label4" runat="server" Text="MD Here" BackColor="Yellow" Font-Underline="True"></asp:Label> <br />      
        <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder><br />
                           <asp:Label ID="Label6" runat="server" Text="MD Not Responding" Font-Underline="True"></asp:Label><br />
             <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
            <br />
            <asp:Label ID="Label8" runat="server" Text="MDs Done" BackColor="Red" Font-Underline="True"></asp:Label><br /> 
            <asp:PlaceHolder ID="PlaceHolder7" runat="server"></asp:PlaceHolder>
            <br />
     


    <br />
    <hr />
    <br />
      <asp:Label ID="Label3" runat="server" Text="PA Enroute" BackColor="Lime" Font-Underline="True"></asp:Label><br />
        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder><br />
      <asp:Label ID="Label5" runat="server" Text="PA Here" BackColor="Yellow" Font-Underline="True"></asp:Label><br />
                 <asp:PlaceHolder ID="PlaceHolder6" runat="server"></asp:PlaceHolder>     <br />        
                <asp:Label ID="Label7" runat="server" Text="PA Not Responding" Font-Underline="True"></asp:Label>  <br />
              <asp:PlaceHolder ID="PlaceHolder5" runat="server"></asp:PlaceHolder>        
    <br />
    <asp:Label ID="Label9" runat="server" Text="PAs Done" BackColor="Red" Font-Underline="True"></asp:Label><br />
    <asp:PlaceHolder ID="PlaceHolder8" runat="server"></asp:PlaceHolder>
    <br />  

</div>






  

    </form>
</body>
</html>
