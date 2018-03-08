using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RuZhu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null || Session["id"].ToString() == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登录超时！');window.location.href='Default.aspx'</script>");
            return;
        }
        if (!IsPostBack)
        {
            bindRuZhu();
        }
    }

    private void bindRuZhu()
    {
        System.Data.DataTable dt = new System.Data.DataTable();
        dt = susheSys.DAL.DBM.getTable("SELECT  dbo.tbchuang.chuangNum,dbo.tbruzhu.tuchudate, dbo.tbruzhu.id,dbo.tbchuang.remark, dbo.tbsushe.ssname, dbo.tbruzhu.ruzhudate FROM  dbo.tbchuang INNER JOIN  dbo.tbsushe ON dbo.tbchuang.susheid = dbo.tbsushe.id INNER JOIN  dbo.tbruzhu ON dbo.tbchuang.id = dbo.tbruzhu.chuangid where  dbo.tbruzhu.userid='" + Session["id"].ToString() + "' and dbo.tbruzhu.state=2  ");
        if (dt != null && dt.Rows.Count > 0)
        {
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        this.GridView1.PageIndex =e.NewPageIndex;
        bindRuZhu();

    }
}