<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<%@ Register Src="~/Control/Login.ascx" TagName="Login" TagPrefix="uc1" %>
<%@ Register Src="~/Control/Reg.ascx" TagName="Reg" TagPrefix="Reg1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:Login ID="Login1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <Reg1:Reg ID="Reg1" runat="server" />

</asp:Content>

