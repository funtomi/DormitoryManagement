<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="Control_Login" %>
<table width="200px" cellpadding="0" cellspacing="0">
<tr>
 
<td align="left" 
        style="font-weight:bold; background:#41588F; color:White; font-size:15px">会员登录</td>
 
</tr>
</table>
<%--会员登陆--%>
<div style="display:none" id="div1" runat="server">
<table width="200px" cellpadding="0" cellspacing="0" class="msgtable"    >
<tr>
<td colspan="2" align="center" style="height:30px; color:Red">
    <asp:Label ID="Label1" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td style="width:60px; height:30px; text-align:right">帐号:</td>
<td style="width:140px; text-align:left"><asp:TextBox ID="TextBox1" runat="server" Width="100px" Height="13px" /></td>
</tr>
<tr>
<td style="width:60px; height:30px; text-align:right">密码:</td>
<td style="width:140px; text-align:left"><asp:TextBox ID="TextBox2" runat="server" Width="100px" Height="13px" TextMode="Password" /></td>
</tr>
 
<tr>
<td colspan="2" align="center">
    <asp:ImageButton ID="btnlogin" runat="server" ImageUrl="~/Images/web/login_bt.gif"  OnClick="btnlogin_Click" style="border-width: 0px;width: 80px; height: 27px;"/>
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/web/reg.gif" style="border-width: 0px;width: 80px; height: 27px;" OnClick="ImageButton1_Click" />
                                        
</td>
</tr>
</table>
</div>
<%--会员信息--%>
<div style="display:none" id="div2" runat="server">
<table width="200px" class="msgtable"   >
<tr>
<td align="left" style="padding-left:10px; height:25px">欢迎您:<asp:Label ID="lblauthor" runat="server"  /></td>
</tr>
 
<tr>
<td align="left" style="padding-left:10px; height:25px">
<a href="UpdatePass.aspx" style="color:Black; text-decoration:none">更改密码</a><br />
<a href="UpdateInfo.aspx" style="color:Black; text-decoration:none">更改资料</a><br />
<a href="TuShu.aspx" style="color:Black; text-decoration:none">退宿</a><br />
<a href="RuZhu.aspx" style="color:Black; text-decoration:none">入住记录</a><br />

<asp:LinkButton  ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">【退出登录】</asp:LinkButton>
</td>
</tr>
</table>
 
</div>