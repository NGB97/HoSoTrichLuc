using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DKBaoHiem_DKBaoHiem : System.Web.UI.Page
{
    string IdMoi = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            IdMoi = StaticData.ValidParameter(Request.QueryString["ID"].Trim());
        }
        catch { }
        
        if (!IsPostBack)
        {
            
        }
        
    }

    protected void btLuu_Click(object sender, EventArgs e)
    {
        string CH_HoTen = "";
        string CH_SDT = "";
        string CH_SoSHK = "";
        string CH_TinhTP = "";
        string CH_QuanHuyen = "";
        string CH_PhuongXa = "";
        string CH_SoDuong = "";

        string NgayDangKy = DateTime.Now.ToString("MM/dd/yyyy");

        if (txtCH_HoTen.Value.Trim() != "")
        {
            CH_HoTen = txtCH_HoTen.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập Họ tên Chủ hộ!')</script>");
            return;
        }

        if (txtCH_SoSHK.Value.Trim() != "")
        {
            CH_SoSHK = txtCH_SoSHK.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập số sổ Hộ khẩu Chủ hộ!')</script>");
            return;
        }
        if (txtCH_TinhTP.Value.Trim() != "")
        {
            CH_TinhTP = txtCH_TinhTP.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin nơi cư trú!')</script>");
            return;
        }
        if (txtCH_QuanHuyen.Value.Trim() != "")
        {
            CH_QuanHuyen = txtCH_QuanHuyen.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin nơi cư trú!')</script>");
            return;
        }
        if (txtCH_PhuongXa.Value.Trim() != "")
        {
            CH_PhuongXa = txtCH_PhuongXa.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin nơi cư trú!')</script>");
            return;
        }
        if (txtCH_SoDuong.Value.Trim() != "")
        {
            CH_SoDuong = txtCH_SoDuong.Value.Trim();
        }
        else
        {
            Response.Write("<script>alert('Bạn chưa nhập đầy đủ thông tin nơi cư trú!')</script>");
            return;
        }
        if(IdMoi == "")
        {
            int idGiaHan = int.Parse(StaticData.getField("tb_PhuLucTVHGD", "isnull(max(IdGiaHan),0)+1", "1", "1"));
            string sqlInsert = "insert into tb_PhuLucTVHGD([IdMoi], [IdGiaHan], [CH_HoTen], [CH_SDT], [CH_SoSHK], [CH_TinhTP], [CH_QuanHuyen], [CH_PhuongXa], [CH_SoDuong], [CH_NgayDangKy])";
            sqlInsert += " values('','" + idGiaHan + "',N'" + CH_HoTen + "','" + CH_SDT + "','" + CH_SoSHK + "',N'" + CH_TinhTP + "',N'" + CH_QuanHuyen + "',N'" + CH_PhuongXa + "',N'" + CH_SoDuong + "','" + NgayDangKy + "')";
            bool ktInsert = Connect.Exec(sqlInsert);
            if (ktInsert)
            {
                DataTable table = Connect.GetTable("select * from tb_TVHGDtemp");
                int RCcheck = table.Rows.Count;
                if (RCcheck > 0)
                {
                    for (int i=0; i<RCcheck; i++)
                    {
                        string sqlTVHGD = "insert into tb_TVHGD([IdMoi], [IdGiaHan], [TV_HoTen], [TV_SoBHXH], [TV_NamSinh], [TV_GioiTinh], [TV_NoiCap], [TV_QuanHe], [TV_SoGTTT], [TV_GhiChu])";
                        sqlTVHGD += " values('','" + idGiaHan + "',N'" + table.Rows[i]["TV_HoTen"].ToString().Trim() + "','" + table.Rows[i]["TV_SoBHXH"].ToString().Trim() + "','" + table.Rows[i]["TV_NamSinh"].ToString().Trim() + "',N'" + table.Rows[i]["TV_GioiTinh"].ToString().Trim() + "',N'" + table.Rows[i]["TV_NoiCap"].ToString().Trim() + "',N'" + table.Rows[i]["TV_QuanHe"].ToString().Trim() + "','" + table.Rows[i]["TV_SoGTTT"].ToString().Trim() + "',N'" + table.Rows[i]["TV_GhiChu"].ToString().Trim() + "')";
                        Connect.Exec(sqlTVHGD);
                    }
                    DeletePhuLuc();
                    Response.Redirect("DKBaoHiem.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Lỗi! Lưu phụ lục TVHGD không thành công!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Gữi không thành công!')</script>");
            }
        }
        else
        {
            //int idMoi = int.Parse(StaticData.getField("tb_PhuLucTVHGD", "isnull(max(IdMoi),0)+1", "1", "1"));
            string sqlInsert = "insert into tb_PhuLucTVHGD([IdMoi], [IdGiaHan], [CH_HoTen], [CH_SDT], [CH_SoSHK], [CH_TinhTP], [CH_QuanHuyen], [CH_PhuongXa], [CH_SoDuong], [CH_NgayDangKy]";
            sqlInsert += " values('" + IdMoi + "','',N'" + CH_HoTen + "','" + CH_SDT + "','" + CH_SoSHK + "',N'" + CH_TinhTP + "',N'" + CH_QuanHuyen + "',N'" + CH_PhuongXa + "',N'" + CH_SoDuong + "','" + NgayDangKy + "'";
            bool ktInsert = Connect.Exec(sqlInsert);
            if (ktInsert)
            {
                DataTable table = Connect.GetTable("select * from tb_TVHGDtemp");
                int RCcheck = table.Rows.Count;
                if (RCcheck > 0)
                {
                    for (int i = 0; i < RCcheck; i++)
                    {
                        string sqlTVHGD = "insert into tb_TVHGD([IdMoi], [IdGiaHan], [TV_HoTen], [TV_SoBHXH], [TV_NamSinh], [TV_GioiTinh], [TV_NoiCap], [TV_QuanHe], [TV_SoGTTT], [TV_GhiChu]";
                        sqlTVHGD += " values('" + IdMoi + "','',N'" + table.Rows[i]["TV_HoTen"].ToString().Trim() + "','" + table.Rows[i]["TV_SoBHXH"].ToString().Trim() + "','" + table.Rows[i]["TV_NamSinh"].ToString().Trim() + "',N'" + table.Rows[i]["TV_GioiTinh"].ToString().Trim() + "',N'" + table.Rows[i]["TV_NoiCap"].ToString().Trim() + "',N'" + table.Rows[i]["TV_QuanHe"].ToString().Trim() + "','" + table.Rows[i]["TV_SoGTTT"].ToString().Trim() + "',N'" + table.Rows[i]["TV_GhiChu"].ToString().Trim() + "'";
                        Connect.Exec(sqlTVHGD);
                    }
                    DeletePhuLuc();
                    Response.Redirect("DKBaoHiem.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Lỗi! Lưu phụ lục TVHGD không thành công!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Gữi không thành công!')</script>");
            }
        }
    }
    public void DeletePhuLuc()
    {
        string sql = "delete from tb_TVHGDtemp";
        bool ktDelete = Connect.Exec(sql);
        if (!ktDelete)
        {
            Response.Write("Lỗi");
        }
    }
}