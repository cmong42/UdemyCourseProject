#pragma checksum "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b4334269e74e5bfd116e03c30211853b917affc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FormView), @"mvc.1.0.view", @"/Views/Home/FormView.cshtml")]
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
#line 1 "/Users/christineong/Projects/Vidly2/Vidly2/Views/_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/christineong/Projects/Vidly2/Vidly2/Views/_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b4334269e74e5bfd116e03c30211853b917affc", @"/Views/Home/FormView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3385476d4b85d199b00cf2e726d5a33682ed59", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FormView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
  
    ViewBag.Title = "New Customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>New Customer</h2>\n\n");
#nullable restore
#line 9 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
 using (Html.BeginForm("SaveCustomer", "Home"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n        <label>\n            First Name: ");
#nullable restore
#line 13 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
                   Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 14 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
       Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </label>\n    </div>\n    <div class=\"form-group\">\n        <label>\n            Last Name: ");
#nullable restore
#line 19 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
                  Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 20 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
       Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </label>\n    </div>\n    <div class=\"form-group\">\n        <label>\n            Birthdate: ");
#nullable restore
#line 25 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
                  Write(Html.TextBoxFor(m => m.Birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 26 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
       Write(Html.ValidationMessageFor(m => m.Birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </label>\n        </div>\n    <div class=\"form-group\">\n        <label>\n            Discount Rate: ");
#nullable restore
#line 31 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
                      Write(Html.TextBoxFor(m => m.DiscountRate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 32 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
       Write(Html.ValidationMessageFor(m => m.DiscountRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </label>\n    </div>\n    <div class=\"form-group\">\n        <label>\n            Membership Duration in Months: ");
#nullable restore
#line 37 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
                                      Write(Html.TextBoxFor(m => m.DurationInMonths, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 38 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
       Write(Html.ValidationMessageFor(m => m.DurationInMonths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </label>\n    </div>\n    <div class=\"checkbox\">\n        <label>\n            ");
#nullable restore
#line 43 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
       Write(Html.CheckBoxFor(m => m.IsSubscribedNewsLetter));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Subscribed to our Newsletter?\n        </label>\n    </div>\n");
#nullable restore
#line 46 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\">Submit</button>\n");
#nullable restore
#line 48 "/Users/christineong/Projects/Vidly2/Vidly2/Views/Home/FormView.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
