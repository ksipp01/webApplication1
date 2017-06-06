<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeBehind="SarahDundee.aspx.cs" Inherits="WebApplication1.SarahDundee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
     <p>
            Sarah Dundee - ETA:</p>
        <asp:TextBox ID="TextBox1" runat="server" pattern="[0-9]*"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
    </div>
            (Enter estimated minutes to arrival e.g. 20) <br />
     <br />
     <a href = "index.aspx" > Index</a>
</asp:Content>
