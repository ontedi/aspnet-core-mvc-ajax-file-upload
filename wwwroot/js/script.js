var strAjax_Dosya_Yukle_Url = "/ajax/dosya-yukle";

/* Ajax Dosya Yükleme İşlemi Tetikleyici (BAŞLANGIÇ) */
fnAjax_Dosya_Yukle_Tetikleyici();
function fnAjax_Dosya_Yukle_Tetikleyici() {
    jQuery("body").on("change", ".jq-dosya-yukle-form-input-file", function () {

        jQuery(".jq-dosya-yukle-form-hedef-div").html("Yükleniyor..");

        var strDosya_Adi = jQuery(".jq-dosya-yukle-form-input-dosya-adi").val();
        var strDosya = jQuery(".jq-dosya-yukle-form-input-file")[0].files[0];

        var fdVeriler = new FormData();
        fdVeriler.append("strDosya_Adi", strDosya_Adi);
        fdVeriler.append("fuDosya", strDosya);

        jQuery.ajax
            ({
                type: 'POST',
                url: "/ajax/dosya-yukle",
                cache: false,
                data: fdVeriler,
                contentType: false,
                processData: false,
                success: function (strSonuc) {
                    jQuery(".jq-dosya-yukle-form-hedef-div").html(strSonuc);
                },
                error: function (ajaxIstek, strDurum) {
                    var strHata_Mesaji = "";
                    if (ajaxIstek.status === 0) {
                        strHata_Mesaji = "Bağlantı yok. Lütfen internet bağlantınızı kontrol ediniz.";
                    } else if (ajaxIstek.status == 404) {
                        strHata_Mesaji = "Sayfa bulunamadı [404].";
                    } else if (ajaxIstek.status == 500) {
                        strHata_Mesaji = "İç Sunucu Hatası [500].";
                    } else if (strDurum === 'parsererror') {
                        strHata_Mesaji = "JSON isteği ayrıştırılamadı.";
                    } else if (strDurum === 'timeout') {
                        strHata_Mesaji = "Zaman aşımı hatası.";
                    } else if (strDurum === 'abort') {
                        strHata_Mesaji = "Ajax isteği iptal edildi.";
                    } else {
                        strHata_Mesaji = "Bilinmeyen hata. Hata detayı: " + ajaxIstek.responseText;
                    }
                    alert("Hata: " + strHata_Mesaji);
                }
            });
    });
}
/* Ajax Dosya Yükleme İşlemi Tetikleyici (BİTİŞ) */