#pragma checksum "/home/user/dotnet_projetos/LojaVirtual/Views/Produto/Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11e70ce7db3508cba44538f4d10145f056e32e03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11e70ce7db3508cba44538f4d10145f056e32e03", @"/Views/Produto/Visualizar.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Olá Mundo!</h1>\n\nRazor:\n");
#nullable restore
#line 9 "/home/user/dotnet_projetos/LojaVirtual/Views/Produto/Visualizar.cshtml"
Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 11 "/home/user/dotnet_projetos/LojaVirtual/Views/Produto/Visualizar.cshtml"
  
    string nome = "Testando a aplicação!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 15 "/home/user/dotnet_projetos/LojaVirtual/Views/Produto/Visualizar.cshtml"
Write(nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n\n\n<h3>");
#nullable restore
#line 18 "/home/user/dotnet_projetos/LojaVirtual/Views/Produto/Visualizar.cshtml"
Write(nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<br>\n<h2>Produto</h2>\n<b>Código:</b> ");
#nullable restore
#line 21 "/home/user/dotnet_projetos/LojaVirtual/Views/Produto/Visualizar.cshtml"
          Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<b>Código:</b> ");
#nullable restore
#line 22 "/home/user/dotnet_projetos/LojaVirtual/Views/Produto/Visualizar.cshtml"
          Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<b>Código:</b> ");
#nullable restore
#line 23 "/home/user/dotnet_projetos/LojaVirtual/Views/Produto/Visualizar.cshtml"
          Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<b>Código:</b> ");
#nullable restore
#line 24 "/home/user/dotnet_projetos/LojaVirtual/Views/Produto/Visualizar.cshtml"
          Write(Model.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591