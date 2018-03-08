<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TuShu.aspx.cs" Inherits="TuShu" %>
<%@ Register Src="~/Control/Login.ascx" TagName="Login" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <uc1:Login ID="Login1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<table width="100%" cellpadding="0" cellspacing="0" class="msgtable"  >
<tr>
<td align="left" 
        style="font-weight:bold; background:#41588F; color:White; font-size:15px">入住信息</td>
</tr>
</table>
<style type="text/css">
    .left
    { background:lavender; width:200px; text-align:right; height:30px}
    #table1 td
    { border:solid 1px #DCDCDC; border-collapse:collapse}
</style>
<table cellpadding="2" cellspacing="2"  align="center"   border="1" class="msgtable"   style="width: 100%;
        margin-left: 0px" >
         
      
     <tr>
         
        <td style="width:auto; text-align:left" colspan="2">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%"
                            HeaderStyle-CssClass="HeaderStyle" CellPadding="4" 
                DataKeyNames="id" ForeColor="Black"
                             BorderColor="Black"  >
                            <Columns>
                                  <asp:BoundField DataField="ssname" HeaderText="宿舍">
                                    <ItemStyle ForeColor="Black" />
                                </asp:BoundField>
                                <asp:BoundField DataField="chuangNum" HeaderText="床号">
                                    <ItemStyle ForeColor="Black" />
                                </asp:BoundField>
                                <asp:BoundField DataField="ruzhudate" HeaderText="入住时间">
                                    <ItemStyle ForeColor="Black" />
                                </asp:BoundField>
                                 <asp:TemplateField HeaderText="退宿">
                                <ItemTemplate>
                                   <a href="TuShuUpdate.aspx?id=<%# Eval("id") %>">退宿</a>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                                 
                            </Columns>
                            <RowStyle ForeColor="#000066" BackColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B5DFDE" Font-Size="12px" Font-Underline="False" ForeColor="#1F3A87"
                                HorizontalAlign="Right" />
                            <HeaderStyle BackColor="White" Font-Bold="False" ForeColor="Black" HorizontalAlign="Center"
                                Height="20px" />
                        </asp:GridView>
        </td>
    </tr>
     
</table>
</asp:Content>

