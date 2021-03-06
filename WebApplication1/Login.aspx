﻿<%@ Page Language="C#" MasterPageFile="~/Mobile/Mobile.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.LoginTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
       
        <asp:Label ID="Label2" runat="server" Text="Name:" Font-Names="Arial"></asp:Label>         
        <br />
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="150px" AutoPostBack="True"></asp:ListBox>
    
        <br />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Font-Names="Arial"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" Font-Names="Arial" />
        <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="ETA:" Font-Names="Arial"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" pattern="[0-9]*" Font-Names="Arial"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Font-Names="Arial" />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Names="Arial" Text="Enter estimated minutes to arrival <br />(e.g. 20)" Font-Size="Small"></asp:Label>
    </div>
 </asp:Content>
