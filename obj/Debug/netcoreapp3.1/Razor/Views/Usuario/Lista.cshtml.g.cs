#pragma checksum "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\Usuario\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1baa7793478c18b8e9558aff71562b9b9707b836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Lista), @"mvc.1.0.view", @"/Views/Usuario/Lista.cshtml")]
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
#line 1 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\_ViewImports.cshtml"
using moe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\_ViewImports.cshtml"
using moe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1baa7793478c18b8e9558aff71562b9b9707b836", @"/Views/Usuario/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8557bb8fc85adf61f25433fc186521086c35fea6", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\Usuario\Lista.cshtml"
  
    ViewData["Title"] = "Cadastro";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1baa7793478c18b8e9558aff71562b9b9707b8363458", async() => {
                WriteLiteral(@"
    <main>
        <div>
            <div class=""titulo"">
            <h2>
                Lista de Usuários
            </h2>
        </div>
        </div>
        <div>
            <table>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Nome</th>
                        <th>Login</th>
                        <th>Senha</th>
                        <th>Data de Nascimento</th>
                        <th>Operações</th>
                    </tr>
                </thead>
");
#nullable restore
#line 27 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\Usuario\Lista.cshtml"
                 foreach (Usuario u in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\Usuario\Lista.cshtml"
                       Write(u.IdUsuario);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\Usuario\Lista.cshtml"
                       Write(u.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\Usuario\Lista.cshtml"
                       Write(u.Login);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\Usuario\Lista.cshtml"
                       Write(u.Senha);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\Usuario\Lista.cshtml"
                       Write(u.DataNascimento);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1013, "\"", 1058, 2);
                WriteAttributeValue("", 1020, "/Usuario/Editar?IdUsuario=", 1020, 26, true);
#nullable restore
#line 36 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\Usuario\Lista.cshtml"
WriteAttributeValue("", 1046, u.IdUsuario, 1046, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Alterar</a> /\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1105, "\"", 1151, 2);
                WriteAttributeValue("", 1112, "/Usuario/Remover?IdUsuario=", 1112, 27, true);
#nullable restore
#line 37 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\Usuario\Lista.cshtml"
WriteAttributeValue("", 1139, u.IdUsuario, 1139, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Excluir</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\Usuario\Lista.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 44 "C:\Users\Deyvison Estevan\Documents\Deyvison\SENAC-TECNICO INFORMÁTICA PARA INTERNET\PI\fase 5\moe\Views\Usuario\Lista.cshtml"
       Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591