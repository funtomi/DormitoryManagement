using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ChuangList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindChuang();
        }
    }

    private void bindChuang()
    {
        DataTable chuangdt = new DataTable();
        chuangdt = susheSys.BLL.TbchuangBLL.GetTbchuangDT("");
        this.GridView1.DataSource = chuangdt;
        this.GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        bindChuang();
    }
}