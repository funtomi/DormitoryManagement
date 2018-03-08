<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RuZhu.aspx.cs" Inherits="Manager_RuZhu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title> </title>
      <LINK href="Images/Style.css"type=text/css rel=stylesheet><LINK  href="Images/Manage.css" type=text/css rel=stylesheet>
</head>
<body>
    <FORM id=form1   runat=server>
<TABLE cellSpacing=0 cellPadding=0 width="98%" border=0>
  <TBODY>
  <TR>
    <TD width=15><IMG src="Images/new_019.jpg" border=0></TD>
    <TD width="100%" background=Images/new_020.jpg height=20></TD>
    <TD width=15><IMG src="Images/new_021.jpg" 
  border=0></TD></TR></TBODY></TABLE>
<TABLE cellSpacing=0 cellPadding=0 width="98%" border=0>
  <TBODY>
  <TR>
    <TD width=15 background=Images/new_022.jpg style="height: 61px"><IMG 
      src="Images/new_022.jpg" border=0> </TD>
    <TD vAlign=top width="100%" bgColor=#ffffff style="height: 61px">
      <TABLE cellSpacing=0 cellPadding=5 width="100%" border=0>
        
        <TR>
          <TD height=2 align="left">
                          <asp:GridView ID="gvInfo" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                              BackColor="White" CellPadding="5" DataKeyNames="id" OnPageIndexChanging="gvInfo_PageIndexChanging"
                                PageSize="12" Width="100%">
                              <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPreviousFirstLast"
                                  NextPageText="下一页" PageButtonCount="12" PreviousPageText="上一页" />
                              <RowStyle HorizontalAlign="Left" />
                              <Columns>
                              <asp:TemplateField HeaderText="会员名">
                    <ItemTemplate>
                        <asp:Label ID="name" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="center"   />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="联系电话">
                    <ItemTemplate>
                        <asp:Label ID="phone" runat="server" Text='<%# Bind("phone") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="center"   />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="床位名">
                    <ItemTemplate>
                        <asp:Label ID="Label11" runat="server" Text='<%# Bind("chuangNum") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="center"   />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="宿舍名称">
                    <ItemTemplate>
                        <asp:Label ID="ssname" runat="server" Text='<%# Bind("ssname")%>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="center"   />
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="入住日期">
                    <ItemTemplate>
                        <asp:Label ID="Label12" runat="server" Text='<%# Bind("ruzhudate") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="center"   />
                </asp:TemplateField>
                 
                 
                       
            </Columns>
                              <HeaderStyle BackColor="#F6F6F6" />
                          </asp:GridView>
              &nbsp 
          </TD></TR></TABLE>
      </TD>
    <TD width=15 background=Images/new_023.jpg style="height: 61px"><IMG 
      src="Images/new_023.jpg" border=0> </TD></TR></TBODY></TABLE>
<TABLE cellSpacing=0 cellPadding=0 width="98%" border=0>
  <TBODY>
  <TR>
    <TD width=15><IMG src="Images/new_024.jpg" border=0></TD>
    <TD align=middle width="100%" background=Images/new_025.jpg 
    height=15></TD>
    <TD width=15><IMG src="Images/new_026.jpg" 
  border=0></TD></TR></TBODY></TABLE>
</FORM>
</body>
</html>
