#pragma checksum "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33679d2c042c13617358b2344f94579ac0d7f6a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receta_Create), @"mvc.1.0.view", @"/Views/Receta/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33679d2c042c13617358b2344f94579ac0d7f6a2", @"/Views/Receta/Create.cshtml")]
    #nullable restore
    public class Views_Receta_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebMisRecetas.Models.Receta>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33679d2c042c13617358b2344f94579ac0d7f6a22845", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Create</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33679d2c042c13617358b2344f94579ac0d7f6a23905", async() => {
                WriteLiteral("\r\n\r\n    <h1>Nombre receta colocar</h1>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
     using (Html.BeginForm("Create", "Receta", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 17 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n");
                WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 23 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n");
                WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 29 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 30 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 31 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n");
                WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 35 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Autor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 36 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Autor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 37 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Autor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n");
                WriteLiteral("            <p>\r\n            ");
#nullable restore
#line 41 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 42 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 43 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n");
                WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 47 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Edad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 48 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Edad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 49 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Edad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n");
                WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 53 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 54 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 55 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n");
                WriteLiteral("        <input type=\"submit\" action=\"Create\" />\r\n");
#nullable restore
#line 60 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
   Write(Html.ActionLink("Ver las recetas", "Index", "Receta"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
                                                              

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaWebMisRecetas.Models.Receta> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591