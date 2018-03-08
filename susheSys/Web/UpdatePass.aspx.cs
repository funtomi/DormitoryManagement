using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class UpdatePass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null || Session["id"].ToString() == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登录超时！');window.location.href='Default.aspx'</script>");
            return;

        }
        this.TextBox1.Text = Session["user"].ToString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string getsql = "select * from tbuser where id='" + Session["id"].ToString() + "'";
        DataTable mydt = new DataTable();
        mydt = susheSys.DAL.DBM.getTable(getsql);
        string oldpwd = mydt.Rows[0]["pwd"].ToString(); //获取原密码

        if (this.TextBox6.Text != oldpwd)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('原密码不正确！');</script>");
            return;
        }
        //修改密码sql
        getsql = "update dbo.tbuser set pwd='" + this.TextBox8.Text + "' where  id='" + Session["id"].ToString() + "'";
        Exception ex = susheSys.DAL.DBM.Execute(getsql); // 执行sql

        if (ex==null)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('密码修改成功！');</script>");

        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('操作出现异常！');</script>");
            return;
        }

    }
}