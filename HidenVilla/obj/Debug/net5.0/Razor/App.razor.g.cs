#pragma checksum "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90fd7c67f5e0788b6194729949a51c7dcd88599a"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "PreferExactMatches", 
#nullable restore
#line 2 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/App.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(6);
                    __builder3.AddAttribute(7, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 4 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(10, "<p>SOrry, you do not have access to this page</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(11, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(12);
                    __builder3.AddAttribute(13, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 11 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(15, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591