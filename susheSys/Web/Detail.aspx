<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="Detail" %>
<%@ Register Src="~/Control/Login.ascx" TagName="Login" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <uc1:Login ID="Login1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<table width="100%" cellpadding="0" cellspacing="0" class="msgtable"  >
<tr>
<td align="left" 
        style="font-weight:bold; background:#41588F; color:White; font-size:15px">信息</td>
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
          <td  colspan="2">
              <asp:Image ID="Image1" runat="server"  Height="100px" Width="200px"/></td>
        </tr>
        <tr>
          <td style="width:100px; text-align:right">宿舍名称： </td>
        <td style="width:auto; text-align:left">
            <asp:Label ID="houseNum" runat="server"  ></asp:Label> </td>
        </tr>
    <tr>
        <td style="width:100px; text-align:right">备注说明： </td>
        <td style="width:auto; text-align:left"><asp:Label ID="typeid" runat="server"  ></asp:Label></td>
    </tr>
      
     <tr>
         
        <td style="width:auto; text-align:left" colspan="2">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%"
                            HeaderStyle-CssClass="HeaderStyle" CellPadding="4" 
                DataKeyNames="id" ForeColor="Black"
                             BorderColor="Black">
                            <Columns>
                                <asp:TemplateField HeaderText="展示图">
                                    <ItemTemplate>
                                        <img  src="<%# Eval("pic") %>"  height="50px" width="50px"/>
                                        
                                    </ItemTemplate>
                                    
                                    <ItemStyle ForeColor="Black" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="chuangNum" HeaderText="床号">
                                    <ItemStyle ForeColor="Black" />
                                </asp:BoundField>
                                <asp:BoundField DataField="remark" HeaderText="备注说明">
                                    <ItemStyle ForeColor="Black" />
                                </asp:BoundField>
                                 <asp:TemplateField HeaderText="入住">
                                <ItemTemplate>
                                   <a href="ruzhuadd.aspx?id=<%# Eval("id") %>">入住</a>
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

