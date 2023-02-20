<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Zahtevi_ADMIN.aspx.cs" Inherits="WebApplication11.Account.Zahtevi_ADMIN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Izaberi zahtev!!"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList><br />
    <asp:Button ID="Button1" runat="server" Text="Otkazi" BorderStyle="Outset" OnClick="Button1_Click" BackColor="#FF3300" />
    <asp:Button ID="Button2" CssClass="p" runat="server" Text="Potvrdi" OnClick="Button2_Click" BackColor="Aqua" /> <br />
    <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>

</asp:Content>
