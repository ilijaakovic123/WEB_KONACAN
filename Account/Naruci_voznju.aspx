<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Naruci_voznju.aspx.cs" Inherits="WebApplication11.Account.Naruci_voznju" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label0" runat="server" Text="Ime narucioca"></asp:Label><br />
    <asp:TextBox ID="TextBox0" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label1" runat="server" Text="Datum"></asp:Label><br />
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar><br />
    <asp:Label ID="Label3" runat="server" Text="Polazna adresa"></asp:Label><br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Krajnja adresa"></asp:Label><br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br />
    <asp:Label ID="ErrorLabel1" runat="server" Text=""></asp:Label>

</asp:Content>
