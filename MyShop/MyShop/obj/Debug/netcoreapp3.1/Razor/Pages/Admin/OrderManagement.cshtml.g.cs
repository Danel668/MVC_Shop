#pragma checksum "C:\Users\Admin\Desktop\Project_C#\MyShop\MyShop\MyShop\Pages\Admin\OrderManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7dfd5e640f26a24f83f99720a7abdbc5b88e57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_OrderManagement), @"mvc.1.0.razor-page", @"/Pages/Admin/OrderManagement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7dfd5e640f26a24f83f99720a7abdbc5b88e57", @"/Pages/Admin/OrderManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_OrderManagement : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/order.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"app\">\r\n    <div v-if=\"selectedOrder == null\">\r\n        <div class=\"tabs is-centered\">\r\n            <ul>\r\n                <li v-bind:class=\"{\'is-active\': status === 0}\"><a ");
            WriteLiteral("@click=\"status = 0\">Pending</a></li>\r\n                <li v-bind:class=\"{\'is-active\': status === 1}\"><a ");
            WriteLiteral("@click=\"status = 1\">Packed</a></li>\r\n                <li v-bind:class=\"{\'is-active\': status === 2}\"><a ");
            WriteLiteral("@click=\"status = 2\">Shipped</a></li>\r\n                <li v-bind:class=\"{\'is-active\': status === 3}\"><a ");
            WriteLiteral(@"@click=""status = 3"">Completed</a></li>
            </ul>
        </div>
        <div v-if=""orders.length > 0"">
            <table class=""table is-fullwidth is-striped"">
                <tr>
                    <th>Email</th>
                    <th>City</th>
                </tr>
                <tr v-for=""order in orders"">
                    <td><a class=""has-text-black subtitle"" ");
            WriteLiteral(@"@click=""getOrder(order.id)"">{{order.email}}</a></td>
                    <td class=""subtitle"">{{order.city}}</td>
                </tr>
            </table>
        </div>
    </div>
    <div v-else>
        <table class=""table is-fullwidth is-bordered"">
            <tr>
                <th>Id</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Email</th>
                <th>Phone Number</th>
                <th>Address 1</th>
                <th>Address 2</th>
                <th>City</th>
                <th>Post Code</th>
            </tr>
            <tr>
                <td>{{selectedOrder.id}}</td>
                <td>{{selectedOrder.firstName}}</td>
                <td>{{selectedOrder.lastName}}</td>
                <td>{{selectedOrder.email}}</td>
                <td>{{selectedOrder.phoneNumber}}</td>
                <td>{{selectedOrder.address1}}</td>
                <td>{{selectedOrder.address2}}</td>
                <td>{{select");
            WriteLiteral(@"edOrder.city}}</td>
                <td>{{selectedOrder.postCode}}</td>
            </tr>
        </table>
        <table class=""table is-fullwidth is-hoverable is-bordered"">
            <tr>
                <th>Product Name</th>
                <th>Size</th>
                <th>Color</th>
                <th>Qty</th>
            </tr>
            <tr v-for=""product in selectedOrder.products"">
                <td>{{product.productName}}</td>
                <td>{{product.size}}</td>
                <td>{{product.color}}</td>
                <td>{{product.qty}}</td>
            </tr>
        </table>

        <div class=""columns"">
            <div class=""column is-10"">
                 <a ");
            WriteLiteral("@click=\"exitOrder()\" class=\"button is-danger\">Exit</a>\r\n            </div>\r\n            <div v-if=\"selectedOrder.status != maxStatus\" class=\"column ml-6\">\r\n                <a ");
            WriteLiteral("@click=\"updateOrder()\" class=\"button is-success\">Proccess</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7dfd5e640f26a24f83f99720a7abdbc5b88e576548", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyShop.Pages.Admin.OrderManagementModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Pages.Admin.OrderManagementModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Pages.Admin.OrderManagementModel>)PageContext?.ViewData;
        public MyShop.Pages.Admin.OrderManagementModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
