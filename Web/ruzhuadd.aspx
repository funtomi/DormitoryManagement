<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ruzhuadd.aspx.cs" Inherits="ruzhuadd" %>
<%@ Register Src="~/Control/Login.ascx" TagName="Login" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <uc1:Login ID="Login1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<script src="My97DatePicker/WdatePicker.js" type="text/javascript"></script>

    <table width="100%" cellpadding="0" cellspacing="0" class="msgtable"  >
<tr>
 <td align="left" 
        style="font-weight:bold; background:#41588F; color:White; font-size:15px">入住登记</td>
 
</tr>
</table>
<table  align="center" cellspacing="0" cellpadding="0" border="1" class="msgtable"   style="width: 100%;
        margin-left: 0px" >
 

<tr>
<td style="width:100px; text-align:right">入住宿舍:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left" colspan="2"><asp:Label ID="Label2" runat="server"  ></asp:Label> </td>
</tr>
<tr>
<td style="width:100px; text-align:right">床号:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left" colspan="2">
    <asp:Label ID="Label1" runat="server"  ></asp:Label> </td>
</tr>
 
<tr>
<td style="width:100px; text-align:right">入住日期:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left" colspan="2"><asp:TextBox ID="TextBox6" runat="server" onfocus="WdatePicker()"  /></td>
</tr>
 


 
 
<tr>
<td style="width:100px; text-align:right"></td>
<td style="width:300px; text-align:left" colspan="2">  <asp:Button ID="Button1" runat="server" Text="入住登记" onclick="Button1_Click"   /></td>
</tr>
 
</table>

</asp:Content>

