#pragma checksum "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Shared/LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09003095b01c84fa83afba02d98c38f231068bba"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using HiddenVilla;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using HiddenVilla.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using HiddenVilla.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        Hello, ");
                __builder2.AddContent(3, 
#nullable restore
#line 4 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Shared/LoginDisplay.razor"
                context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.AddMarkupContent(5, "<a href=\"Identity/Account/Logout\">Logout</a>");
            }
            ));
            __builder.AddAttribute(6, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "<a href=\"Identity/Account/Register\">Register</a>\r\n        ");
                __builder2.AddMarkupContent(8, "<a href=\"Identity/Account/Login\">Login</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
