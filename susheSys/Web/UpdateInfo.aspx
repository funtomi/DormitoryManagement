<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UpdateInfo.aspx.cs" Inherits="UpdateInfo" %>

<%@ Register Src="~/Control/Login.ascx" TagName="Login" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<uc1:Login ID="Login1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<script language="javascript" type="text/javascript">
    function MustSave() {



        if (document.getElementById("<%=TextBox1.ClientID %>").value == "") {
            alert('帐号不能为空');
            return false;
        }
        if (document.getElementById("<%=TextBox8.ClientID %>").value == "") {
            alert('姓名不能为空');
            return false;
        }

        if (document.getElementById("<%=TextBox5.ClientID %>").value == "") {
            alert('电话不能为空');
            return false;
        }

        if (document.getElementById("<%=TextBox7.ClientID %>").value == "") {
            alert('邮箱不能为空');
            return false;
        }
    }
    
    </script>
    <table width="100%" cellpadding="0" cellspacing="0" class="msgtable"  >
<tr>
 <td align="left" 
        style="font-weight:bold; background:#41588F; color:White; font-size:15px">信息修改</td>
 
</tr>
</table>
<table  align="center" cellspacing="0" cellpadding="0" border="1" class="msgtable"   style="width: 100%;
        margin-left: 0px" >
 

<tr>
<td style="width:100px; text-align:right">登录帐号:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left" colspan="2"><asp:TextBox ID="TextBox1" runat="server" /></td>
</tr>
<tr>
<td style="width:100px; text-align:right">姓名:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left" colspan="2"><asp:TextBox ID="TextBox8" runat="server"  /></td>
</tr>
 
<tr>
<td style="width:100px; text-align:right">性别:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left" colspan="2"> 
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="1">男</asp:ListItem>
        <asp:ListItem Value="2">女</asp:ListItem>
    </asp:DropDownList></td>
</tr>
 
<tr>
<td style="width:100px; text-align:right">家庭地址:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left" colspan="2"><asp:TextBox ID="TextBox6" runat="server" /></td>
</tr>
<tr>
<td style="width:100px; text-align:right">电话:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left" colspan="2"><asp:TextBox ID="TextBox5" runat="server"  onkeyup="value=value.replace(/[^\d]/g,'')" /></td>
</tr>


<tr>
<td style="width:100px; text-align:right">邮箱:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left" colspan="2"><asp:TextBox ID="TextBox7" runat="server" /></td>
</tr>
<tr>
<td style="width:100px; text-align:right">备注:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left" colspan="2"><asp:TextBox ID="TextBox4" runat="server"  /></td>
 
</tr>
 
<tr>
<td style="width:100px; text-align:right"></td>
<td style="width:300px; text-align:left" colspan="2">  <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" OnClientClick="return MustSave()" /></td>
</tr>
 
</table>

</asp:Content>

