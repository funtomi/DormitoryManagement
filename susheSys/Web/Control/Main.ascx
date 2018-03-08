<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Main.ascx.cs" Inherits="Control_Main" %>
<table align="center" cellspacing="0" cellpadding="0"   class="msgtable"   style="width: 100%;
        margin-left: 0px" >
<tr>
 
<td align="left" 
        style="font-weight:bold; background:#41588F; color:White; font-size:15px">最新宿舍</td>
 
</tr>
<tr>
<td style="height: 174px" >
<asp:DataList ID="DataList1" runat="server"     style="border-right: #cccccc 1px solid; border-top: #cccccc 1px solid; border-left: #cccccc 1px solid; border-bottom: #cccccc 1px solid" 
              Width="100%" RepeatColumns="5" RepeatDirection="Horizontal" >
                   <ItemTemplate>
                        <table>
                            <tr>
                                <td height="10">
                                </td>
                            </tr>
                            <tr>
                                <td>
                                  <a href='Detail.aspx?id=<%#Eval("id") %>'><asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("pic") %>'    Style="width: 96px;
                                        height: 85px" /></a></td>
                            </tr>
                            <tr>
                                <td style="height: 16px">
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("ssname").ToString().Length > 14? Eval("ssname").ToString().Substring(0, 14):Eval("ssname") %>'></asp:Label>
                                    </td>
                            </tr>
                            <tr>
                                <td style="height: 10px">
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
</td>
</tr>


 
  
</table>