using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class UpdateInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null || Session["id"].ToString() == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登录超时！');window.location.href='Default.aspx'</script>");
            return;
        }
        this.TextBox1.Text = Session["user"].ToString();
        if (!IsPostBack)
        {
            bindInfo();
        }
    }

    private void bindInfo()
    {
        string getsql = "select * from tbuser where id='" + Session["id"].ToString() + "'";
        DataTable mydt = new DataTable();
        mydt = susheSys.DAL.DBM.getTable(getsql);
        if (mydt.Rows.Count > 0)
        {
            this.TextBox8.Text = mydt.Rows[0]["uname"].ToString();
            DropDownList1.SelectedItem.Text = mydt.Rows[0]["sex"].ToString();

            TextBox5.Text = mydt.Rows[0]["phone"].ToString();
            TextBox4.Text = mydt.Rows[0]["remark"].ToString();

            TextBox6.Text = mydt.Rows[0]["address"].ToString();
            TextBox7.Text = mydt.Rows[0]["email"].ToString();
 

             
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        //修改 sql
        string getsql = "update dbo.tbuser set uname='" + this.TextBox8.Text + "', sex='" + DropDownList1.SelectedItem.Text + "',phone='" + TextBox5.Text + "',remark='" + TextBox4.Text + "',address='" + TextBox6.Text + "',email='" + this.TextBox7.Text + "'  where  id='" + Session["id"].ToString() + "'";
        
        Exception ex= susheSys.DAL.DBM.Execute(getsql); // 执行sql

        if (ex==null)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');</script>");

        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('操作出现异常！');</script>");
            return;
        }
    }
}