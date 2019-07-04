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
    xmlhttp.open("GET", "Ajax_DKKT.aspx?Action=Load_NoiCap", true);
    xmlhttp.send();
}
function Load_NC_NoiCap() {
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
                $("#ContentPlaceHolder1_txtNC_NoiCap").autocomplete({

                    minLength: 0,
                    source: listGioAutocomplete,
                    focus: function (event, ui) {
                        $("#ContentPlaceHolder1_txtNC_NoiCap").val(ui.item.label);
                        return false;
                    },
                    select: function (event, ui) {
                        $("#ContentPlaceHolder1_txtNC_NoiCap").val(ui.item.value);
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
    xmlhttp.open("GET", "Ajax_DKKT.aspx?Action=Load_NoiCap", true);
    xmlhttp.send();
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
        xmlhttp.open("GET", "Ajax_DKKT.aspx?Action=LoadTinh&QuocGia=" + NYC_QG + "", true);
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
        xmlhttp.open("GET", "Ajax_DKKT.aspx?Action=LoadQuanHuyen&Tinh=" + NYC_TinhTP + "", true);
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
        xmlhttp.open("GET", "Ajax_DKKT.aspx?Action=LoadPhuongXa&QuanHuyen=" + NYC_QuanHuyen + "", true);
        xmlhttp.send();
    }
}
///////////////////////////////////
function LoadTinh_NC() {
    var NC_QG = $('#ContentPlaceHolder1_txtNC_QuocGia').val();
    if (NC_QG != "" && NC_QG == "Việt Nam") {
        document.getElementById('ContentPlaceHolder1_txtNC_TinhTP').disabled = false;
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
                    $("#ContentPlaceHolder1_txtNC_TinhTP").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNC_TinhTP").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNC_TinhTP").val(ui.item.value);
                            $("#ContentPlaceHolder1_idNC_TinhTP").val(ui.item.id);
                            document.getElementById('ContentPlaceHolder1_txtNC_QuanHuyen').disabled = false;
                            //$("#ContentPlaceHolder1_txtTTT_TinhTP_QQ").val(ui.item.label);
                            LoadQuanHuyen_NC();
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
        xmlhttp.open("GET", "Ajax_DKKT.aspx?Action=LoadTinh&QuocGia=" + NC_QG + "", true);
        xmlhttp.send();
    }
}
function LoadQuanHuyen_NC() {
    var NC_TinhTP = $('#ContentPlaceHolder1_idNC_TinhTP').val();
    if (NC_TinhTP != "" && NC_TinhTP != "0") {
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
                    $("#ContentPlaceHolder1_txtNC_QuanHuyen").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNC_QuanHuyen").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNC_QuanHuyen").val(ui.item.value);
                            $("#ContentPlaceHolder1_idNC_QuanHuyen").val(ui.item.id);
                            document.getElementById('ContentPlaceHolder1_txtNC_PhuongXa').disabled = false;
                            LoadPhuongXa_NC();
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
        xmlhttp.open("GET", "Ajax_DKKT.aspx?Action=LoadQuanHuyen&Tinh=" + NC_TinhTP + "", true);
        xmlhttp.send();
    }
}
function LoadPhuongXa_NC() {
    var NC_QuanHuyen = $('#ContentPlaceHolder1_idNC_QuanHuyen').val();
    if (NC_QuanHuyen != "" && NC_QuanHuyen != "0") {
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
                    $("#ContentPlaceHolder1_txtNC_PhuongXa").autocomplete({

                        minLength: 0,
                        source: listGioAutocomplete,
                        focus: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNC_PhuongXa").val(ui.item.label);
                            return false;
                        },
                        select: function (event, ui) {
                            $("#ContentPlaceHolder1_txtNC_PhuongXa").val(ui.item.value);

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
        xmlhttp.open("GET", "Ajax_DKKT.aspx?Action=LoadPhuongXa&QuanHuyen=" + NC_QuanHuyen + "", true);
        xmlhttp.send();
    }
}
function PrinfKhaiTu() {
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
    xmlhttp.open("GET", "../Ajax.aspx?Action=PrinfKhaiTu", true);
    xmlhttp.send();
}
function pikaday() {
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
            field: document.getElementById('ContentPlaceHolder1_txtNC_NgaySinh'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtNC_NgayCap'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtNC_NgayChet'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
    var picker = new Pikaday(
        {
            field: document.getElementById('ContentPlaceHolder1_txtNC_NgayCapGBT'),
            firstDay: 1,
            format: "DD/MM/YYYY",
            minDate: new Date(1900, 1, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [1900, 2020]
        });
    var timepicker = new TimePicker('ContentPlaceHolder1_txtNC_GioChet', {
        lang: 'en',
        theme: 'dark'
    });
    timepicker.on('change', function (evt) {

        var value = (evt.hour || '00') + ':' + (evt.minute || '00');
        evt.element.value = value;

    });
}




