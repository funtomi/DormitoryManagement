using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_Login : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            div1.Style.Add("display", "none");
            div2.Style.Add("display", "none");
            if (Session["user"] == null)
                div1.Style.Add("display", "block");
            else
            {

                div2.Style.Add("display", "block");
                lblauthor.Text = Session["user"].ToString();

            }
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        div2.Style.Add("display", "none");
        div1.Style.Add("display", "block");
        Response.Redirect("Default.aspx");
    }
    protected void btnlogin_Click(object sender, ImageClickEventArgs e)
    {
        //  提数据库记录  根据用户名和密码
        DataTable mydt = new DataTable();
        mydt = susheSys.BLL.TbuserBLL.GetTbuserDT(" name='" + this.TextBox1.Text.Trim() + "' and pwd='" + this.TextBox2.Text.Trim() + "' ");
        if (mydt != null && mydt.Rows.Count > 0)
        {
            Session["user"] = mydt.Rows[0]["name"].ToString(); //存储session值返回dt 
            Session["id"] = mydt.Rows[0]["id"].ToString();
            div2.Style.Add("display", "block");
            lblauthor.Text = Session["user"].ToString();
            div1.Style.Add("display", "none");

        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('帐号密码不正确！');</script>");
            return;
        }
        


    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}