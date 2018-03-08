<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Manager_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="css/admin_login.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
  <div class="admin_login_wrap">
    <h1 align="center">宿舍管理系统</h1>
    <div class="adming_login_border">
        <div class="admin_input">
            
                <ul class="admin_items">
                    <li>
                        <label for="user">用户名</label>
                        <asp:TextBox ID="Text2" runat="server" class="admin_input_style" Width="242px"></asp:TextBox>
                    </li>
                    <li>
                        <label for="pwd">密码</label>
                        <asp:TextBox ID="Password1" runat="server" TextMode="Password" class="admin_input_style" Width="242px"></asp:TextBox>
                    </li>
                    
                   
                    <li>
                        <input type="submit" tabindex="3" value="提交" class="btn btn-primary" id="Submit1" onserverclick="Submit1_ServerClick" runat="server" />
                    </li>
                </ul>
            
        </div>
    </div>
    
</div>
    </form>
</body>
</html>
