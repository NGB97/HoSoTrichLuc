using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DKBaoHiem_Ajax_DKBaoHiem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string action = Request.QueryString["Action"].Trim();
        switch (action)
        {
            case "ThemTVHGD":
                ThemTVHGD(); break;
            case "LoadChiTietPhuLuc":
                LoadChiTietPhuLuc(); break;
            case "DeleteChiTietPhuLuc":
                DeleteChiTietPhuLuc(); break;
            case "LoadTinh":
                LoadTinh(); break;
            case "LoadQuanHuyen":
                LoadQuanHuyen(); break;
            case "LoadPhuongXa":
                LoadPhuongXa(); break;
        }
    }
    private void ThemTVHGD()
    {
        int STT = int.Parse(StaticData.getField("tb_TVHGDtemp", "isnull(max(STT),0)", "1", "1"));
        string TV_HoTen = StaticData.ValidParameter(Request.QueryString["TV_HoTen"].Trim());
        string TV_SoBHXH = StaticData.ValidParameter(Request.QueryString["TV_SoBHXH"].Trim());
        string TV_NamSinh = StaticData.ValidParameter(Request.QueryString["TV_NamSinh"].Trim());
        string TV_GioiTinh = StaticData.ValidParameter(Request.QueryString["TV_GioiTinh"].Trim());
        string TV_NoiCap = StaticData.ValidParameter(Request.QueryString["TV_NoiCap"].Trim());
        string TV_QuanHe = StaticData.ValidParameter(Request.QueryString["TV_QuanHe"].Trim());
        string TV_SoGTTT = StaticData.ValidParameter(Request.QueryString["TV_SoGTTT"].Trim());
        string TV_GhiChu = StaticData.ValidParameter(Request.QueryString["TV_GhiChu"].Trim());
        string sql1 = "select * from tb_TVHGDtemp where TV_HoTen=N'" + TV_HoTen + "' and TV_SoGTTT='" + TV_SoGTTT + "'";
        DataTable check = Connect.GetTable(sql1);
        if (check.Rows.Count > 0)
        {
            Response.Write("False");
        }
        else
        {
            STT += 1;
            string sql = "insert into tb_TVHGDtemp(STT,TV_HoTen,TV_SoBHXH,TV_NamSinh,TV_GioiTinh,TV_NoiCap,TV_QuanHe,TV_SoGTTT,TV_GhiChu) " +
                "values('" + STT + "',N'" + TV_HoTen + "','" + TV_SoBHXH + "','" + StaticData.ConvertDDMMtoMMDD(TV_NamSinh) + "',N'" + TV_GioiTinh + "',N'" + TV_NoiCap + "',N'" + TV_QuanHe + "','" + TV_SoGTTT + "',N'" + TV_GhiChu + "')";
            bool rs = Connect.Exec(sql);
            if (rs)
            {
                Response.Write("True");
            }
            else
            {
                Response.Write("False");
            }
        }

    }
    private void LoadChiTietPhuLuc()
    {
        string sql = "";
        sql += "select * from tb_TVHGDtemp";
        DataTable table = Connect.GetTable(sql);
        string html = @"<table class='table table-bordered table-striped'>
                        <tr>
                            <th style = 'text-align:center;font-size:14px'>STT</th>
                            <th style = 'text-align:center;font-size:14px'>Họ và tên thành viên</th>
                            <th style = 'text-align:center;font-size:14px' > Mã số BHXH</ th >
                            <th style = 'text-align:center;font-size:14px' > Năm sinh </ th >
                            <th style = 'text-align:center;font-size:14px' > Giới tính </ th >
                            <th style = 'text-align:center;font-size:14px' > Nơi cấp giấy khai sinh</ th >
                            <th style = 'text-align:center;font-size:14px' > Quan hệ với chủ hộ</ th >
                            <th style = 'text-align:center;font-size:14px' > Số giấy tờ tùy thân</ th >
                            <th style = 'text-align:center;font-size:14px' > Ghi chú </ th >
                            <th style = 'text-align:center;font-size:14px' > Xóa </ th >
                         </ tr >";
        for (int i = 0; i < table.Rows.Count; i++)
        {
            html += "       <tr>";
            int stt = i + 1;
            html += "       <td>" + stt + "</td>";
            html += "       <td>" + table.Rows[i]["TV_HoTen"].ToString().Trim()+ "</td>";
            html += "       <td>" + table.Rows[i]["TV_SoBHXH"].ToString().Trim() + "</td>";
            html += "       <td>" + DateTime.Parse(table.Rows[i]["TV_NamSinh"].ToString().Trim()).ToString("dd/MM/yyyy") + "</td>";
            html += "       <td>" + table.Rows[i]["TV_GioiTinh"].ToString().Trim() + "</td>";
            html += "       <td>" + table.Rows[i]["TV_NoiCap"].ToString().Trim() + "</td>";
            html += "       <td>" + table.Rows[i]["TV_Quanhe"].ToString().Trim() + "</td>";
            html += "       <td>" + table.Rows[i]["TV_SoGTTT"].ToString().Trim() + "</td>";
            html += "       <td>" + table.Rows[i]["TV_GhiChu"].ToString().Trim().Replace("\n", "<br />") + "</td>";
            html += "       <td><a style='cursor: pointer;' onclick='DeleteChiTietPhuLuc(\"" + table.Rows[i]["STT"].ToString() + "\");'><img title='Xóa' style='width:18px;' src='../Content/img/Delete.png'/></a></td>";
            html += "       </tr>";
        }

        html += "  </table>";
        Response.Write(html);

    }
    private void DeleteChiTietPhuLuc()
    {
        string STT = StaticData.ValidParameter(Request.QueryString["STT"].Trim());

        string sql = "delete from tb_TVHGDtemp where STT=" + STT;

        bool ktDelete = Connect.Exec(sql);

        if (ktDelete)
            Response.Write("True");
        else
            Response.Write("False");
    }
    private void LoadTinh()
    {
        DataTable table = Connect.GetTable("select * from tb_TinhTP");
        string listgAutocomplete = "[";
        //listgAutocomplete += "{";
        //listgAutocomplete += "value: 'Chọn',";
        //listgAutocomplete += "label: '--Chọn--',";
        //listgAutocomplete += "id: '0'";
        //listgAutocomplete += "},";
        for (int i = 0; i < table.Rows.Count; i++)
        {
            listgAutocomplete += "{";
            listgAutocomplete += "label: '" + table.Rows[i]["Ten"].ToString() + "',";
            listgAutocomplete += "value: '" + table.Rows[i]["Ten"].ToString() + "',";
            listgAutocomplete += "id: '" + table.Rows[i]["id"].ToString() + "',";
            if (i == table.Rows.Count - 1)
                listgAutocomplete += "}";
            else
                listgAutocomplete += "},";
        }
        listgAutocomplete += " ]";
        Response.Write(listgAutocomplete);
    }
    private void LoadQuanHuyen()
    {
        string CH_Tinh = StaticData.ValidParameter(Request.QueryString["Tinh"].Trim());
        if (CH_Tinh != "0" && CH_Tinh != "")
        {
            DataTable table = Connect.GetTable("select * from tb_QuanHuyen where idTinhTP = '" + CH_Tinh + "'");
            string listgAutocomplete = "[";
            //listgAutocomplete += "{";
            //listgAutocomplete += "value: 'Chọn',";
            //listgAutocomplete += "label: '--Chọn--',";
            //listgAutocomplete += "id: '0'";
            //listgAutocomplete += "},";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                listgAutocomplete += "{";
                listgAutocomplete += "label: '" + table.Rows[i]["Ten"].ToString() + "',";
                listgAutocomplete += "value: '" + table.Rows[i]["Ten"].ToString() + "',";
                listgAutocomplete += "id: '" + table.Rows[i]["id"].ToString() + "',";
                if (i == table.Rows.Count - 1)
                    listgAutocomplete += "}";
                else
                    listgAutocomplete += "},";
            }
            listgAutocomplete += " ]";
            Response.Write(listgAutocomplete);
        }
    }
    private void LoadPhuongXa()
    {
        string CH_QuanHuyen = StaticData.ValidParameter(Request.QueryString["QuanHuyen"].Trim());
        if (CH_QuanHuyen != "0" && CH_QuanHuyen != "")
        {
            DataTable table = Connect.GetTable("select * from tb_PhuongXa where idQuanHuyen = '" + CH_QuanHuyen + "'");
            string listgAutocomplete = "[";
            //listgAutocomplete += "{";
            //listgAutocomplete += "value: 'Chọn',";
            //listgAutocomplete += "label: '--Chọn--',";
            //listgAutocomplete += "id: '0'";
            //listgAutocomplete += "},";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                listgAutocomplete += "{";
                listgAutocomplete += "label: '" + table.Rows[i]["Ten"].ToString() + "',";
                listgAutocomplete += "value: '" + table.Rows[i]["Ten"].ToString() + "',";
                listgAutocomplete += "id: '" + table.Rows[i]["id"].ToString() + "',";
                if (i == table.Rows.Count - 1)
                    listgAutocomplete += "}";
                else
                    listgAutocomplete += "},";
            }
            listgAutocomplete += " ]";
            Response.Write(listgAutocomplete);
        }
    }

}