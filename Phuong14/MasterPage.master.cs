using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage1 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string dateNow = DateTime.Now.ToString("MM/dd/yyyy");
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbCount.Text = StaticData.getField("tb_DetailB","count(*)","NgayDangKy",dateNow);
        }

    }
}
