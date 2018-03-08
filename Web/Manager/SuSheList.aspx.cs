using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_SuSheList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindSushe();
        }
    }

    private void bindSushe()
    {
        System.Data.DataTable dt = new System.Data.DataTable();
        dt = susheSys.BLL.TbsusheBLL.GetTbsusheDT("");
        this.gvInfo.DataSource = dt;
        this.gvInfo.DataBind();
    }
    protected void gvInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.gvInfo.PageIndex = e.NewPageIndex;
        bindSushe();
    }
}