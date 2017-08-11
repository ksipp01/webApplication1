<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="WebApplication1.Success" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Thank you! <br /> <br /> Your ETA has been submitted" Font-Names="Arial"></asp:Label>  
    </div>
    <script type="text/javascript">
setTimeout("self.close()", 30000 ) // after 30 seconds
    </script>
 </asp:Content>
