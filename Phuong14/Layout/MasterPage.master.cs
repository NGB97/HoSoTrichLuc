using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage1 : System.Web.UI.MasterPage
{
    string IdMoi = "";
    string html = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            IdMoi = StaticData.ValidParameter(Request.QueryString["IDBaoHiem"].Trim());
        }
        catch { }
        if (!IsPostBack)
        {
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            HoSo();
        }

    }
    private void HoSo()
    {
        string dateNow = DateTime.Now.ToString("MM/dd/yyyy");
        string URL = HttpContext.Current.Request.Url.AbsoluteUri.ToUpper();
        if (URL.Contains("/DKHSINH/"))
        {
            lbCount.Text = StaticData.getField("tb_DetailB", "count(*)", "NgayDangKy", dateNow);
            html = "ĐĂNG KÝ KHAI SINH";
            nameform.InnerHtml = html;
        }
        else if (URL.Contains("/DKKHAITU/"))
        {
            lbCount.Text = StaticData.getField("tb_KhaiTu", "count(*)", "NC_NgayDK", dateNow);
            html = "ĐĂNG KÝ KHAI TỬ";
            nameform.InnerHtml = html;
        }
        if (URL.Contains(("/DKBaoHiem/DKBaoHiem_Moi.aspx").ToUpper()))
        {
            lbCount.Text = StaticData.getField("tb_BaoHiem", "COUNT (DISTINCT IdMoi)", "NYC_NgayDK", dateNow);
            html = "ĐĂNG KÝ BẢO HIỂM";
            nameform.InnerHtml = html;
        }
        if (URL.Contains(("/DKBaoHiem/DKBaoHiem.aspx").ToUpper()) && IdMoi != "")
        {
            DataTable tablePL = Connect.GetTable("select COUNT(*) from tb_PhuLucTVHGD where CH_NgayDangKy = '" + dateNow + "' and IdMoi > 0 ");
            lbCount.Text = tablePL.Rows[0][0].ToString();
            html = "ĐĂNG KÝ BẢO HIỂM";
            nameform.InnerHtml = html;
        }
        else if (URL.Contains(("/DKBaoHiem/DKBaoHiem.aspx").ToUpper()) && IdMoi == "")
        {
            DataTable tablePL = Connect.GetTable("select COUNT(*) from tb_PhuLucTVHGD where CH_NgayDangKy = '" + dateNow + "' and IdGiaHan > 0 ");
            lbCount.Text = tablePL.Rows[0][0].ToString();
            html = "ĐĂNG KÝ BẢO HIỂM";
            nameform.InnerHtml = html;
        }
    }
}
