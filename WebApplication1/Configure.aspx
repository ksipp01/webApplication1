﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Configure.aspx.cs" Inherits="WebApplication1.Configure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Select the configuration file.  <br />   
       Use Notepad to make a .txt file in the following format: <br />  
         <br />  
        MD <br />  
        Firstname Lastname <br />  
        Firstname Lastname <br />  
        (add all MDs) <br />  
        PA <br />  
        Firstname Lastname <br />  
        Firstname Lastname <br />  
        (add all PAs) <br />  
        end <br />  
          <br />  
        Save, then upload by clicking Browse below and select the .txt file.   <br />  
        Then click Load Configuration 
        <br />
        <br />  
        The File should appear below if successfully uploaded. 
        <br />
        (Note: the headings MD and PA will not be displayed)<br />
        If errors, correct the .txt file, reload page and re-upload. <br />  
        <br />  
        <asp:FileUpload ID="FileUpload1" runat="server" />  <br />  
        <br />
        <asp:Button ID="Button1" runat="server" Text="Load Configuration" OnClick="Button1_Click" /><br />  <br />  
        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="700px" Width="381px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
