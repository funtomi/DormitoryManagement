using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_ChuangDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        susheSys.BLL.TbchuangBLL.Delete(Request.QueryString["id"].ToString());
        Response.Redirect("ChuangList.aspx");
    }
}