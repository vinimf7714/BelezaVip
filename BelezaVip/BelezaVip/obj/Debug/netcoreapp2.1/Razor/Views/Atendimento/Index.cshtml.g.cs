#pragma checksum "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\Atendimento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b37759579dcf76b19f9369d1cbaf4da48dfbef94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Atendimento_Index), @"mvc.1.0.view", @"/Views/Atendimento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Atendimento/Index.cshtml", typeof(AspNetCore.Views_Atendimento_Index))]
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
#line 1 "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\_ViewImports.cshtml"
using BelezaVip;

#line default
#line hidden
#line 2 "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\_ViewImports.cshtml"
using BelezaVip.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37759579dcf76b19f9369d1cbaf4da48dfbef94", @"/Views/Atendimento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ace8d2835bf2196ef4d057aa25d6ed2363e0f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Atendimento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BelezaVip.Models.AtendimentoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(106, 257, true);
            WriteLiteral(@"

<script src=""https://code.jquery.com/jquery-3.3.1.js/""> </script>
<script src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.19/js/dataTables.bootstrap4.min.js""></script>



");
            EndContext();
            BeginContext(578, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(838, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1219, 575, true);
            WriteLiteral(@"
<h2>Atendimentos</h2>

<div class=""col-md-12"">

    <table id=""tableAtendimento"" class=""table table-striped table-bordered"" >
        <thead>
            <tr>
                <th scope=""col""> Data Atendimento</th>
                <th> Cliente</th>
                <th> Profissional</th>
                <th> Procedimento</th>
                <th> Valor Procedimento</th>
                <th> Valor Desconto</th>
                <th> Comissão Porcentagem </th>
                <th> Comissão Valor </th>
            </tr>
        </thead>
        <tbody>

");
            EndContext();
#line 48 "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\Atendimento\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1851, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1898, 20, false);
#line 51 "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\Atendimento\Index.cshtml"
                   Write(item.DataAtendimento);

#line default
#line hidden
            EndContext();
            BeginContext(1918, 33, true);
            WriteLiteral("</td>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(1952, 16, false);
#line 53 "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\Atendimento\Index.cshtml"
                   Write(item.NomeCliente);

#line default
#line hidden
            EndContext();
            BeginContext(1968, 33, true);
            WriteLiteral("</td>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(2002, 21, false);
#line 55 "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\Atendimento\Index.cshtml"
                   Write(item.NomeProfissional);

#line default
#line hidden
            EndContext();
            BeginContext(2023, 33, true);
            WriteLiteral("</td>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(2057, 21, false);
#line 57 "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\Atendimento\Index.cshtml"
                   Write(item.NomeProcedimento);

#line default
#line hidden
            EndContext();
            BeginContext(2078, 33, true);
            WriteLiteral("</td>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(2112, 22, false);
#line 59 "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\Atendimento\Index.cshtml"
                   Write(item.ValorProcedimento);

#line default
#line hidden
            EndContext();
            BeginContext(2134, 33, true);
            WriteLiteral("</td>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(2168, 18, false);
#line 61 "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\Atendimento\Index.cshtml"
                   Write(item.ValorDesconto);

#line default
#line hidden
            EndContext();
            BeginContext(2186, 33, true);
            WriteLiteral("</td>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(2220, 24, false);
#line 63 "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\Atendimento\Index.cshtml"
                   Write(item.ComissaoPorcentagem);

#line default
#line hidden
            EndContext();
            BeginContext(2244, 33, true);
            WriteLiteral("</td>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(2278, 18, false);
#line 65 "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\Atendimento\Index.cshtml"
                   Write(item.ComissaoValor);

#line default
#line hidden
            EndContext();
            BeginContext(2296, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 67 "C:\Users\vinicius\source\repos\BelezaVip\BelezaVip\Views\Atendimento\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(2343, 276, true);
            WriteLiteral(@"


        </tbody>



    </table>
</div>

<script>

    $(document).ready(function () {
        $('#tbAtendimento').DataTable({
            ""serverSide"": true,
            ""processing"": true,
            ""ordering"": false
        });
    });


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BelezaVip.Models.AtendimentoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591