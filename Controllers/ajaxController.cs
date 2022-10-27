using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text.RegularExpressions;

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
            string strSonuc = DateTime.Now.ToString("yyyyMMdd hh:mm:ss").Replace(" ", "-").Replace(":", string.Empty);
            return strSonuc;
        }
        [Route("ajax/dosya-yukle")]
        [HttpPost]
        public string dosya_yukle(string strDosya_Adi, IFormFile fuDosya)
        {
            string strKlasor = "wwwroot/dosyalar/";
            string strKlasor_Relative = "/wwwroot/dosyalar/";
            string strSonuc = string.Empty;
            bool blnDosya_Yukle = false;
            bool blnResim = false;
            string strDosya_Tipi = fuDosya.ContentType;

            switch(strDosya_Tipi) 
            {
            case "application/vnd.ms-word":
                blnDosya_Yukle = true;
                break;
            case "application/pdf":
                blnDosya_Yukle = true;
                break;
            case "application/octet-stream":
                blnDosya_Yukle = true;
                break;
            case "application/vnd.ms-excel":
                blnDosya_Yukle = true;
                break;
            case "application/vnd.openxmlformats-officedocument.presentationml.presentation":
                blnDosya_Yukle = true;
                break;
            case "image/jpg":
                blnDosya_Yukle = true;
                blnResim = true;
                break;
            case "image/jpeg":
                blnDosya_Yukle = true;
                blnResim = true;
                break;
            case "image/png":
                blnDosya_Yukle = true;
                blnResim = true;
                break;
            case "image/gif":
                blnDosya_Yukle = true;
                blnResim = true;
                break;
            case "video/mp4":
                blnDosya_Yukle = true;
                break;
            default:
                break;
            }

            if (blnDosya_Yukle)
            {
                string strContentRootPath = _iwheWebHostEnvironment.ContentRootPath;

                string strDosya_Patika = Path.Combine(strContentRootPath, strKlasor);
                if (!Directory.Exists(strDosya_Patika))
                {
                    Directory.CreateDirectory(strDosya_Patika);
                }

                if (string.IsNullOrEmpty(strDosya_Adi))
                {
                    strDosya_Adi = Path.GetFileNameWithoutExtension(fuDosya.FileName);
                }

                string strDosya_Uzantisi = Path.GetExtension(fuDosya.FileName);
                string strSayi = fnSayi_Uret();
                strDosya_Adi = strDosya_Adi + "-" + strSayi + strDosya_Uzantisi;

                using (FileStream fsDosya_Akis = new FileStream(Path.Combine(strDosya_Patika, strDosya_Adi), FileMode.Create))
                {
                    fuDosya.CopyTo(fsDosya_Akis);
                }

                string strDosya_Adresi_Relative = strKlasor_Relative + strDosya_Adi;

                strSonuc = $"<div class='dosya-kapsul'>";
                if (blnResim)
                {
                    strSonuc += $"<span class='dosya-adi'>{strDosya_Adi}</span><img class='resim' src='{strDosya_Adresi_Relative}' alt='{strDosya_Adi}' />";
                }  
                else
                {
                    strSonuc += $"<a href='{strDosya_Adresi_Relative}' target='_blank'>{strDosya_Adi}</a>";
                }
                    
                strSonuc += $"</div>";
            }

            return strSonuc;
        }
    }
}
