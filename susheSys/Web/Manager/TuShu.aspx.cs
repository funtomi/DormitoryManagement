using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_TuShu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindRuzhu();
        }
    }

    private void bindRuzhu()
    {
        string getsql = @"SELECT     dbo.tbuser.name, dbo.tbuser.sex, dbo.tbuser.phone, dbo.tbuser.address, dbo.tbuser.email, dbo.tbsushe.ssname, dbo.tbruzhu.ruzhudate, dbo.tbchuang.chuangNum, 
                      dbo.tbruzhu.id , dbo.tbruzhu.tuchudate  FROM         dbo.tbchuang INNER JOIN  dbo.tbruzhu ON dbo.tbchuang.id = dbo.tbruzhu.chuangid INNER JOIN
                      dbo.tbsushe ON dbo.tbchuang.susheid = dbo.tbsushe.id INNER JOIN        dbo.tbuser ON dbo.tbruzhu.userid = dbo.tbuser.id where dbo.tbruzhu.state=2 ";
        System.Data.DataTable dt = new System.Data.DataTable();
        dt = susheSys.DAL.DBM.getTable(getsql);

        this.gvInfo.DataSource = dt;
        this.gvInfo.DataBind();
    }
    protected void gvInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.gvInfo.PageIndex = e.NewPageIndex;
        bindRuzhu();
    }
}