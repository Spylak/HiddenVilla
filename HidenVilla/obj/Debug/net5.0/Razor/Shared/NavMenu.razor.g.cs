#pragma checksum "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee13b1799484af9b95cf4b695c85d0098bed9e0f"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-vhk5955vz0");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-vhk5955vz0>HiddenVilla</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Shared/NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-vhk5955vz0");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-vhk5955vz0></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Shared/NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Shared/NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-vhk5955vz0");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-vhk5955vz0");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-vhk5955vz0");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Shared/NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-vhk5955vz0></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-vhk5955vz0");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "hotel-room");
            __builder.AddAttribute(33, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Shared/NavMenu.razor"
                                                               NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-vhk5955vz0></span> Hotel Rooms\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "nav-item px-3");
            __builder.AddAttribute(39, "b-vhk5955vz0");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "class", "nav-link");
            __builder.AddAttribute(42, "href", "hotel-amenity");
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-vhk5955vz0></span> Hotel Amenity\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "nav-item px-3");
            __builder.AddAttribute(48, "b-vhk5955vz0");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "class", "nav-link");
            __builder.AddAttribute(51, "href", "hotel-room-order");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-vhk5955vz0></span> Hotel Amenity\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
