#pragma checksum "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e6772ff186c37f404c49fefb02c4c14cf75f72b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\_ViewImports.cshtml"
using Istikbal_Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\_ViewImports.cshtml"
using Istikbal_Backend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e6772ff186c37f404c49fefb02c4c14cf75f72b", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84eac7c8606e99a178da8c5e153620fe32822baa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-25 w-sm-50 br-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none sm-block "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none sm-block  text-black hover2 t-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none delete text-black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor: pointer;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int totalprice = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--====== Cart-Area Start ======-->
<div class=""container"">
    <div>
        <h3>Səbət</h3>
    </div>
    <!-- Cart-Top -->
    <div class=""row px-sm-0  "">
        <div class=""col-lg-4 col-5 p-0"">
            <div class="" border bg-grey text-center"">
                <h4 class=""fw-normal"">Məhsul</h4>
            </div>
        </div>
        <div class=""col-lg-2 d-none d-sm-block  p-0"">
            <div class="" border bg-grey text-center"">
                <h4 class=""fw-normal"">Qiymət</h4>
            </div>
        </div>
        <div class=""col-lg-1 d-none d-sm-block  p-0"">
            <div class="" border bg-grey text-center"">
                <h4 class=""fw-normal"">Status</h4>
            </div>
        </div>
        <div class=""col-lg-2 col-2 p-0"">
            <div class="" border bg-grey text-center"">
                <h4 class=""fw-normal"">Ədəd</h4>
            </div>
        </div>
        <div class=""col-lg-2 col-3 p-0"">
            <div class="" border bg-grey text-center"">
 ");
            WriteLiteral(@"               <h4 class=""fw-normal"">Cəmi</h4>
            </div>
        </div>
        <div class=""col-lg-1 col-2 p-0"">
            <div class="" border bg-grey text-center"">
                <h4 class=""fw-normal"">Sil</h4>
            </div>
        </div>
    </div>

    <!-- Cart-Bottom -->
");
#nullable restore
#line 47 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
     foreach (var item in Model.BasketItems)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span style=\"display:none\">");
#nullable restore
#line 49 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                               Write(totalprice += item.Count * item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("        <div class=\"row px-sm-0 align-items-center\">\r\n            <div class=\"col-lg-4 col-5 p-0\">\r\n                <div class=\"border h-90 h-sm-120 text-sm-start text-center ps-sm-4 pt-sm-4 pt-1\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e6772ff186c37f404c49fefb02c4c14cf75f72b9200", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                         foreach (var image in item.Product.ProductImages)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                             if (image.IsMain)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0e6772ff186c37f404c49fefb02c4c14cf75f72b10058", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2168, "~/assets/img/product/", 2168, 21, true);
#nullable restore
#line 60 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
AddHtmlAttributeValue("", 2189, image.ImageUrl, 2189, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                                                                   WriteLiteral(item.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e6772ff186c37f404c49fefb02c4c14cf75f72b14497", async() => {
#nullable restore
#line 64 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                                                                                                                                                        Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                                                                  WriteLiteral(item.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-2 d-none d-sm-block p-0\">\r\n                <div class=\"border h-90 pt-4 ps-4\">\r\n                    <h4 class=\"text-grey\"><span class=\"money\">");
#nullable restore
#line 69 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                                                         Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> AZN</h4>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-1 d-none d-sm-block p-0\">\r\n                <div class=\"border h-90 pt-4 ps-2\">\r\n");
#nullable restore
#line 74 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                     if (item.Product.Count != 0)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"text-grey\">Mövcuddur\t</span>\r\n");
#nullable restore
#line 78 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"text-grey\">Mövcud deyil\t</span>\r\n");
#nullable restore
#line 82 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-lg-2 col-2 p-0\">\r\n                <div class=\"border h-90 h-sm-120\">\r\n                    <div class=\"qty pt-4 d-flex\">\r\n                        <div data-id=\"");
#nullable restore
#line 89 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                                 Write(item.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"minus down fw-bold\" style=\"cursor: pointer;\">-</div>\r\n                        <span class=\"bg-transparent inp-value border-0 w-24\" style=\"outline: none;\">");
#nullable restore
#line 90 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                                                                                               Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <div data-id=\"");
#nullable restore
#line 91 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                                 Write(item.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""plus up fw-bold"" style=""cursor: pointer;"">+</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-2 col-3 p-0"">
                <div class=""border h-90 h-sm-120 pt-4 ps-2"">
                    <h4 class=""text-yellow text-center""><span class=""money-t"" data-id=""");
#nullable restore
#line 97 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                                                                                  Write(item.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 97 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                                                                                                     Write((item.Product.Price * item.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> AZN</h4>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-1 col-2 p-0\">\r\n                <div class=\"border text-center h-90 h-sm-120 pt-4 ps-2\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e6772ff186c37f404c49fefb02c4c14cf75f72b21338", async() => {
                WriteLiteral("\r\n                        <i class=\"fa-regular fa-circle-xmark\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                                                                     WriteLiteral(item.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 108 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Continue-shopping -->
    <div class=""row "">
        <div class=""col-lg-12 text-end bg-grey py-4"">
            <a href=""/shop/index"" class=""bg-yellow text-black hover3 t-5 text-decoration-none br-5  py-2 px-3"">Almaga davam et</a>
        </div>
    </div>

    <!-- Total -->
    <div class=""row mt-5 justify-content-end"">
        <div class=""col-lg-6 "">
            <div class=""border"">
                <h4 class="" fw-normal py-1 text-center p-0 m-0"">Sifarişlərin məbləği</h4>
                <div class=""d-flex border-top py-2"">
                    <span class=""text-grey"">Ümumi	</span>
                    <span class=""text-grey ml-5""><span class=""total_pric"">");
#nullable restore
#line 123 "C:\Users\hp\Desktop\Istikbal_Backend\Istikbal_Backend\Views\Basket\Index.cshtml"
                                                                     Write(totalprice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> AZN</span>
                </div>
            </div>
        </div>
    </div>
</div>
<!--====== Cart-Area End ======-->
<script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script>
    // Input count
    var myInp = document.querySelectorAll("".inp-value"");
    var increaseBtn = document.querySelectorAll("".up"");
    var decreaseBtn = document.querySelectorAll("".down"");
    for (let elem of decreaseBtn) {

        elem.addEventListener(""click"", function (e) {
            e.preventDefault()
            countst = this.nextElementSibling.innerText
            countstn = Number(countst)
            if (countstn > 1) {
                count = this.nextElementSibling.innerText
                countn = Number(count)
                countn -= 1;
                this.nextElementSibling.innerText = countn;
            }
        })
    }
    for (let elem of increaseBtn) {

        elem");
            WriteLiteral(@".addEventListener(""click"", function (e) {
            e.preventDefault()
            count = this.previousElementSibling.innerText
            countn = Number(count)
            countn += 1;
            this.previousElementSibling.innerText = countn;


        })
    }
    $(document).ready(function () {

        $(document).on(""click"", "".down"", function (e) {
            e.preventDefault();
            var id = $(this).attr(""data-id"")
            var totall = document.querySelector("".total_pric"")
            var money = document.querySelectorAll("".money-t"")
            console.log(id)
            $.ajax({
                url: ""/basket/minus"",
                data: {
                    id: id
                },
                type: ""post"",
                datatype: ""json"",
                success: function (data) {
                    money.forEach(mon => {
                        if (id == mon.getAttribute(""data-id"")) {
                            mon.innerHTML = data.price
   ");
            WriteLiteral(@"                         console.log(data.price)
                        }
                    })
                    totall.innerHTML = `${data.totalPrice}`

                }
            })

        })

        $(document).on(""click"", "".up"", function (e) {
            e.preventDefault();
            var id = $(this).attr(""data-id"")
            var totall = document.querySelector("".total_pric"")
            var money = document.querySelectorAll("".money-t"")
            console.log(id)
            $.ajax({
                url: ""/basket/plus"",
                data: {
                    id: id
                },
                type: ""post"",
                datatype: ""json"",
                success: function (data) {
                    money.forEach(mon => {
                        if (id == mon.getAttribute(""data-id"")) {
                            mon.innerHTML = data.price
                            console.log(data.price)
                        }
                    })
      ");
            WriteLiteral(@"              totall.innerHTML = `${data.totalPrice}`

                }
            })

        })

        $("".delete"").click(function (e) {
            e.preventDefault()
            console.log($(this).attr(""href""))
            Swal.fire({
                title: 'Əminsiniz?',
                text: ""Bunun geri dönüşü yoxdur!"",
                icon: 'Xəbərdarlıq',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Bəli sil!'
            }).then((result) => {
                if (result.isConfirmed) {
                    var link = $(this).attr(""href"");
                    fetch(link).then(response => response.json()).then(data => {
                        if (data.status == 200) {
                            location.reload(true)
                        } else {
                            Swal.fire(
                                'Tapılmadı!',
                       ");
            WriteLiteral("         \'Fayl silinmiş ola bilər.\',\r\n                                \'Uğursuz cəhd\'\r\n                            )\r\n                        }\r\n                    });\r\n                }\r\n            })\r\n        })\r\n    })\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591