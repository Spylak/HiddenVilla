// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Client.Pages.HotelRooms
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
#line 14 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/_Imports.razor"
using HiddenVilla_Client.Model.ViewModel;

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
#line 7 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/Pages/HotelRooms/RoomDetails.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/Pages/HotelRooms/RoomDetails.razor"
           [Authorize(Roles = SD.Role_Customer)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel/room-details/{Id:int}")]
    public partial class RoomDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 148 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HiddenVilla_Client/Pages/HotelRooms/RoomDetails.razor"
        [Parameter]
            public int? Id { get; set; }

            public HotelRoomBookingVM HotelBooking { get; set; } = new HotelRoomBookingVM();
            private int NoOfNights { get; set; } = 1;

            protected override async Task OnInitializedAsync()
            {
                try
                {
                    await Task.Delay(5000);
                    HotelBooking.OrderDetails = new RoomOrderDetailsDTO();
                    if (Id != null)
                    {
                        if (await localStorage.GetItemAsync<HomeVM>
            (SD.Local_InitialBooking) != null)
                        {
                            var roomInitialInfo = await localStorage.GetItemAsync<HomeVM>
                                (SD.Local_InitialBooking);
                            HotelBooking.OrderDetails.HotelRoomDTO = await hotelRoomService.GetHotelRoomDetails(Id.Value,
                            roomInitialInfo.StartDate.ToString("MM/dd/yyyy"), roomInitialInfo.EndDate.ToString("MM/dd/yyyy"));
                            NoOfNights = roomInitialInfo.NoOfNights;
                            HotelBooking.OrderDetails.CheckInDate = roomInitialInfo.StartDate;
                            HotelBooking.OrderDetails.CheckOutDate = roomInitialInfo.EndDate;
                            HotelBooking.OrderDetails.HotelRoomDTO.TotalDays = roomInitialInfo.NoOfNights;
                            HotelBooking.OrderDetails.HotelRoomDTO.TotalAmount =
                            roomInitialInfo.NoOfNights * HotelBooking.OrderDetails.HotelRoomDTO.RegularRate;
                        }
                        else
                        {
                            HotelBooking.OrderDetails.HotelRoomDTO = await hotelRoomService.GetHotelRoomDetails(Id.Value,
                            DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
                            NoOfNights = 1;
                            HotelBooking.OrderDetails.CheckInDate = DateTime.Now;
                            HotelBooking.OrderDetails.CheckOutDate = DateTime.Now.AddDays(1);
                            HotelBooking.OrderDetails.HotelRoomDTO.TotalDays = 1;
                            HotelBooking.OrderDetails.HotelRoomDTO.TotalAmount =
                            HotelBooking.OrderDetails.HotelRoomDTO.RegularRate;
                        }
                    }

                    if (await localStorage.GetItemAsync<UserDTO>
                        (SD.Local_UserDetails) != null)
                    {
                        var userInfo = await localStorage.GetItemAsync<UserDTO>
                            (SD.Local_UserDetails);
                        HotelBooking.OrderDetails.UserId = userInfo.Id;
                        HotelBooking.OrderDetails.Name = userInfo.Name;
                        HotelBooking.OrderDetails.Email = userInfo.Email;
                        HotelBooking.OrderDetails.Phone = userInfo.PhoneNo;
                    }
                }
                catch (Exception e)
                {
                    await jsRuntime.ToastrError(e.Message);
                }
            }


            private async Task HandleNoOfNightsChange(ChangeEventArgs e)
            {
                NoOfNights = Convert.ToInt32(e.Value.ToString());
                HotelBooking.OrderDetails.HotelRoomDTO = await hotelRoomService.GetHotelRoomDetails(Id.Value,
                HotelBooking.OrderDetails.CheckInDate.ToString("MM/dd/yyyy"),
                HotelBooking.OrderDetails.CheckInDate.AddDays(NoOfNights).ToString("MM/dd/yyyy"));

                HotelBooking.OrderDetails.CheckOutDate = HotelBooking.OrderDetails.CheckInDate.AddDays(NoOfNights);
                HotelBooking.OrderDetails.HotelRoomDTO.TotalDays = NoOfNights;
                HotelBooking.OrderDetails.HotelRoomDTO.TotalAmount = NoOfNights * HotelBooking.OrderDetails.HotelRoomDTO.RegularRate;
            }

            private async Task HandleCheckout()
            {
                if (!await HandleValidation())
                {
                    return;
                }

                try
                {
                    var paymentDTO = new StripePaymentDTO()
                    {
                        Amount = Convert.ToInt32(HotelBooking.OrderDetails.HotelRoomDTO.TotalAmount * 100),
                        ProductName = HotelBooking.OrderDetails.HotelRoomDTO.Name,
                        ReturnUrl = "/hotel/room-details/" + Id
                    };

                    var result = await stripePaymentService.CheckOut(paymentDTO);

                    HotelBooking.OrderDetails.StripeSessionId = result.Data.ToString();
                    HotelBooking.OrderDetails.RoomId = HotelBooking.OrderDetails.HotelRoomDTO.Id;
                    HotelBooking.OrderDetails.TotalCost =  HotelBooking.OrderDetails.HotelRoomDTO.TotalAmount;

                    var roomOrderDetailsSaved = await roomOrderDetailsService.SaveRoomOrderDetails(HotelBooking.OrderDetails);

                    await localStorage.SetItemAsync(SD.Local_RoomOrderDetails, roomOrderDetailsSaved);

                    await jsRuntime.InvokeVoidAsync("redirectToCheckout", result.Data.ToString());
                }
                catch (Exception e)
                {
                    await jsRuntime.ToastrError(e.Message);
                }

            }

            private async Task<bool> HandleValidation()
            {
                if (string.IsNullOrEmpty(HotelBooking.OrderDetails.Name))
                {
                    await jsRuntime.ToastrError("Name cannot be empty");
                    return false;
                }
                if (string.IsNullOrEmpty(HotelBooking.OrderDetails.Phone))
                {
                    await jsRuntime.ToastrError("Phone cannot be empty");
                    return false;
                }

                if (string.IsNullOrEmpty(HotelBooking.OrderDetails.Email))
                {
                    await jsRuntime.ToastrError("Email cannot be empty");
                    return false;
                }
                return true;

            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoomOrderDetailsService roomOrderDetailsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStripePaymentService stripePaymentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomService hotelRoomService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
