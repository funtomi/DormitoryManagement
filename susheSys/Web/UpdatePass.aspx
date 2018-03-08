<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UpdatePass.aspx.cs" Inherits="UpdatePass" %>

<%@ Register Src="~/Control/Login.ascx" TagName="Login" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:Login ID="Login1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table width="100%" cellpadding="0" cellspacing="0" class="msgtable"  >
<tr>
 
<td align="left" 
        style="font-weight:bold; background:#41588F; color:White; font-size:15px">修改密码</td>
 
</tr>
</table>
<table  align="center" cellspacing="0" cellpadding="0" border="1" class="msgtable"   style="width: 100%;
        margin-left: 0px" >
        <tr>
          <td  style="width:100px; text-align:right">帐号<span style="color:Red">*</span>：</td>
        <td style="width:auto; text-align:left"><asp:TextBox ID="TextBox1" runat="server"   Enabled="false"/></td>
        </tr>
    <tr>
        <td style="width:100px; text-align:right">原始密码<span style="color:Red">*</span>：</td>
        <td style="width:auto; text-align:left"><asp:TextBox ID="TextBox6" runat="server"   TextMode="Password" /></td>
    </tr>
    <tr>
        <td style="width:100px; text-align:right">密码<span style="color:Red">*</span>：</td>
        <td style="width:auto; text-align:left"><asp:TextBox ID="TextBox8" runat="server"  TextMode="Password" /></td>
    </tr>
    <tr>
        <td style="width:100px; text-align:right">确认密码<span style="color:Red">*</span>：</td>
        <td style="width:auto; text-align:left"><asp:TextBox ID="TextBox9" runat="server"   TextMode="Password" /></td>
    </tr>
    <tr>
        <td class="left">&nbsp;</td>
        <td style="width:auto; text-align:left">
            <asp:Button ID="Button1" runat="server" Text="修改密码" onclick="Button1_Click" OnClientClick="return sub()" />
        </td>
    </tr>
</table>

<script type="text/javascript">
    //重填
    function clean() {
        var input = document.getElementsByTagName("input");
        for (var i = 0; i < input.length; i++) {
            if (input[i].type == "text")
                input[i].value = "";
            else if (input[i].type == "password")
                input[i].value = "";
        }
        return false;
    }

    function sub() {
        var mes = ["<%=TextBox6.ClientID %>", "<%=TextBox8.ClientID %>", "<%=TextBox9.ClientID %>"];
        var mgf = ["请填写原始密码", "请填写新密码", "请确认密码"];
        for (var i = 0; i < mes.length; i++) {
            if (document.getElementById(mes[i]).value.length == 0) {
                alert(mgf[i]);
                return false;
            }
           if (document.getElementById(mes[2]).value != document.getElementById(mes[1]).value) {
                alert("两次输入的密码不一致");
                return false;
            }
        }
    }
</script> 
</asp:Content>



