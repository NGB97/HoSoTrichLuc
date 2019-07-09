<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Layout/MasterPage.master" CodeFile="DKKhaiTu.aspx.cs" Inherits="DKKhaiTu_DKKhaiTu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script src="../Content/js/jquery-latest.js"></script>
    <script src="../Content/dist/jquery-ui-1.11.3/jquery-ui.js"></script>
    <script src="../Content/js/timepicker.min.js"></script>
    <link href="../Content/css/timepicker.min.css" rel="stylesheet" />
    <link href="../Content/dist/jquery-ui-1.11.3/jquery-ui.css" rel="stylesheet" />
    <script src="DKKhaiTu.js"></script>
    <script src="../Content/cssdatepicker/moment.min.js"></script>
    <link href="../Content/cssdatepicker/pikaday.css" rel="stylesheet" />
    <script src="../Content/cssdatepicker/pikaday.js"></script>
    <script>
        window.onload = function () {
            Load_NYC_NoiCap();
            LoadTinh_NYC();
            Load_NC_NoiCap();
            LoadTinh_NC();
            pikaday();
        }

    </script>
    
    <div class="container position top_ft">
        <div class="col-md-offset-1  col-md-10 bg_form">
            <div class=" bd_bottom">
                <h5>thông tin người yêu cầu</h5>
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
                        <label for="">Quan hệ với người đã khuất<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_QuanHe" name="Content.ContentName" type="text" value="" placeholder="" runat="server" />
                    </div>
                </div>
            </div>
            <div class="">
                <h6>Giấy tờ</h6>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Giấy tờ tùy thân<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_LoaiGT" runat="server" name="Content.ContentName" value="" placeholder="CMND/CCCD/HC" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Số<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_SoGT" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Ngày cấp <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_NgayCap" runat="server" autocomplete="off" name="Content.ContentName" value="" placeholder="ngày / tháng / năm" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Nơi cấp <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_NoiCap" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
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
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Quốc gia<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_QuocGia" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />

                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Tỉnh/Thành phố <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNYC_TinhTP" ongchange="LoadTinhTP_NYC();" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                        <input type="hidden" runat="server" id="idNYC_TinhTP" />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Quận/huyện<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" disabled id="txtNYC_QuanHuyen" ongchange="LoadPhuongXa_NYC();" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                        <input type="hidden" runat="server" id="idNYC_QuanHuyen" />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Phường/Xã<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" disabled id="txtNYC_PhuongXa" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>

            </div>
            <br>
            <div class="row">
                <div class=" col-lg-12 col-md-12 col-sm-12">
                    <div class="row col-lg-2 col-md-2 col-sm-2 col-xs-3">
                        <label for="">Số nhà/Đường <span>*</span></label>
                    </div>
                    <div class="row col-lg-10 col-md-10 col-sm-10 col-xs-9">
                        <input class="form-control left_1" placeholder="Khu phố/Thôn/Tổ/Xóm/Tòa nhà, số nhà, đường" data-val="true" data-val-required="" id="txtNYC_SoNhaDuong" runat="server" name="Content.ContentName" value="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class=" bd_bottom">
                <h5>thông tin người được khai tử</h5>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Họ và tên <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_HoTen" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Giới tính <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <select class="form-control" data-val="true" data-val-required="" id="txtNC_GioiTinh" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus>
                            <option>Nam</option>
                            <option>Nữ</option>
                        </select>
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Ngày sinh <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_NgaySinh" runat="server" autocomplete="off" name="Content.ContentName" value="" placeholder="ngày / tháng / năm" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Dân tộc<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_DanToc" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Quốc tịch<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_QuocTich" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>

            <div class="">
                <h6>Giấy tờ</h6>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Giấy tờ tùy thân<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_GTTT" runat="server" name="Content.ContentName" value="" placeholder="CMND/CCCD/HC" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Số<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_SoGTTT" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Ngày cấp <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_NgayCap" runat="server" autocomplete="off" name="Content.ContentName" value="" placeholder="ngày / tháng / năm" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Nơi cấp <span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_NoiCap" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="">
                <h6>Nơi cư trú
                    <span style="padding-left: 65px">
                        <input type="checkbox" id="TTT_NCT" runat="server">
                        <label class="css-label radGroup1"><span><i>(Chọn nếu Cư trú nước ngoài)</i></span></label>
                    </span>
                </h6>
            </div>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Quốc gia<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_QuocGia" onchange="LoadQuanHuyen_TTT();" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Tỉnh/Thành phố<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_TinhTP" onchange="LoadQuanHuyen_NC();" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                        <input runat="server" type="hidden" id="idNC_TinhTP" />
                    </div>
                </div>

            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Quận/huyện<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" disabled id="txtNC_QuanHuyen" onchange="LoadPhuongXa_NC();" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                        <input runat="server" type="hidden" onchange="LoadPhuongXa_NC();" id="idNC_QuanHuyen" />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Phường/Xã<span>*</span></label>

                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" disabled id="txtNC_PhuongXa" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class=" col-lg-12 col-md-12 col-sm-12">
                    <div class="row col-lg-2 col-md-2 col-sm-2 col-xs-3">
                        <label for="">Số nhà/Đường <span>*</span></label>
                    </div>
                    <div class="row col-lg-10 col-md-10 col-sm-10 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_SoNhaDuong" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="">
                <h6>Thông tin về cái chết</h6>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Đã chết vào lúc<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_GioChet" runat="server" name="Content.ContentName" value="" placeholder="Giờ : Phút" type="text" required autofocus autocomplete="off" />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Ngày, tháng, năm chết<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_NgayChet" autocomplete="off" runat="server" name="Content.ContentName" value="" placeholder="Ngày / tháng / năm" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class=" col-lg-12 col-md-12 col-sm-12">
                    <div class="row col-lg-2 col-md-2 col-sm-2 col-xs-3">
                        <label for="">Nơi chết<span>*</span></label>
                    </div>
                    <div class="row col-lg-10 col-md-10 col-sm-10 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_NoiChet" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class=" col-lg-12 col-md-12 col-sm-12">
                    <div class="row col-lg-2 col-md-2 col-sm-2 col-xs-3">
                        <label for="">Ngyên nhân chết<span>*</span></label>
                    </div>
                    <div class="row col-lg-10 col-md-10 col-sm-10 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_NguyenNhanChet" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Số giấy báo tử/Giấy tờ thay thế giấy báo tử<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_SoGBT" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3 mg_left">
                        <label for="">Do<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_Do" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Ngày cấp<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_NgayCapGBT" runat="server" name="Content.ContentName" autocomplete="off" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="row col-lg-6 col-md-6 col-sm-6 col-xs-6">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-3">
                        <label for="">Số lượng bản sao yêu cầu<span>*</span></label>
                    </div>
                    <div class="row col-lg-8 col-md-8 col-sm-8 col-xs-9">
                        <input class="form-control" data-val="true" data-val-required="" id="txtNC_SoLuong" runat="server" name="Content.ContentName" value="" placeholder="" type="text" required autofocus />
                    </div>
                </div>
            </div>
            <br />
        </div>
        <div class="col-md-offset-1 col-lg-offset-1 col-sm-offset-1 col-xs-offset-1 col-md-10 col-lg-10 col-sm-10 col-xs-9">
            <div class="form-check">
                <div class="col-md-1 col-lg-1 col-sm-1 col-xs-1">
                    <input type="checkbox" class="form-check-input" id="exampleCheck1">
                </div>
                <div class="col-md-11 col-lg-11 col-sm-11 col-xs-11">
                    <label class="form-check-label label" for="exampleCheck1">
                        Tôi xin chịu trách nhiệm trước pháp
                        luật
                        về lời
                        khai trên.</label>
                </div>
            </div>
        </div>
        <div class="col-lg-offset-9 col-lg-3 col-md-offset-9 col-md-3 col-sm-offset-9 col-sm-3 col-xs-offset-9 col-xs-3">
            <asp:LinkButton ID="btLuu" type="button" class="btn" OnClick="btLuu_Click" runat="server">Gửi thông tin</asp:LinkButton>
            <button href="#" type="button" class="btn" onclick="PrinfKhaiTu();" runat="server">In Đơn</button>
        </div>
        <br>
        <%--    <asp:LinkButton ID="btExcel" type="button" class="btn" OnClick="btExcel_Click" runat="server">Xuất Excel</asp:LinkButton>--%>
    </div>
</asp:Content>
