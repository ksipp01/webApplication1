<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeBehind="LisaLarson.aspx.cs" Inherits="WebApplication1.LisaLarson" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
     <p>
            Lisa Larson - ETA:</p>
        <asp:TextBox ID="TextBox1" runat="server" pattern="[0-9]*"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
    </div>
     <br />
            (Enter estimated minutes to arrival e.g. 20) <br />
     <a href = "index.aspx" > Index</a>
</asp:Content>
