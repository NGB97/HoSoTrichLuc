﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Data;

public partial class Ajax : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string action = Request.QueryString["Action"].Trim();
            switch (action)
            {
                case "PrinfKhaiSinh":
                    PrinfKhaiSinh(); break;

            }
        }
        catch { }
    }

    private void PrinfKhaiSinh()
    {
        string sqlKhaiSinh = @"select *, 'nd'=(select max(id) from tb_DetailB) from  tb_DetailB";
        DataTable data = Connect.GetTable(sqlKhaiSinh);
        if (data.Rows.Count > 0)
        {
            // em tính cho swtich case ở đây
            string html = "";
            html += @"
            <div style='width:100%'>
            <div style='font-family: 'Times New Roman', Times, serif; font-size: 13px; text-align: left; width: 842px; margin-top: -10px; margin-left: -20px;'>
            <div style='margin-top: 0; margin-left: 20px'>";
            /*Form đăng kí khai sinh*/
            html += @"
            <div style='page-break-before:always'>
            <form>
                <div class='text-center'>
                    <h4 class='title'> CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM </h4>
                    <h4 class='sub-title line-title'> Độc lập - Tự do - Hạnh phúc </h4>
                    <h4 class='title'>TỜ KHAI ĐĂNG KÝ KHAI SINH</h4>
                </div>
                <p class='text-center'>Kính gửi: UBND phường 14, quận Gò Vấp, thành phố Hồ Chí Minh</p>
                <div>
                    <p class='tieude'>Họ, chữ đệm, tên người yêu cầu:
                        <span class='ten'>" + data.Rows[0]["NYC_HoTen"].ToString() + @"<span>
                    </p>
                    <p>CMND/CCCD số:
                        <span class='gt'>" + data.Rows[0]["NYC_SoGT"].ToString() + @"</span>
                    </p>
                    <p>Ngày cấp:
                        <span class='gt'>" + DateTime.Parse(data.Rows[0]["NYC_NgayCap"].ToString()).ToString("dd/MM/yyyy") + @"</span>
                        <span class='ttgiua'>Nơi cấp:
                            <span class='gt'>" + data.Rows[0]["NYC_NoiCap"].ToString() + @"</span>
                        </span>
                    </p>
                    <p>Nơi cư trú:
                        <span class='gt'>" + data.Rows[0]["NYC_SoNhaDuong"].ToString() + @", " + data.Rows[0]["NYC_PhuongXa"].ToString() + @", " + data.Rows[0]["NYC_QuanHuyen"].ToString() + @", " + data.Rows[0]["NYC_TinhTP"].ToString() + @"</span>
                    </p>
                    <p>Quan hệ với trẻ được làm khai sinh:
                        <span class='gt'>" + data.Rows[0]["NYC_QuanHe"].ToString() + @"</span>
                    </p>
                    <p><b>Đề nghị cơ quan đăng ký khai sinh cho người dưới đây:</b></p>
                    <p class='tieude'>Họ, chữ đệm, tên:
                        <span class=' gt ten'>" + data.Rows[0]["TTT_HoTen"].ToString() + @"<span>
                    </p>
                    <p>Ngày,tháng,năm sinh:
                        <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTT_NgaySinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
                    </p>
                    <p>Bằng chữ:
                        <span class='gt'>Ngày mười hai, tháng sáu, năm hai nghìn không trăm mười chín</span>
                    </p>
                    <p>Nơi sinh:
                        <span class='gt'>" + data.Rows[0]["TTT_TenCSYT"].ToString() + @", " + data.Rows[0]["TTT_TinhTP"].ToString() + @"</span>
                    </p>
                    <p>Giới tính:
                        <span class='gt'>" + data.Rows[0]["TTT_GioiTinh"].ToString() + @"  </span>
                        <span class='padd'>Dân tộc:
                            <span class='gt'>" + data.Rows[0]["TTT_DanToc"].ToString() + @"</span>
                            <span class='padd'>Quốc tịch:
                                <span class='gt'>" + data.Rows[0]["TTT_QuocGia"].ToString() + @"</span>
                            </span>
                        </span>
                    </p>
                    <p>Quê quán:
                        <span class='gt'>" + data.Rows[0]["TTT_SoNhaDuong_QQ"].ToString() + @"," + data.Rows[0]["TTT_PhuongXa_QQ"].ToString() + @"," + data.Rows[0]["TTT_QuanHuyen_QQ"].ToString() + @"," + data.Rows[0]["TTT_TinhTP_QQ"].ToString() + @"</span>
                    </p>
                </div>
                <div>
                    <p class='tieude'>Họ, chữ đệm, tên người mẹ:
                        <span class='ten'>" + data.Rows[0]["TTM_HoTen"].ToString() + @"<span>
                    </p>
                    <p>Năm sinh:
                        <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTM_NamSinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
                        <span class='padd'>Dân tộc:
                            <span class='gt'>" + data.Rows[0]["TTM_DanToc"].ToString() + @"</span>
                            <span class='padd'>Quốc tịch:
                                <span class='gt'>" + data.Rows[0]["TTM_QuocTich"].ToString() + @"</span>
                            </span>
                        </span>
                    </p>
                    <p>Quê quán:
                        <span class='gt'>" + data.Rows[0]["TTM_SoNhaDuong"].ToString() + @"," + data.Rows[0]["TTM_PhuongXa"].ToString() + @"," + data.Rows[0]["TTM_QuanHuyen"].ToString() + @"," + data.Rows[0]["TTM_TinhTP"].ToString() + @"</span>
                    </p>
                </div>
                <div>
                    <p class='tieude'>Họ, chữ đệm, tên người cha:
                        <span class='ten'>" + data.Rows[0]["TTC_HoTen"].ToString() + @"<span>
                    </p>
                    <p>Năm sinh:
                        <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTC_NamSinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
                        <span class='padd'>Dân tộc:
                            <span class='gt'>" + data.Rows[0]["TTC_DanToc"].ToString() + @"</span>
                            <span class='padd'>Quốc tịch:
                                <span class='gt'>" + data.Rows[0]["TTC_QuocTich"].ToString() + @"</span>
                            </span>
                        </span>
                    </p>
                    <p>Quê quán:
                        <span class='gt'>" + data.Rows[0]["TTC_SoNhaDuong"].ToString() + @"," + data.Rows[0]["TTC_PhuongXa"].ToString() + @"," + data.Rows[0]["TTC_QuanHuyen"].ToString() + @"," + data.Rows[0]["TTC_TinhTP"].ToString() + @"</span>
                    </p>
                </div>
                <p class='camdoan'>Tôi cam đoan nội dung đề nghị đăng ký khai sinh trên đây là đúng sự thật, được sự thỏa thuận nhất trí của các bên liên quan theo quy định pháp luật.</p>
                <p>Tôi chịu hoàn toàn trách nhiệm trước pháp luật về nội dung cam đoan của mình.</p>
                <p class='canphai'>Phường 14,ngày&nbsp;
                    <span>" + DateTime.Now.Day.ToString() + @"&nbsp;
                        <span>tháng&nbsp;
                            <span>" + DateTime.Now.Month.ToString() + @"&nbsp;
                                <span>năm&nbsp;
                                    <span>" + DateTime.Now.Year.ToString() + @"
                                    </span>
                                </span>
                            </span>
                        </span>
                    </span>
                </p>
                <p class='kyten'><b> Người yêu cầu </b></p><br></br><br>
                <p class='Tenkyten'><b>" + data.Rows[0]["NYC_HoTen"].ToString() + @"</b></p>
            </form>
            </div>
           ";

            /*Form Cấp bản sao*/
            html += @"
        <div style='page-break-before:always'>
            <form>
                <div class='text-center'>
                    <h3 class='title'> CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM </h3>
                    <h3 class='sub-title line-title'> Độc lập - Tự do - Hạnh phúc </h3>
                    <h3 class='title'>TỜ KHAI CẤP BẢN SAO TRÍCH LỤC HỘ TỊCH</h3>
                </div>
                <p class='kg'>Kính gửi: UBND phường 14, quận Gò Vấp, thành phố Hồ Chí Minh</p>
                <p class='tieude'>Họ, chữ đệm, tên người yêu cầu:
                    <span class='gt ten'>" + data.Rows[0]["NYC_HoTen"].ToString() + @"<span>
                </p>
                <p>CMND/CCCD số:
                    <span class='gt'>" + data.Rows[0]["NYC_SoGT"].ToString() + @"</span>
                </p>
                <p>Ngày cấp:
                    <span class='gt'>" + DateTime.Parse(data.Rows[0]["NYC_NgayCap"].ToString()).ToString("dd/MM/yyyy") + @"</span>
                    <span class='ttgiua'>Nơi cấp:
                        <span class='gt'>" + data.Rows[0]["NYC_NoiCap"].ToString() + @"</span>
                    </span>
                </p>
                <p>Nơi cư trú:
                    <span class='gt'>" + data.Rows[0]["NYC_SoNhaDuong"].ToString() + @", " + data.Rows[0]["NYC_PhuongXa"].ToString() + @", " + data.Rows[0]["NYC_QuanHuyen"].ToString() + @", " + data.Rows[0]["NYC_TinhTP"].ToString() + @"</span>
                </p>
                <p>Quan hệ với trẻ được làm khai sinh:
                    <span class='gt'>" + data.Rows[0]["NYC_QuanHe"].ToString() + @"</span>
                </p>
                <p><b>Đề nghị cơ quan cấp bản sao trích lục Giấy Khai Sinh cho người có tên dưới đây:</b></p>
                <p>Họ, chữ đệm, tên:
                    <span class='ten'>" + data.Rows[0]["TTT_HoTen"].ToString() + @"<span>
                </p>
                <p>Ngày,tháng,năm sinh:
                    <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTT_NgaySinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
                </p>
                <p>Giới tính:
                    <span class='gt'>" + data.Rows[0]["TTT_GioiTinh"].ToString() + @" </span>
                    <span class='padd'>Dân tộc:
                        <span class='gt'>" + data.Rows[0]["TTT_DanToc"].ToString() + @"</span>
                        <span class='padd'>Quốc tịch:
                            <span class='gt'>" + data.Rows[0]["TTT_QuocGia"].ToString() + @"</span>
                        </span>
                    </span>
                </p>
                <p>Nơi cư trú:
                    <span class='gt'>" + data.Rows[0]["TTT_PhuongXa"].ToString() + @"," + data.Rows[0]["TTT_QuanHuyen"].ToString() + @"," + data.Rows[0]["TTT_TinhTP"].ToString() + @"</span>
                </p>
                <p>Giấy tớ tùy thân:
                    <span class='gt'>" + data.Rows[0]["TTT_GiayToTuyThan"].ToString() + @"</span>
                </p>
                <p>Số định danh cá nhân:
                    <span class='gt'>" + data.Rows[0]["TTT_SoDinhDanh"].ToString() + @"</span>
                </p>
                <p>Đã đăng kí khai sinh tại:
                    <span class='gt'> Ủy ban nhân dân phường 14, quận Gò Vấp, thành phố Hồ Chí Min </span>
                </p>
                <p>Theo giấy khai sinh số:
                    <span class='gt ten'>" + data.Rows[0]["id"].ToString() + @"</span>
                </p>
                <p>Số lượng bản sao đề nghị cấp:
                    <span class='gt'> </span>bản sao
                </p>
                <p class='camdoan'>Tôi cam đoan nội dung đề nghị đăng ký khai sinh trên đây là đúng sự thật, được sự thỏa thuận nhất trí của các bên liên quan theo quy định pháp luật.</p>
                <p>Tôi chịu hoàn toàn trách nhiệm trước pháp luật về nội dung cam đoan của mình.</p>
                <p class='canphai'>Phường 14,ngày&nbsp;
             <span>" + DateTime.Now.Day.ToString() + @"&nbsp;
                   <span>tháng&nbsp;
                 <span>" + DateTime.Now.Month.ToString() + @"&nbsp;
                   <span>năm&nbsp;
                     <span>" + DateTime.Now.Year.ToString() + @"
                     </span>
                   </span>
                 </span>
               </span>
             </span>
           </p>
        <p class='kyten'><b> Người yêu cầu </b></p><br><br><br>
        <p class='Tenkyten'><b>" + data.Rows[0]["NYC_HoTen"].ToString() + @"</b></p>
        </form> 
        </div>            
        ";

            /*Bảo Hiểm*/
            html += @"<div style='page-break-before:always'>
    <form>
        <div>
            <div class='flex justify-content-between'>
                <div class='item'>
                    <h4 class='line-title'>BẢO HIỂM XÃ HỘI VIỆT NAM</h4>
                    <h4 class='item'> </h4>
                </div>
                <div class='item text-center'>
                    <h4 class='title margin-bottom-3px'> CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM </h4>
                    <h4 class='sub-title line-title '> Độc lập - Tự do - Hạnh phúc </h4>
                </div>
            </div>
        </div>
        <div>
            <h4 class='margin-bottom2'>TỜ KHAI</h4>
            <h4 class='title'>THAM GIA, ĐIỀU CHỈNH THÔNG TIN BẢO HIỂM XÃ HỘI, BẢO HIỂM Y TẾ</h4>
            <p class='text-center'>Kính gửi: UBND phường 14, quận Gò Vấp, thành phố Hồ Chí Minh</p>
            <p class='tieude'>I.Phần kê khai bắt buộc:
                <p>Họ, chữ đệm, tên:
                    <span class='gt ten'>" + data.Rows[0]["TTT_HoTen"].ToString() + @"<span>
                </p>
                <p>Ngày, tháng, năm sinh:
                    <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTT_NgaySinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
                    <span class='ttgiua'>Giới tính:
                        <span class='gt'>" + data.Rows[0]["TTT_GioiTinh"].ToString() + @"</span>
                    </span>
                </p>
                <p>Quốc tịch:
                    <span class='gt'>" + data.Rows[0]["TTT_QuocGia_NoiSinh"].ToString() + @"</span>
                    <span class='ttgiua'> Dân tộc:
                        <span class='gt'>" + data.Rows[0]["TTT_GioiTinh"].ToString() + @"</span>
                    </span>
                </p>
                <p>Nơi đăng ký giấy khai sinh:
                    <span class='padd'> UBND phường 14,quận Gò vấp, TP.HCM</span> </p>
                <p class='tieude'> Địa chỉ nhận hồ sơ:</p>
                <p>Số nhà, đường phố, thôn xóm:
                    <span class='gt'>" + data.Rows[0]["NYC_SoNhaDuong"].ToString() + @"</span>
                    <span class='padd'>Xã(phường,thị trấn):
                        <span class='gt'>" + data.Rows[0]["NYC_PhuongXa"].ToString() + @"</span>
                    </span>
                </p>
                <p>Huyện (quận, thị xã, Tp thuộc tỉnh):
                    <span class='gt'>" + data.Rows[0]["NYC_QuanHuyen"].ToString() + @"</span>
                    <span class='padd'>Tỉnh/Thành phố:
                        <span class='gt'>" + data.Rows[0]["NYC_TinhTP"].ToString() + @"</span>
                    </span>
                </p>
                <p>Họ tên cha/ mẹ/ người giám hộ (đối với trẻ em dưới 6 tuổi):
                    <span class='ten'>" + data.Rows[0]["TTC_HoTen"].ToString() + @"
                </p>
                <p class='tieude'>II. Phần kê khai chung :
                    <p>Mã số BHXH(đã cấp):
                        <span class='gt'>...</span>
                        <span class='ttgiua'>Số điện thoại liên hệ:
                            <span class='gt'>" + data.Rows[0]["NYC_SDT"].ToString() + @"</span>
                        </span>
                    </p>
                    <p>Số CMND:
                        <span class='gt'>" + data.Rows[0]["NYC_SoGT"].ToString() + @"</span>
                        <span class='padd'>Mã số hộ gia đình (đã cấp):
                            <span class='gt'>...</span>
                        </span>
                    </p>
                    <p>Nơi sinh:
                        <span class='gt'>" + data.Rows[0]["TTT_TenCSYT"].ToString() + @"</span>
                        <span>Nơi đăng kí khám chữa bệnh ban đầu:
                            <span class='gt'>" + data.Rows[0]["TTT_KCB"].ToString() + @"</span>
                        </span>
                    </p>
                    <p>Mức tiền đóng:
                        <span class='gt'>....</span>đồng
                        <span class='padd'>Phương thức đóng:
                            <span class='gt'>....</span>
                        </span>
                    </p>
                    <p>Nội dung thay đổi, yêu cầu:
                        <span class='gt'>.....</span>
                    </p>
                    <p>Hồ sơ kèm theo (nếu có):
                        <span class='gt'>......</span>
                    </p>
        </div>
        <div class='flex justify-content-between'>
            <div class='item'>
                <p class='item title text-center sub-title'>XÁC NHẬN CỦA ĐƠN VỊ</p>
                <p class='title'>(chỉ áp dụng đối với người lao động thay đổi</p>
                <p class='text-center title sub-title'> họ, tên đệm, tên; ngày, tháng, năm sinh)</p>
            </div>
            <div class='item'>
                <p class='item title text-center sub-title'>Tôi cam đoan những nội dung kê khai là đúng và chịu </p>
                <p class='title'>trách nhiệm trước pháp luật về những nội dung đã kê khai.</p>
                <p class='title sub-title text-center'>Phường 14, ngày&nbsp;
                    <span>" + DateTime.Now.Day.ToString() + @"&nbsp;
                        <span>tháng&nbsp;
                            <span>" + DateTime.Now.Month.ToString() + @"&nbsp;
                                <span>năm&nbsp;
                                    <span>" + DateTime.Now.Year.ToString() + @"
                                    </span>
                                </span>
                            </span>
                        </span>
                </p>
                <p class='kyten'><b> Người yêu cầu </b></p><br><br></br>
                <p class='Tenkyten'><b>" + data.Rows[0]["NYC_HoTen"].ToString() + @"</b></p>
            </div>
        </div>
    </form>
</div>
";
            /*Y tế*/
            html += @"
<div style='page-break-before:always'>
    <form>
        <h3 class='title text-center'>PHIẾU CUNG CẤP THÔNG TIN TRẺ SINH TRONG NĂM</h3>
        <div class='flex justify-content-between'>
            <div class='item'>
                <p>Họ tên trẻ:
                    <span class='gt'>" + data.Rows[0]["TTT_HoTen"].ToString() + @"</span>
                </p>
                <p>Ngày sinh:
                    <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTT_NgaySinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
                </p>
                <p>Nơi sinh:
                    <span class='gt'>" + data.Rows[0]["TTT_TenCSYT"].ToString() + @"</span>
                </p>
                <p>Kiểu sinh:
                    <span class='gt'>" + data.Rows[0]["TTT_KieuSinh"].ToString() + @"</span>
                </p>
                <p>Họ tên mẹ:
                    <span class='gt'>" + data.Rows[0]["TTM_HoTen"].ToString() + @"</span>
                </p>
                <p>Họ tên cha:
                    <span class='gt'>" + data.Rows[0]["TTC_HoTen"].ToString() + @"</span>
                </p>
            </div>
            <div class='item'>
                <p>Giới tính:
                    <span class='gt'>" + data.Rows[0]["TTT_GioiTinh"].ToString() + @"</span>
                </p>
                <p>Con thứ:
                    <span class='gt'>" + data.Rows[0]["TTT_ConThu"].ToString() + @"</span>
                </p>
                <p>
                    <span class='gt'></span>
                </p>
                <p>Cân nặng:
                    <span class='gt'>" + data.Rows[0]["TTT_CanNang"].ToString() + @"</span>gram
                </p>
                <p>Năm sinh:
                    <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTM_NamSinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
                </p>
                <p>Năm sinh:
                    <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTC_NamSinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
                </p>
            </div>
            <div class='item'>
                <p></p>
            </div>
        </div>
        <p>Địa chỉ thường trú:
            <span class='gt'>" + data.Rows[0]["NYC_SoNhaDuong"].ToString() + @", " + data.Rows[0]["NYC_PhuongXa"].ToString() + @", " + data.Rows[0]["NYC_QuanHuyen"].ToString() + @", " + data.Rows[0]["NYC_TinhTP"].ToString() + @"</span>
        </p>
        <p>Chỗ ở thực tế hiện nay:
            <span class='gt'>" + data.Rows[0]["NYC_SoNhaDuong"].ToString() + @", " + data.Rows[0]["NYC_PhuongXa"].ToString() + @", " + data.Rows[0]["NYC_QuanHuyen"].ToString() + @", " + data.Rows[0]["NYC_TinhTP"].ToString() + @"</span>
        </p>
        <p>Số điện thoại liên hệ:
            <span class='gt'>" + data.Rows[0]["NYC_SDT"].ToString() + @"</span>
        </p>
        <p class='text-right padd-right'><b>Người kê khai</b></p><br>
        <p class='text-right padd-right1 padd'><b>" + data.Rows[0]["NYC_HoTen"].ToString() + @"</b>
    </form>
</div>
";

            /*Ủy quyền*/

            html += @"
    <div style='page-break-before:always'>
        <div class='text-center'>
		    <h3 class='title'> CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM </h3>
		    <h3 class='sub-title line-title'> Độc lập - Tự do - Hạnh phúc </h3>
		    <h3 class='title'>GIẤY ỦY QUYỀN</h3>
		    <h3 class='sub-title'>(Dành cho cá nhân)</h3>
		</div>
        <p>Căn cứ Bộ Luật Dân Sự nước Cộng Hòa Xã Hội Chủ Nghĩa Việt Nam.</p>
		<p>Căn cứ vào các văn bản pháp luật hiện hành.</p>
		<p class='text-right'>Ngày 27 tháng 4 năm 2019,chúng tôi gồm có:</p>
            ";
            if (StaticData.getField("tb_DetailB", "*", "NYC_HoTen", "TTC_HoTen") != null)
            {
                html += @"
		        <div>
			        <p class='tieude'>I/ Bên ủy quyền:</p>
			        <p>Họ và tên: 
				        <span class='ten gt'>" + data.Rows[0]["TTC_HoTen"].ToString() + @"</span>
				        <span class='text-right1 padd1'> Năm sinh:
					        <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTC_NamSinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
				        </span>
			        </p>
			        <p>Nơi cư trú:
				        <span class='gt'>" + data.Rows[0]["TTC_SoNhaDuong"].ToString() + @"," + data.Rows[0]["TTC_PhuongXa"].ToString() + @"," + data.Rows[0]["TTC_QuanHuyen"].ToString() + @"," + data.Rows[0]["TTC_TinhTP"].ToString() + @"</span>
			        </p>
			        <p>Số CMND/CCCD/HC: 
				        <span class='gt'>" + data.Rows[0]["TTC_SoGT"].ToString() + @"</span>
				        <span> Ngày cấp:
					        <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTC_NgayCap"].ToString()).ToString("dd/MM/yyyy") + @"</span>
				        </span>
				        <span> Nơi cấp:
					        <span class='gt'>" + data.Rows[0]["TTC_NoiCap"].ToString() + @"</span>
				        </span>
			        </p>		
		        </div>";
            }
            else
            {
                html += @"
		        <div>
			        <p class='tieude'>I/ Bên ủy quyền:</p>
			        <p>Họ và tên: 
				        <span class='ten gt'>" + data.Rows[0]["TTM_HoTen"].ToString() + @"</span>
				        <span class='text-right1 padd1'> Năm sinh:
					        <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTM_NamSinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
				        </span>
			        </p>
			        <p>Nơi cư trú:
				        <span class='gt'>" + data.Rows[0]["TTM_SoNhaDuong"].ToString() + @"," + data.Rows[0]["TTM_PhuongXa"].ToString() + @"," + data.Rows[0]["TTM_QuanHuyen"].ToString() + @"," + data.Rows[0]["TTM_TinhTP"].ToString() + @"</span>
			        </p>
			        <p>Số CMND/CCCD/HC: 
				        <span class='gt'>" + data.Rows[0]["TTM_SoGT"].ToString() + @"</span>
				        <span> Ngày cấp:
					        <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTM_NgayCap"].ToString()).ToString("dd/MM/yyyy") + @"</span>
				        </span>
				        <span> Nơi cấp:
					        <span class='gt'>" + data.Rows[0]["TTM_NoiCap"].ToString() + @"</span>
				        </span>
			        </p>		
		        </div>";
            }
        
            html += @"
		<div>
			<p class='tieude'>II/ Bên được ủy quyền:</p>
			<p>Họ và tên: 
				<span class='ten gt'>" + data.Rows[0]["NYC_HoTen"].ToString() + @"</span>
				<span class='text-right1 padd1'> Năm sinh:
					<span class='gt'>" + DateTime.Parse(data.Rows[0]["NYC_NamSinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
				</span>
			</p>
			<p>Nơi cư trú:
				<span class='gt'>" + data.Rows[0]["NYC_SoNhaDuong"].ToString() + @", " + data.Rows[0]["NYC_PhuongXa"].ToString() + @", " + data.Rows[0]["NYC_QuanHuyen"].ToString() + @", " + data.Rows[0]["NYC_TinhTP"].ToString() + @"</span>
			</p>
			<p>Số CMND/CCCD/HC: 
				<span class='gt'>" + data.Rows[0]["NYC_SoGT"].ToString() + @"</span>
				<span> Ngày cấp:
					<span class='gt'>" + DateTime.Parse(data.Rows[0]["TTC_NgayCap"].ToString()).ToString("dd/MM/yyyy") + @"</span>
				</span>
				<span> Nơi cấp:
					<span class='gt'>" + data.Rows[0]["NYC_NoiCap"].ToString() + @"</span>
				</span>
			</p>		
		</div>";
            

            html += @"
        <div>
			<p class='tieude'>III/Nội dung ủy quyền:</p>
			<p>Tôi ủy quyền cho: 
				<span class='gt'><b>" + data.Rows[0]["NYC_Quanhe"].ToString() + @"</b></span>
				<span > của con tôi là:
					<span class='gt ten'>" + data.Rows[0]["NYC_HoTen"].ToString() + @"</span>
                    <span>liên hệ UBND phường 14 để đăng ký khai sinh và các thủ tục liên quan.</span>
				</span>
			</p>

		</div>";

            html +=@"
		<div>
			<p class='tieude'>IV/Cam kết:</p>	
			<p>
				Hai bên cam kết sẽ hoàn toàn chịu trách nhiệm trước pháp luật về mọi thông tin ủy quyền ở trên.	
			</p>
			<p>
			Mọi tranh chấp phát sinh giữa bên ủy quyền và bên được uỷ quyền do hai bên tự giải quyết.
			</p>
		</div>
		<div>
	    <div class='flex justify-content-between'>
	        <div class='item'>
	            <p class='gt text-center tieude'> Bên được ủy quyền</p>
	        </div>
	        <div class='item text-center padd-right2'>
	            <p class='gt tieude'> Bên ủy quyền</p>
	        </div>
	    </div>
	</div>
</div>
";

            /*Phiếu hẹn*/
            html += @"
         <div style='page-break-before:always'>
			<div>
                <div class='flex justify-content-between'>
                    <div class='item'>
                        <h4 class='title'>UBND PHƯỜNG 6</h4>
                        <h4 class='sub-title line-title'>BỘ PHẬN HỘ TỊCH</h4>
                    </div>
                    <div class='item text-center'>
                        <h4 class='title'> CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM </h4>
                        <h4 class='sub-title line-title'> Độc lập - Tự do - Hạnh phúc </h4>
                    </div>
                </div>
            </div>
            <div class='flex justify-content-between'>
                <div class='item'>
                    <p>Số 1 /TNHS/KS </p>             
                </div>
                <div class='item'>
                    <p class='padd-right2'>Phường 14, ngày 27, tháng 4, năm 2019</p>
                </div>
            </div>
            <div>
                <h4 class='tex-center'>GIẤY TIẾP NHẬN HỒ SƠ VÀ HẸN TRẢ KẾT QUẢ</h4>
                <p>Bộ phận tiếp nhận và trả kết quả: Bộ phận Hộ tịch</p>
                <p>Tiếp nhận hồ sơ của ông/bà: 
                    <span class='gt'>" + data.Rows[0]["NYC_HoTen"].ToString() + @"</span>
                </p>
                <p>Địa chỉ: 
                    <span class='gt'>" + data.Rows[0]["NYC_SoNhaDuong"].ToString() + @", " + data.Rows[0]["NYC_PhuongXa"].ToString() + @", " + data.Rows[0]["NYC_QuanHuyen"].ToString() + @", " + data.Rows[0]["NYC_TinhTP"].ToString() + @"</span>
                </p>
                <p>Số điện thoại liên hệ: 
                    <span class='gt'>" + data.Rows[0]["NYC_SDT"].ToString() + @"</span>
                </p>
                <p>Nội dung yêu cầu giải quyết: 
                    <span class='gt'>Đăng ký khai sinh, BHYT, Nhập khẩu</span>
                </p>
                <p >Cho trẻ:
                    <span class='gt ten'>" + data.Rows[0]["TTT_HoTen"].ToString() + @"</span>
                    <span class='padd'>Sinh ngày:
                        <span class='gt'>" + DateTime.Parse(data.Rows[0]["TTT_NgaySinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
                    </span>
                    <span>Giới tính:
                    <span class='gt'>" + data.Rows[0]["TTT_GioiTinh"].ToString() + @"</span>
                    </span>
                <p>
            </div>
            <p class='tieude'>1.Thành phần hồ sơ nộp gồm:</p>
            <div class='flex justify-content-between'>
                    <div class='item'>
                        <p>a.Tờ khai tham gia bảo hiểm y tế</p>
                        <p>b.Phiếu báo thay đổi hộ khẩu,nhân khẩu</p>
                        <p>c.Giấy chứng sinh (bản chính)</p>
                        <p>d.Sổ hộ khẩu (bản chính)</p>
                        <p>e.Văn bản ủy quyền</p>
                    </div>
                    <div class='item'>
                        <p><input  type="" name=""></p>
                        <p><input  type="" name=""></p>
                        <p><input  type="" name=""></p>
                        <p><input  type="" name=""></p>
                        <p><input  type="" name=""></p>                        
                    </div>
                    <div class='item'>
                    </div>
            </div>
            <p class='tieude'>2.Giấy tờ phải xuất trình</p>
            <p>a. Giấy tờ tùy thân của người đi đăng ký khai sinh</p>
            <p>b.Giấy tờ chứng minh nơi cư trú</p>
            <p>c.Thời gian nhận hồ sơ: "+DateTime.Now.Hour.ToString()+ @" giờ, "+ DateTime.Now.Minute.ToString()+ @" phút, ngày " + DateTime.Now.Day.ToString() + @", tháng " + DateTime.Now.Month.ToString() + @", năm " + DateTime.Now.Year.ToString() + @"</p>
            <p>d.Thời gian trả kết quả: </p>
            <p>Đăng kí nhận kết quả tại Bộ phận hộ tịch</p>
            <div class='flex justify-content-between'>
                <div class='item'>
                    <p class='gt text-center tieude'> Người nộp hồ sơ</p>
                    <p class='gt'></p>
                    <p class='gt ten'>" + data.Rows[0]["NYC_HoTen"].ToString() + @"</p>
                </div>
                <div class='item text-center padd-right2'>
                    <p class='gt tieude'>Người tiếp nhận hồ sơ</p>
                    <p class='gt'> </p>
                    <p class='gt'></p>
                </div>
            </div>
		</div>
        ";

            /*Nhập khẩu*/
            html += @"
        <div style='page-break-before:always'>
			<div class='text-center'>
			    <h3 class='text-center margin-bottom1'> CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM </h3>
			    <h3 class='sub-title line-title'> Độc lập - Tự do - Hạnh phúc </h3>
			</div>
			<h3 class='title text-center'>PHIẾU BÁO THAY ĐỔI HỘ KHẨU, NHÂN KHẨU</h3>
			<p class='text-center'> Kính gửi: Công an quận Gò Vấp, thành phố Hồ Chí Minh</p>
			<p class='tieude'>I. Thông tin về người viết phiếu báo</p>
						<p>1.Họ và tên:
				<span class='gt ten'>" + data.Rows[0]["NYC_HoTen"].ToString() + @"</span>
				<span class='padd1'>2.Giới tính:
					<span class='gt'></span>
				</span>
			</p>
			<p>3.Số CMND:
				<span class='gt'>" + data.Rows[0]["NYC_SoGT"].ToString() + @"</span>
				<span class='padd1'>4.Hộ chiếu số:
					<span class='gt'>....</span>
				</span>
			</p>
			<p>5.Nơi thường trú:
				<span class='gt'>" + data.Rows[0]["NYC_SoNhaDuong"].ToString() + @", " + data.Rows[0]["NYC_PhuongXa"].ToString() + @", " + data.Rows[0]["NYC_QuanHuyen"].ToString() + @", " + data.Rows[0]["NYC_TinhTP"].ToString() + @"</span>
			</p>
			<p>6.Địa chỉ chỗ ở hiện nay:
				<span class='gt'>" + data.Rows[0]["NYC_SoNhaDuong"].ToString() + @", " + data.Rows[0]["NYC_PhuongXa"].ToString() + @", " + data.Rows[0]["NYC_QuanHuyen"].ToString() + @", " + data.Rows[0]["NYC_TinhTP"].ToString() + @"</span>
			</p>
			<p>7.Số điện thoại liên hệ:
				<span class='gt'>" + data.Rows[0]["NYC_SDT"].ToString() + @"</span>
			</p>
			<p class='tieude'>II. Thông tin về người có thay đổi hộ khẩu, nhân khẩu</p>

			<p>1. Họ và tên:
				<span class='gt ten'>" + data.Rows[0]["TTT_HoTen"].ToString() + @"</span>
				<span class='padd1'>2. Giới tính:
					<span class='gt'>" + data.Rows[0]["TTT_GioiTinh"].ToString() + @"</span>
				</span>
			</p>
			<p>3. Ngày, tháng, năm sinh:
				<span class='gt'>" + DateTime.Parse(data.Rows[0]["TTT_NgaySinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
				<span>4. Dân tộc:
					<span class='gt'>" + data.Rows[0]["TTT_DanToc"].ToString() + @"</span>
				</span>
				<span class='padd'>5. Quốc tịch
					<span class='gt'>" + data.Rows[0]["TTT_QuocGia_NoiSinh"].ToString() + @"</span>
				</span>
			</p>

			<p>6. Số CMND:
				<span class='gt'></span>
				<span class='padd1'>7. Hộ chiếu số:
					<span class='gt'></span>
				</span>
			</p>
			<p>8. Nơi Sinh:
				<span class='gt'>" + data.Rows[0]["TTT_TenCSYT"].ToString() + @"</span>
				<span>9. Quê quán:" + data.Rows[0]["TTT_SoNhaDuong_QQ"].ToString() + @"," + data.Rows[0]["TTT_PhuongXa_QQ"].ToString() + @"," + data.Rows[0]["TTT_QuanHuyen_QQ"].ToString() + @"," + data.Rows[0]["TTT_TinhTP_QQ"].ToString() + @"</span>
				</span>
			</p>
			</p>
			
			<p>10. Nghề nghiệp:
				<span class='gt padd1'></span>
				<span>11. Nơi trường trú: Chưa nhập khẩu</span>
			</p>
			<p>12. Địa chỉ chỗ ở hiện nay: 
				<span class='gt'>" + data.Rows[0]["TTT_SoNhaDuong"].ToString() + @"," + data.Rows[0]["TTT_PhuongXa"].ToString() + @"," + data.Rows[0]["TTT_QuanHuyen"].ToString() + @"," + data.Rows[0]["TTT_TinhTP"].ToString() + @"</span>
			</p>
			<p>13. Họ và tên chủ hộ:
				<span class='gt'>" + data.Rows[0]["CH_HoTen"].ToString() + @"</span>
				<span class='padd1'>14.Quan hệ với chủ hộ:
					<span class='gt'>" + data.Rows[0]["CH_QuanHe"].ToString() + @"</span>
				</span>
			</p>
			<p>15. Nội dung thay đổi hộ khẩu, nhân thân: 
				<span class='gt'>...</span>
			</p>
			<p>16. Những người cùng thay đổi: </p>
			<table>
				<thead>
					<tr>
						<th>TT</th>
						<th>Họ và tên</th>
						<th>Ngày, tháng, năm sinh</th>
						<th>Giới tính</th>
						<th>Nghề nghiệp</th>
						<th>Dân tộc</th>
						<th>CMND số(hoặc Hộ chiếu số)</th>
						<th>Quan hệ với người có thay đổi</th>
					</tr>
				</thead>
				<tbody>
					<tr><td>1</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
					<tr><td>2</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
					<tr><td>3</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
					<tr><td>4</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
					<tr><td>5</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
				</tbody>
			</table><br>
			<div class='flex justify-content-between text-center'>
                <div class='item'>
                	<p>Phường 14, ngày " + DateTime.Now.Day.ToString() + @", tháng " + DateTime.Now.Month.ToString() + @", năm " + DateTime.Now.Year.ToString() + @"</p>
                    <p class='margin-bottom1'>Ý KIẾN CỦA CHỦ HỘ</p>
                    <p>(Ghi rõ nội dung và ký, ghi rõ họ tên)</p>
                </div>
                <div class='item text-center padd-right2'>
                	<p>Phường 14, ngày " + DateTime.Now.Day.ToString() + @", tháng " + DateTime.Now.Month.ToString() + @", năm " + DateTime.Now.Year.ToString() + @"</p>
                    <p class='margin-bottom1'>NGƯỜI VIẾT PHIẾU BÁO</p>
                    <p>(Ghi rõ nội dung và ký, ghi rõ họ tên)</p>
                </div>
            </div><br><br><br>
    <p>XÁC NHẬN CỦA CÔNG AN......................................................................................................................</p>
    <p>...............................................................................................................................................................................</p>    
    <p>...............................................................................................................................................................................</p>    
    <p>...............................................................................................................................................................................</p>    
    <p>...............................................................................................................................................................................</p>    
    <p>...............................................................................................................................................................................</p>    
    <p>...............................................................................................................................................................................</p>
	        <div class='flex justify-content-between text-center'>
                <div class='item'>
                	<p></p>
                    <p></p>
                    <p></p>
                </div>
                <div class='item text-center padd-right2'>
                	<p>Phường 14, ngày " + DateTime.Now.Day.ToString() + @", tháng " + DateTime.Now.Month.ToString() + @", năm " + DateTime.Now.Year.ToString() + @"</p>
                    <p class='margin-bottom1'>TRƯỞNG CÔNG AN</p>
                    <p>(Ghi rõ nội dung và ký, ghi rõ họ tên)</p>
                </div>
            </div>
    </div>
    ";
            /*Phiếu thay đổi HK*/
            html += @"
        <div style='page-break-before:always'>
            <div class='flex justify-content-between'>
                <div class='item text-center'>
                    <h3 class='title'>CÔNG AN TP.HỒ CHÍ MINH</h4>
                        <h3 class='sub-title line-title'>CÔNG AN QUẬN GÒ VẤP</h4>
                </div>
                <div class='item text-center'>
                    <h3 class='title'> CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM </h4>
                        <h3 class='sub-title line-title'> Độc lập - Tự do - Hạnh phúc </h4>
                </div>
            </div>
            <h3 class=' margin-bottom1'>PHIẾU THÔNG TIN THAY ĐỔI VỀ HỘ KHẨU, NHÂN KHẨU</h3>
            <p class='text-center'><b>Kính gửi: Công an Phường 14, Quận Gò Vấp, Thành phố Hồ Chí Minh</b></p><br>
            <p>1. Họ và tên người có thay đổi:
                <span class='ten gt'>" + data.Rows[0]["TTT_HoTen"].ToString() + @"</span>
            </p>
            <p>2. Họ và tên gọi khác (nếu có):
                <span class='ten gt'></span>
            </p>
            <p>3. Ngày, tháng, năm sinh:
                <span class='ten gt'>" + DateTime.Parse(data.Rows[0]["TTT_NgaySinh"].ToString()).ToString("dd/MM/yyyy") + @"</span>
                <span class='padd1'>4. Giới tính:
                    <span class='gt'>" + data.Rows[0]["TTT_GioiTinh"].ToString() + @"</span>
                </span>
            </p>
            <p>5. Nơi sinh:
                <span class='ten gt'>" + data.Rows[0]["TTT_TenCSYT"].ToString() + @"</span>
            </p>
            <p>6. Quê quán:
                <span class='ten gt'>" + data.Rows[0]["TTT_SoNhaDuong_QQ"].ToString() + @", " + data.Rows[0]["TTT_PhuongXa_QQ"].ToString() + @", " + data.Rows[0]["TTT_QuanHuyen_QQ"].ToString() + @", " + data.Rows[0]["TTT_TinhTP_QQ"].ToString() + @"</span>
            </p>
            <p>7. Dân tộc:
                <span class='gt'>" + data.Rows[0]["TTT_DanToc"].ToString() + @"</span>
                <span class='padd'>8. Tôn Giáo:
                    <span class='gt'>" + data.Rows[0]["TTT_TonGiao"].ToString() + @"</span>
                </span>
                <span class='padd'>9. Quốc tịch:
                    <span class='gt'>" + data.Rows[0]["TTT_QuocGia"].ToString() + @"</span>
                </span>
            </p>
            <p>10. CMND số:
                <span class='gt'></span>
            </p>
            <p>11. Hồ sơ hộ khẩu số:
                <span class='gt'>" + data.Rows[0]["CH_HoSoSHK"].ToString() + @"</span>
                <span class='padd1'>12.Sổ hộ khẩu số:
                    <span class='gt'>" + data.Rows[0]["CH_SHK"].ToString() + @"</span>
                </span>
            </p>
            <p>13. Họ và tên chủ hộ:
                <span class='ten gt'>" + data.Rows[0]["CH_HoTen"].ToString() + @"</span>
                <span class='padd1'>14. Quan hệ với chủ hộ:
                    <span class='gt'>" + data.Rows[0]["CH_QuanHe"].ToString() + @"</span>
                </span>
            </p>
            <p>15. Nơi thường trú:
                <span class='gt'>" + data.Rows[0]["CH_SoNhaDuong"].ToString() + @", " + data.Rows[0]["CH_PhuongXa"].ToString() + @", " + data.Rows[0]["CH_QuanHuyen"].ToString() + @", " + data.Rows[0]["CH_TinhTP"].ToString() + @"</span>
            </p>
            <p class='tieude text-center'>NỘI DUNG THAY ĐỔI</p>
            <p>Nhập sinh</p><br>
            <p class='tieude text-center'>ĐỀ XUẤT, KIẾN NGHỊ (Nếu có)</p>
            <p>............................................................................................................................................................................................</p>
            <p>............................................................................................................................................................................................</p><br>
            <p class='canphai padd-right'>Gò vấp, ngày 27, tháng 4, năm 2019</p>
            <div class='flex justify-content-between text-center'>
                <div class='item'>
                    <p class='tieude margin-bottom1'>CÁN BỘ LẬP PHIẾU</p>
                    <p>(Ký, ghi rõ họ tên)</p>
                </div>
                <div class='item text-center padd-right2'>
                    <p class='tieude margin-bottom1'>TRƯỞNG CÔNG AN QUẬN GÒ VẤP</p>
                    <p>(Ký, ghi rõ họ tên và đóng dấu)</p>
                </div>
            </div>
        </div>

";

            html += @" </div></div></div>";
            Response.Write(html);
        }
    }
    

}