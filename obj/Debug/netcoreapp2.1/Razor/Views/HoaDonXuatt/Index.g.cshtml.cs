#pragma checksum "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05fcc51840d4f31e0da06d6cc3703c3a28c9e024"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDonXuatt_Index), @"mvc.1.0.view", @"/Views/HoaDonXuatt/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HoaDonXuatt/Index.cshtml", typeof(AspNetCore.Views_HoaDonXuatt_Index))]
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
#line 1 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\_ViewImports.cshtml"
using XNHH;

#line default
#line hidden
#line 2 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\_ViewImports.cshtml"
using XNHH.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fcc51840d4f31e0da06d6cc3703c3a28c9e024", @"/Views/HoaDonXuatt/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"524b61eb668137cec9e48759f946413b3a9c91c5", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDonXuatt_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApplication1.Models.HD_XUAT>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HoaDonXuatt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 1100, true);
            WriteLiteral(@"
<div class=""col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main"">
    <div class=""row"">
        <ol class=""breadcrumb"">
            <li>
                <a href=""#"">
                    <em class=""fa fa-home""></em>
                </a>
            </li>
            <li class=""active"">Hóa đơn xuất</li>
        </ol>
    </div><!--/.row-->

    <div class=""row"">
        <div class=""col-lg-12"">
            <h1 class=""page-header"">Danh sách hóa đơn xuất</h1>
        </div>
    </div><!--/.row-->

    <div class=""row"">
        
    </div>

    <div class=""panel panel-default"">

        <table class=""tablencc"" id=""dataTable"">
            <thead>
                <tr>

                    <th>Mã hóa đơn</th>
                    <th>Mã khách hàng</th>
                    <th>Số hóa đơn xuất</th>
                    <th>Ngày xuất</th>
                    <th>Thành tiền</th>
                    <th>Phí vận chuyển</th>
                    <th>Tổng cộng</th>
                    <th");
            WriteLiteral("></th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                 foreach (var tmp in Model)
                {

#line default
#line hidden
            BeginContext(1218, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1273, 9, false);
#line 49 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                       Write(tmp.MaHDX);

#line default
#line hidden
            EndContext();
            BeginContext(1282, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1318, 8, false);
#line 50 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                       Write(tmp.MaKH);

#line default
#line hidden
            EndContext();
            BeginContext(1326, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1362, 9, false);
#line 51 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                       Write(tmp.SoHDX);

#line default
#line hidden
            EndContext();
            BeginContext(1371, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1407, 8, false);
#line 52 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                       Write(tmp.Ngay);

#line default
#line hidden
            EndContext();
            BeginContext(1415, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1451, 12, false);
#line 53 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                       Write(tmp.TongTien);

#line default
#line hidden
            EndContext();
            BeginContext(1463, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1499, 16, false);
#line 54 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                       Write(tmp.PhiVanCHuyen);

#line default
#line hidden
            EndContext();
            BeginContext(1515, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1551, 12, false);
#line 55 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                       Write(tmp.TongCong);

#line default
#line hidden
            EndContext();
            BeginContext(1563, 71, true);
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1634, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38ecf637a30f484b9de465795db4ea0a", async() => {
                BeginContext(1738, 52, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-pencil\"></span>Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                                                                                                            WriteLiteral(tmp.MaHDX);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1794, 42, true);
            WriteLiteral("\r\n                            <a data-id=\"");
            EndContext();
            BeginContext(1837, 9, false);
#line 61 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                                   Write(tmp.MaHDX);

#line default
#line hidden
            EndContext();
            BeginContext(1846, 78, true);
            WriteLiteral("\" data-controller=\"HoaDonXuatt\" data-action=\"Delete\" data-bodymessage=\"Delete ");
            EndContext();
            BeginContext(1925, 9, false);
#line 61 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                                                                                                                           Write(tmp.MaHDX);

#line default
#line hidden
            EndContext();
            BeginContext(1934, 163, true);
            WriteLiteral("?\" class=\"btn btn-danger btn-sm delete\"><span class=\"glyphicon glyphicon-trash\"></span>Delete</a>\r\n\r\n                        </td>\r\n\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 67 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2116, 47, true);
            WriteLiteral("            <tbody></tbody>\r\n        </table>\r\n");
            EndContext();
#line 70 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
         if (!string.IsNullOrEmpty(ViewBag.ErrorTienNo))
        {

#line default
#line hidden
            BeginContext(2232, 38, true);
            WriteLiteral("            <span class=\"text-danger\">");
            EndContext();
            BeginContext(2271, 19, false);
#line 72 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"
                                 Write(ViewBag.ErrorTienNo);

#line default
#line hidden
            EndContext();
            BeginContext(2290, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 73 "C:\Users\Thanh\Downloads\XuatNhaphh\XuatNhaphh\XNHH\XNHH\Views\HoaDonXuatt\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(2312, 2606, true);
            WriteLiteral(@"        <div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" datadismiss=""modal"" aria-label=""Close"">
                            <span ariahidden=""true"">&times;</span>
                        </button>
                        <h4 class=""modaltitle"" id=""myModalLabel"">
                            Warning
                        </h4>
                    </div>
                    <div class=""modal-body delete-modal-body"">
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btndefault"" data-dismiss=""modal"" id=""cancel-delete"">
                            Cancel
                        </button>
                        <button type=""button"" class=""btn btndanger"" id=""conf");
            WriteLiteral(@"irm-delete"">
                            Delete
                        </button>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>


<script type=""text/javascript"">
    $(document).ready(function () {
        $('#dataTable').DataTable();
    });
    $(function () {
        var url;
        var redirectUrl;
        var target;
        $("".delete"").on('click', (e) => {
            e.preventDefault();
            target = e.target;
            var Id = $(target).data('id');
            var controller = $(target).data('controller');
            var action = $(target).data('action');
            var bodyMessage = $(target).data('bodymessage');
            redirectUrl = $(target).data('redirect-url');
            url = ""/"" + controller + ""/"" + action + ""?id="" + Id;

            $("".delete-modal-body"").text(bodyMessage);
            $(""#deleteModal"").modal('show');
            debugger
        });
        $(""#confirm-delete"").on(");
            WriteLiteral(@"'click', () => {
            $.get(url)
                .done((result) => {
                    if (!redirectUrl) {
                        return $(target).parent().parent().hide(""slow"");
                    }
                    window.location.href = redirectUrl;
                }).fail((error) => {
                    if (redirectUrl)
                        window.location.href = redirectUrl;
                }).always(() => {
                    $(""#deleteModal"").modal('hide');
                });
        });
    });

</script>

");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApplication1.Models.HD_XUAT>> Html { get; private set; }
    }
}
#pragma warning restore 1591