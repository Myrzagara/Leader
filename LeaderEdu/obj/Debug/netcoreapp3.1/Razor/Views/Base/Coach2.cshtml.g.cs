#pragma checksum "/Users/mac/Projects/LeaderEdu/Leader/LeaderEdu/Views/Base/Coach2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a5731a4c77867624a70af00f18d3fbcbf652e00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Base_Coach2), @"mvc.1.0.view", @"/Views/Base/Coach2.cshtml")]
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
#line 1 "/Users/mac/Projects/LeaderEdu/Leader/LeaderEdu/Views/_ViewImports.cshtml"
using LeaderEdu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mac/Projects/LeaderEdu/Leader/LeaderEdu/Views/_ViewImports.cshtml"
using LeaderEdu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a5731a4c77867624a70af00f18d3fbcbf652e00", @"/Views/Base/Coach2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98aa850d8cedddd06531dc731e4c4be87dab2c14", @"/Views/_ViewImports.cshtml")]
    public class Views_Base_Coach2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelMixForCoach>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>Base</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a5731a4c77867624a70af00f18d3fbcbf652e003761", async() => {
                WriteLiteral("\r\n    \r\n            <input type=\"submit\" value=\"Выйти\" class=\"btn btn-outline-dark\" />\r\n      \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div id=\"dvCategoryResults\">\r\n");
#nullable restore
#line 10 "/Users/mac/Projects/LeaderEdu/Leader/LeaderEdu/Views/Base/Coach2.cshtml"
      await Html.RenderPartialAsync("PartialQuestionnaire", Model.questionnaireLeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<input type=\'button\' id=\"AddQues\" value=\'Анкета\' />\r\n<div id=\"datetimepickerCoach\"></div>\r\n<input type=\'button\' id=\"addCoachTime\" value=\'Добавить\' />\r\n<input id=\"time\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 500, "\"", 508, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
<table border=""1"">
    <tr>
        <td><input type=""button"" class=""btn btn-outline-success"" value=""08:00"" /></td>
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
        <td><input type=""button"" class=""btn btn-outline-success"" va");
            WriteLiteral(@"lue=""18:00"" /></td>
        <td><input type=""button"" class=""btn btn-outline-success"" value=""19:00"" /></td>
    </tr>
    <tr>
        <td><input type=""button"" class=""btn btn-outline-success"" value=""20:00"" /></td>
        <td><input type=""button"" class=""btn btn-outline-success"" value=""21:00"" /></td>
        <td><input type=""button"" class=""btn btn-outline-success"" value=""22:00"" /></td>
        <td><input type=""button"" class=""btn btn-outline-success"" value=""23:00"" /></td>
    </tr>

</table>
<div id=""results""></div>
<div id=""dvCategoryResults"">
");
#nullable restore
#line 45 "/Users/mac/Projects/LeaderEdu/Leader/LeaderEdu/Views/Base/Coach2.cshtml"
      await Html.RenderPartialAsync("PartialEduTimes", Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {

            $('.btn').prop(""disabled"", false);

            $('#datetimepickerCoach').datepicker({
                inline: true,
                altField: '#d',
                onSelect: onDateChange,
                changeMonth: false,
                changeYear: false,
                stepMonths: false,
            });
            function onDateChange(dateText, inst) {
                UpdateTime(dateText);
            }
        });

       function UpdateTime(dateText){
            var settings = {
                ""url"": ""/Base/GetDisableTimesForCoach"",
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

                $('.btn').prop(""disabled"", fa");
                WriteLiteral(@"lse);


                for (var i = 0; i < response.length; i++) {

                    $('input[type=""button""][value=""' + response[i] + '""]').prop(""disabled"", true);
                }
            });

        };



        $(document).ready(function () {
            $('#dvCategoryResults').hide();
           

            $('#AddQues').click(function (e) {
                e.preventDefault();
                $('#dvCategoryResults').toggle('show');

            });
          
                var AddTime = '");
#nullable restore
#line 106 "/Users/mac/Projects/LeaderEdu/Leader/LeaderEdu/Views/Base/Coach2.cshtml"
                          Write(Model.AddTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
            if (AddTime) {
                $('#addCoachTime').hide();
            };



            $('#addCoachTime').click(function (e) {
                e.preventDefault();
                var date = $(""#datetimepickerCoach"").val();

                var time = $(""#time"").val();

                let bd = new Date(date + "" "" + time + ' UTC').toISOString();
                if (time != """") {
                    var settings = {
                        ""url"": ""/Base/AddCoachTime"",
                        ""method"": ""POST"",
                        ""timeout"": 0,
                        ""headers"": {
                            ""Content-Type"": ""application/json""
                        },
                        ""data"": JSON.stringify({ ""CoachGuid"": """", ""BeginDate"": bd, ""EndDate"": bd, ""LeaderGuid"": """", ""Status"": 0 }),
                    };

                    $.ajax(settings).done(function (data) {

                        $('#dvCategoryResults').empty();
                        $('#");
                WriteLiteral(@"dvCategoryResults').html(data);
                        UpdateTime(date);

                    });

                }
                else {
                    alert(""Не выбрано время"");
                }




            });
        });

        $("".btn"").click(function () {
            var fired_button = $(this).val();
            $(""#time"").val(fired_button);

        });</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelMixForCoach> Html { get; private set; }
    }
}
#pragma warning restore 1591
