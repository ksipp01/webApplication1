<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EMPAC Tracker</title>
    <meta http-equiv="refresh" content="20" />
    <style type="text/css">
        #form1 {
            height: 1185px;
            width: 488px;
        }
        .auto-style1 {
            width: 130px;
             height: 20px;
        }
       </style>

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
                    <asp:TextBox ID="TextBox28" runat="server" Width="50px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox29" runat="server" Width="50px"></asp:TextBox>
                </td>
                 <td class="auto-style3">
                     <asp:TextBox ID="TextBox30" runat="server" Width="50px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox31" runat="server" Width="50px"></asp:TextBox>
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
            .auto-style2 {
                width: 287px;
            }
            .auto-style3 {
                width: 214px;
            }
            .auto-style5 {
                width: 74px;
            }
            .auto-style6 {
                width: 136px;
            }
            .auto-style7 {
                width: 73px;
            }
            </style>
</head>
<body>

<table style="width:100%">
            <tr>
                <td class="auto-style1">
                    <a href="KarenAnderson.aspx">Karen Anderson</a>&nbsp;&nbsp;</td>
                <td class="auto-style5">
        <asp:TextBox ID="TextBox1" runat="server" Width="60px"></asp:TextBox>
                </td>
                <td class="auto-style7">
        <asp:Button ID="Button28" runat="server" OnClick="Button28_Click" Text="Arrived" />
                    </td>
                     <td class="auto-style6">
                    <asp:Button ID="Button52" runat="server" Text="Complete" OnClick="Button52_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
            <a href="LaresaDeBoer.aspx">Laresa DeBoer</a>&nbsp;&nbsp;</td>
                <td class="auto-style5">
        <asp:TextBox ID="TextBox2" runat="server" Width="60px"></asp:TextBox>
                </td>
                <td class="auto-style7">
        <asp:Button ID="LaresaArrivalButton" runat="server" OnClick="LaresaArrivalButton_Click" Text="Arrived" />
                </td>
                 <td class="auto-style6">
                    <asp:Button ID="Button1" runat="server" Text="Complete" OnClick="Button1_Click" />
                </td>
            </tr>
             <tr>
                <td class="auto-style1">
            <a href="DanDewey.aspx">Dan Dewey</a>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5">
        <asp:TextBox ID="TextBox3" runat="server" Width="60px"></asp:TextBox>
                 </td>
                <td class="auto-style7">
        <asp:Button ID="DeweyArrivalButton" runat="server" OnClick="DeweyArrivalButton_Click" Text="Arrived" />
                 </td>
                  <td class="auto-style6">
                    <asp:Button ID="Button2" runat="server" Text="Complete" OnClick="Button2_Click" />
                </td>
            </tr>
             <tr>
                <td class="auto-style1">
         <a href="JoseDundee.aspx">Jose Dundee</a>&nbsp;&nbsp;</td>
                <td class="auto-style5">
        <asp:TextBox ID="TextBox4" runat="server" Width="60px"></asp:TextBox>
                 </td>
                <td class="auto-style7">
        <asp:Button ID="JoseArrivalButton" runat="server" OnClick="JoseArrivalButton_Click" Text="Arrived" />
                 </td>
                  <td class="auto-style6">
                    <asp:Button ID="Button3" runat="server" Text="Complete" OnClick="Button3_Click" />
                </td>
            </tr>
             <tr>
                <td class="auto-style1">
        <a href="SarahDundee.aspx">Sarah Dundee</a>&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5">     
        <asp:TextBox ID="TextBox5" runat="server" Width="60px"></asp:TextBox>
                 </td>
                <td class="auto-style7">
        <asp:Button ID="SDundeeARrivalButton" runat="server" OnClick="SDundeeARrivalButton_Click" Text="Arrived" />
                 </td>
                  <td class="auto-style6">
                    <asp:Button ID="Button4" runat="server" Text="Complete" OnClick="Button4_Click" />
                </td>
            </tr>
             <tr>
                <td class="auto-style1">      
        <a href="SaraFish.aspx">Sara Fish</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5">
        <asp:TextBox ID="TextBox6" runat="server" Width="60px" Height="22px"></asp:TextBox>
                 </td>
                <td class="auto-style7">
        <asp:Button ID="Button29" runat="server" OnClick="Button29_Click" Text="Arrived" />
                 </td>
                  <td class="auto-style6">
                    <asp:Button ID="Button5" runat="server" Text="Complete" OnClick="Button5_Click" />
                </td>
            </tr>
             <tr>
                <td class="auto-style1">
        <a href="ErineFong.aspx">Erine Fong</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5">
        <asp:TextBox ID="TextBox7" runat="server" Width="60px"></asp:TextBox>
                 </td>
                <td class="auto-style7">
        <asp:Button ID="Button30" runat="server" OnClick="Button30_Click" Text="Arrived" />
                 </td>
                  <td class="auto-style6">
                    <asp:Button ID="Button6" runat="server" Text="Complete" OnClick="Button6_Click" />
                </td>
            </tr>
             <tr>
                <td class="auto-style1">
        <a href="MattHerold.aspx">Matt Herold</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style5">        
        <asp:TextBox ID="TextBox8" runat="server" Width="60px"></asp:TextBox>
                 </td>
                <td class="auto-style7">
        <asp:Button ID="Button31" runat="server" OnClick="Button31_Click" Text="Arrived" />
                 </td>
                  <td class="auto-style6">
                    <asp:Button ID="Button7" runat="server" Text="Complete" OnClick="Button7_Click" />
                </td>
            </tr>
             <tr>
                <td class="auto-style1">
          <a href="BruceHubbard.aspx">Bruce Hubbard</a>&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5">     
        <asp:TextBox ID="TextBox9" runat="server" Width="60px"></asp:TextBox>
                 </td>
                <td class="auto-style7">
        <asp:Button ID="Button32" runat="server" OnClick="Button32_Click" Text="Arrived" />
                 </td>
                  <td class="auto-style6">
                    <asp:Button ID="Button8" runat="server" Text="Complete" OnClick="Button8_Click" />
                </td>
            </tr>
             <tr>
                <td class="auto-style1">
         <a href="ValerieJohnson.aspx">Valerie Johnson</a>&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5">    
        <asp:TextBox ID="TextBox10" runat="server" Width="60px"></asp:TextBox>
                 </td>
                <td class="auto-style7">
        <asp:Button ID="Button33" runat="server" OnClick="Button33_Click" Text="Arrived" />
                 </td>
                  <td class="auto-style6">
                    <asp:Button ID="Button9" runat="server" Text="Complete" OnClick="Button9_Click" />
                </td>
            </tr>
             <tr>
                <td class="auto-style1">
        <a href="DaveLarson.aspx">Dave Larson</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5">      
        <asp:TextBox ID="TextBox11" runat="server" Width="60px"></asp:TextBox>
                 </td>
                <td class="auto-style7">
        <asp:Button ID="Button34" runat="server" OnClick="Button34_Click" Text="Arrived" />
                 </td>
                  <td class="auto-style6">
                    <asp:Button ID="Button10" runat="server" Text="Complete" OnClick="Button10_Click" />
                </td>
                  <tr>
                <td class="auto-style1">
        <a href="AmyOsborn.aspx">Amy Osborn</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5"> 
        <asp:TextBox ID="TextBox12" runat="server" Width="60px"></asp:TextBox>
                      </td>
                <td class="auto-style7">
        <asp:Button ID="Button35" runat="server" OnClick="Button35_Click" Text="Arrived" />
                      </td>
                       <td class="auto-style6">
                    <asp:Button ID="Button11" runat="server" Text="Complete" OnClick="Button11_Click" />
                </td>
            </tr>
                  <tr>
                <td class="auto-style1">
        <a href="GregPeterson.aspx">Greg Peterson</a>&nbsp;&nbsp;</td>
                <td class="auto-style5"> 
        <asp:TextBox ID="TextBox13" runat="server" Width="60px"></asp:TextBox>
                      </td>
                <td class="auto-style7">
        <asp:Button ID="Button36" runat="server" OnClick="Button36_Click" Text="Arrived" />
                      </td>
                       <td class="auto-style6">
                    <asp:Button ID="Button12" runat="server" Text="Complete" OnClick="Button12_Click" />
                </td>
            </tr>
                  <tr>
                <td class="auto-style1">
        <a href="YoSchugel.aspx">Yo Schugel</a>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5"> 
        <asp:TextBox ID="TextBox14" runat="server" Width="60px"></asp:TextBox>
                      </td>
                <td class="auto-style7">
        <asp:Button ID="Button37" runat="server" OnClick="Button37_Click" Text="Arrived" />
                      </td>
                       <td class="auto-style6">
                    <asp:Button ID="Button13" runat="server" Text="Complete" OnClick="Button13_Click" />
                </td>
            </tr>
                  <tr>
                <td class="auto-style1">
        <a href="KevinSipprell.aspx">Kevin Sipprell</a>&nbsp;&nbsp;</td>
                <td class="auto-style5">      
        <asp:TextBox ID="TextBox15" runat="server" Width="60px"></asp:TextBox>
                      </td>
                <td class="auto-style7">
        <asp:Button ID="Button38" runat="server" OnClick="Button38_Click" Text="Arrived" />
                      </td>
                       <td class="auto-style6">
                    <asp:Button ID="Button14" runat="server" Text="Complete" OnClick="Button14_Click" />
                </td>
            </tr>
                  <tr>
                <td class="auto-style1">
         <a href="EmilyAnderson.aspx">Emily Anderson</a>&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5"> 
        <asp:TextBox ID="TextBox16" runat="server" Width="60px"></asp:TextBox>
                      </td>
                <td class="auto-style7">
        <asp:Button ID="Button39" runat="server" OnClick="Button39_Click" Text="Arrived" />
                      </td>
                       <td class="auto-style6">
                    <asp:Button ID="Button15" runat="server" Text="Complete" OnClick="Button15_Click" />
                </td>
            </tr>
                  <tr>
                <td class="auto-style1">
         <a href="JerodBarnes.aspx">Jarod Barnes</a>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5"> 
        <asp:TextBox ID="TextBox17" runat="server" Width="60px"></asp:TextBox>
                      </td>
                <td class="auto-style7">
        <asp:Button ID="Button40" runat="server" OnClick="Button40_Click" Text="Arrived" />
                      </td>
                       <td class="auto-style6">
                    <asp:Button ID="Button16" runat="server" Text="Complete" OnClick="Button16_Click" />
                </td>
            </tr>
                  <tr>
                <td class="auto-style1">
         <a href="ErinBischoff.aspx">Erin Bischoff</a>&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5">   
        <asp:TextBox ID="TextBox18" runat="server" Width="60px"></asp:TextBox>
                      </td>
                <td class="auto-style7">
        <asp:Button ID="Button41" runat="server" OnClick="Button41_Click" Text="Arrived" />
                      </td>
                       <td class="auto-style6">
                    <asp:Button ID="Button17" runat="server" Text="Complete" OnClick="Button17_Click" />
                </td>
            </tr>
                  <tr>
                <td class="auto-style1">
        <a href="FredDemeuse.aspx">Fred Demeuse</a>&nbsp;&nbsp;</td>
                <td class="auto-style5"> 
        <asp:TextBox ID="TextBox19" runat="server" Width="60px"></asp:TextBox>
                      </td>
                <td class="auto-style7">
        <asp:Button ID="Button42" runat="server" OnClick="Button42_Click" Text="Arrived" />
                      </td>
                       <td class="auto-style6">
                    <asp:Button ID="Button18" runat="server" Text="Complete" OnClick="Button18_Click" />
                </td>
            </tr>
                  <tr>
                <td class="auto-style1">
        <a href="ChelseaEernisse.aspx">Chelsea Eernisse</a>&nbsp;&nbsp;</td>
                <td class="auto-style5">     
        <asp:TextBox ID="TextBox20" runat="server" Width="60px"></asp:TextBox>
                      </td>
                <td class="auto-style7">
        <asp:Button ID="Button43" runat="server" OnClick="Button43_Click" Text="Arrived" />
                      </td>
                       <td class="auto-style6">
                    <asp:Button ID="Button19" runat="server" Text="Complete" OnClick="Button19_Click" />
                </td>
            </tr>
                  <tr>
                <td class="auto-style1">
        <a href="AlliEngelsma.aspx">Alli Engelsma</a></td>
                <td class="auto-style5">    
        <asp:TextBox ID="TextBox21" runat="server" Width="60px"></asp:TextBox>
                      </td>
                <td class="auto-style7">
        <asp:Button ID="Button44" runat="server" OnClick="Button44_Click" Text="Arrived" />
                      </td>
                       <td class="auto-style6">
                    <asp:Button ID="Button20" runat="server" Text="Complete" OnClick="Button20_Click" />
                </td>
            </tr>
                  <tr>
                <td class="auto-style1">
        <a href="BradyGriffith.aspx">Brady Griffith</a>&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5">      
        <asp:TextBox ID="TextBox22" runat="server" Width="60px"></asp:TextBox>
                      </td>
                <td class="auto-style7">
        <asp:Button ID="Button45" runat="server" OnClick="Button45_Click" Text="Arrived" />
                      </td>
                       <td class="auto-style6">
                    <asp:Button ID="Button21" runat="server" Text="Complete" OnClick="Button21_Click" />
                </td>
                       <tr>
                <td class="auto-style1">
        <a href="JasonHicks.aspx">Jason Hicks</a>&nbsp;&nbsp;</td>
                <td class="auto-style5">    
        <asp:TextBox ID="TextBox23" runat="server" Width="60px"></asp:TextBox>
                           </td>
                <td class="auto-style7">
        <asp:Button ID="Button46" runat="server" OnClick="Button46_Click" Text="Arrived" />
                           </td>
                            <td class="auto-style6">
                    <asp:Button ID="Button22" runat="server" Text="Complete" OnClick="Button22_Click" />
                </td>
            </tr>
                       <tr>
                <td class="auto-style1">
        <a href="LisaLarson.aspx">Lisa Larson</a>&nbsp;&nbsp;</td>
                <td class="auto-style5">       
        <asp:TextBox ID="TextBox24" runat="server" Width="60px"></asp:TextBox>
                           </td>
                <td class="auto-style7">
        <asp:Button ID="Button47" runat="server" OnClick="Button47_Click" Text="Arrived" />
                           </td>
                            <td class="auto-style6">
                    <asp:Button ID="Button23" runat="server" Text="Complete" OnClick="Button23_Click" />
                </td>
            </tr>
                       <tr>
                <td class="auto-style1">
        <a href="BethRadke.aspx">Beth Radke</a>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style5">
        <asp:TextBox ID="TextBox25" runat="server" Width="60px"></asp:TextBox>
                           </td>
                <td class="auto-style7">
        <asp:Button ID="Button48" runat="server" OnClick="Button48_Click" Text="Arrived" />
                           </td>
                              <td class="auto-style6">
                    <asp:Button ID="Button24" runat="server" Text="Complete" OnClick="Button24_Click" />
                </td>
            </tr>
                       <tr>
                <td class="auto-style1">
        <a href="TamrahTenhaeff.aspx">Tamrah Tenhaeff</a>&nbsp;&nbsp;</td>
                <td class="auto-style5">
        <asp:TextBox ID="TextBox26" runat="server" Width="60px"></asp:TextBox>
                           </td>
                <td class="auto-style7">
        <asp:Button ID="Button49" runat="server" OnClick="Button49_Click" Text="Arrived" />
                           </td>
                          <td class="auto-style6">
                    <asp:Button ID="Button25" runat="server" Text="Complete" OnClick="Button25_Click" />
                </td>
            </tr>
                       <tr>
                <td class="auto-style1">
        <a href="ErinnVonRein.aspx">Erinn VonRein</a>&nbsp;&nbsp;</td>
                <td class="auto-style5">
        <asp:TextBox ID="TextBox27" runat="server" Width="60px"></asp:TextBox>
                           </td>
                <td class="auto-style7">
        <asp:Button ID="Button50" runat="server" OnClick="Button50_Click" Text="Arrived" />
                           </td>
                            <td class="auto-style6">
                    <asp:Button ID="Button26" runat="server" Text="Complete" OnClick="Button26_Click" />
                </td>
            </tr>
    
            </tr>
            </tr>
       
        </table>

            <br />
       

     <a href="Log.aspx">View Log</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <asp:Button ID="Button51" runat="server" Text="Reset" OnClientClick = "return confirm('Are you sure you want to reset?');" OnClick="Button51_Click"/>
       
    <br />
    <br />
    <br />
    </form>
</body>
    
</html>
