<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Reg.ascx.cs" Inherits="Control_Reg" %>
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

        if (document.getElementById("<%=TextBox2.ClientID %>").value == "") {
            alert('密码不能为空');
            return false;
        }

        if (document.getElementById("<%=TextBox3.ClientID %>").value == "") {
            alert('确认密码不能为空');
            return false;
        }
        if (document.getElementById("<%=TextBox2.ClientID %>").value != document.getElementById("<%=TextBox3.ClientID %>").value) {
            alert('两次密码输入不匹配');
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
        style="font-weight:bold; background:#41588F; color:White; font-size:15px">用户注册</td>
 
</tr>
</table>
<table  align="center" cellspacing="0" cellpadding="0" border="1" class="msgtable"   style="width: 100%;
        margin-left: 0px" >
 

<tr>
<td style="width:100px; text-align:right">登录帐号:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left"><asp:TextBox ID="TextBox1" runat="server" /></td>
</tr>
<tr>
<td style="width:100px; text-align:right">姓名:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left"><asp:TextBox ID="TextBox8" runat="server"  /></td>
</tr>
<tr>
<td style="width:100px; text-align:right">密码:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left"><asp:TextBox ID="TextBox2" runat="server" TextMode="Password" /></td>
</tr>
<tr>
<td style="width:100px; text-align:right">确认密码:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left"><asp:TextBox ID="TextBox3" runat="server" TextMode="Password" /></td>
</tr>
<tr>
<td style="width:100px; text-align:right">性别:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left"> 
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="1">男</asp:ListItem>
        <asp:ListItem Value="2">女</asp:ListItem>
    </asp:DropDownList></td>
</tr>
 
<tr>
<td style="width:100px; text-align:right">家庭地址:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left"><asp:TextBox ID="TextBox6" runat="server" /></td>
</tr>
<tr>
<td style="width:100px; text-align:right">电话:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left"><asp:TextBox ID="TextBox5" runat="server"  onkeyup="value=value.replace(/[^\d]/g,'')" /></td>
</tr>


<tr>
<td style="width:100px; text-align:right">邮箱:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left"><asp:TextBox ID="TextBox7" runat="server" /></td>
</tr>
<tr>
<td style="width:100px; text-align:right">备注信息:&nbsp;&nbsp;</td>
<td style="width:300px; text-align:left"><asp:TextBox ID="TextBox4" runat="server"  /></td>
</tr>
 
<tr>
<td style="width:100px; text-align:right"></td>
<td style="width:300px; text-align:left"> <asp:ImageButton ID="ImageButton1" OnClientClick="return MustSave()" runat="server" ImageUrl="~/Images/web/reg.gif" style="border-width: 0px;width: 80px; height: 27px;" OnClick="ImageButton1_Click" /></td>
</tr>
 
</table>