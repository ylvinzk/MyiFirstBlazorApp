#pragma checksum "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4e9d764f44239c35e3c9244c0ea48fc355646f1"
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
#line 2 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\Index.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n");
            __builder.OpenComponent<MyFirstBlazorApp.Client.Components.MyFirstComponent>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<MyFirstBlazorApp.Client.Shared.SurveyPrompt>(3);
            __builder.AddAttribute(4, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "ul");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "li");
            __builder.AddContent(9, "Last multiple of three = ");
            __builder.AddContent(10, 
#nullable restore
#line 11 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\Index.razor"
                                  lastMultipleOfThree

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "li");
            __builder.AddContent(13, "Last multiple of two = ");
            __builder.AddContent(14, 
#nullable restore
#line 12 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\Index.razor"
                                lastMultipleOfTwo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenComponent<MyFirstBlazorApp.Client.Pages.Counter>(17);
            __builder.AddAttribute(18, "OnMultipleOfThree", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 15 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\Index.razor"
                            UpdateLastMultipleOfThreeValue

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "OnMultipleOfTwoAction", new System.Action<System.Int32>(
#nullable restore
#line 16 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\Index.razor"
                                 UpdateLastMultipleOfTwoValue

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\workspace\source\repos\MyiFirstBlazorApp\MyFirstBlazorApp\Client\Pages\Index.razor"
 
    int lastMultipleOfThree;
    int lastMultipleOfTwo;

    private void UpdateLastMultipleOfThreeValue(int value)
    {
        lastMultipleOfThree = value;
    }

    private void UpdateLastMultipleOfTwoValue(int value)
    {
        lastMultipleOfTwo = value;
    }

    private static void TopLevelClicked()
    {
        Debug.WriteLine("Top level clicked");
    }
    private static void SecondLevelClicked()
    {
        Debug.WriteLine("Second level clicked");
    }
    private static void ThirdLevelClicked()
    {
        Debug.WriteLine("Third level clicked");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
