<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mTrac.aspx.cs" Inherits="WebApplication1.mTrac" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <style type="text/css">
      *{box-sizing:border-box;

      }
       .row::after {
           content: "";
           clear: both;
           display: table;
       }
       [class*="col-"] {
    float: left;
    padding: 30px;
}	
html {
    font-family: "Lucida Sans", sans-serif;
}
.aside {
   /* background-color: #33b5e5; */
    padding: 15px;
  /*  color: #ffffff;*/
    text-align: left;
    font-size: 24px;
  /*  box-shadow: 5px 5px 5px rgba(0,0,0,0.12), 0 1px 2px rgba(0,0,0,0.24);*/
}
.header {
    background-color: #ff0000;
    color: #ffffff;
    padding: 15px;
 /*    position:fixed;

  width: 100%;
  height: 48px;
  z-index: 10;
    */
}
.textbox1 {
    width:30px;
    text-align:left;
    float:right;
    display:block;
}
/* For mobile phones: */
[class*="col-"] {
    width: 100%;
}
@media only screen and (min-width: 600px) {
    /* For tablets: */
    .col-m-1 {width: 8.33%;}
    .col-m-2 {width: 16.66%;}
    .col-m-3 {width: 25%;}
    .col-m-4 {width: 33.33%;}
    .col-m-5 {width: 41.66%;}
    .col-m-6 {width: 50%;}
    .col-m-7 {width: 58.33%;}
    .col-m-8 {width: 66.66%;}
    .col-m-9 {width: 75%;}
    .col-m-10 {width: 83.33%;}
    .col-m-11 {width: 91.66%;}
    .col-m-12 {width: 100%;}
}
@media only screen and (min-width: 768px) {
    /* For desktop: */
    .col-1 {width: 8.33%;}
    .col-2 {width: 16.66%;}
    .col-3 {width: 25%;}
    .col-4 {width: 33.33%;}
    .col-5 {width: 41.66%;}
    .col-6 {width: 50%;}
    .col-7 {width: 58.33%;}
    .col-8 {width: 66.66%;}
    .col-9 {width: 75%;}
    .col-10 {width: 83.33%;}
    .col-11 {width: 91.66%;}
    .col-12 {width: 100%;}
}
     
       </style> 

    <title>EMPAC - Tracker</title>

</head>
<body>
    <form id="form1" runat="server">
  <div class="header">
       <h1>EMPAC - Tracker</h1>
       </div>
         <hr />   
        <asp:HiddenField  ID="_repostcheckcode" runat="server" />
 <div class="row"> 
      <div class="col-3 col-m-12">     
      <div class="aside">
       <p>MDs Responding:          
           <asp:TextBox ID="TextBox1"  runat="server" CssClass="textbox1" Font-Size="Large" Width="50px" ></asp:TextBox></p>
        <p> MDs Here:
            <asp:TextBox ID="TextBox2" runat="server" CssClass="textbox1" Font-Size="Large" Width="50px"></asp:TextBox></p>
        <p>  PAs Responding:
            <asp:TextBox ID="TextBox3" runat="server" CssClass="textbox1" Font-Size="Large" Width="50px"></asp:TextBox></p>
  <p> PAs Here:  
      <asp:TextBox ID="TextBox4" runat="server" CssClass="textbox1" Font-Size="Large" Width="50px"></asp:TextBox></p>   
  </div>
            </div>
<div class="col-3 col-m-12">   
       <asp:Label ID="Label2" runat="server" Text="MD Enroute" BackColor="Lime" Font-Size="26px" Font-Underline="True"></asp:Label> <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder><br />
                      <asp:Label ID="Label4" runat="server" Text="MD Here" BackColor="Yellow" Font-Size="26px" Font-Underline="True"></asp:Label> <br />      
        <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder><br />
                           <asp:Label ID="Label6" runat="server" Text="MD Not Responded" Font-Size="26px" Font-Underline="True"></asp:Label><br />
             <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
            <br />
     </div>
  <div class="col-3 col-m-12">   

      <asp:Label ID="Label3" runat="server" Text="PA Enroute" BackColor="Lime" Font-Size="26px" Font-Underline="True"></asp:Label><br />
        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder><br />
      <asp:Label ID="Label5" runat="server" Text="PA Here" BackColor="Yellow" Font-Size="26px" Font-Underline="True"></asp:Label><br />
                 <asp:PlaceHolder ID="PlaceHolder6" runat="server"></asp:PlaceHolder>     <br />        
                <asp:Label ID="Label7" runat="server" Text="PA Not Responded" Font-Size="26px" Font-Underline="True"></asp:Label>  <br />
              <asp:PlaceHolder ID="PlaceHolder5" runat="server"></asp:PlaceHolder>        
    <br />


</div>
<div class="col-3 col-m-12">   

           <asp:Label ID="Label8" runat="server" Text="MDs Done" BackColor="Red" Font-Size="26px" Font-Underline="True"></asp:Label><br /> 
            <asp:PlaceHolder ID="PlaceHolder7" runat="server"></asp:PlaceHolder>
            <br />
        <asp:Label ID="Label9" runat="server" Text="PAs Done" BackColor="Red" Font-Size="26px" Font-Underline="True"></asp:Label><br />
    <asp:PlaceHolder ID="PlaceHolder8" runat="server"></asp:PlaceHolder>
    <br />  
</div>

  
    </form>
</body>
</html>
