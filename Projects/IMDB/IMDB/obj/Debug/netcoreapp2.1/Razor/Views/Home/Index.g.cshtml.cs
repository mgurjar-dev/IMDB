#pragma checksum "/Users/manish/Projects/IMDB/IMDB/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f87b9a884dcbc93f0d2170bf3931e332142c88a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/manish/Projects/IMDB/IMDB/Views/_ViewImports.cshtml"
using IMDB;

#line default
#line hidden
#line 2 "/Users/manish/Projects/IMDB/IMDB/Views/_ViewImports.cshtml"
using IMDB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f87b9a884dcbc93f0d2170bf3931e332142c88a3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91baad4c8d71f4a3f30a0c67a8a5a8dda16cedb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IMDB.Models.IMViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/manish/Projects/IMDB/IMDB/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(90, 288, true);
            WriteLiteral(@"
        

<table class=""table table-bordered table-striped table-condensed"">
    <thead>
        <tr>
            <th>Movie Name</th>
            <th>Actors</th>
            <th>Producer Name</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
        
");
            EndContext();
#line 19 "/Users/manish/Projects/IMDB/IMDB/Views/Home/Index.cshtml"
         foreach (var item in Model)
        {
            var actorList = new List<SelectListItem>();
            

#line default
#line hidden
#line 22 "/Users/manish/Projects/IMDB/IMDB/Views/Home/Index.cshtml"
             foreach (var actor in item.Actors)
            {
                actorList.Add(new SelectListItem { Text = actor.Name, Value = actor.ActorId.ToString() });

            }

#line default
#line hidden
#line 26 "/Users/manish/Projects/IMDB/IMDB/Views/Home/Index.cshtml"
             
            item.ActorsList = actorList;

#line default
#line hidden
            BeginContext(715, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(754, 35, false);
#line 29 "/Users/manish/Projects/IMDB/IMDB/Views/Home/Index.cshtml"
               Write(Html.DisplayFor(e=> item.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(789, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(817, 86, false);
#line 30 "/Users/manish/Projects/IMDB/IMDB/Views/Home/Index.cshtml"
               Write(Html.ListBoxFor(e=> item.ActorsList,item.ActorsList, new { @id="lstmovie", @style=""}));

#line default
#line hidden
            EndContext();
            BeginContext(903, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(931, 39, false);
#line 31 "/Users/manish/Projects/IMDB/IMDB/Views/Home/Index.cshtml"
               Write(Html.DisplayFor(e=> item.Producer.Name));

#line default
#line hidden
            EndContext();
            BeginContext(970, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1019, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21113ca3cd8a41509d616cd839e10d27", async() => {
                BeginContext(1069, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "/Users/manish/Projects/IMDB/IMDB/Views/Home/Index.cshtml"
                                           WriteLiteral(item.MovieId);

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
            BeginContext(1077, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1363, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 41 "/Users/manish/Projects/IMDB/IMDB/Views/Home/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1418, 27, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IMDB.Models.IMViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591