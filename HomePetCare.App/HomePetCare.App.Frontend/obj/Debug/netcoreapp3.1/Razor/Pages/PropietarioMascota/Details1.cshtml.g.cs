#pragma checksum "C:\HospitalizacionMascota\HomePetCare.App\HomePetCare.App.Frontend\Pages\PropietarioMascota\Details1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b0013e144b7bdd42c6c57e33ca9ddb071f76b2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HomePetCare.App.Frontend.Pages.PropietarioMascota.Pages_PropietarioMascota_Details1), @"mvc.1.0.razor-page", @"/Pages/PropietarioMascota/Details1.cshtml")]
namespace HomePetCare.App.Frontend.Pages.PropietarioMascota
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
#line 1 "C:\HospitalizacionMascota\HomePetCare.App\HomePetCare.App.Frontend\Pages\_ViewImports.cshtml"
using HomePetCare.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b0013e144b7bdd42c6c57e33ca9ddb071f76b2b", @"/Pages/PropietarioMascota/Details1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0161bd1e999404a326257397b585e024cd3bf4c6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PropietarioMascota_Details1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Datos Propietario Mascota</h2>\r\n<div>\r\n    Id Persona: ");
#nullable restore
#line 7 "C:\HospitalizacionMascota\HomePetCare.App\HomePetCare.App.Frontend\Pages\PropietarioMascota\Details1.cshtml"
           Write(Model.PropietarioMascota.IdPersona);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n<div>\r\n    Nombres: ");
#nullable restore
#line 10 "C:\HospitalizacionMascota\HomePetCare.App\HomePetCare.App.Frontend\Pages\PropietarioMascota\Details1.cshtml"
        Write(Model.PropietarioMascota.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n<div>\r\n    Apellidos: ");
#nullable restore
#line 13 "C:\HospitalizacionMascota\HomePetCare.App\HomePetCare.App.Frontend\Pages\PropietarioMascota\Details1.cshtml"
          Write(Model.PropietarioMascota.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n    Direccion: ");
#nullable restore
#line 16 "C:\HospitalizacionMascota\HomePetCare.App\HomePetCare.App.Frontend\Pages\PropietarioMascota\Details1.cshtml"
          Write(Model.PropietarioMascota.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n    Telefono: ");
#nullable restore
#line 19 "C:\HospitalizacionMascota\HomePetCare.App\HomePetCare.App.Frontend\Pages\PropietarioMascota\Details1.cshtml"
         Write(Model.PropietarioMascota.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n    Ciudad: ");
#nullable restore
#line 22 "C:\HospitalizacionMascota\HomePetCare.App\HomePetCare.App.Frontend\Pages\PropietarioMascota\Details1.cshtml"
       Write(Model.PropietarioMascota.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n    Correo: ");
#nullable restore
#line 25 "C:\HospitalizacionMascota\HomePetCare.App\HomePetCare.App.Frontend\Pages\PropietarioMascota\Details1.cshtml"
       Write(Model.PropietarioMascota.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b0013e144b7bdd42c6c57e33ca9ddb071f76b2b5966", async() => {
                WriteLiteral("Volver lista Propietario Mascota ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomePetCare.App.Frontend.Pages.Details1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HomePetCare.App.Frontend.Pages.Details1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HomePetCare.App.Frontend.Pages.Details1Model>)PageContext?.ViewData;
        public HomePetCare.App.Frontend.Pages.Details1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
