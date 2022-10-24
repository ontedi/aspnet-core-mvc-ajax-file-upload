using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace aspnet_core_mvc_ajax_file_upload.Controllers
{
    public class ajaxController : Controller
    {
        private readonly IWebHostEnvironment _iwheWebHostEnvironment;

        public ajaxController(IWebHostEnvironment iwheWebHostEnvironment)
        {
            _iwheWebHostEnvironment = iwheWebHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public string fnSayi_Uret()
        {
            string strSonuc = string.Empty;
            int intSalise = DateTime.Now.Millisecond;
            string strSalise = intSalise.ToString();
            int intSaniye = DateTime.Now.Second;
            string strSaniye = intSaniye.ToString();
            int intDakika = DateTime.Now.Minute;
            string strDakika = intDakika.ToString();
            int intSaat = DateTime.Now.Hour;
            string strSaat = intSaat.ToString();
            int intGun = DateTime.Now.Day;
            string strGun = intGun.ToString();
            int intAy = DateTime.Now.Month;
            string strAy = intAy.ToString();
            int intYil = DateTime.Now.Year;
            string strYil = intYil.ToString();
            strSonuc = strYil + strAy + strGun + strSaat + strDakika + strSaniye;
            return strSonuc;
        }
        [Route("ajax/dosya-yukle")]
        [HttpPost]
        public string dosya_yukle(string strDosya_Adi_Ek, IFormFile fuDosya)
        {
            string strKlasor = "wwwroot/dosyalar/";
            string strKlasor_Relative = "/wwwroot/dosyalar/";
            string strSonuc = string.Empty;
            bool blnDosya_Yukle = false;
            bool blnResim = false;
            string strDosya_Tipi = fuDosya.ContentType;
            if (strDosya_Tipi == "application/vnd.ms-word")
                blnDosya_Yukle = true;
            else if (strDosya_Tipi == "application/pdf")
                blnDosya_Yukle = true;
            else if (strDosya_Tipi == "application/octet-stream")
                blnDosya_Yukle = true;
            else if (strDosya_Tipi == "application/vnd.ms-excel")
                blnDosya_Yukle = true;
            else if (strDosya_Tipi == "application/vnd.openxmlformats-officedocument.presentationml.presentation")
                blnDosya_Yukle = true;
            else if (strDosya_Tipi == "image/jpg")
            {
                blnDosya_Yukle = true;
                blnResim = true;
            }
            else if (strDosya_Tipi == "image/jpeg")
            {
                blnDosya_Yukle = true;
                blnResim = true;
            }
            else if (strDosya_Tipi == "image/png")
            {
                blnDosya_Yukle = true;
                blnResim = true;
            }
            else if (strDosya_Tipi == "image/gif")
            {
                blnDosya_Yukle = true;
                blnResim = true;
            }
            else if (strDosya_Tipi == "video/mp4")
            {
                blnDosya_Yukle = true;
                blnResim = false;
            }

            if (blnDosya_Yukle)
            {
                string strContentRootPath = _iwheWebHostEnvironment.ContentRootPath;

                string strDosya_Patika = Path.Combine(strContentRootPath, strKlasor);
                if (!Directory.Exists(strDosya_Patika))
                {
                    Directory.CreateDirectory(strDosya_Patika);
                }

                string strDosya_Adi = Path.GetFileNameWithoutExtension(fuDosya.FileName);
                string strDosya_Uzantisi = Path.GetExtension(fuDosya.FileName);
                string strSayi = fnSayi_Uret();
                strDosya_Adi = strDosya_Adi + "-" + strDosya_Adi_Ek + "-" + strSayi + strDosya_Uzantisi;

                using (FileStream fsDosya_Akis = new FileStream(Path.Combine(strDosya_Patika, strDosya_Adi), FileMode.Create))
                {
                    fuDosya.CopyTo(fsDosya_Akis);
                }

                string strHTML = string.Empty;

                string strDosya_Adresi_Relative = strKlasor_Relative + strDosya_Adi;

                strHTML += "<div class='dosya-kapsul'>";
                if (blnResim)
                    strHTML += "<img class='resim' src='" + strDosya_Adresi_Relative + "' alt='" + strDosya_Adi + "' />";
                else
                    strHTML += "<a href='" + strDosya_Adresi_Relative + "' target='_blank'>" + strDosya_Adi + "</a>";
                strHTML += "</div>";

                strSonuc = strHTML;
            }

            return strSonuc;
        }
    }
}
