#pragma checksum "/Users/mac/Projects/LeaderEdu/LeaderEdu/Views/Base/Leader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1d64bf8c13916fe8b20311b9be108dd3a7e0df0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Base_Leader), @"mvc.1.0.view", @"/Views/Base/Leader.cshtml")]
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
#line 1 "/Users/mac/Projects/LeaderEdu/LeaderEdu/Views/_ViewImports.cshtml"
using LeaderEdu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mac/Projects/LeaderEdu/LeaderEdu/Views/_ViewImports.cshtml"
using LeaderEdu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1d64bf8c13916fe8b20311b9be108dd3a7e0df0", @"/Views/Base/Leader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98aa850d8cedddd06531dc731e4c4be87dab2c14", @"/Views/_ViewImports.cshtml")]
    public class Views_Base_Leader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelMixForLeader>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-anti-forgery", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1d64bf8c13916fe8b20311b9be108dd3a7e0df04616", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b1d64bf8c13916fe8b20311b9be108dd3a7e0df04880", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 4 "/Users/mac/Projects/LeaderEdu/LeaderEdu/Views/Base/Leader.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Выйти\" class=\"btn btn-outline-dark\" />\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n \r\n\r\n    <div id=\"datetimepickerLeader\"></div>\r\n    <input id=\"time\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 447, "\"", 455, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
    <table border=""1"">
        <tr>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""08:00""/></td>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""09:00"" /></td>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""10:00"" /></td>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""11:00"" /></td>
        </tr>
        <tr>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""12:00"" /></td>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""13:00"" /></td>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""14:00"" /></td>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""15:00"" /></td>
        </tr>
        <tr>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""16:00"" /></td>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""17:00"" /></td>
    ");
            WriteLiteral(@"        <td><input type=""button"" class=""btn btn-outline-success"" value=""18:00"" /></td>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""19:00"" /></td>
        </tr>
        <tr>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""20:00"" /></td>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""21:00"" /></td>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""22:00"" /></td>
            <td><input type=""button"" class=""btn btn-outline-success"" value=""23:00"" /></td>
        </tr>

    </table>
<input type='button' id=""addLeaderTime"" value='Добавить' />



");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n\r\n             var AddTime = \'");
#nullable restore
#line 52 "/Users/mac/Projects/LeaderEdu/LeaderEdu/Views/Base/Leader.cshtml"
                       Write(Model.AddTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
            if (AddTime) {
                $('#addLeaderTime').hide();
            }


            $('#addLeaderTime').click(function (e) {
                e.preventDefault();
                var date = $(""#datetimepickerLeader"").val();
                var time = $(""#time"").val();

                let bd = new Date(date + "" "" + time + ' UTC').toISOString();
                if (time != """") {
                    var settings = {
                        ""url"": ""/Base/AddLeaderTime"",
                        ""method"": ""POST"",
                        ""timeout"": 0,
                        ""headers"": {
                            ""Content-Type"": ""application/json""
                        },
                        ""data"": JSON.stringify({ ""CoachId"": 1, ""BeginDate"": bd, ""EndDate"": bd, ""LeaderId"": 2, ""Status"": 3 }),
                    };

                    $.ajax(settings).done(function (data) {


                    });
                }
                else {
                    alr");
                WriteLiteral(@"t(""Не выбрано время"");
                }

            });
        });

        $("".btn"").click(function () {
            var fired_button = $(this).val();
            $(""#time"").val(fired_button);

        });


        $(function () {

            var arrayDates = JSON.parse('");
#nullable restore
#line 96 "/Users/mac/Projects/LeaderEdu/LeaderEdu/Views/Base/Leader.cshtml"
                                    Write(Html.Raw(Json.Serialize(Model.disableDates)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
            $('.btn').prop(""disabled"", true);


            $('#datetimepickerLeader').datepicker({
                inline: true,
                altField: '#d',
                onSelect: onDateChange,
                changeMonth: false,
                changeYear: false,
                stepMonths: false,
                beforeShowDay: function (date) {
                    var string = jQuery.datepicker.formatDate('yy-mm-dd', date);
                    return [arrayDates.indexOf(string) == -1]
                }
            });

          //  $(""#datetimepickerLeader"").datepicker(""setDate"", null);
            // remove current-day class (because default date is still highlighted)
           // $(""#datetimepickerLeader"").find("".ui-datepicker-current-day"").removeClass(""ui-datepicker-current-day"");

            function onDateChange(dateText, inst) {
                //let bd = new Date(dateText + ' UTC').toISOString();
                var settings = {
                    ""url"": ""/Base");
                WriteLiteral(@"/GetDisableTimesForLeader"",
                    ""method"": ""POST"",
                    ""timeout"": 0,
                    ""headers"": {
                        ""Content-Type"": ""application/x-www-form-urlencoded""
                    },
                    ""data"": {
                        ""BeginDate"": dateText
                    }
                };

                $.ajax(settings).done(function (response) {

                    $('.btn').prop(""disabled"", true);


                    for (var i = 0; i < response.length; i++) {

                        $('input[type=""button""][value=""' + response[i] + '""]').prop(""disabled"", false);
            }
                });




            }

        });

    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelMixForLeader> Html { get; private set; }
    }
}
#pragma warning restore 1591
