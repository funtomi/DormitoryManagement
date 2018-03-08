using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_Reg : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //重名判断
        DataTable mydt = new DataTable();
        mydt = susheSys.BLL.TbuserBLL.GetTbuserDT(" name='" + this.TextBox1.Text + "'");
        if (mydt!=null&&mydt.Rows.Count > 0)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('帐号重复了请换一个！');</script>");
            return;

        }
        susheSys.Models.TbuserInfo tbuser = new susheSys.Models.TbuserInfo();
        tbuser.Name = this.TextBox1.Text.Trim();
        tbuser.Pwd = this.TextBox2.Text.Trim();
        tbuser.Sex = this.DropDownList1.SelectedItem.Text;
        tbuser.Phone = this.TextBox5.Text.Trim();
        tbuser.Address = this.TextBox6.Text.Trim();
        tbuser.Uname = this.TextBox8.Text.Trim();

        tbuser.Email = this.TextBox7.Text.Trim();
        tbuser.Remark = this.TextBox4.Text.Trim();
        // insert 
        Exception ex=  susheSys.BLL.TbuserBLL.Add(tbuser);
        if (ex==null)
        {

            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('注册成功！');window.location.href='Default.aspx'</script>");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('操作出现异常！请重试');</script>");
            return;
        }
    }
}