#pragma checksum "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92549c23642bef9b747ad86eace142ef1b7f25d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_InstructorChange), @"mvc.1.0.view", @"/Views/Instructor/InstructorChange.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructor/InstructorChange.cshtml", typeof(AspNetCore.Views_Instructor_InstructorChange))]
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
#line 1 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\_ViewImports.cshtml"
using CourseApp304;

#line default
#line hidden
#line 1 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
using CourseApp304.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92549c23642bef9b747ad86eace142ef1b7f25d4", @"/Views/Instructor/InstructorChange.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990a712cc40bb61434d603468a8770bddc5cf148", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructor_InstructorChange : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ValueTuple<Instructor, IEnumerable<Instructor>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Change", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
   int counter = 0;

#line default
#line hidden
            BeginContext(111, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(113, 1695, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0c6cb37a9e4498b46328bed5961b35", async() => {
                BeginContext(153, 36, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 189, "\"", 212, 1);
#line 8 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 197, Model.Item1.Id, 197, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(213, 7, true);
                WriteLiteral(" />\r\n\r\n");
                EndContext();
#line 10 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
     foreach (var course in Model.Item1.Courses)
    {


#line default
#line hidden
                BeginContext(279, 24, true);
                WriteLiteral("    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 303, "\"", 321, 1);
#line 13 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 311, course.Id, 311, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 322, "\"", 349, 3);
                WriteAttributeValue("", 329, "courses[", 329, 8, true);
#line 13 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 337, counter, 337, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 345, "].Id", 345, 4, true);
                EndWriteAttribute();
                BeginContext(350, 29, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 379, "\"", 408, 3);
                WriteAttributeValue("", 386, "Courses[", 386, 8, true);
#line 14 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 394, counter, 394, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 402, "].Name", 402, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 409, "\"", 429, 1);
#line 14 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 417, course.Name, 417, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(430, 50, true);
                WriteLiteral(" class=\"form-control\" />\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 480, "\"", 510, 3);
                WriteAttributeValue("", 487, "Courses[", 487, 8, true);
#line 15 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 495, counter, 495, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 503, "].Price", 503, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 511, "\"", 532, 1);
#line 15 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 519, course.Price, 519, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(533, 50, true);
                WriteLiteral(" class=\"form-control\" />\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 583, "\"", 619, 3);
                WriteAttributeValue("", 590, "courses[", 590, 8, true);
#line 16 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 598, counter, 598, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 606, "].Description", 606, 13, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 620, "\"", 647, 1);
#line 16 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 628, course.Description, 628, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(648, 29, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 677, "\"", 710, 3);
                WriteAttributeValue("", 684, "courses[", 684, 8, true);
#line 17 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 692, counter, 692, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 700, "].isActive", 700, 10, true);
                EndWriteAttribute();
                BeginContext(711, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(714, 64, false);
#line 17 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                                                       Write(Html.Raw(course.isActive ? "value=\"true\"" : "value=\"false\""));

#line default
#line hidden
                EndContext();
                BeginContext(779, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
                BeginContext(786, 67, true);
                WriteLiteral("    <div class=\"row my-2\">\r\n        <div class=\"col\">\r\n            ");
                EndContext();
                BeginContext(854, 11, false);
#line 21 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
       Write(course.Name);

#line default
#line hidden
                EndContext();
                BeginContext(865, 57, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            ");
                EndContext();
                BeginContext(923, 12, false);
#line 24 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
       Write(course.Price);

#line default
#line hidden
                EndContext();
                BeginContext(935, 64, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            <select");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 999, "\"", 1036, 3);
                WriteAttributeValue("", 1006, "Courses[", 1006, 8, true);
#line 27 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 1014, counter, 1014, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1022, "].InstructorId", 1022, 14, true);
                EndWriteAttribute();
                BeginContext(1037, 26, true);
                WriteLiteral(" class=\"form-control\">\r\n\r\n");
                EndContext();
#line 29 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                 foreach(Instructor i in Model.Item2)
                    {
                        if(course.Instructor==i)
                        {

#line default
#line hidden
                BeginContext(1218, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1234, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20c8c771e85b45df92ca5da3068ced70", async() => {
                    BeginContext(1266, 6, false);
#line 33 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                                          Write(i.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#line 33 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                            WriteLiteral(i.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1281, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 34 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1367, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1383, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def7b4d672ea4bdcb9bd0e8afcc9ae05", async() => {
                    BeginContext(1406, 6, false);
#line 37 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                                 Write(i.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 37 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                   WriteLiteral(i.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1421, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 38 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(1473, 51, true);
                WriteLiteral("            </select>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
#line 43 "C:\Users\Muhammed\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"

        { counter++; }
    }

#line default
#line hidden
                BeginContext(1557, 156, true);
                WriteLiteral("\r\n    <div class=\"row mt-2\">\r\n        <div class=\"col text-center\">\r\n            <button class=\"btn btn-success\" type=\"submit\">Submit</button>\r\n            ");
                EndContext();
                BeginContext(1713, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d523c0494b44c19800e1f1b8ebec0f2", async() => {
                    BeginContext(1759, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1769, 32, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ValueTuple<Instructor, IEnumerable<Instructor>>> Html { get; private set; }
    }
}
#pragma warning restore 1591