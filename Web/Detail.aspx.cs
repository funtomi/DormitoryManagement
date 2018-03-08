using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] == null || Request.QueryString["id"].ToString() == "")
            {
                Response.Redirect("SuSheList.aspx");
            }
            bindSushe();
        }


    }

    private void bindSushe()
    {
        susheSys.Models.TbsusheInfo tsushe = new susheSys.Models.TbsusheInfo();
        tsushe = susheSys.DAL.TbsusheDAL.GetModel(Request.QueryString["id"]);
        this.houseNum.Text = tsushe.Ssname.ToString();
        this.typeid.Text = tsushe.Remark;
        this.Image1.ImageUrl = tsushe.Pic;
        //绑定该宿舍的床位信息
        DataTable chuangdt = new DataTable();
        chuangdt = susheSys.BLL.TbchuangBLL.GetTbchuangDT(" susheid='" + Request.QueryString["id"].ToString() + "'");
        this.GridView1.DataSource = chuangdt;
        this.GridView1.DataBind();
    }
}