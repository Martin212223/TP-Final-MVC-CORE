#pragma checksum "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37a6e110f9a7381ecc3cbae00faf4e685c9eecb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receta_Eliminar), @"mvc.1.0.view", @"/Views/Receta/Eliminar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37a6e110f9a7381ecc3cbae00faf4e685c9eecb4", @"/Views/Receta/Eliminar.cshtml")]
    #nullable restore
    public class Views_Receta_Eliminar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebMisRecetas.Models.Receta>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
  
    ViewData["Title"] = "Eliminar Receta";

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
            WriteLiteral("\r\n<h2>Receta: ");
#nullable restore
#line 14 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
       Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>¿Desea eliminar esta receta?</p>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
 using (Html.BeginForm("Eliminar", "Receta", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <span>");
#nullable restore
#line 20 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 21 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        <span>");
#nullable restore
#line 25 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 26 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        <span>");
#nullable restore
#line 30 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayNameFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 31 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayFor(model => model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        <span>");
#nullable restore
#line 35 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayNameFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 36 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayFor(model => model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        <span>");
#nullable restore
#line 40 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayNameFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 41 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        <span>");
#nullable restore
#line 45 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 46 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        <span>");
#nullable restore
#line 50 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayNameFor(model => model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 51 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayFor(model => model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        <span>");
#nullable restore
#line 55 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>");
#nullable restore
#line 56 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
         Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" action=\"Eliminar\" />\r\n");
#nullable restore
#line 61 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
Write(Html.ActionLink("Volver", "Index", "Receta"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Alternativa\Desktop\Último curso\TP FINAL MVC CORE\slnQuirogaMartin\SistemaWebMisRecetas\Views\Receta\Eliminar.cshtml"
                                                 

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
