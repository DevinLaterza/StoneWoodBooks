﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePW.aspx.cs" Inherits="StoneWoodBooks.UpdatePW" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style ="height:300px; width:700px; border:solid; 
    border-width:10px; border-radius:10px; margin:auto;
    text-align:center; vertical-align:auto">
        <asp:Label ID="lblpw" runat="server" Text="Type in your password"></asp:Label>
    <br />
        <asp:TextBox ID="txtPW" runat="server"></asp:TextBox>
    </div>
</asp:Content>