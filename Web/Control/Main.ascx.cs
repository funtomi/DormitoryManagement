﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_Main : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind(); // 

        }
    }



    protected void Bind()
    {
        DataTable mydt = new DataTable();
        mydt = susheSys.BLL.TbsusheBLL.GetTbsusheTop(10, "");
        if (mydt.Rows.Count > 0)
        {
            this.DataList1.DataSource = mydt;
            this.DataList1.DataBind();
        }
        else
        {
            this.DataList1.DataSource = null;
            this.DataList1.DataBind();
        }
    }
}