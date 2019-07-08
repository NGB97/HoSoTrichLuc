<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Layout/MasterPage_Menu.master" CodeFile="Menu.aspx.cs" Inherits="SelectMenu_Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script src="../Content/js/jquery.min.js"></script>
    <script src="../Content/js/bootstrap.min.js"></script>
    <style>
        .btn-default {
            color: white;
            background-color: #017dc7;
            width: 20%;
            padding: 2px 2px !important;
            margin-top: -2px;
        }
        input{
            color:black !important;
            text-align:center;
            width:20%;
        }
    </style>
    <script>
        function checkDK() {
            document.getElementById('ContentPlaceHolder1_SoDon').style.display = "inline";
        }
        function checkSoDon() {
            var SoDon = $('#ContentPlaceHolder1_txtSoDKMoi').val();
            var el = document.getElementById("DK");
            el.href = "../DKBaoHiem/DKBaoHiem_Moi.aspx?SoDon="+SoDon;
        }
        function checkGiaHan() {
            var GiaHan = $('#ContentPlaceHolder1_txtSoGiaHan').val();
            var ex = document.getElementById("DK_GiaHan");
            ex.href = "../DKBaoHiem/DKBaoHiem.aspx?SoDon=" + GiaHan;
        }
        function checkSoGiaHan() {
            document.getElementById('ContentPlaceHolder1_DivGiaHan').style.display = "inline";
        }
    </script>
     <div id="chooseType" class="container">             
                <div class="row">
                    <div class="col-lg-12">
                        <div class="dichvu-text" style="text-align:center;">
                          <h2> HỆ THỐNG ĐĂNG KÝ HỘ TỊCH</h2>
                        </div><br /><br /><br />
                        <div class="col-lg-12" style="margin-left: 4.1%">
                            <div class="col-6 col-sm-2 text-center border-menu">
                                <a href="../DKhSinh/DKKhaiSinh.aspx" class="btn btn-lg btn-outline dichvu-btn"">
                                    <img src="../Content/img/khaisinh.png">
                                    <br><br />
                                    <nav><b>Đăng ký</b><br><b>khai sinh</b></nav>
                                </a>
                            </div>
                            
                            <div class="col-6 col-sm-2 text-center border-menu">
                                <a href="../DKKhaiTu/DKKhaiTu.aspx" class="btn btn-lg btn-outline dichvu-btn">
                                    <img src="../Content/img/khaitu.png"><br><br /><nav><b>Đăng ký</b><br><b>KHAI TỬ</b></nav>
                                </a>
                            </div>
                            
                            <div class="col-6 col-sm-2 text-center border-menu">
                                <a data-toggle="modal" data-target="#myModal" class="btn btn-lg btn-outline dichvu-btn">
                                    <img src="../Content/img/baohiem.png"><br><br /><nav><b>Đăng ký</b><br><b>BẢO HIỂM</b></nav>
                                </a>
                            </div>
                            <!-- Modal -->
                            <div class="modal fade" id="myModal" role="dialog">
                                <div class="modal-dialog">
                                    <!-- Modal content-->
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                                            <h4 class="modal-title">Chọn hình thức đăng ký</h4>
                                        </div>
                                        <div class="modal-body">
                                            <br />
                                            <p style="font-size:25px;text-align:center">
                                                <a class="btn btn-success" onclick="checkDK()">Đăng ký mới</a>
                                            </p>
                                            <div id="SoDon" hidden="hidden" runat="server">
                                                 <label style="color:black !important">Số thành viên đăng ký:</label>
                                                <span>
                                                    <input type="text" name="name" id="txtSoDKMoi" onchange="checkSoDon()" runat="server" value=""/>
                                                </span>
                                                <span>
                                                    <a href="#" id="DK" class="btn btn-default">Đăng ký</a>
                                                </span>
                                            </div>
                                            <hr />
                                             <p style="font-size:25px;text-align:center">
                                                 <a class="btn btn-success" onclick="checkSoGiaHan()">Gia Hạn</a>
                                            </p>
                                            <div id="DivGiaHan" hidden="hidden" runat="server">
                                                 <label style="color:black !important">Số thành viên đăng ký:</label>
                                                <span>
                                                    <input type="text" name="name" id="txtSoGiaHan" onchange="checkGiaHan()" runat="server" value=""/>
                                                </span>
                                                <span>
                                                    <a href="#" id="DK_GiaHan" class="btn btn-default">Đăng ký</a>
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="col-lg-12" style="margin-left: 8.1%">                           
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>
