var objInputDosya = document.getElementsByClassName('js-input-dosya')[0];
objInputDosya.addEventListener("change", function () {

    let strDosya = objInputDosya.files[0];
    let strDosya_Adi = document.getElementsByClassName("js-input-dosya-adi")[0].value;
    let objDosya_Yukle_Hedef = document.getElementsByClassName("js-dosya-yukle-hedef")[0];

    objDosya_Yukle_Hedef.innerHTML = "Yükleniyor..";

    let fdVeriler = new FormData();
    fdVeriler.append("strDosya_Adi", strDosya_Adi);
    fdVeriler.append("fuDosya", strDosya);

    const optAyarlar = {
        method: "POST",
        mode: "no-cors",
        body: fdVeriler,
        contentType: false,
        processData: false
    }

    fetch('/ajax/dosya-yukle', optAyarlar)
    .then(function(response) {
        return response.text()
    })
    .then((sonuc) => {
        objDosya_Yukle_Hedef.innerHTML = sonuc;
    }).catch(hata => 
    { 
        alert("Bir hata oluştu! Hata detayları: " + hata);
    });
});