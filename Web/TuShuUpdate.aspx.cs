using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TuShuUpdate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        susheSys.DAL.DBM.Execute("update tbruzhu set state=2,tuchudate='"+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"' where id='"+Request.QueryString["id"].ToString()+"' ");
        Response.Redirect("TuShu.aspx");
    }
}