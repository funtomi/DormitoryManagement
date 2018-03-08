<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChuangAdd.aspx.cs" Inherits="Manager_ChuangAdd" %>

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
          <TD height=2 align="center">
              <table id="Table1" align="center" border="0" cellpadding="5" cellspacing="0" width="100%">
                 
                 <tr>
                      <td    align="right">
                          <font face="宋体">所属宿舍：</font></td>
                      <td align="left" >
                          <asp:DropDownList ID="DropDownList1" runat="server">
                          </asp:DropDownList>    
                      </td>
                     
                  </tr>
                  <tr>
                      <td    align="right">
                          <font face="宋体">床位名：</font></td>
                      <td align="left" >
                          <asp:TextBox ID="Name" runat="server" ForeColor="Gray" Width="150px"></asp:TextBox>
                           
                      </td>
                     
                  </tr>
                   <tr>
                      <td    align="right">
                          <font face="宋体">展示图片：</font></td>
                      <td align="left" >
                          <input id="Pic"  runat="server" class="submit" style="width: 150px" type="file" />
                           
                      </td>
                     
                  </tr>
                 
                  <tr>
                      <td    align="right">
                          <font face="宋体">备注说明：</font></td>
                      <td align="left" >
                          <asp:TextBox ID="TextBox1" runat="server" ForeColor="Gray" Width="400px"></asp:TextBox>
                           
                      </td>
                     
                  </tr>
                  <tr>
                      <td align="center" colspan="2">
                          <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="保存" /></td>
                  </tr>
              </table>
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
