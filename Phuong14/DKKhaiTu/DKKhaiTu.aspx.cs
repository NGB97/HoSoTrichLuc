using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DKKhaiTu_DKKhaiTu : System.Web.UI.Page
{
    string sID = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtNYC_QuocGia.Value = "Việt Nam";
            txtNC_QuocGia.Value = "Việt Nam";
            txtNC_QuocTich.Value = "Việt Nam"; 
            //LoadNoiCapNYC_CMND();
            //LoadNoiCapTTM_CMND();
            //LoadNoiCapTTC_CMND();
        }
    }
    protected void btLuu_Click(object sender, EventArgs e)
    {
        string NYC_HoTen = "";
        string NYC_QuanHe = "";
        string NYC_LoaiGT = "";
        string NYC_SoGT = "";
        string NYC_NgayCap = "";
        string NYC_NoiCap = "";
        string NYC_QuocGia = "";
        string NYC_TinhTP = "";
        string NYC_QuanHuyen = "";
        string NYC_PhuongXa = "";
        string NYC_SoNhaDuong = "";
        string NC_HoTen = "";
        string NC_GioiTinh = "";
        string NC_NgaySinh = "";
      
        string NC_DanToc = "";
        string NC_QuocTich = "";
        string NC_GTTT = "";
        string NC_SoGTTT = "";
        string NC_NgayCap = "";
        string NC_NoiCap = "";
        string NC_QuocGia = "";
        string NC_TinhTP = "";
        string NC_QuanHuyen = "";
        string NC_PhuongXa = "";
        string NC_SoNhaDuong = "";
        string NC_GioChet = "";
        string NC_NgayChet = "";
        string NC_NoiChet = "";
        string NC_NguyenNhanChet = "";
        string NC_SoGBT = "";
        string NC_Do = "";
        string NC_NgayCapGBT = "";
        string NC_SoLuong = "";
        string NC_NgayDK = "";

        string NgayDangKy = DateTime.Now.ToString("MM/dd/yyyy");

        if (txtNYC_HoTen.Value.Trim() != "")
        {
            NYC_HoTen = txtNYC_HoTen.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Họ tên Người yêu cầu!')</script>");
            return;
        }

        if (txtNYC_QuanHe.Value.Trim() != "")
        {
            NYC_QuanHe = txtNYC_QuanHe.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập quan hệ!')</script>");
            return;
        }

        if (txtNYC_LoaiGT.Value.Trim() != "")
        {
            NYC_LoaiGT = txtNYC_LoaiGT.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Loại giấy tờ!')</script>");
            return;
        }

        if (txtNYC_SoGT.Value.Trim() != "")
        {

            NYC_SoGT = txtNYC_SoGT.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập số giấy tờ tùy thân!')</script>");
            return;
        }

        if (txtNYC_NgayCap.Value.Trim() != "")
        {

            NYC_NgayCap = StaticData.ConvertDDMMtoMMDD(txtNYC_NgayCap.Value.Trim());
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Ngày Cấp!')</script>");
            return;
        }

        if (txtNYC_NoiCap.Value.Trim() != "")
        {
            NYC_NoiCap = txtNYC_NoiCap.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Nơi Cấp!')</script>");
            return;
        }

        if (txtNYC_QuocGia.Value.Trim() != "")
        {
            NYC_QuocGia = txtNYC_QuocGia.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin Nơi cư trú!')</script>");
            return;
        }

        if (txtNYC_TinhTP.Value.Trim() != "")
        {
            NYC_TinhTP = txtNYC_TinhTP.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin Nơi cư trú!')</script>");
            return;
        }

        if (txtNYC_QuanHuyen.Value.Trim() != "")
        {
            NYC_QuanHuyen = txtNYC_QuanHuyen.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin Nơi cư trú!')</script>");
            return;
        }

        if (txtNYC_PhuongXa.Value.Trim() != "")
        {
            NYC_PhuongXa = txtNYC_PhuongXa.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin Nơi cư trú!')</script>");
            return;
        }
        if (txtNYC_SoNhaDuong.Value.Trim() != "")
        {
            NYC_SoNhaDuong = txtNYC_SoNhaDuong.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin Nơi cư trú!')</script>");
            return;
        }
        if (txtNC_HoTen.Value.Trim() != "")
        {
            NC_HoTen = txtNC_HoTen.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập tên Người yêu cầu!')</script>");
            return;
        }
        if (txtNC_GioiTinh.Value.Trim() != "")
        {
            NC_GioiTinh = txtNC_GioiTinh.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Giới tính!')</script>");
            return;
        }
        if (txtNC_NgaySinh.Value.Trim() != "")
        {
            NC_NgaySinh = StaticData.ConvertDDMMtoMMDD(txtNC_NgaySinh.Value.Trim());
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Ngày sinh!')</script>");
            return;
        }
        if (txtNC_DanToc.Value.Trim() != "")
        {
            NC_DanToc = txtNC_DanToc.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Dân tộc!')</script>");
            return;
        }
        if (txtNC_QuocTich.Value.Trim() != "")
        {
            NC_QuocTich = txtNC_QuocTich.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Quốc tịch!')</script>");
            return;
        }
        if (txtNC_GTTT.Value.Trim() != "")
        {
            NC_GTTT = txtNC_GTTT.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Giấy tờ tùy thân!')</script>");
            return;
        }
        if (txtNC_SoGTTT.Value.Trim() != "")
        {
            NC_SoGTTT = txtNC_SoGTTT.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập số Giấy tờ tùy thân!')</script>");
            return;
        }
        if (txtNC_NgayCap.Value.Trim() != "")
        {
            NC_NgayCap = StaticData.ConvertDDMMtoMMDD(txtNC_NgayCap.Value.Trim());
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Ngày cấp Giấy tờ tùy thân!')</script>");
            return;
        }
        if (txtNC_NoiCap.Value.Trim() != "")
        {
            NC_NoiCap = txtNC_NoiCap.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Nơi cấp Giấy tờ tùy thân!')</script>");
            return;
        }
        if (txtNC_QuocGia.Value.Trim() != "")
        {
            NC_QuocGia = txtNC_QuocGia.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin Nơi cư trú cuối cùng của người chết!')</script>");
            return;
        }
        if (txtNC_TinhTP.Value.Trim() != "")
        {
            NC_TinhTP = txtNC_TinhTP.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin Nơi cư trú cuối cùng của người chết!')</script>");
            return;
        }
        if (txtNC_QuanHuyen.Value.Trim() != "")
        {
            NC_QuanHuyen = txtNC_QuanHuyen.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin Nơi cư trú cuối cùng của người chết!')</script>");
            return;
        }
        if (txtNC_PhuongXa.Value.Trim() != "")
        {
            NC_PhuongXa = txtNC_PhuongXa.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin Nơi cư trú cuối cùng của người chết!')</script>");
            return;
        }
        if (txtNC_SoNhaDuong.Value.Trim() != "")
        {
            NC_SoNhaDuong = txtNC_SoNhaDuong.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin Nơi cư trú cuối cùng của người chết!')</script>");
            return;
        }
        if (txtNC_GioChet.Value.Trim() != "")
        {
            NC_GioChet = DateTime.Parse(txtNC_GioChet.Value.Trim().ToString()).ToString("HH:mm");
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Giờ chết!')</script>");
            return;
        }
        if (txtNC_NgayChet.Value.Trim() != "")
        {
            NC_NgayChet = StaticData.ConvertDDMMtoMMDD(txtNC_NgayChet.Value.Trim());
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Ngày chết!')</script>");
            return;
        }
        if (txtNC_NoiChet.Value.Trim() != "")
        {
            NC_NoiChet = txtNC_NoiChet.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin Nơi chết cuối cùng của người chết!')</script>");
            return;
        }
        if (txtNC_NguyenNhanChet.Value.Trim() != "")
        {
            NC_NguyenNhanChet = txtNC_NguyenNhanChet.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ nguyên chết!')</script>");
            return;
        }
        if (txtNC_SoGBT.Value.Trim() != "")
        {
            NC_SoGBT = txtNC_SoGBT.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập số giấy Báo tử!')</script>");
            return;
        }
        if (txtNC_Do.Value.Trim() != "")
        {
            NC_Do = txtNC_Do.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập nơi cấp giấy Báo tử!')</script>");
            return;
        }
        if (txtNC_NgayCapGBT.Value.Trim() != "")
        {
            NC_NgayCapGBT = StaticData.ConvertDDMMtoMMDD(txtNC_NgayCapGBT.Value.Trim());
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Ngày cấp giấy Báo tử!')</script>");
            return;
        }
        if (txtNC_SoLuong.Value.Trim() != "")
        {
            NC_SoLuong = txtNC_SoLuong.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập số lượng bản sao cần cấp!')</script>");
            return;
        }
        //TTM_NamSinh = DateTime.Parse(txtTTM_NamSinh.Value.Trim().ToString()).ToString("MM/dd/yyyy");    

        if (sID == "")
        {
            string sqlInsert = "insert into tb_KhaiTu([NYC_HoTen], [NYC_QuanHe], [NYC_LoaiGT], [NYC_SoGT], [NYC_NgayCap], [NYC_NoiCap], [NYC_QuocGia], [NYC_TinhTP], [NYC_QuanHuyen], [NYC_PhuongXa], [NYC_SoNhaDuong], [NC_HoTen], [NC_GioiTinh], [NC_NgaySinh], [NC_DanToc], [NC_QuocTich], [NC_GTTT], [NC_SoGTTT], [NC_NgayCap], [NC_NoiCap], [NC_QuocGia], [NC_TinhTP], [NC_QuanHuyen], [NC_PhuongXa], [NC_SoNhaDuong], [NC_GioChet], [NC_NgayChet], [NC_NoiChet], [NC_NguyenNhanChet], [NC_SoGBT], [NC_Do], [NC_NgayCapGBT], [NC_SoLuong], [NC_NgayDK])";
            sqlInsert += " values(N'" + NYC_HoTen + "',N'" + NYC_QuanHe + "',N'" + NYC_LoaiGT + "','" + NYC_SoGT + "','" + NYC_NgayCap + "',N'" + NYC_NoiCap + "',N'" + NYC_QuocGia + "',N'" + NYC_TinhTP + "',N'" + NYC_QuanHuyen + "',N'" + NYC_PhuongXa + "',N'" + NYC_SoNhaDuong + "',N'" + NC_HoTen + "',N'" + NC_GioiTinh + "','" + NC_NgaySinh + "',N'" + NC_DanToc + "',N'" + NC_QuocTich + "',N'" + NC_GTTT + "','" + NC_SoGTTT + "','" + NC_NgayCap + "',N'" + NC_NoiCap + "',N'" + NC_QuocGia + "',N'" + NC_TinhTP + "',N'" + NC_QuanHuyen + "',N'" + NC_PhuongXa + "',N'" + NC_SoNhaDuong + "',N'" + NC_GioChet + "',N'" + NC_NgayChet + "',N'" + NC_NoiChet + "',N'" + NC_NguyenNhanChet + "',N'" + NC_SoGBT + "',N'" + NC_Do + "',N'" + NC_NgayCapGBT + "',N'" + NC_SoLuong + "','" + NgayDangKy + "')";
            bool ktInsert = Connect.Exec(sqlInsert);
            if (ktInsert)
            {
                Response.Redirect("DKKhaiTu.aspx");
                Response.Write("<script>alert('Gữi thông tin thành công! Có thể bắt đầu IN')</script>");
            }
            else
            {
                Response.Write("<script>alert('Lỗi!')</script>");
            }

        }

    }
}