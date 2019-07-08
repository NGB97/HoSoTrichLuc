function ThemTVHGD() {
    var TV_HoTen = $('#ContentPlaceHolder1_txtTV_HoTen').val();
    var TV_SoBHXH = $('#ContentPlaceHolder1_txtTV_SoBHXH').val();
    var TV_NamSinh = $('#ContentPlaceHolder1_txtTV_NamSinh').val();
    var TV_GioiTinh = $('#ContentPlaceHolder1_txtTV_GioiTinh').val();
    var TV_NoiCap = $('#ContentPlaceHolder1_txtTV_NoiCap').val();
    var TV_QuanHe = $('#ContentPlaceHolder1_txtTV_QuanHe').val();
    var TV_SoGTTT = $('#ContentPlaceHolder1_txtTV_SoGTTT').val();
    var TV_GhiChu = $('#ContentPlaceHolder1_txtTV_GhiChu').val();
    if (TV_HoTen.trim().length <= 0 || TV_SoGTTT.trim().length <=0) {
        alert('Hãy nhập đủ các mục được yêu cầu')
    }
    else {
        var xmlhttp;
        if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
            xmlhttp = new XMLHttpRequest();
        }
        else {// code for IE6, IE5
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                if (xmlhttp.responseText == "True") {
                    LoadChiTietPhuLuc();
                    ReloadInput();
                    return false;
                }
                else {
                    if (xmlhttp.responseText == "False") {
                        alert("Đề nghị kiểm tra lại thông tin thành viên!");
                    }
                    else
                        alert("Lỗi internet !");
                }
            }
        }
        xmlhttp.open("GET", "Ajax_DKBaoHiem.aspx?Action=ThemTVHGD&TV_HoTen=" + TV_HoTen + "&TV_SoBHXH=" + TV_SoBHXH + "&TV_NamSinh=" + TV_NamSinh + "&TV_GioiTinh=" + TV_GioiTinh + "&TV_NoiCap=" + TV_NoiCap + "&TV_QuanHe=" + TV_QuanHe + "&TV_SoGTTT=" + TV_SoGTTT + "&TV_GhiChu=" + TV_GhiChu, true);
        xmlhttp.send();
    }
}

function LoadChiTietPhuLuc() {
    var xmlhttp;
    if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
        xmlhttp = new XMLHttpRequest();
    }
    else {// code for IE6, IE5
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            if (xmlhttp.responseText != "") {
                $("#ChiTietTVHGD").html(xmlhttp.responseText);
                return false;
            }
            else
                alert("Lỗi !")
        }
    }
    xmlhttp.open("GET", "Ajax_DKBaoHiem.aspx?Action=LoadChiTietPhuLuc", true);
    xmlhttp.send();
}

function DeleteChiTietPhuLuc(STT) {
    if (confirm('Bạn có muốn xóa không ?')) {
        var xmlhttp;
        if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
            xmlhttp = new XMLHttpRequest();
        }
        else {// code for IE6, IE5
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                // alert(xmlhttp.responseText);
                if (xmlhttp.responseText == "True") {
                    LoadChiTietPhuLuc();
                    return false;
                }
                else
                    alert("Lỗi không thể xóa !")
            }
        }
        xmlhttp.open("GET", "Ajax_DKBaoHiem.aspx?Action=DeleteChiTietPhuLuc&STT=" + STT, true);
        xmlhttp.send();
    }
}

function ReloadInput() {
    document.getElementById('ContentPlaceHolder1_txtTV_HoTen').value = '';
    document.getElementById('ContentPlaceHolder1_txtTV_SoBHXH').value = '';
    document.getElementById('ContentPlaceHolder1_txtTV_NamSinh').value = '';
    document.getElementById('ContentPlaceHolder1_txtTV_NoiCap').value = '';
    document.getElementById('ContentPlaceHolder1_txtTV_QuanHe').value = '';
    document.getElementById('ContentPlaceHolder1_txtTV_SoGTTT').value = '';
    document.getElementById('ContentPlaceHolder1_txtTV_GhiChu').value = '';
}

function LoadTinh_CH() {
    var xmlhttp;
    if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
        xmlhttp = new XMLHttpRequest();
    }
    else {// code for IE6, IE5
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            if (xmlhttp.responseText != "") {
                //alert(xmlhttp.responseText);
                var txt = xmlhttp.responseText
                    .replace(/[\"]/g, '\\"')
                    .replace(/[\\]/g, '\\\\')
                    .replace(/[\/]/g, '\\/')
                    .replace(/[\b]/g, '\\b')
                    .replace(/[\f]/g, '\\f')
                    .replace(/[\n]/g, '\\n')
                    .replace(/[\r]/g, '\\r')
                    .replace(/[\t]/g, '\\t');

                var listGioAutocomplete = eval("(" + xmlhttp.responseText + ")");
                $("#ContentPlaceHolder1_txtCH_TinhTP").autocomplete({

                    minLength: 0,
                    source: listGioAutocomplete,
                    focus: function (event, ui) {
                        $("#ContentPlaceHolder1_txtCH_TinhTP").val(ui.item.label);
                        return false;
                    },
                    select: function (event, ui) {
                        $("#ContentPlaceHolder1_txtCH_TinhTP").val(ui.item.value);
                        $("#ContentPlaceHolder1_idCH_TinhTP").val(ui.item.id);
                        document.getElementById('ContentPlaceHolder1_txtCH_QuanHuyen').disabled = false;
                        LoadQuanHuyen_CH();
                        return false;
                    }
                }).focus(function () {
                    $(this).autocomplete("search", "");
                });
            }
            else {

                alert("Lỗi get Giờ!")
            }

        }
    }
    xmlhttp.open("GET", "Ajax_DKBaoHiem.aspx?Action=LoadTinh", true);
    xmlhttp.send();
}

function LoadQuanHuyen_CH() {
    var CH_TinhTP = $('#ContentPlaceHolder1_idCH_TinhTP').val();
    if (CH_TinhTP != "" && CH_TinhTP != "0") {
        var xmlhttp;
        if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
            xmlhttp = new XMLHttpRequest();
        }
        else {// code for IE6, IE5
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                if (xmlhttp.responseText != "") {
                    //alert(xmlhttp.responseText);
                    var txt = xmlhttp.responseText
                        .replace(/[\"]/g, '\\"')
                        .replace(/[\\]/g, '\\\\')
                        .replace(/[\/]/g, '\\/')
                        .replace(/[\b]/g, '\\b')
                        .replace(/[\f]/g, '\\f')
                        .replace(/[\n]/g, '\\n')
                        .replace(/[\r]/g, '\\r')
                        .replace(/[\t]/g, '\\t');

                    var listGioAutocomplete = eval("(" + xmlhttp.responseText + ")");
                    $("#ContentPlaceHolder1_txtCH_QuanHuyen").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtCH_QuanHuyen").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtCH_QuanHuyen").val(ui.item.value);
                            $("#ContentPlaceHolder1_idCH_QuanHuyen").val(ui.item.id);
                            document.getElementById('ContentPlaceHolder1_txtCH_PhuongXa').disabled = false;
                            LoadPhuongXa_CH();
                            return false;
                        }
                    }).focus(function () {
                        $(this).autocomplete("search", "");
                    });
                }
                else {
                    alert("Lỗi không tìm thấy danh sách quận huyện!")
                }

            }
        }
        xmlhttp.open("GET", "Ajax_DKBaoHiem.aspx?Action=LoadQuanHuyen&Tinh=" + CH_TinhTP + "", true);
        xmlhttp.send();
    }
}

function LoadPhuongXa_CH() {
    var CH_QuanHuyen = $('#ContentPlaceHolder1_idCH_QuanHuyen').val();
    if (CH_QuanHuyen != "" && CH_QuanHuyen != "0") {
        var xmlhttp;
        if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
            xmlhttp = new XMLHttpRequest();
        }
        else {// code for IE6, IE5
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                if (xmlhttp.responseText != "") {
                    //alert(xmlhttp.responseText);
                    var txt = xmlhttp.responseText
                        .replace(/[\"]/g, '\\"')
                        .replace(/[\\]/g, '\\\\')
                        .replace(/[\/]/g, '\\/')
                        .replace(/[\b]/g, '\\b')
                        .replace(/[\f]/g, '\\f')
                        .replace(/[\n]/g, '\\n')
                        .replace(/[\r]/g, '\\r')
                        .replace(/[\t]/g, '\\t');

                    var listGioAutocomplete = eval("(" + xmlhttp.responseText + ")");
                    $("#ContentPlaceHolder1_txtCH_PhuongXa").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtCH_PhuongXa").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtCH_PhuongXa").val(ui.item.value);
                            document.getElementById('ContentPlaceHolder1_txtCH_SoDuong').disabled = false;
                            return false;
                        }
                    }).focus(function () {
                        $(this).autocomplete("search", "");
                    });
                }
                else {
                    alert("Lỗi không tìm thấy danh sách Phường xã!")
                }

            }
        }
        xmlhttp.open("GET", "Ajax_DKBaoHiem.aspx?Action=LoadPhuongXa&QuanHuyen=" + CH_QuanHuyen + "", true);
        xmlhttp.send();
    }
}

function pikaday() {
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtTV_NamSinh'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
}

function pikadayBH() {
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtNYC_NamSinh'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
}

function LoadTinh_NYC() {
    var xmlhttp;
    if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
        xmlhttp = new XMLHttpRequest();
    }
    else {// code for IE6, IE5
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            if (xmlhttp.responseText != "") {
                //alert(xmlhttp.responseText);
                var txt = xmlhttp.responseText
                    .replace(/[\"]/g, '\\"')
                    .replace(/[\\]/g, '\\\\')
                    .replace(/[\/]/g, '\\/')
                    .replace(/[\b]/g, '\\b')
                    .replace(/[\f]/g, '\\f')
                    .replace(/[\n]/g, '\\n')
                    .replace(/[\r]/g, '\\r')
                    .replace(/[\t]/g, '\\t');

                var listGioAutocomplete = eval("(" + xmlhttp.responseText + ")");
                $("#ContentPlaceHolder1_txtNYC_TinhTP_NS").autocomplete({

                    minLength: 0,
                    source: listGioAutocomplete,
                    focus: function (event, ui) {
                        $("#ContentPlaceHolder1_txtNYC_TinhTP_NS").val(ui.item.label);
                        return false;
                    },
                    select: function (event, ui) {
                        $("#ContentPlaceHolder1_txtNYC_TinhTP_NS").val(ui.item.value);
                        $("#ContentPlaceHolder1_idNYC_TinhTP_NS").val(ui.item.id);
                        document.getElementById('ContentPlaceHolder1_txtNYC_QuanHuyen_NS').disabled = false;
                        LoadQuanHuyen_NYC();
                        return false;
                    }
                }).focus(function () {
                    $(this).autocomplete("search", "");
                });
            }
            else {

                alert("Lỗi get Giờ!")
            }

        }
    }
    xmlhttp.open("GET", "Ajax_DKBaoHiem.aspx?Action=LoadTinh", true);
    xmlhttp.send();
}

function LoadQuanHuyen_NYC() {
    var NYC_TinhTP = $('#ContentPlaceHolder1_idNYC_TinhTP_NS').val();
    if (NYC_TinhTP != "" && NYC_TinhTP != "0") {
        var xmlhttp;
        if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
            xmlhttp = new XMLHttpRequest();
        }
        else {// code for IE6, IE5
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                if (xmlhttp.responseText != "") {
                    //alert(xmlhttp.responseText);
                    var txt = xmlhttp.responseText
                        .replace(/[\"]/g, '\\"')
                        .replace(/[\\]/g, '\\\\')
                        .replace(/[\/]/g, '\\/')
                        .replace(/[\b]/g, '\\b')
                        .replace(/[\f]/g, '\\f')
                        .replace(/[\n]/g, '\\n')
                        .replace(/[\r]/g, '\\r')
                        .replace(/[\t]/g, '\\t');

                    var listGioAutocomplete = eval("(" + xmlhttp.responseText + ")");
                    $("#ContentPlaceHolder1_txtNYC_QuanHuyen_NS").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNYC_QuanHuyen_NS").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNYC_QuanHuyen_NS").val(ui.item.value);
                            $("#ContentPlaceHolder1_idNYC_QuanHuyen_NS").val(ui.item.id);
                            document.getElementById('ContentPlaceHolder1_txtNYC_PhuongXa_NS').disabled = false;
                            LoadPhuongXa_NYC();
                            return false;
                        }
                    }).focus(function () {
                        $(this).autocomplete("search", "");
                    });
                }
                else {
                    alert("Lỗi không tìm thấy danh sách quận huyện!")
                }

            }
        }
        xmlhttp.open("GET", "Ajax_DKBaoHiem.aspx?Action=LoadQuanHuyen&Tinh=" + NYC_TinhTP + "", true);
        xmlhttp.send();
    }
}

function LoadPhuongXa_NYC() {
    var NYC_QuanHuyen = $('#ContentPlaceHolder1_idNYC_QuanHuyen_NS').val();
    if (NYC_QuanHuyen != "" && NYC_QuanHuyen != "0") {
        var xmlhttp;
        if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
            xmlhttp = new XMLHttpRequest();
        }
        else {// code for IE6, IE5
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                if (xmlhttp.responseText != "") {
                    //alert(xmlhttp.responseText);
                    var txt = xmlhttp.responseText
                        .replace(/[\"]/g, '\\"')
                        .replace(/[\\]/g, '\\\\')
                        .replace(/[\/]/g, '\\/')
                        .replace(/[\b]/g, '\\b')
                        .replace(/[\f]/g, '\\f')
                        .replace(/[\n]/g, '\\n')
                        .replace(/[\r]/g, '\\r')
                        .replace(/[\t]/g, '\\t');

                    var listGioAutocomplete = eval("(" + xmlhttp.responseText + ")");
                    $("#ContentPlaceHolder1_txtNYC_PhuongXa_NS").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNYC_PhuongXa_NS").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNYC_PhuongXa_NS").val(ui.item.value);
                            return false;
                        }
                    }).focus(function () {
                        $(this).autocomplete("search", "");
                    });
                }
                else {
                    alert("Lỗi không tìm thấy danh sách Phường xã!")
                }

            }
        }
        xmlhttp.open("GET", "Ajax_DKBaoHiem.aspx?Action=LoadPhuongXa&QuanHuyen=" + NYC_QuanHuyen + "", true);
        xmlhttp.send();
    }
}

function LoadTinh_NCT() {
    var xmlhttp;
    if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
        xmlhttp = new XMLHttpRequest();
    }
    else {// code for IE6, IE5
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            if (xmlhttp.responseText != "") {
                //alert(xmlhttp.responseText);
                var txt = xmlhttp.responseText
                    .replace(/[\"]/g, '\\"')
                    .replace(/[\\]/g, '\\\\')
                    .replace(/[\/]/g, '\\/')
                    .replace(/[\b]/g, '\\b')
                    .replace(/[\f]/g, '\\f')
                    .replace(/[\n]/g, '\\n')
                    .replace(/[\r]/g, '\\r')
                    .replace(/[\t]/g, '\\t');

                var listGioAutocomplete = eval("(" + xmlhttp.responseText + ")");
                $("#ContentPlaceHolder1_txtNYC_TinhTP").autocomplete({

                    minLength: 0,
                    source: listGioAutocomplete,
                    focus: function (event, ui) {
                        $("#ContentPlaceHolder1_txtNYC_TinhTP").val(ui.item.label);
                        return false;
                    },
                    select: function (event, ui) {
                        $("#ContentPlaceHolder1_txtNYC_TinhTP").val(ui.item.value);
                        $("#ContentPlaceHolder1_idNYC_TinhTP").val(ui.item.id);
                        document.getElementById('ContentPlaceHolder1_txtNYC_QuanHuyen').disabled = false;
                        LoadQuanHuyen_NCT();
                        return false;
                    }
                }).focus(function () {
                    $(this).autocomplete("search", "");
                });
            }
            else {

                alert("Lỗi get Giờ!")
            }

        }
    }
    xmlhttp.open("GET", "Ajax_DKBaoHiem.aspx?Action=LoadTinh", true);
    xmlhttp.send();
}

function LoadQuanHuyen_NCT() {
    var NCT_TinhTP = $('#ContentPlaceHolder1_idNYC_TinhTP').val();
    if (NCT_TinhTP != "" && NCT_TinhTP != "0") {
        var xmlhttp;
        if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
            xmlhttp = new XMLHttpRequest();
        }
        else {// code for IE6, IE5
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                if (xmlhttp.responseText != "") {
                    //alert(xmlhttp.responseText);
                    var txt = xmlhttp.responseText
                        .replace(/[\"]/g, '\\"')
                        .replace(/[\\]/g, '\\\\')
                        .replace(/[\/]/g, '\\/')
                        .replace(/[\b]/g, '\\b')
                        .replace(/[\f]/g, '\\f')
                        .replace(/[\n]/g, '\\n')
                        .replace(/[\r]/g, '\\r')
                        .replace(/[\t]/g, '\\t');

                    var listGioAutocomplete = eval("(" + xmlhttp.responseText + ")");
                    $("#ContentPlaceHolder1_txtNYC_QuanHuyen").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNYC_QuanHuyen").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNYC_QuanHuyen").val(ui.item.value);
                            $("#ContentPlaceHolder1_idNYC_QuanHuyen").val(ui.item.id);
                            document.getElementById('ContentPlaceHolder1_txtNYC_PhuongXa').disabled = false;
                            LoadPhuongXa_NCT();
                            return false;
                        }
                    }).focus(function () {
                        $(this).autocomplete("search", "");
                    });
                }
                else {
                    alert("Lỗi không tìm thấy danh sách quận huyện!")
                }

            }
        }
        xmlhttp.open("GET", "Ajax_DKBaoHiem.aspx?Action=LoadQuanHuyen&Tinh=" + NCT_TinhTP + "", true);
        xmlhttp.send();
    }
}

function LoadPhuongXa_NCT() {
    var NCT_QuanHuyen = $('#ContentPlaceHolder1_idNYC_QuanHuyen').val();
    if (NCT_QuanHuyen != "" && NCT_QuanHuyen != "0") {
        var xmlhttp;
        if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
            xmlhttp = new XMLHttpRequest();
        }
        else {// code for IE6, IE5
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                if (xmlhttp.responseText != "") {
                    //alert(xmlhttp.responseText);
                    var txt = xmlhttp.responseText
                        .replace(/[\"]/g, '\\"')
                        .replace(/[\\]/g, '\\\\')
                        .replace(/[\/]/g, '\\/')
                        .replace(/[\b]/g, '\\b')
                        .replace(/[\f]/g, '\\f')
                        .replace(/[\n]/g, '\\n')
                        .replace(/[\r]/g, '\\r')
                        .replace(/[\t]/g, '\\t');

                    var listGioAutocomplete = eval("(" + xmlhttp.responseText + ")");
                    $("#ContentPlaceHolder1_txtNYC_PhuongXa").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNYC_PhuongXa").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNYC_PhuongXa").val(ui.item.value);
                            return false;
                        }
                    }).focus(function () {
                        $(this).autocomplete("search", "");
                    });
                }
                else {
                    alert("Lỗi không tìm thấy danh sách Phường xã!")
                }

            }
        }
        xmlhttp.open("GET", "Ajax_DKBaoHiem.aspx?Action=LoadPhuongXa&QuanHuyen=" + NCT_QuanHuyen + "", true);
        xmlhttp.send();
    }
}

function checkClick() {
    $('ContentPlaceHolder1_btLuu').click(function () {
        document.getElementById('ContentPlaceHolder1_btnPrint').style.display = "inline";
        document.getElementById('ContentPlaceHolder1_btLuu').style.display = "none";
    });
}

function load_btnPrint() {
    var Check = $('#ContentPlaceHolder1_IDBaoHiem').val();
    if (Check != "") {
        document.getElementById('ContentPlaceHolder1_btnPrint_PhuLuc').style.display = "inline";
    } else {
        document.getElementById('ContentPlaceHolder1_btnPrint_PhuLuc').style.display = "none";
    }
}

function PrinfBaoHiem() {
    var IDBaoHiem = $('#ContentPlaceHolder1_IDBaoHiem').val();
    var SoDon = $('#ContentPlaceHolder1_txtSoDon').val();
    var xmlhttp;
    if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
        xmlhttp = new XMLHttpRequest();
    }
    else {// code for IE6, IE5
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            if (xmlhttp.responseText != "") {
                var print = window.open('', '_blank');
                var shtml = "<html>";
                shtml += "<head>";
                shtml += "<link rel='stylesheet' type='text/css' media='print' href ='../Content/css/dk_khaitu.css'>";
                shtml += "</head>";
                shtml += "<body onload=\"window.print(); window.close();\">";
                shtml += xmlhttp.responseText;
                shtml += "</body>";
                shtml += "</html>";
                print.document.write(shtml);
                print.document.close();
            }
        }
    }
    xmlhttp.open("GET", "../Ajax.aspx?Action=PrinfBaoHiem&IDBaoHiem=" + IDBaoHiem + "&SoDon=" + SoDon + "", true);
    xmlhttp.send();
}

function PrinfPhuLuc()
{
    var IDBaoHiem1 = $('#ContentPlaceHolder1_IDBaoHiem').val();
    var xmlhttp;
    if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
        xmlhttp = new XMLHttpRequest();
    }
    else {// code for IE6, IE5
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            if (xmlhttp.responseText != "") {
                var print = window.open('', '_blank');
                var shtml = "<html>";
                shtml += "<head>";
                shtml += "<link rel='stylesheet' type='text/css' media='print' href ='../Content/css/dk_khaitu.css'>";
                shtml += "</head>";
                shtml += "<body onload=\"window.print(); window.close();\">";
                shtml += xmlhttp.responseText;
                shtml += "</body>";
                shtml += "</html>";
                print.document.write(shtml);
                print.document.close();
            }
        }
    }
    xmlhttp.open("GET", "../Ajax.aspx?Action=PrinfPhuLuc&IDBaoHiem="+IDBaoHiem1, true);
    xmlhttp.send();
}