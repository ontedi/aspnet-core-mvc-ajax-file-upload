var objDosyaYukleFormInputFile = document.getElementById('js-form-dosya-yukle');
objDosyaYukleFormInputFile.addEventListener("change", function () {
    let strDosya_Adi = document.getElementsByClassName("js-input-dosya-adi")[0].value;
    let strDosya = document.getElementsByClassName("js-input-dosya")[0].files[0];
    let objDosya_Yukle_Hedef = document.getElementsByClassName("js-dosya-yukle-hedef")[0];
    let fdVeriler = new FormData();
    fdVeriler.append("strDosya_Adi", strDosya_Adi);
    fdVeriler.append("fuDosya", strDosya);
    const options = {
        method: "POST",
        mode: "no-cors",
        body: fdVeriler,
        contentType: false,
        processData: false
    }
    fetch('/ajax/dosya-yukle', options)
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