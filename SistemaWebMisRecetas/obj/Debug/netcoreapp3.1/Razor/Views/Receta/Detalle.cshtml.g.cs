#pragma checksum "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f85259f5c3f265462481cd4171aa4f7b138dad0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receta_Detalle), @"mvc.1.0.view", @"/Views/Receta/Detalle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f85259f5c3f265462481cd4171aa4f7b138dad0", @"/Views/Receta/Detalle.cshtml")]
    #nullable restore
    public class Views_Receta_Detalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebMisRecetas.Models.Receta>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f85259f5c3f265462481cd4171aa4f7b138dad02850", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Detalle</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f85259f5c3f265462481cd4171aa4f7b138dad03911", async() => {
                WriteLiteral("\r\n\r\n    <h2>Ver Detalle</h2>\r\n    ");
#nullable restore
#line 13 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
Write(Html.ActionLink("Volver a recetas", "Index", "Receta"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 16 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 21 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 26 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayNameFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 27 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 31 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayNameFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 32 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 36 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayNameFor(model => model.Autor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 37 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayFor(model => model.Autor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 41 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 42 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 46 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayNameFor(model => model.Edad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 47 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayFor(model => model.Edad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 51 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 52 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Detalle.cshtml"
   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n\r\n");
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
