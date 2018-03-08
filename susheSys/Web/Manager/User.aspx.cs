﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_User : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindUser();
        }
    }

    private void bindUser()
    {
        System.Data.DataTable dt = new System.Data.DataTable();
        dt = susheSys.BLL.TbuserBLL.GetTbuserDT("");
        this.gvInfo.DataSource = dt;
        this.gvInfo.DataBind();
    }
    protected void gvInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.gvInfo.PageIndex = e.NewPageIndex;
        bindUser();

    }
}