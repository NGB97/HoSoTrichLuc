using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DKBaoHiem_DKBaoHiem_Moi : System.Web.UI.Page
{
    int SoDon;
    int MaDon = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SoDon = int.Parse(StaticData.ValidParameter(Request.QueryString["SoDon"].Trim()));
        }
        catch { }
        try
        {
            MaDon = int.Parse(StaticData.ValidParameter(Request.QueryString["MaDon"].Trim()));
        }
        catch { }

        if (!IsPostBack)
        {
            txtNYC_QuocTich.Value = "Việt Nam";

        }

    }
    protected void btLuu_Click(object sender, EventArgs e)
    {
        string NYC_HoTen = "";
        string NYC_NamSinh = "";
        string NYC_GioiTinh = "";
        string NYC_DanToc = "";
        string NYC_QuocTich = "";
        string NYC_TinhTP_NS = "";
        string NYC_QuanHuyen_NS = "";
        string NYC_PhuongXa_NS = "";
        string NYC_TinhTP = "";
        string NYC_QuanHuyen = "";
        string NYC_PhuongXa = "";
        string NYC_SoNhaDuong = "";
        string NYC_NGH = "";
        string NYC_BHXH = "";
        string NYC_SDT = "";
        string NYC_GTTT = "";
        string NYC_SoGTTT = "";
        string NYC_MaSoHGD = "";
        string NYC_NoiKCB = "";
        string NYC_NoiDungYC = "";
        string NYC_HoSo = "";
        string NYC_NgayDK = DateTime.Now.ToString("MM/dd/yyyy");
        NYC_TinhTP_NS = txtNYC_TinhTP_NS.Value.Trim();
        NYC_QuanHuyen_NS = txtNYC_QuanHuyen_NS.Value.Trim();
        NYC_PhuongXa_NS = txtNYC_PhuongXa_NS.Value.Trim();
        NYC_TinhTP = txtNYC_TinhTP.Value.Trim();
        NYC_QuanHuyen = txtNYC_QuanHuyen.Value.Trim();
        NYC_PhuongXa = txtNYC_PhuongXa.Value.Trim();
        NYC_SoNhaDuong = txtNYC_SoNhaDuong.Value.Trim();
        NYC_MaSoHGD = txtNYC_MaSoHGD.Value.Trim();
        NYC_SDT = txtNYC_SDT.Value.Trim();
        NYC_NoiDungYC = txtNYC_NoiDungYC.Value.Trim();
        NYC_HoSo = txtNYC_HoSo.Value.Trim();
        if (txtNYC_HoTen.Value.Trim() != "")
        {
            NYC_HoTen = txtNYC_HoTen.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Họ tên Người yêu cầu!')</script>");
            return;
        }
        if (txtNYC_NamSinh.Value.Trim() != "")
        {
            NYC_NamSinh = StaticData.ConvertDDMMtoMMDD(txtNYC_NamSinh.Value.Trim());
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Năm sinh!')</script>");
            return;
        }
        if (txtNYC_GioiTinh.Value.Trim() != "")
        {
            NYC_GioiTinh = txtNYC_GioiTinh.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Giới tính!')</script>");
            return;
        }
        if (txtNYC_DanToc.Value.Trim() != "")
        {
            NYC_DanToc = txtNYC_DanToc.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Dân tộc!')</script>");
            return;
        }
        if (txtNYC_QuocTich.Value.Trim() != "")
        {
            NYC_QuocTich = txtNYC_QuocTich.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Quốc tịch!')</script>");
            return;
        }
        if (txtNYC_NGH.Value.Trim() != "")
        {
            NYC_NGH = txtNYC_NGH.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Cha/Mẹ/Người giám hộ!')</script>");
            return;
        }
        if (txtNYC_BHXH.Value.Trim() != "")
        {
            NYC_BHXH = txtNYC_BHXH.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập BHXH!')</script>");
            return;
        }
        if (txtNYC_GTTT.Value.Trim() != "" && txtNYC_SoGTTT.Value.Trim() != "")
        {
            NYC_GTTT = txtNYC_GTTT.Value.Trim();
            NYC_SoGTTT = txtNYC_SoGTTT.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập thông tin giấy tờ tùy thân!')</script>");
            return;
        }
        if (txtNYC_NoiKCB.Value.Trim() != "")
        {
            NYC_NoiKCB = txtNYC_NoiKCB.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Nơi Khám chữa bệnh ban đầu!')</script>");
            return;
        }
        if (MaDon==0)
        {
            int idMoi = int.Parse(StaticData.getField("tb_BaoHiem", "isnull(max(IdMoi),0)+1", "1", "1"));
            string sqlInsert = "INSERT INTO tb_BaoHiem([IdMoi],[NYC_HoTen],[NYC_NamSinh],[NYC_GioiTinh],[NYC_DanToc],[NYC_QuocTich],[NYC_TinhTP_NS],[NYC_QuanHuyen_NS],[NYC_PhuongXa_NS],[NYC_TinhTP],[NYC_QuanHuyen],[NYC_PhuongXa],[NYC_SoNhaDuong],[NYC_NGH],[NYC_BHXH],[NYC_SDT],[NYC_GTTT],[NYC_SoGTTT],[NYC_MaSoHGD],[NYC_NoiKCB],[NYC_NoiDungYC],[NYC_HoSo],[NYC_NgayDK])";
            sqlInsert += " values('" + idMoi + "',N'" + NYC_HoTen + "','" + NYC_NamSinh + "',N'" + NYC_GioiTinh + "',N'" + NYC_DanToc + "',N'" + NYC_QuocTich + "',N'" + NYC_TinhTP_NS + "',N'" + NYC_QuanHuyen_NS + "',N'" + NYC_PhuongXa_NS + "',N'" + NYC_TinhTP + "',N'" + NYC_QuanHuyen + "',N'" + NYC_PhuongXa + "',N'" + NYC_SoNhaDuong + "',N'" + NYC_NGH + "','" + NYC_BHXH + "','" + NYC_SDT + "',N'" + NYC_GTTT + "','" + NYC_SoGTTT + "','" + NYC_MaSoHGD + "',N'" + NYC_NoiKCB + "',N'" + NYC_NoiDungYC + "',N'" + NYC_HoSo + "',N'" + NYC_NgayDK + "')";
            bool ktInsert = Connect.Exec(sqlInsert);
            if (ktInsert)
            {
                Response.Redirect("DKBaoHiem_Moi.aspx?SoDon="+ SoDon + "&MaDon=" + idMoi + "");
            }
        }
        else
        {
            string sqlInsert = "INSERT INTO tb_BaoHiem([IdMoi],[NYC_HoTen],[NYC_NamSinh],[NYC_GioiTinh],[NYC_DanToc],[NYC_QuocTich],[NYC_TinhTP_NS],[NYC_QuanHuyen_NS],[NYC_PhuongXa_NS],[NYC_TinhTP],[NYC_QuanHuyen],[NYC_PhuongXa],[NYC_SoNhaDuong],[NYC_NGH],[NYC_BHXH],[NYC_SDT],[NYC_GTTT],[NYC_SoGTTT],[NYC_MaSoHGD],[NYC_NoiKCB],[NYC_NoiDungYC],[NYC_HoSo],[NYC_NgayDK])";
            sqlInsert += " values('" + MaDon + "',N'" + NYC_HoTen + "','" + NYC_NamSinh + "',N'" + NYC_GioiTinh + "',N'" + NYC_DanToc + "',N'" + NYC_QuocTich + "',N'" + NYC_TinhTP_NS + "',N'" + NYC_QuanHuyen_NS + "',N'" + NYC_PhuongXa_NS + "',N'" + NYC_TinhTP + "',N'" + NYC_QuanHuyen + "',N'" + NYC_PhuongXa + "',N'" + NYC_SoNhaDuong + "',N'" + NYC_NGH + "','" + NYC_BHXH + "','" + NYC_SDT + "',N'" + NYC_GTTT + "','" + NYC_SoGTTT + "','" + NYC_MaSoHGD + "',N'" + NYC_NoiKCB + "',N'" + NYC_NoiDungYC + "',N'" + NYC_HoSo + "',N'" + NYC_NgayDK + "')";
            bool ktInsert = Connect.Exec(sqlInsert);

            string sqlRow = "select * from tb_BaoHiem where IdMoi = '" + MaDon + "'";
            DataTable table = Connect.GetTable(sqlRow);
            if(table.Rows.Count==SoDon)
            {
                Response.Redirect("DKBaoHiem.aspx?IDBaoHiem=" + MaDon);
            }
            else if (ktInsert)
            {
                Response.Redirect("DKBaoHiem_Moi.aspx?SoDon=" + SoDon + "&MaDon=" + MaDon + "");
            }
            else
            {
                Response.Write("<script>alert('Lỗi! Đăng ký không thành công!')</script>");
            }
        }
        
    }
}