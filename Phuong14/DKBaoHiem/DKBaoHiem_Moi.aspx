<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Layout/MasterPage.master" CodeFile="DKBaoHiem_Moi.aspx.cs" Inherits="DKBaoHiem_DKBaoHiem_Moi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script src="../Content/js/jquery-latest.js"></script>
    <script src="../Content/dist/jquery-ui-1.11.3/jquery-ui.js"></script>
    <script src="DKBaoHiem.js"></script>
    <script src="../Content/js/timepicker.min.js"></script>
    <link href="../Content/css/timepicker.min.css" rel="stylesheet" />
    <link href="../Content/dist/jquery-ui-1.11.3/jquery-ui.css" rel="stylesheet" />
    <script src="../Content/cssdatepicker/moment.min.js"></script>
    <link href="../Content/cssdatepicker/pikaday.css" rel="stylesheet" />
    <script src="../Content/cssdatepicker/pikaday.js"></script>
    <script>
        window.onload = function () {
            LoadTinh_NYC();
            LoadTinh_NCT();
            pikadayBH();
        }
    </script>
    <div class="check_qh margin_top" id="Div1" runat="server">
        <h3 class="dk">hệ thống đăng ký bảo hiểm</h3>
    </div>
    <div class="container position top_ft">
        <div class="col-md-offset-1  col-md-10 bg_form">
            <div class=" bd_bottom">
                <h5>thông tin người chủ hộ</h5>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 ">
                        <label for="">Họ và tên <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9 ">
                        <input class="form-control  left" data-val="true" data-val-required="" id="txtNYC_HoTen" runat='server' name="Content.ContentName" value="" placeholder="" type="text" required />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Năm sinh <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_NamSinh" name="Content.ContentName" type="text" value="" placeholder="ngày / tháng / năm" runat="server" />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Giới tính <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <select class="form-control " data-val="true" data-val-required="" id="txtNYC_GioiTinh" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus>
                            <option value="Nam"></option>
                            <option value="Nữ"></option>
                        </select>
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Dân tộc <span></span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_DanToc" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Quốc tịch<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control " data-val="true" data-val-required="" id="txtNYC_QuocTich" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="">
                <h6>Nơi đăng kí khai sinh</h6>
                <i style="color: red;">Nhập theo thứ tự Tỉnh/TP - Quận/Huyện - Phường/Xã</i>
            </div>
            <br />
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Tỉnh/Thành phố <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_TinhTP_NS" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                        <input type="hidden" runat="server" id="idNYC_TinhTP_NS" />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Quận/huyện<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" disabled id="txtNYC_QuanHuyen_NS" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                        <input type="hidden" runat="server" id="idNYC_QuanHuyen_NS" />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Phường/Xã<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" disabled id="txtNYC_PhuongXa_NS" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="">
                <h6>Nơi cư trú</h6>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Tỉnh/Thành phố <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_TinhTP" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                        <input type="hidden" runat="server" id="idNYC_TinhTP" />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Quận/huyện<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" disabled id="txtNYC_QuanHuyen" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                        <input type="hidden" runat="server" id="idNYC_QuanHuyen" />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Phường/Xã<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" disabled id="txtNYC_PhuongXa" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Số nhà/Đường <span>*</span></label>
                    </div>
                    <div class="row row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control left_1" placeholder="Phố/Thôn/Tổ/Xóm/Số nhà, đường" data-val="true" data-val-required="" id="txtNYC_SoNhaDuong" runat="server" name="Content.ContentName" value="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Họ tên cha/ mẹ/ người giám hộ<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_NGH" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                        <i style="color: red;">(Đối với trẻ em dưới 6 tuổi)</i>
                    </div>
                </div>
            </div>
            <br />
            <div class=" bd_bottom">
                <h5>phần kê khai chung</h5>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 ">
                        <label for="">Mã số BHXH (đã cấp)<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9 ">
                        <input class="form-control  left" data-val="true" data-val-required="" id="txtNYC_BHXH" runat='server' name="Content.ContentName" value="" placeholder="" type="text" required />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Số điện thoại <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_SDT" name="Content.ContentName" type="text" value="" placeholder="" runat="server" />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 ">
                        <label for="">Giấy tờ tùy thân<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9 ">
                        <input class="form-control  left" data-val="true" data-val-required="" id="txtNYC_GTTT" runat='server' name="Content.ContentName" value="" placeholder="CMND/CCCD/HC" type="text" required />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="" style="float:right;padding-right:26px">Số<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_SoGTTT" name="Content.ContentName" type="text" value="" placeholder="" runat="server" />
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 ">
                        <label for="">Mã số hộ gia đình (đã cấp)<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9 ">
                        <input class="form-control  left" data-val="true" data-val-required="" id="txtNYC_MaSoHGD" runat='server' name="Content.ContentName" value="" placeholder="" type="text" required />
                    </div>
                </div>
                
            </div>
            <br />
            <div class="row">
                <div class=" col-lg-12 col-md-12 col-sm-12">
                    <div class="row col-lg-2 col-md-2 col-sm-2 col-xs-3">
                        <label for="">Nơi đăng ký khám chữa bệnh ban đầu</label>
                    </div>
                    <div class="row col-lg-10 col-md-10 col-sm-10 col-xs-9">

                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_NoiKCB" runat="server" name="Content.ContentName" value="" placeholder="Tên bệnh viện, thành phố" type="text" required autofocus />
                        <i style="color: red;">Ghi rõ tên Bệnh viện, Thành phố</i>
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class=" col-lg-12 col-md-12 col-sm-12">
                    <div class="row col-lg-2 col-md-2 col-sm-2 col-xs-3">
                        <label for="">Nội dung thay đổi yêu cầu</label>
                    </div>
                    <div class="row col-lg-10 col-md-10 col-sm-10 col-xs-9">

                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_NoiDungYC" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class=" col-lg-12 col-md-12 col-sm-12">
                    <div class="row col-lg-2 col-md-2 col-sm-2 col-xs-3">
                        <label for="">Hồ sơ kèm theo (nếu có) </label>
                    </div>
                    <div class="row col-lg-10 col-md-10 col-sm-10 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_HoSo" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
        </div>
    </div>
    <br />
    <div class="col-lg-offset-9 col-lg-3 col-md-offset-9 col-md-3 col-sm-offset-9 col-sm-3 col-xs-offset-9 col-xs-3">
        <asp:LinkButton ID="btLuu" type="button" class="btn" OnClick="btLuu_Click" runat="server">Gửi thông tin</asp:LinkButton>
<%--        <button href="#" type="button" class="btn" onclick="PrinfKhaiSinh1()" runat="server">In Đơn</button>--%>
    </div>
</asp:Content>
