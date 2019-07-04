<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Layout/MasterPage_Menu.master" CodeFile="Menu.aspx.cs" Inherits="SelectMenu_Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                                <a href="#" class="btn btn-lg btn-outline dichvu-btn">
                                    <img src="../Content/img/baohiem.png"><br><br /><nav><b>Đăng ký</b><br><b>BẢO HIỂM</b></nav>
                                </a>
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
