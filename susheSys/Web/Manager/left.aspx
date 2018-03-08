<%@ Page Language="C#" AutoEventWireup="true" CodeFile="left.aspx.cs" Inherits="Manager_left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0" bgcolor="#EEF2FB">
                <tr>
                    <td width="182" valign="top">
                        <asp:TreeView ID="TreeView1" runat="server" ImageSet="Faq">
                            <HoverNodeStyle Font-Underline="True" ForeColor="Purple" />
                            <Nodes>
                                <asp:TreeNode Text="宿舍管理" Value="宿舍管理">
                                    <asp:TreeNode Text="宿舍管理" NavigateUrl="SuSheList.aspx" Value="宿舍管理" Target="mainframe"></asp:TreeNode>
                                    <asp:TreeNode Text="宿舍添加"  NavigateUrl="SuSheAdd.aspx" Value="宿舍添加" Target="mainframe"></asp:TreeNode>
                                    <asp:TreeNode Text="床位信息管理"  NavigateUrl="ChuangList.aspx" Value="床位信息管理" Target="mainframe"></asp:TreeNode>
                                    <asp:TreeNode Text="床位信息管理添加"  NavigateUrl="ChuangAdd.aspx" Value="床位信息管理添加" Target="mainframe"></asp:TreeNode>
                                
                                    

                                </asp:TreeNode>
                                
                               <asp:TreeNode Text="会员信息管理" Value="会员信息管理">
                                    <asp:TreeNode Text="会员信息管理" NavigateUrl="User.aspx" Value="会员信息管理" Target="mainframe"></asp:TreeNode>
                                   
                                </asp:TreeNode>
                              
                                 <asp:TreeNode Text="入住信息管理" Value="入住信息管理">
                                  <asp:TreeNode Text="在住信息查看"  NavigateUrl="RuZhu.aspx" Value="在住信息查看" Target="mainframe"></asp:TreeNode>
                                    <asp:TreeNode Text="入住记录查看"  NavigateUrl="TuShu.aspx" Value="入住记录查看" Target="mainframe"></asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="退出系统" Value="退出系统">
                                  <asp:TreeNode Text="注销登录"  NavigateUrl="Login.aspx" Value="注销登录" Target="mainframe"></asp:TreeNode>
                                </asp:TreeNode>
                            </Nodes>
                            <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="DarkBlue" 
                                HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                            <ParentNodeStyle Font-Bold="False" />
                            <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" 
                                VerticalPadding="0px" />
                        </asp:TreeView>
                         
        </form>
</body>
</html>
