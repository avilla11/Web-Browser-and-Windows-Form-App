<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="Button1" runat="server" Height="89px" OnClick="Button1_Click" Text="Sort" Width="143px" />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Label ID="Label1" runat="server" Text="Sorted Numbers:" Width="100px"></asp:Label>

</asp:Content>
