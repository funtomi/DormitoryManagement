using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_SuSheDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         susheSys.BLL.TbsusheBLL.Delete(Request.QueryString["id"].ToString());
         Response.Redirect("SuSheList.aspx");
    }
}