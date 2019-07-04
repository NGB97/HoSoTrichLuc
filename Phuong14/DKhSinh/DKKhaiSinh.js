function Load_NYC_NoiCap() {
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
                $("#ContentPlaceHolder1_txtNYC_NoiCap").autocomplete({

                    minLength: 0,
                    source: listGioAutocomplete,
                    focus: function (event, ui) {
                        $("#ContentPlaceHolder1_txtNYC_NoiCap").val(ui.item.label);
                        return false;
                    },
                    select: function (event, ui) {
                        $("#ContentPlaceHolder1_txtNYC_NoiCap").val(ui.item.value);
                        return false;
                    }
                }).focus(function () {
                    $(this).autocomplete("search", "");
                });
            }
            else {
                alert("Lỗi không có danh sách Tỉnh!")
            }

        }
    }
    xmlhttp.open("GET", "Ajax_DKKS.aspx?Action=Load_NoiCap", true);
    xmlhttp.send();
}
function Load_TTM_NoiCap() {
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
                $("#ContentPlaceHolder1_txtTTM_NoiCap").autocomplete({

                    minLength: 0,
                    source: listGioAutocomplete,
                    focus: function (event, ui) {
                        $("#ContentPlaceHolder1_txtTTM_NoiCap").val(ui.item.label);
                        return false;
                    },
                    select: function (event, ui) {
                        $("#ContentPlaceHolder1_txtTTM_NoiCap").val(ui.item.value);
                        return false;
                    }
                }).focus(function () {
                    $(this).autocomplete("search", "");
                });
            }
            else {
                alert("Lỗi không có danh sách Tỉnh!")
            }

        }
    }
    xmlhttp.open("GET", "Ajax_DKKS.aspx?Action=Load_NoiCap", true);
    xmlhttp.send();
}
function KTCheck() {
    document.getElementById('ContentPlaceHolder1_TTT_NN_QQ').onclick = function (e) {
        if (this.checked) {
            alert("Nhập Quốc gia quê quán");
            document.getElementById('ContentPlaceHolder1_txtTTT_QuocGia_QQ').value = '';
            document.getElementById('ContentPlaceHolder1_txtTTT_TinhTP_QQ').disabled = true;
            document.getElementById('ContentPlaceHolder1_txtTTT_QuanHuyen_QQ').disabled = true;
            document.getElementById('ContentPlaceHolder1_txtTTT_PhuongXa_QQ').disabled = true;
        }
        else {
            alert("Bạn vừa hủy chọn sinh sống ở nước ngoài");
        }
    };
}
function KTcheckNCT() {
    document.getElementById('ContentPlaceHolder1_TTT_NCT').onclick = function (e) {
        if (this.checked) {
            alert("Nhập Quốc gia Nơi cư trú");
            document.getElementById('ContentPlaceHolder1_TTT_NN_QQ').style.display = "none";
            document.getElementById('lb_TTT_NN_QQ').style.display = "none";
            document.getElementById('ContentPlaceHolder1_txtTTT_QuocGia').value = '';
            document.getElementById('ContentPlaceHolder1_txtTTT_TinhTP').disabled = true;
            document.getElementById('ContentPlaceHolder1_txtTTT_QuanHuyen').disabled = true;
            document.getElementById('ContentPlaceHolder1_txtTTT_PhuongXa').disabled = true;
        }
        else {
            document.getElementById('ContentPlaceHolder1_TTT_NN_QQ').style.display = "inline";
            document.getElementById('lb_TTT_NN_QQ').style.display = "inline";
            document.getElementById('ContentPlaceHolder1_txtTTT_TinhTP').disabled = false;
        }
    };

}
function LoadTinh_NYC() {
    var NYC_QG = $('#ContentPlaceHolder1_txtNYC_QuocGia').val();
    if (NYC_QG != "" && NYC_QG == "Việt Nam") {
        document.getElementById('ContentPlaceHolder1_txtNYC_TinhTP').disabled = false;
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
                            //$("#ContentPlaceHolder1_txtTTT_TinhTP_QQ").val(ui.item.label);
                            LoadQuanHuyen_NYC();
                            //alert(ui.item.id);
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
        xmlhttp.open("GET", "Ajax_DKKS.aspx?Action=LoadTinh&QuocGia=" + NYC_QG + "", true);
        xmlhttp.send();
    }
}
function LoadQuanHuyen_NYC() {
    var NYC_TinhTP = $('#ContentPlaceHolder1_idNYC_TinhTP').val();
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
                            LoadPhuongXa_NYC();
                            //$("#ContentPlaceHolder1_txtTTT_TinhTP_QQ").val(ui.item.label);
                            //alert(ui.item.id);
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
        xmlhttp.open("GET", "Ajax_DKKS.aspx?Action=LoadQuanHuyen&Tinh=" + NYC_TinhTP + "", true);
        xmlhttp.send();
    }
}
function LoadPhuongXa_NYC() {
    var NYC_QuanHuyen = $('#ContentPlaceHolder1_idNYC_QuanHuyen').val();
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
        xmlhttp.open("GET", "Ajax_DKKS.aspx?Action=LoadPhuongXa&QuanHuyen=" + NYC_QuanHuyen + "", true);
        xmlhttp.send();
    }
}
function LoadTinh_TTT_QQ() {
    var TTT_QG_QQ = $('#ContentPlaceHolder1_txtTTT_QuocGia_QQ').val();
    if (TTT_QG_QQ != "" && TTT_QG_QQ == "Việt Nam") {
        document.getElementById('ContentPlaceHolder1_txtTTT_TinhTP_QQ').disabled = false;
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
                    $("#ContentPlaceHolder1_txtTTT_TinhTP_QQ").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtTTT_TinhTP_QQ").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtTTT_TinhTP_QQ").val(ui.item.value);
                            $("#ContentPlaceHolder1_idTTT_TinhTP_QQ").val(ui.item.id);
                            document.getElementById('ContentPlaceHolder1_txtTTT_QuanHuyen_QQ').disabled = false;
                            //$("#ContentPlaceHolder1_txtTTT_TinhTP_QQ").val(ui.item.label);
                            LoadQuanHuyen_TTT_QQ();
                            //alert(ui.item.id);
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
        xmlhttp.open("GET", "Ajax_DKKS.aspx?Action=LoadTinh&QuocGia=" + TTT_QG_QQ + "", true);
        xmlhttp.send();
    }
}
function LoadQuanHuyen_TTT_QQ() {
    var TTT_TinhTP_QQ = $('#ContentPlaceHolder1_idTTT_TinhTP_QQ').val();
    if (TTT_TinhTP_QQ != "" && TTT_TinhTP_QQ != "0") {
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
                    $("#ContentPlaceHolder1_txtTTT_QuanHuyen_QQ").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtTTT_QuanHuyen_QQ").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtTTT_QuanHuyen_QQ").val(ui.item.value);
                            $("#ContentPlaceHolder1_idTTT_QuanHuyen_QQ").val(ui.item.id);
                            document.getElementById('ContentPlaceHolder1_txtTTT_PhuongXa_QQ').disabled = false;
                            LoadPhuongXa_TTT_QQ();
                            //$("#ContentPlaceHolder1_txtTTT_TinhTP_QQ").val(ui.item.label);
                            //alert(ui.item.id);
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
        xmlhttp.open("GET", "Ajax_DKKS.aspx?Action=LoadQuanHuyen&Tinh=" + TTT_TinhTP_QQ + "", true);
        xmlhttp.send();
    }
}
function LoadPhuongXa_TTT_QQ() {
    var TTT_QuanHuyen_QQ = $('#ContentPlaceHolder1_idTTT_QuanHuyen_QQ').val();
    if (TTT_QuanHuyen_QQ != "" && TTT_QuanHuyen_QQ != "0") {
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
                    $("#ContentPlaceHolder1_txtTTT_PhuongXa_QQ").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtTTT_PhuongXa_QQ").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtTTT_PhuongXa_QQ").val(ui.item.value);
                            //$("#ContentPlaceHolder1_txtTTT_PhuongXa_QQ").val(ui.item.id);
                            //$("#ContentPlaceHolder1_txtTTT_TinhTP_QQ").val(ui.item.label);
                            //alert(ui.item.id);
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
        xmlhttp.open("GET", "Ajax_DKKS.aspx?Action=LoadPhuongXa&QuanHuyen=" + TTT_QuanHuyen_QQ + "", true);
        xmlhttp.send();
    }
}
function LoadTinh_TTT() {
    var TTT_QG = $('#ContentPlaceHolder1_txtTTT_QuocGia').val();
    if (TTT_QG != "" && TTT_QG == "Việt Nam") {
        document.getElementById('ContentPlaceHolder1_txtTTT_TinhTP').disabled = false;
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
                    $("#ContentPlaceHolder1_txtTTT_TinhTP").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtTTT_TinhTP").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtTTT_TinhTP").val(ui.item.value);
                            $("#ContentPlaceHolder1_idTTT_TinhTP").val(ui.item.id);
                            document.getElementById('ContentPlaceHolder1_txtTTT_QuanHuyen').disabled = false;
                            //$("#ContentPlaceHolder1_txtTTT_TinhTP_QQ").val(ui.item.label);
                            LoadQuanHuyen_TTT();
                            //alert(ui.item.id);
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
        xmlhttp.open("GET", "Ajax_DKKS.aspx?Action=LoadTinh&QuocGia=" + TTT_QG + "", true);
        xmlhttp.send();
    }
}
function LoadQuanHuyen_TTT() {
    var TTT_TinhTP = $('#ContentPlaceHolder1_idTTT_TinhTP').val();
    if (TTT_TinhTP != "" && TTT_TinhTP != "0") {
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
                    $("#ContentPlaceHolder1_txtTTT_QuanHuyen").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtTTT_QuanHuyen").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtTTT_QuanHuyen").val(ui.item.value);
                            $("#ContentPlaceHolder1_idTTT_QuanHuyen").val(ui.item.id);
                            document.getElementById('ContentPlaceHolder1_txtTTT_PhuongXa').disabled = false;
                            LoadPhuongXa_TTT();
                            //$("#ContentPlaceHolder1_txtTTT_TinhTP_QQ").val(ui.item.label);
                            //alert(ui.item.id);
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
        xmlhttp.open("GET", "Ajax_DKKS.aspx?Action=LoadQuanHuyen&Tinh=" + TTT_TinhTP + "", true);
        xmlhttp.send();
    }
}
function LoadPhuongXa_TTT() {
    var TTT_QuanHuyen = $('#ContentPlaceHolder1_idTTT_QuanHuyen').val();
    if (TTT_QuanHuyen != "" && TTT_QuanHuyen != "0") {
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
                    $("#ContentPlaceHolder1_txtTTT_PhuongXa").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtTTT_PhuongXa").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtTTT_PhuongXa").val(ui.item.value);
                            //$("#ContentPlaceHolder1_txtTTT_PhuongXa_QQ").val(ui.item.id);
                            //$("#ContentPlaceHolder1_txtTTT_TinhTP_QQ").val(ui.item.label);
                            //alert(ui.item.id);
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
        xmlhttp.open("GET", "Ajax_DKKS.aspx?Action=LoadPhuongXa&QuanHuyen=" + TTT_QuanHuyen + "", true);
        xmlhttp.send();
    }
}
function pikaday() {
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtNYC_NamSinh'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtNYC_NgayCap'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtTTT_NgaySinh'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtTTM_NamSinh'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtTTM_NgayCap'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtTTC_NamSinh'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtTTC_NgayCap'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtCH_NamSinh'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
}
function PrinfKhaiSinh1() {
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
                shtml += "<link rel='stylesheet' type='text/css' media='print' href ='../Content/css/dk_khaisinh.css'>";
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
    xmlhttp.open("GET", "../Ajax.aspx?Action=PrinfKhaiSinh", true);
    xmlhttp.send();
}
