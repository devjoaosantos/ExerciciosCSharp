#pragma checksum "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f718ef45c242e3e11ec3c00b9bd94ee30605dad4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f718ef45c242e3e11ec3c00b9bd94ee30605dad4", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecd1f98a04a4696ecde4ba045dcb777a275b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-secondary-pages.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-form-pages.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("toggleMobileMenu()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Shared\_Layout.cshtml"
  
    var nomeView = (string) ViewData["NomeView"];

#line default
#line hidden
            BeginContext(58, 40, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            EndContext();
            BeginContext(98, 1103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f718ef45c242e3e11ec3c00b9bd94ee30605dad46491", async() => {
                BeginContext(104, 602, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <!-- PASSOS DO MENU RESPONSIVO -->
    <!-- PASSO 1 - Certifique-se de que essa linha abaixo existe no seu código -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>McBonald's</title>
    <link href=""img/logo_simbolo.png"" rel=""icon"" type=""image/x-icon""/>
    <link href=""https://fonts.googleapis.com/css?family=Fredoka+One&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Londrina+Solid:900%7COpen+Sans"" rel=""stylesheet"">

");
                EndContext();
#line 18 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Shared\_Layout.cshtml"
     if(!"Home".Equals(nomeView)){

#line default
#line hidden
                BeginContext(742, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(750, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f718ef45c242e3e11ec3c00b9bd94ee30605dad47782", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(828, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(838, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f718ef45c242e3e11ec3c00b9bd94ee30605dad49207", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(911, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 21 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Shared\_Layout.cshtml"
        
    }

#line default
#line hidden
                BeginContext(930, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(934, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f718ef45c242e3e11ec3c00b9bd94ee30605dad410885", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(995, 199, true);
                WriteLiteral("\r\n    <!-- PASSO 2 - Copie a linha do <script> abaixo para o seu HTML -->\r\n    <!-- Importar o Font Awesome para o projeto -->\r\n    <script src=\"https://kit.fontawesome.com/349a64cb04.js\"></script>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1201, 912, true);
            WriteLiteral(@"

    <header>
        <nav>
            <div class=""section-container"">
                <ul>
                    <!-- PASSO 3 - Adicione esse li à sua ul -->
                    <li id=""bt-mobile-menu"">
                        <!-- HTML para colocar os ícones do FA -->
                        <a href=""javascript:void(0);"" class=""icon"" onclick=""toggleMobileMenu()"">
                            <i class=""fa fa-bars""></i>
                        </a>
                    </li>
                    <!-- PASSO 4 - Adicione essa class=""bt-common-menu"" nas suas li -->
                    <!-- PASSO 5 - Adicione o onclick=""toggleMobileMenu()"" nas tags a -->
                    <li class=""bt-common-menu""><a onclick=""toggleMobileMenu()"" asp-asp-controller = ""Home"" asp-action = ""Index"" class=""active"">Principal</a></li>
                    <li class=""bt-common-menu""><a onclick=""toggleMobileMenu()""");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2113, "\'", 2162, 2);
#line 43 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2120, Url.Action("index" , "Home"), 2120, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 2149, "#hamburgueres", 2149, 13, true);
            EndWriteAttribute();
            BeginContext(2163, 102, true);
            WriteLiteral(">Hamburgueres</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2265, "\'", 2308, 2);
#line 44 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2272, Url.Action("index" , "Home"), 2272, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 2301, "#shakes", 2301, 7, true);
            EndWriteAttribute();
            BeginContext(2309, 96, true);
            WriteLiteral(">Shakes</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2405, "\'", 2450, 2);
#line 45 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2412, Url.Action("index" , "Home"), 2412, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 2441, "#historia", 2441, 9, true);
            EndWriteAttribute();
            BeginContext(2451, 98, true);
            WriteLiteral(">História</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2549, "\'", 2591, 2);
#line 46 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2556, Url.Action("index" , "Home"), 2556, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 2585, "#local", 2585, 6, true);
            EndWriteAttribute();
            BeginContext(2592, 64, true);
            WriteLiteral(">Local</a></li>\r\n                    <li class=\"bt-common-menu\">");
            EndContext();
            BeginContext(2656, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f718ef45c242e3e11ec3c00b9bd94ee30605dad416598", async() => {
                BeginContext(2732, 5, true);
                WriteLiteral("Login");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2741, 148, true);
            WriteLiteral("</li>\r\n                    <li><a id=\"bt-peca_ja\" href=\"pedidos.html\">Peça já!</a></li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n");
            EndContext();
#line 52 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Shared\_Layout.cshtml"
       if ("Home".Equals(nomeView))
      {
        Html.RenderPartial("_HeaderHomePage");   
      }

#line default
#line hidden
            BeginContext(2995, 19, true);
            WriteLiteral("    </header>\r\n    ");
            EndContext();
            BeginContext(3015, 12, false);
#line 57 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(3027, 378, true);
            WriteLiteral(@"
     <footer>
        <div class=""section-container"">
            <address>
                Avenida de Limeira, 539 - Campos Elíseos - SP
                <br />
                mcbonalds@email.com
                <br />
                11 1234 6789
            </address>
            <a href=""#"">Voltar para o topo!</a>
        </div>
    </footer>
    

</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591