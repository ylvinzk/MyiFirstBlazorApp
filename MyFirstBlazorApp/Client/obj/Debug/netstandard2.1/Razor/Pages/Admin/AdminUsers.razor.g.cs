#pragma checksum "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\Admin\AdminUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae65794b8d4af45e0a44bb0bd37a8f88eaf7c38e"
// <auto-generated/>
#pragma warning disable 1591
namespace MyFirstBlazorApp.Client.Pages.Admin
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
#line 2 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\Admin\AdminUsers.razor"
using MyFirstBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/users")]
    public partial class AdminUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"col-4\">To HTML attribute using .ToString()</div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-8");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "readonly", true);
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 6 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\Admin\AdminUsers.razor"
                                              myPerson

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, "<div class=\"col-4\">To component value as object</div>\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-8");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenComponent<MyFirstBlazorApp.Client.Components.PersonView>(18);
            __builder.AddAttribute(19, "Person", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MyFirstBlazorApp.Shared.Person>(
#nullable restore
#line 12 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\Admin\AdminUsers.razor"
                            myPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\Admin\AdminUsers.razor"
 
    Person myPerson;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        myPerson = new Person
        {
            Salutation = "Mr",
            GivenName = "Peter",
            FamilyName = "Morris"
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
