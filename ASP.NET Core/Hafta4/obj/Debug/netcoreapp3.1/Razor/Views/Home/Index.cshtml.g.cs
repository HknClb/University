#pragma checksum "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d059b119fe6a31709a1cacf25d9760a70f490cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d059b119fe6a31709a1cacf25d9760a70f490cb", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Hafta4.Entities.News>>
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
            WriteLiteral("<!--\r\n    C# içerisinde HTML olarak yazmak için \"et\": şeklinde kullanılır.\r\n\r\n-->\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d059b119fe6a31709a1cacf25d9760a70f490cb2909", async() => {
                WriteLiteral("\r\n    <title></title>\r\n    <meta http-equiv=\"content-type\" content=\"text/html;charset=UTF-8\" />\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d059b119fe6a31709a1cacf25d9760a70f490cb3978", async() => {
                WriteLiteral(@"

    <!--#region CSS Codes-->
    <style>
        .oddNumber {
            border: groove;
            border-width: 3px;
            border-color: black;
            font-size: 12pt;
            font-family: 'Times New Roman';
            color: blue;
        }

        .evenNumber {
            border: groove;
            border-width: 3px;
            border-color: black;
            font-size: 12pt;
            font-family: 'Times New Roman';
            color: red;
        }

        .newsHeader{
            border: double;
            border-width: 6px;
            border-color: red;
            background-color: white;
            font-size: 14pt;
            font-family:'Times New Roman';
            color: black;
            text-align: center;
        }

        .newsContent {
            border: groove;
            border-width: 4px;
            border-color: gray;
            background-color: navajowhite;
            font-size: 12pt;
            font-family");
                WriteLiteral(": \'Times New Roman\';\r\n            color: darkred;\r\n            text-align: center;\r\n        }\r\n    </style>\r\n    <!--#endregion-->\r\n    <!--#region Generating a Random Numbers Code-->\r\n");
#nullable restore
#line 58 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
      
        var generated = new List<int>();
        var selectedClassName = string.Empty;
        bool isGenerated;
        Random rnd = new Random();
        int random;
        int counter = 0;
        for (int i = 0; i < 100; i++)
        {
            isGenerated = false;
            random = rnd.Next(0, 10000);
            foreach (var item in generated)
            {
                if (item == random)
                {
                    isGenerated = true;
                    break;
                }
            }
            if (!isGenerated)
                generated.Add(random);
            else
                i--;
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <!--#endregion-->\r\n    <!--#region Set Generated Numbers Class Name-->\r\n    <table>\r\n");
#nullable restore
#line 86 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
         while (counter < generated.Count)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n");
#nullable restore
#line 89 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
                 for (int i = 0; i < generated.Count * 0.10; i++)
                {
                    selectedClassName = generated[counter] % 2 == 0 ? "evenNumber" : "oddNumber";

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td");
                BeginWriteAttribute("class", " class=\"", 2531, "\"", 2557, 1);
#nullable restore
#line 92 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
WriteAttributeValue("", 2539, selectedClassName, 2539, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 92 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
                                              Write(generated[counter++]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 93 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n");
#nullable restore
#line 95 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    <!--#endregion-->\r\n    <!--#region Use HTML Code From C# Codes-->\r\n");
#nullable restore
#line 99 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
      counter = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral("    <ul>\r\n        <li>\r\n");
#nullable restore
#line 102 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
             foreach (var item in generated)
            {
                if (counter % 4 == 0 && counter != 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                WriteLiteral("</li><li>\r\n");
#nullable restore
#line 107 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
                }
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
           Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 109 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
                counter++;
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </li>\r\n    </ul>\r\n    <!--#endregion-->\r\n    <!--#region Sample Of Comment Line-->\r\n");
                WriteLiteral("    <!--#endregion-->\r\n\r\n\r\n    <table>\r\n        <tr class=\"newsHeader\">\r\n            <th>News Number</th>\r\n            <th>News Title</th>\r\n            <th>Approve Status</th>\r\n        </tr>\r\n");
#nullable restore
#line 125 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr class=\"newsContent\">\r\n                <td>");
#nullable restore
#line 128 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
               Write(item.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 129 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 130 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
                 if (item.Approve)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Approved</td>\r\n");
#nullable restore
#line 133 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Not Approved</td>\r\n");
#nullable restore
#line 137 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n");
#nullable restore
#line 139 "C:\Users\Hakan ÇELEBİ7\Desktop\Güz Yarıyılı 5.Dönem Dersler\İnternet Tabanlı Program Geliştirme\Hafta4\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n\r\n");
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Hafta4.Entities.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
