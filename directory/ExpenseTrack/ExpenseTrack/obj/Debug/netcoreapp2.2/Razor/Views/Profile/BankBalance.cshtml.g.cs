#pragma checksum "C:\Users\Deepa\Desktop\MSSA\Cohort 7 2019\Homeworks\CourseProject\directory\ExpenseTrack\ExpenseTrack\Views\Profile\BankBalance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d15f737c71ba452b3881c10203eb6c25066be3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_BankBalance), @"mvc.1.0.view", @"/Views/Profile/BankBalance.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/BankBalance.cshtml", typeof(AspNetCore.Views_Profile_BankBalance))]
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
#line 1 "C:\Users\Deepa\Desktop\MSSA\Cohort 7 2019\Homeworks\CourseProject\directory\ExpenseTrack\ExpenseTrack\Views\_ViewImports.cshtml"
using ExpenseTrack;

#line default
#line hidden
#line 2 "C:\Users\Deepa\Desktop\MSSA\Cohort 7 2019\Homeworks\CourseProject\directory\ExpenseTrack\ExpenseTrack\Views\_ViewImports.cshtml"
using ExpenseTrack.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d15f737c71ba452b3881c10203eb6c25066be3b", @"/Views/Profile/BankBalance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"947c02822068d2b97d3bb5e4750a239199803e6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_BankBalance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Deepa\Desktop\MSSA\Cohort 7 2019\Homeworks\CourseProject\directory\ExpenseTrack\ExpenseTrack\Views\Profile\BankBalance.cshtml"
  
    ViewData["Title"] = "BankBalance";

#line default
#line hidden
            BeginContext(49, 74, true);
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1>Bank Balance</h1>\r\n\r\n        ");
            EndContext();
            BeginContext(123, 545, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d15f737c71ba452b3881c10203eb6c25066be3b3932", async() => {
                BeginContext(129, 532, true);
                WriteLiteral(@"
            Bank Account Balance:
            <input type=""number"" id=""bankamount"">
            <br>
            Income:<br>
            <input type=""number"" id=""incomeamount"">
            <br />
            Expenses:<br>
            <input type=""number"" id=""expenses"">
            <br />


            Account Balance:<br />
            <input type=""number"" id=""total"">
            <br />

            <br />
            <input type=""button"" onclick=""getTotal()"" value=""Get Total"" />
            <br />
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(668, 502, true);
            WriteLiteral(@"

        <p>""There is no such thing called Privacy in today's world.""</p>

    </div>

<script type=""text/javascript"">
   function getTotal(){

      var first = document.getElementById('bankamount') .value;
      var second = document.getElementById('incomeamount').value;
      var third = document.getElementById('expenses') .value;
      var total  = parseInt(first) + parseInt(second) - parseInt(third);

        document.getElementById('total') .value = total;
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
