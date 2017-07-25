<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.TestProviderClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
   <style type="text/css">
      *{box-sizing:border-box;

      }
       .row::after {
           content: "";
           clear: both;
           display: table;
       }
  
html {
    font-family: "Lucida Sans", sans-serif;
    font-size: 26px;
}
.aside {
   /* background-color: #33b5e5; */
    padding: 5px;
  /*  color: #ffffff;*/
    text-align: left;
    font-size: 26px;
  /* box-shadow: 5px 5px 5px rgba(0,0,0,0.12), 0 1px 2px rgba(0,0,0,0.24); */
}
.header {
    background-color: #ff0000;
    color: #ffffff;
    padding: 5px;
 position: fixed; /* Set the navbar to fixed position */
    top: 0; /* Position the navbar at the top of the page */
    width: 100%; /* Full width */
    font-size: large;
}
P
{
    font-size: 26px;
        margin-top: .5em;
    margin-bottom: .5em;
 
}
 .footer {
           padding: 5px;
           text-align: center;
       }
 
  .button {
           margin-right : 30px;
     
           text-align: center;
        /*   margin-top: 20px;*/
       }
.textbox1 {
    width:40px;
    text-align:left;
    float:right;
    display:block;
    font-size: 80%;
}
.placeholder{
    margin-top: 5px;
    padding: 10px;
   
}
 hr {
           border:solid 1px black;
  clear:both;
  display:block;
  width: 98%;               
  margin-top: 80px;
  height: 1px;


       }
     [class*="col-"] {
    float: left;
    padding: 5px;
    margin-top: 10px;
}	
/* For mobile phones: */
[class*="col-"] {
    margin-top: 10px;
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
   
      
          
        <asp:HiddenField runat="server" ID="_repostcheckcode"  />
            <meta http-equiv="refresh" content="20" />

          <br />

      <hr />
  

<div class="row">
      
  <div class="col-3 col-m-12">     
      <div class="aside">
  
       
       <p>MDs Responding:          
      <asp:TextBox ID="TextBox68" runat="server" CssClass="textbox1"></asp:TextBox></p>
       
           <p>MDs Here:
         <asp:TextBox ID="TextBox67" runat="server" CssClass="textbox1"></asp:TextBox></p>
        
<!-- all PA stuff here-->
      <p>  PAs Responding:
          <asp:TextBox ID="TextBox70" runat="server" CssClass="textbox1"></asp:TextBox></p>
    <p> PAs Here:  
       <asp:TextBox ID="TextBox69" runat="server" CssClass="textbox1"></asp:TextBox></p>   
  </div>
</div>
 <div class="col-3 col-m-12">   

        <asp:Label ID="Label2" runat="server" Text="MDs Responding" BackColor="Lime" Font-Underline="True"></asp:Label> <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder><br />
                      <asp:Label ID="Label4" runat="server" Text="MDs Here" BackColor="Yellow" Font-Underline="True"></asp:Label> <br />      
        <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder><br />
                           <asp:Label ID="Label6" runat="server" Text="MDs Not Responded" Font-Underline="True"></asp:Label><br />
             <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
            <br />
     </div>
  <div class="col-3 col-m-12">   

      <asp:Label ID="Label3" runat="server" Text="PAs Responding" BackColor="Lime" Font-Underline="True"></asp:Label><br />
        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder><br />
      <asp:Label ID="Label5" runat="server" Text="PAs Here" BackColor="Yellow" Font-Underline="True"></asp:Label><br />
                 <asp:PlaceHolder ID="PlaceHolder6" runat="server"></asp:PlaceHolder>     <br />        
                <asp:Label ID="Label7" runat="server" Text="PAs Not Responded" Font-Underline="True"></asp:Label>  <br />
              <asp:PlaceHolder ID="PlaceHolder5" runat="server"></asp:PlaceHolder>        
    <br />


</div>
<div class="col-3 col-m-12">   

           <asp:Label ID="Label8" runat="server" Text="MDs Done" BackColor="Red" Font-Underline="True"></asp:Label><br /> 
            <asp:PlaceHolder ID="PlaceHolder7" runat="server"></asp:PlaceHolder><br />         
        <asp:Label ID="Label9" runat="server" Text="PAs Done" BackColor="Red" Font-Underline="True"></asp:Label><br />
    <asp:PlaceHolder ID="PlaceHolder8" runat="server"></asp:PlaceHolder>
    <br />  
    </div>
    </div>
    <div class="footer">
    <asp:Button ID="Button1" runat="server" Text="Reset" CssClass="button" OnClick="Button1_Click" Width="90px" />   
      <asp:Button ID="Button2" runat="server" CssClass="button" Text="Enter ETA" Width="90px" OnClick="Button2_Click" /> 
      <asp:Button ID="Button3" runat="server" CssClass="button" Text="View Log" OnClick="Button3_Click" Width="90px" />    
      <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" CssClass="button" Text="Configure" Width="90px" />   
      </div>
    </form>
</body>
</html>
