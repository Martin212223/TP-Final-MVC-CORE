#pragma checksum "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e87eedd311f799bfe5696b9b4e9e1116a85ac4a5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e87eedd311f799bfe5696b9b4e9e1116a85ac4a5", @"/Views/Receta/Create.cshtml")]
    #nullable restore
    public class Views_Receta_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebMisRecetas.Models.Receta>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
  
    ViewData["Title"] = "Create Receta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("SideBar", async() => {
                WriteLiteral(@"
    <h3>Bienvenido!</h3>
    <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/3/3a/Continental_Breakfast.jpg/1024px-Continental_Breakfast.jpg"" alt=""desayuno-continental"" />
    <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Paula_Modersohn-Becker_022.jpg/800px-Paula_Modersohn-Becker_022.jpg"" alt=""pintura-desayuno"" />
    <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Breakfast_manitou2121.jpg/1024px-Breakfast_manitou2121.jpg"" alt=""desayuno-frutas"" />
");
            }
            );
            WriteLiteral("\r\n");
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
       Write(Html.LabelFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 23 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 29 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        ");
#nullable restore
#line 31 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
   Write(Html.EditorFor(model => model.Ingredientes, additionalViewData: new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 32 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 36 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        ");
#nullable restore
#line 38 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
   Write(Html.EditorFor(model => model.Instrucciones, additionalViewData: new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 39 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 43 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 44 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 45 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
            WriteLiteral("            <p>\r\n            ");
#nullable restore
#line 49 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 50 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 51 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 55 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 56 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 57 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 61 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 62 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 63 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
            WriteLiteral("        <input type=\"submit\" action=\"Create\" />\r\n");
#nullable restore
#line 68 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
   Write(Html.ActionLink("Ver las recetas", "Index", "Receta"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Create.cshtml"
                                                              

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
