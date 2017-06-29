<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestProviderClass.aspx.cs" Inherits="WebApplication1.TestProviderClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

 





    <title></title>
</head>
<body>
 
    <form id="form1" runat="server">
   
    
        <asp:HiddenField runat="server" ID="_repostcheckcode"  />
            <meta http-equiv="refresh" content="20" />
         <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="large" Text="EMPAC Provider Tracker"></asp:Label>

          <br />

        <div style="float:left; width:50%;">
            <!-- all MD stuff here-->
                       MD Responding:&nbsp;  <asp:TextBox ID="TextBox68" runat="server" Width="25px"></asp:TextBox><br />
            MD Here:&nbsp;  <asp:TextBox ID="TextBox67" runat="server" Width="25px"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="MDs Enroute"></asp:Label> <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder><br />
                      <asp:Label ID="Label4" runat="server" Text="MDs Here"></asp:Label> <br />      
        <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder><br />
                           <asp:Label ID="Label6" runat="server" Text="MDs Not Responding"></asp:Label><br />
             <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
            <br />
            <asp:Label ID="Label8" runat="server" Text="MDs Done"></asp:Label><br /> 
            <asp:PlaceHolder ID="PlaceHolder7" runat="server"></asp:PlaceHolder>
            <br />
     
            </div>

<div style="float:right; width:50%; ">
<!-- all PS stuff here-->
        PA Responding:&nbsp;  <asp:TextBox ID="TextBox70" runat="server" Width="25px"></asp:TextBox><br />
     PA Here:&nbsp; <asp:TextBox ID="TextBox69" runat="server" Width="25px"></asp:TextBox><br />
      <asp:Label ID="Label3" runat="server" Text="PAs Enroute"></asp:Label><br />
        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder><br />
      <asp:Label ID="Label5" runat="server" Text="PAs Here"></asp:Label><br />
                 <asp:PlaceHolder ID="PlaceHolder6" runat="server"></asp:PlaceHolder>     <br />        
                <asp:Label ID="Label7" runat="server" Text="PAs Not Responding"></asp:Label>  <br />
              <asp:PlaceHolder ID="PlaceHolder5" runat="server"></asp:PlaceHolder>        
    <br />
    <asp:Label ID="Label9" runat="server" Text="PAs Done"></asp:Label><br />
    <asp:PlaceHolder ID="PlaceHolder8" runat="server"></asp:PlaceHolder>
    <br />  

</div>






  

    </form>
</body>
</html>
