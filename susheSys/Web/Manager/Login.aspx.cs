using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Submit1_ServerClick(object sender, EventArgs e)
    {
        if (Text2.Text == "" && Password1.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请输入账号和密码！');window.location.href='Login.aspx'</script>");
            return;
        }
      System.Data.DataTable dt=  susheSys.BLL.AdminBLL.GetAdminDT(" Name='" + this.Text2.Text + "' and pass='"+this.Password1.Text+"'");
      if (dt != null && dt.Rows.Count > 0)
      {
          Session["mid"] = dt.Rows[0]["id"].ToString();
          Session["mname"] = dt.Rows[0]["Name"].ToString();
          Response.Redirect("Frame.aspx");
      }
      else
      {
          Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('帐号密码不正确！');</script>");
          return;
      }
         

    }
}