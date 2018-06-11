// کد تبدیل به فرمت  ر یال :
function convert_to_rial(pr1) {

    var pr2 = "";
    var pr = pr1.toString();
    for (var i = 0; i < pr.length; i++) {

        if ((i == 1 && pr.length == 4)) pr2 += ",";
        if ((i == 2 && pr.length == 5)) pr2 += ",";
        if ((i == 3 && pr.length == 6)) pr2 += ",";

        if ((i == 1 && pr.length == 7) || (i == 4 && pr.length == 7)) pr2 += ",";
        if ((i == 2 && pr.length == 8) || (i == 5 && pr.length == 8)) pr2 += ",";
        if ((i == 3 && pr.length == 9) || (i == 6 && pr.length == 9)) pr2 += ",";

        if ((i == 1 && pr.length == 10) || (i == 4 && pr.length == 10) || (i == 7 && pr.length == 10)) pr2 += ",";
        if ((i == 2 && pr.length == 11) || (i == 5 && pr.length == 11) || (i == 8 && pr.length == 11)) pr2 += ",";
        if ((i == 3 && pr.length == 12) || (i == 6 && pr.length == 12) || (i == 9 && pr.length == 12)) pr2 += ",";

        pr2 += pr[i];
    }

    return pr2;
}


// بررسی کد ملی :
function checkCodeMeli(code) {

    var L = code.length;

    if (L < 8 || parseInt(code, 10) == 0) return false;
    code = ('0000' + code).substr(L + 4 - 10);
    if (parseInt(code.substr(3, 6), 10) == 0) return false;
    var c = parseInt(code.substr(9, 1), 10);
    var s = 0;
    for (var i = 0; i < 9; i++)
        s += parseInt(code.substr(i, 1), 10) * (10 - i);
    s = s % 11;
    return (s < 2 && c == s) || (s >= 2 && c == (11 - s));
    return true;
}

//تبدیل اعداد فارسی به اینگلیسی
function convert_to_en_number(a) {

    //١٢٣٤٥٦٧٨٩٠
    var rep_arry_fa = ["١", "٢", "٣", "٤", "٥", "٦", "٧", "٨", "٩", "٠"];
    var rep_arry_en = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "0"];
    for (var i = 0; i < rep_arry_fa.length; i++) {

        if (a.split(rep_arry_fa[i]).length > 1) {
            while (a.split(rep_arry_fa[i]).length > 1) {
                a = a.replace(rep_arry_fa[i], rep_arry_en[i]);
            }
        }
    }
    return a;
}