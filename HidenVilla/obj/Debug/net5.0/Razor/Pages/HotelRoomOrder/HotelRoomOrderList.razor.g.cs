#pragma checksum "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aae4ae0db12484edf572e12ce79dcc7e8b6f521"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla.Pages.HotelRoomOrder
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
#nullable restore
#line 2 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room-order")]
    public partial class HotelRoomOrderList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
 if (!IsLoading)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h4 class=\"card-title text-info\">Hotel Room Order\'s</h4>\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<RoomOrderDetailsDTO>>(1);
            __builder.AddAttribute(2, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
                                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 12 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
                                FilterMode.Advanced

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
                                                               5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
                                                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RoomOrderDetailsDTO>>(
#nullable restore
#line 13 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
                                               HotelRoomOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ColumnWidth", "300px");
            __builder.AddAttribute(10, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 14 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
                                                               LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RoomOrderDetailsDTO>>(12);
                __builder2.AddAttribute(13, "Property", "Name");
                __builder2.AddAttribute(14, "Title", "Customer Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RoomOrderDetailsDTO>>(16);
                __builder2.AddAttribute(17, "Property", "Phone");
                __builder2.AddAttribute(18, "Title", "Customer Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RoomOrderDetailsDTO>>(20);
                __builder2.AddAttribute(21, "Property", "Email");
                __builder2.AddAttribute(22, "Title", "Customer Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RoomOrderDetailsDTO>>(24);
                __builder2.AddAttribute(25, "Property", "HotelRoomDTO.Name");
                __builder2.AddAttribute(26, "Title", "Room");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RoomOrderDetailsDTO>>(28);
                __builder2.AddAttribute(29, "Property", "Status");
                __builder2.AddAttribute(30, "Title", "Status");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RoomOrderDetailsDTO>>(32);
                __builder2.AddAttribute(33, "Property", "CheckInDate");
                __builder2.AddAttribute(34, "Title", "Check in Date");
                __builder2.AddAttribute(35, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RoomOrderDetailsDTO>)((data) => (__builder3) => {
                    __builder3.AddContent(36, 
#nullable restore
#line 23 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
                     String.Format("{0:d}", data.CheckInDate)

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RoomOrderDetailsDTO>>(38);
                __builder2.AddAttribute(39, "Property", "ID");
                __builder2.AddAttribute(40, "Title", "");
                __builder2.AddAttribute(41, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RoomOrderDetailsDTO>)((data) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
                    __builder3.AddAttribute(43, "class", "btn btn-primary");
                    __builder3.AddAttribute(44, "href", 
#nullable restore
#line 28 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
                                                             $"hotel-room-order/details/{data.Id}"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(46, "Details");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 33 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "<p>loading..</p>");
#nullable restore
#line 37 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoomOrder/HotelRoomOrderList.razor"
       
    private IEnumerable<RoomOrderDetailsDTO> HotelRoomOrders { get; set; } = new List<RoomOrderDetailsDTO>();
    private bool IsLoading { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        IsLoading = true;
        HotelRoomOrders = await roomOrderDetailsRepository.GetAllRoomOrderDetail();
        IsLoading = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoomOrderDetailsRepository roomOrderDetailsRepository { get; set; }
    }
}
#pragma warning restore 1591
