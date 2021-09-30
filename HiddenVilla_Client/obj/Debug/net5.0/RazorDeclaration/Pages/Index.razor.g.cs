// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using HiddenVilla_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using HiddenVilla_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using HiddenVilla_Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using HiddenVilla_Client.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/Pages/Index.razor"
using HiddenVilla_Client.Model.ViewModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/Pages/Index.razor"
       public HomeVM HomeModel { get; set; } = new HomeVM();
            public IEnumerable<HotelAmenityDTO> HotelAmenities { get; set; } = new List<HotelAmenityDTO>();
            public bool IsProcessing { get; set; } = false;
            protected override async Task OnInitializedAsync()
            {
                IsProcessing = true;
                HotelAmenities = await hotelAmenityService.GetHotelAmenities();
                IsProcessing = false;
            }


            private async Task SaveInitialData()
            {
                try
                {
                    HomeModel.EndDate = HomeModel.StartDate.AddDays(HomeModel.NoOfNights);

                    await localStorage.SetItemAsync(SD.Local_InitialBooking, HomeModel);
                    navigationManager.NavigateTo("hotel/rooms", true);
                }
                catch (Exception e)
                {
                    await jsRuntime.ToastrError(e.Message);
                }
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelAmenityService hotelAmenityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591
