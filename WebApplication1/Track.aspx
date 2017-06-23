<%@ Page Language="C#"  MasterPageFile="~/Master.master" AutoEventWireup="true" CodeBehind="Track.aspx.cs" Inherits="WebApplication1.Track" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div>
     <asp:HiddenField runat="server" ID="_repostcheckcode" />
            <meta http-equiv="refresh" content="20" />
          <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="large" Text="EMPAC Provider Tracker"></asp:Label>
        <br />
   <div id="placeholder" runat="server">
    <!-- here is where the dinamically created elements will be placed -->
    </div>




    </div>
     </asp:Content>
