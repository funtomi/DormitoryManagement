using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ruzhuadd : System.Web.UI.Page
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
            this.TextBox6.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
            bindInfo();
        }
    }

    private void bindInfo()
    {
        System.Data.DataTable dt = new System.Data.DataTable();
        dt = susheSys.DAL.DBM.getTable(" SELECT     dbo.tbsushe.ssname, dbo.tbchuang.chuangNum, dbo.tbchuang.id  FROM         dbo.tbchuang INNER JOIN    dbo.tbsushe ON dbo.tbchuang.susheid = dbo.tbsushe.id where dbo.tbchuang.id='"+Request.QueryString["id"].ToString()+"'");
        this.Label1.Text = dt.Rows[0]["chuangNum"].ToString();
        this.Label2.Text = dt.Rows[0]["ssname"].ToString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        susheSys.Models.TbruzhuInfo ruzhu = new susheSys.Models.TbruzhuInfo();
        ruzhu.Ruzhudate = this.TextBox6.Text.ToString();
        ruzhu.Userid =Convert.ToInt32( Session["id"].ToString());
        ruzhu.Chuangid=Convert.ToInt32(Request.QueryString["id"].ToString());
        ruzhu.State = 1;
        System.Data.DataTable dt = new System.Data.DataTable();
        dt = susheSys.BLL.TbruzhuBLL.GetTbruzhuDT(" state=1  and chuangid='"+Request.QueryString["id"].ToString()+"'");

        if (dt != null && dt.Rows.Count > 0)
        {
            //state =1 标示已经入住 2标示退
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('您选择的床位为入住状态，请选择其他的床位！');</script>");
            return;
        }
        System.Data.DataTable dt1 = new System.Data.DataTable();
        dt1 = susheSys.BLL.TbruzhuBLL.GetTbruzhuDT(" state=1  and userid='" + Session["id"].ToString() + "'");

        if (dt1 != null && dt1.Rows.Count > 0)
        {
            //state =1 标示已经入住 2标示退
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('您已经有相应入住信息，请先退床而后在进行入住操作！');</script>");
            return;
        }

        Exception ex = susheSys.BLL.TbruzhuBLL.Add(ruzhu);
        if (ex == null)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('入住成功！');window.location.href='ChuangList.aspx'</script>");

        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('操作出现异常！');</script>");
            return;
        }
    }
}