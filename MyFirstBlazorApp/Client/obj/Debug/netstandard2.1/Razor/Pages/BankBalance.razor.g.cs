#pragma checksum "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\BankBalance.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aa9e3d05c36c2063f35778572147bd7f4e49c50"
// <auto-generated/>
#pragma warning disable 1591
namespace MyFirstBlazorApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\_Imports.razor"
using MyFirstBlazorApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\_Imports.razor"
using MyFirstBlazorApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\_Imports.razor"
using MyFirstBlazorApp.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\BankBalance.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bank-balance")]
    public partial class BankBalance : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Bank balance</h1>\r\n\r\n");
            __builder.OpenElement(1, "label");
            __builder.AddContent(2, "Name = ");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\BankBalance.razor"
               name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\BankBalance.razor"
                       name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "label");
            __builder.AddContent(13, "Date of birth = ");
            __builder.AddContent(14, 
#nullable restore
#line 12 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\BankBalance.razor"
                        dateOfBirth?.ToString("MMMM d, yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\BankBalance.razor"
                       dateOfBirth

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd"));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dateOfBirth = __value, dateOfBirth, format: "yyyy-MM-dd"));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.OpenElement(23, "label");
            __builder.AddContent(24, "Bank balance = ");
            __builder.AddContent(25, 
#nullable restore
#line 18 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\BankBalance.razor"
                       bankBalance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "div");
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\BankBalance.razor"
                       bankBalance

#line default
#line hidden
#nullable disable
            , culture: 
#nullable restore
#line 21 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\BankBalance.razor"
                               turkishCulture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => bankBalance = __value, bankBalance, culture: turkishCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\BankBalance.razor"
       
    private string name;
    private DateTime? dateOfBirth;
    private decimal? bankBalance;

    private CultureInfo turkishCulture = CultureInfo.GetCultureInfo("tr-TR");
    private readonly CultureInfo usCulture = CultureInfo.GetCultureInfo("en-US");

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
