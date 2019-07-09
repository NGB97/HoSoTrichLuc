<%@ Page Language="C#" MasterPageFile="~/Layout/MasterPage.master" AutoEventWireup="true" CodeFile="DKBaoHiem.aspx.cs" Inherits="DKBaoHiem_DKBaoHiem" %>

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
            LoadTinh_CH();
            LoadChiTietPhuLuc();
            pikaday();
            load_btnPrint();
            //checkClick();
        }
    </script>
    <asp:HiddenField ID="IDBaoHiem" value="" runat="server" />
    <asp:HiddenField ID="txtSoDon" runat="server" />
    
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
                        <input class="form-control left" data-val="true" data-val-required="" id="txtCH_HoTen" runat='server' name="Content.ContentName" value="" placeholder="" type="text" required />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Số điện thoại (nếu có)<span></span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtCH_SDT" name="Content.ContentName" type="text" value="" placeholder="" runat="server" />
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Số sổ hộ khẩu( hoặc sổ tạm trú )<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtCH_SoSHK" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="">
                <h6>Nơi cư trú</h6>
            </div>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Tỉnh/Thành phố <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtCH_TinhTP" ongchange="LoadTinhTP_NYC();" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                        <input type="hidden" runat="server" id="idCH_TinhTP" />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Quận/huyện<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" disabled id="txtCH_QuanHuyen" ongchange="LoadPhuongXa_NYC();" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                        <input type="hidden" runat="server" id="idCH_QuanHuyen" />
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
                        <input class="form-control" data-val="true" data-val-required="" disabled id="txtCH_PhuongXa" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Số nhà, Đường/Thôn<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" disabled id="txtCH_SoDuong" runat="server" name="Content.ContentName" value="" placeholder="Phố/Thôn/Tổ/Xóm/Số nhà, đường" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class=" bd_bottom">
                <h5>thông tin thành viên trong hộ khẩu</h5>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-10 col-md-10 col-sm-10 col-xs-9">
                    <i style="color: red;">(Lưu ý: nhập tất cả thành viên trong hộ khẩu)</i>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Họ và tên <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtTV_HoTen" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Mã số BHXH<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtTV_SoBHXH" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Ngày, tháng, năm sinh<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtTV_NamSinh" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Giới tính<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <select class="form-control" data-val="true" data-val-required="" id="txtTV_GioiTinh" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus>
                            <option value="Nam"></option>
                            <option value="Nữ"></option>
                        </select>
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Nơi cấp giấy khai sinh<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtTV_NoiCap" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Quan hệ với chủ hộ<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtTV_QuanHe" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Số Giấy tờ tùy thân<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtTV_SoGTTT" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Ghi chú<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtTV_GhiChu" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="row col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div style="text-align: center">
                        <a style="cursor: pointer;" onclick="ThemTVHGD();" class="btn btn-flat">
                            <div>Thêm</div>
                        </a>
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div id="ChiTietTVHGD">
                </div>
            </div>
                <br />
        </div>
    </div>
    <br />
    <div class="col-lg-12">
       <div class="col-lg-4"></div>
       <div class="col-lg-4"></div>
       <div class="col-lg-4">
            <asp:LinkButton ID="btLuu" type="button" class="btn" OnClick="btLuu_Click" runat="server">Gửi thông tin</asp:LinkButton>
            <button href="#" id="btnPrint" type="button" class="btn" onclick="PrinfBaoHiem()" runat="server">In Đơn</button>
            <button href="#" id="btnPrint_PhuLuc" type="button" class="btn" onclick="PrinfPhuLuc()" runat="server">In Phụ Lục</button>
        </div>
    </div>
</asp:Content>
