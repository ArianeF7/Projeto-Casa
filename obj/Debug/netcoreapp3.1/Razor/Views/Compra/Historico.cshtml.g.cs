#pragma checksum "C:\Users\AAFA\Desktop\cópia 25022020\CasaDeShow1\Views\Compra\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f340ae2cc99c47d5683931dcf949e6cf7da1552d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compra_Historico), @"mvc.1.0.view", @"/Views/Compra/Historico.cshtml")]
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
#line 1 "C:\Users\AAFA\Desktop\cópia 25022020\CasaDeShow1\Views\_ViewImports.cshtml"
using CasaDeShow1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AAFA\Desktop\cópia 25022020\CasaDeShow1\Views\_ViewImports.cshtml"
using CasaDeShow1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f340ae2cc99c47d5683931dcf949e6cf7da1552d", @"/Views/Compra/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f5242d4348c188684094174dc7c806fe4f9851e", @"/Views/_ViewImports.cshtml")]
    public class Views_Compra_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CasaDeShow1.Models.Comprar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
 <div >
     <h1>Otima escolha!</h1>
     <H2 class=""text-center"">Histórico de Compras</H2>   
     <hr>
</div>

    <table class=""table table-bordered"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Nome do Evento</th>
            <th scope=""col"">Quantidade Ingressos comprados</th>
            <th scope=""col"">Preço unitário</th> 
            <th scope=""col"">Valor Total da compra</th>            
            <th scope=""col"">Local</th>
            <th scope=""col"">Data do Evento</th>
        </tr>
  </thead>

");
#nullable restore
#line 21 "C:\Users\AAFA\Desktop\cópia 25022020\CasaDeShow1\Views\Compra\Historico.cshtml"
     foreach (var compra in Model)
    {    

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>  \r\n            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\AAFA\Desktop\cópia 25022020\CasaDeShow1\Views\Compra\Historico.cshtml"
               Write(Html.DisplayFor(model => compra.Evento.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\AAFA\Desktop\cópia 25022020\CasaDeShow1\Views\Compra\Historico.cshtml"
               Write(compra.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n                <td>");
#nullable restore
#line 27 "C:\Users\AAFA\Desktop\cópia 25022020\CasaDeShow1\Views\Compra\Historico.cshtml"
               Write(String.Format("R$ {0:0.00}", compra.Evento.preco).Replace(".", ","));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                <td>");
#nullable restore
#line 28 "C:\Users\AAFA\Desktop\cópia 25022020\CasaDeShow1\Views\Compra\Historico.cshtml"
               Write(String.Format("R$ {0:0.00}", compra.TotalCompra).Replace(".", ","));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n                <td>");
#nullable restore
#line 29 "C:\Users\AAFA\Desktop\cópia 25022020\CasaDeShow1\Views\Compra\Historico.cshtml"
               Write(Html.DisplayFor(model => compra.Evento.Local.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\AAFA\Desktop\cópia 25022020\CasaDeShow1\Views\Compra\Historico.cshtml"
               Write(Html.DisplayFor(model => compra.Evento.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody> \r\n");
#nullable restore
#line 33 "C:\Users\AAFA\Desktop\cópia 25022020\CasaDeShow1\Views\Compra\Historico.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("     </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CasaDeShow1.Models.Comprar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
