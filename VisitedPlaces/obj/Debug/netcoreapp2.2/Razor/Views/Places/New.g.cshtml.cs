#pragma checksum "/Users/Guest/Desktop/Places.Solution/VisitedPlaces/Views/Places/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cadbe086702a44afe32680d12f15a75ab5de5f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Places_New), @"mvc.1.0.view", @"/Views/Places/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Places/New.cshtml", typeof(AspNetCore.Views_Places_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cadbe086702a44afe32680d12f15a75ab5de5f0", @"/Views/Places/New.cshtml")]
    public class Views_Places_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 606, true);
            WriteLiteral(@"<form action=""/places"" method=""post"">
  <label for=""newCity"">Add city name: </label>
  <input id=""newCity"" name=""newCity"" type=""text"">
  <label for=""stayTime"">How long you stayed? </label>
  <input id=""stayTime"" name=""stayTime"" type=""text"">
  <label for=""withWhom""> Whom you travelled with? </label>
  <input id=""withWhom"" name=""withWhom"" type=""text"">
  <label for=""entry""> Add journal entry: </label>
  <input id=""entry"" name=""entry"" type=""text"">
  <label for=""photoUrl""> Add a link to a photo: </label>
  <input id=""photoUrl"" name=""photoUrl"" type=""text"">


  <button type=""submit"">Submit</button>
</form>");
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
