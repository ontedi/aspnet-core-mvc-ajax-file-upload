#pragma checksum "D:\calisma-masasi\projeler-dotnetcore\aspnet-core-mvc-ajax-file-upload\Views\Anasayfa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c136fb98e7b36fdf054401307bf3097aa227f18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_Index), @"mvc.1.0.view", @"/Views/Anasayfa/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c136fb98e7b36fdf054401307bf3097aa227f18", @"/Views/Anasayfa/Index.cshtml")]
    #nullable restore
    public class Views_Anasayfa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c136fb98e7b36fdf054401307bf3097aa227f182827", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>");
#nullable restore
#line 5 "D:\calisma-masasi\projeler-dotnetcore\aspnet-core-mvc-ajax-file-upload\Views\Anasayfa\Index.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""publisher"" content=""Mikro İnteraktif - Serkan TOGAL"" />
    <link rel=""publisher"" href=""https://www.ontedi.com"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"" />
    <link rel=""stylesheet""");
                BeginWriteAttribute("href", " href=\'", 448, "\'", 494, 1);
#nullable restore
#line 10 "D:\calisma-masasi\projeler-dotnetcore\aspnet-core-mvc-ajax-file-upload\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 455, Url.Content("/wwwroot/css/jquery.css"), 455, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\'", 526, "\'", 571, 1);
#nullable restore
#line 11 "D:\calisma-masasi\projeler-dotnetcore\aspnet-core-mvc-ajax-file-upload\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 533, Url.Content("/wwwroot/css/style.css"), 533, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c136fb98e7b36fdf054401307bf3097aa227f185298", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""form-horizontal m-t20"">
            <div class=""form-group"">
                <label class=""col-sm-2 control-label"">Dosya</label>
                <div class=""col-sm-10"">
                    <div class=""media-body"">
                        <form method=""post"" enctype=""multipart/form-data"" class=""jq-dosya-yukle-form"" name=""jq-dosya-yukle-form"">
                            <input type=""file"" name=""fuDosya"" title=""Dosya Ekle"" class=""fileinput btn-primary jq-dosya-yukle-form-input-file"" />
                            <input type=""text"" name=""dosya_adi"" class=""jq-dosya-yukle-form-input-dosya-adi"" placeholder=""Dosya Adı"" />
                        </form>
                    </div>
                </div>
            </div>
            <div class=""form-group m-t20"">
                <label class=""col-sm-2 control-label"">Yüklenen Dosya</label>
                <div class=""col-sm-10"">
                    <div class=""jq-dosya-yukle-form-hedef-div""></div>
  ");
                WriteLiteral("              </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <script type=\"text/javascript\"");
                BeginWriteAttribute("src", " src=\'", 1720, "\'", 1763, 1);
#nullable restore
#line 35 "D:\calisma-masasi\projeler-dotnetcore\aspnet-core-mvc-ajax-file-upload\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 1726, Url.Content("/wwwroot/js/jquery.js"), 1726, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script type=\"text/javascript\"");
                BeginWriteAttribute("src", " src=\'", 1810, "\'", 1853, 1);
#nullable restore
#line 36 "D:\calisma-masasi\projeler-dotnetcore\aspnet-core-mvc-ajax-file-upload\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 1816, Url.Content("/wwwroot/js/script.js"), 1816, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
