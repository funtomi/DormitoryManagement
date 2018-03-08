using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Manager_ChuangAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindSuShe();
            ViewState["pic"] = "";
            if (Request.QueryString["id"] != null&&Request.QueryString["id"].ToString()!="")
            {
                bindChuang();
 
            }

        }
    }

    private void bindChuang()
    {
        System.Data.DataTable dt = new System.Data.DataTable();
        dt = susheSys.BLL.TbchuangBLL.GetTbchuangDT(" id='" + Request.QueryString["id"].ToString() + "'");

        this.DropDownList1.SelectedValue = dt.Rows[0]["susheid"].ToString();
        this.TextBox1.Text = dt.Rows[0]["remark"].ToString();
        Name.Text = dt.Rows[0]["chuangNum"].ToString();
        ViewState["pic"] = dt.Rows[0]["pic"].ToString();
    }

    private void bindSuShe()
    {
        System.Data.DataTable dt = new System.Data.DataTable();
        dt = susheSys.BLL.TbsusheBLL.GetTbsusheDT("");
        if (dt != null && dt.Rows.Count > 0)
        {
            foreach (System.Data.DataRow dr in dt.Rows)
            {
                this.DropDownList1.Items.Add(new ListItem(dr["ssname"].ToString(), dr["id"].ToString()));
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string picurl = "";
        HttpPostedFile hf = this.Pic.PostedFile;
        if (hf == null || hf.FileName.Trim() == "")
        {
            picurl = ViewState["pic"].ToString();//未选择图片 指定默认图片
        }
        else
        {
            // 进行上传操作
            string fname = hf.FileName;
            string exname = fname.Substring(fname.LastIndexOf(".") + 1).ToLower();
            if (exname == "png" || exname == "gif" || exname == "jpg" || exname == "jpeg") //  验证文件类型是否符合规范
            {
                int length = hf.ContentLength;
                string url = Server.MapPath(@"~/Upload/");
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }
                Random dt = new Random(unchecked((int)DateTime.Now.Ticks));
                string newname = (Environment.TickCount & int.MaxValue).ToString() + dt.Next(100, 999).ToString();
                url = url + newname + "." + exname;
                hf.SaveAs(url);

                picurl = newname + "." + exname;
            }
            else
            {
                // 格式不正确 提示信息 
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('文件格式不正确，请您选择图片格式');</script>");
                return;
            }
        }

        susheSys.Models.TbchuangInfo tchuang = new susheSys.Models.TbchuangInfo();
        tchuang.Chuangnum = this.Name.Text;
        tchuang.Pic = ViewState["pic"].ToString();
        tchuang.Susheid =Convert.ToInt32( this.DropDownList1.SelectedValue);
        tchuang.Remark = this.TextBox1.Text;

        Exception ex = null;
        if (Request.QueryString["id"] != null && Request.QueryString["id"].ToString() != "")
        {
            tchuang.Id = Convert.ToInt32(Request.QueryString["id"].ToString());
            ex = susheSys.BLL.TbchuangBLL.Update(tchuang);
        }
        else
        {
            ex = susheSys.BLL.TbchuangBLL.Add(tchuang);

        }

        if (ex == null)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('操作成功！');window.location.href='ChuangList.aspx'</script>");

        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('操作出现异常！');</script>");
            return;
        }
    }
}