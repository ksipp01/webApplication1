<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication1.Admin" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
         <asp:HiddenField runat="server" ID="_repostcheckcode" />
          <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="X-Large" Text="EMPAC Casualty Response Provider Tracker"></asp:Label>
        <br />
        <br />
        <table style="width: 100%;">
            <tr>
                <td class="auto-style3">MDs Here</td>
                <td class="auto-style2">MDs Responding</td>
                </tr>
             
            <tr>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox59" runat="server" Width="50px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox60" runat="server" Width="50px"></asp:TextBox>
                </td>
                 </tr>
              <tr>
                 <td class="auto-style3">PAs Here</td>
                <td class="auto-style2">PAs Responding</td>

            </tr>
            <tr>
                 <td class="auto-style3">
                     <asp:TextBox ID="TextBox61" runat="server" Width="50px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox62" runat="server" Width="50px"></asp:TextBox>
                </td>

            </tr>
          
          
        </table>
        <br />
        <style>            table, th, td {
       padding: 2px;
}
           tr{height:10px}
table {
    border-spacing: 5px;
}
table {
    border-collapse: collapse;
}
             .auto-style1 {
                width: auto;
                text-align:left;
            }
      
            .auto-style2 {
                width: auto;
            }
             .auto-style3 {
                width: auto;
            }
              .auto-style5 {
                width: 100px;
            }
         
            </style>



<table style="width:100%">
     <tr>
                <td style="border-bottom: thin solid" class="auto-style1"> MDs&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td style="border-bottom: thin solid" class="auto-style5"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>                   
              
            </tr>
            <tr>
                <td class="auto-style1">
                  Karen Anderson</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox32" runat="server" Width="100px"></asp:TextBox>
                </td>
            
            </tr>
            <tr>
                <td class="auto-style1">
            Laresa DeBoer </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox33" runat="server" Width="100px"></asp:TextBox>
                </td>
              
            </tr>
             <tr>
                <td class="auto-style1">
           Dan Dewey</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox34" runat="server" Width="100px"></asp:TextBox>
                 </td>
              
            </tr>
             <tr>
                <td class="auto-style1">
       Jose Dundee </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox35" runat="server" Width="100px"></asp:TextBox>
                 </td>
             
            </tr>
             <tr>
                <td class="auto-style1">
         Sarah Dundee</td>
                <td class="auto-style5">     
                    <asp:TextBox ID="TextBox36" runat="server" Width="100px"></asp:TextBox>
                 </td>
             
            </tr>
             <tr>
                <td class="auto-style1">       
          Sara Fish </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox37" runat="server" Width="100px"></asp:TextBox>
                 </td>
              
            </tr>
             <tr>
                <td class="auto-style1">
        Erine Fong </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox38" runat="server" Width="100px"></asp:TextBox>
                 </td>
             
            </tr>
             <tr>
                <td class="auto-style1">
        Matt Herold </td>
                <td class="auto-style5">        
                    <asp:TextBox ID="TextBox39" runat="server" Width="100px"></asp:TextBox>
                 </td>
              
            </tr>
             <tr>
                <td class="auto-style1">
          Bruce Hubbard </td>
                <td class="auto-style5">     
                    <asp:TextBox ID="TextBox40" runat="server" Width="100px"></asp:TextBox>
                 </td>
              
            </tr>
             <tr>
                <td class="auto-style1">
         Valerie Johnson </td>
                <td class="auto-style5">    
                    <asp:TextBox ID="TextBox41" runat="server" Width="100px"></asp:TextBox>
                 </td>
              
            </tr>
             <tr>
                <td class="auto-style1">
        Dave Larson </td>
                <td class="auto-style5">      
                    <asp:TextBox ID="TextBox42" runat="server" Width="100px"></asp:TextBox>
                 </td>
              
                 </tr>
                          <tr>
                <td class="auto-style1">
        Lisa Larson &nbsp;&nbsp;</td>
                <td class="auto-style5">       
                    <asp:TextBox ID="TextBox43" runat="server" Width="100px"></asp:TextBox>
                           </td>
              
            </tr>
                  <tr>
                <td class="auto-style1">
        Amy Osborn</td>
                <td class="auto-style5"> 
                    <asp:TextBox ID="TextBox44" runat="server" Width="100px"></asp:TextBox>
                      </td>
             
            </tr>
                  <tr>
                <td class="auto-style1">
        Greg Peterson</td>
                <td class="auto-style5"> 
                    <asp:TextBox ID="TextBox45" runat="server" Width="100px"></asp:TextBox>
                      </td>
              
            </tr>
                  <tr>
                <td class="auto-style1">
       Yo Schugel </td>
                <td class="auto-style5"> 
                    <asp:TextBox ID="TextBox46" runat="server" Width="100px"></asp:TextBox>
                      </td>
             
            </tr>
                  <tr>
                <td class="auto-style1">Kevin Sipprell</td>
                <td class="auto-style5">      
                    <asp:TextBox ID="TextBox47" runat="server" Width="100px"></asp:TextBox>
                      </td>
              
                               </tr>
                       <tr>
                <td style="border-top: thin dashed" class="auto-style1"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td style="border-top: thin dashed" class="auto-style5"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>                   
  
            </tr>
   
                 <tr>
                <td style="border-bottom: thin solid" class="auto-style1"> PAs&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td style="border-bottom: thin solid" class="auto-style5"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>                   

            </tr>
                  <tr>
                <td class="auto-style1">
        Emily Anderson</td>
                <td class="auto-style5"> 
                    <asp:TextBox ID="TextBox48" runat="server" Width="100px"></asp:TextBox>
                      </td>
             
            </tr>
                  <tr>
                <td class="auto-style1">
         Jarod Barnes</td>
                <td class="auto-style5"> 
                    <asp:TextBox ID="TextBox49" runat="server" Width="100px"></asp:TextBox>
                      </td>
              
            </tr>
                  <tr>
                <td class="auto-style1">
         Erin Bischoff </td>
                <td class="auto-style5">   
                    <asp:TextBox ID="TextBox50" runat="server" Width="100px"></asp:TextBox>
                      </td>
             
            </tr>
                  <tr>
                <td class="auto-style1">
        Fred Demeuse </td>
                <td class="auto-style5"> 
                    <asp:TextBox ID="TextBox51" runat="server" Width="100px"></asp:TextBox>
                      </td>
             
            </tr>
                  <tr>
                <td class="auto-style1">
        Chelsea Eernisse</td>
                <td class="auto-style5">     
                    <asp:TextBox ID="TextBox52" runat="server" Width="100px"></asp:TextBox>
                      </td>
              
            </tr>
                  <tr>
                <td class="auto-style1">
        Alli Engelsma </td>
                <td class="auto-style5">    
                    <asp:TextBox ID="TextBox53" runat="server" Width="100px"></asp:TextBox>
                      </td>
            
            </tr>
                  <tr>
                <td class="auto-style1">
        Brady Griffith </td>
                <td class="auto-style5">      
                    <asp:TextBox ID="TextBox54" runat="server" Width="100px"></asp:TextBox>
                      </td>
             
                      </tr>
                       <tr>
                <td class="auto-style1">
       Jason Hicks</td>
                <td class="auto-style5">    
                    <asp:TextBox ID="TextBox55" runat="server" Width="100px"></asp:TextBox>
                           </td>
              
            </tr>
                       <tr>
                <td class="auto-style1">
        Beth Radke</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox56" runat="server" Width="100px"></asp:TextBox>
                           </td>
            
            </tr>
                       <tr>
                <td class="auto-style1">
        Tamrah Tenhaeff </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox57" runat="server" Width="100px"></asp:TextBox>
                           </td>
         
            </tr>
                       <tr>
                <td style="border-bottom: thin dashed" class="auto-style1">
        Erinn VonRein </td>
                <td style="border-bottom: thin dashed" class="auto-style5">
                    <asp:TextBox ID="TextBox58" runat="server" Width="100px"></asp:TextBox>
                           </td>
            
            </tr>
    
       
        </table>
                <br />
       

     <a href="Log.aspx">View Log</a>      
    </div>
 


     </asp:Content>