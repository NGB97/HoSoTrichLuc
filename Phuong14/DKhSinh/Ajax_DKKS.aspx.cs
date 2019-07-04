using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DKhSinh_Ajax_DKKS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string action = Request.QueryString["Action"].Trim();
            switch (action)
            {
                case "Load_NoiCap":
                    Load_NoiCap();break;
                case "LoadTinh":
                    LoadTinh();break;
                case "LoadQuanHuyen":
                    LoadQuanHuyen();break;
                case "LoadPhuongXa":
                    LoadPhuongXa(); break;
            }
        }
        catch { }
    }
    private void Load_NoiCap()
    {
        DataTable table = Connect.GetTable("select * from tb_TinhTP order by Ten asc");
        string listgAutocomplete = "[";
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
    private void LoadTinh()
    {
        string TTT_QG = StaticData.ValidParameter(Request.QueryString["QuocGia"].Trim());
        if (TTT_QG == "Việt Nam" && TTT_QG != "")
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
    }
    private void LoadQuanHuyen()
    {
        string TTT_Tinh = StaticData.ValidParameter(Request.QueryString["Tinh"].Trim());
        if (TTT_Tinh != "0" && TTT_Tinh != "")
        {
            DataTable table = Connect.GetTable("select * from tb_QuanHuyen where idTinhTP = '" + TTT_Tinh + "'");
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
        string TTT_QuanHuyen = StaticData.ValidParameter(Request.QueryString["QuanHuyen"].Trim());
        if (TTT_QuanHuyen != "0" && TTT_QuanHuyen != "")
        {
            DataTable table = Connect.GetTable("select * from tb_PhuongXa where idQuanHuyen = '" + TTT_QuanHuyen + "'");
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