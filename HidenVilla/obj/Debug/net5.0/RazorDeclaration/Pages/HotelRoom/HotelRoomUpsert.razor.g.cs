// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla.Pages.HotelRoom
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
#line 3 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoom/HotelRoomUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoom/HotelRoomUpsert.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoom/HotelRoomUpsert.razor"
using HiddenVilla.Service.IService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/edit/{Id:int}")]
    public partial class HotelRoomUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "/media/mrspyretos/MemoryBoard/desktop2/TestProjects/Blazor/HidenVilla/HidenVilla/Pages/HotelRoom/HotelRoomUpsert.razor"
       
    [Parameter]
    public int? Id { get; set; }
    private HotelRoomDTO HotelRoomModel { get; set; } = new HotelRoomDTO();
    private string Title { get; set; } = "Create";
    private HotelRoomImageDTO RoomImage { get; set; } = new HotelRoomImageDTO();
    private List<string> DeletedImageNames { get; set; } = new List<string>();
    private bool IsImageUploadProcessStarted { get; set; } = false;
    public BlazoredTextEditor QuillHtml { get; set; } = new BlazoredTextEditor();

    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationState { get; set; }


    protected override async Task OnInitializedAsync()
    {
        var authenticationState = await AuthenticationState;
        if (!authenticationState.User.IsInRole(Common.SD.Role_Admin))
        {
            var uri = new Uri(NavigationManager.Uri);
            NavigationManager.NavigateTo($"/identity/account/login?=returnUrl={uri.LocalPath}");
        }
        //if (authenticationState.User.IsInRole("Admin")) { }
        if (Id != null)
        {
            //updating
            Title = "Update";
            HotelRoomModel = await HotelRoomRepository.GetHotelRoom(Id.Value);
            if (HotelRoomModel?.HotelRoomImages != null)
            {
                HotelRoomModel.ImageUrls = HotelRoomModel.HotelRoomImages.Select(u => u.RoomImageUrl).ToList();
            }
        }
        else
        {
            //create
            HotelRoomModel = new HotelRoomDTO();
        }
    }
    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
            return;
        bool loading = true;
        while (loading)
        {
            try
            {
                if (!string.IsNullOrEmpty(HotelRoomModel.Details))
                {
                    await this.QuillHtml.LoadHTMLContent(HotelRoomModel.Details);
                }
                loading = false;
            }
            catch
            {
                await Task.Delay(10);
                loading = true;
            }
        }
    }

    private async Task HandleHotelRoomUpsert()
    {
        var roomDetailsByname = await HotelRoomRepository.IsRoomUnique(HotelRoomModel.Name, HotelRoomModel.Id);
        if (roomDetailsByname != null)
        {
            await JsRUntime.ToastrError("Room name already exists");
            //there is duplicate room show error
            return;
        }
        try
        {
            if (HotelRoomModel.Id != 0 && Title == "Update")
            {
                HotelRoomModel.Details = await QuillHtml.GetHTML();
                //update
                var updateRoomResult = await HotelRoomRepository.UpdateHotelRoom(HotelRoomModel.Id, HotelRoomModel);
                if ((HotelRoomModel.ImageUrls != null && HotelRoomModel.ImageUrls.Any())
                    || (DeletedImageNames != null && DeletedImageNames.Any()))
                {
                    if (DeletedImageNames != null && DeletedImageNames.Any())
                    {
                        foreach (var deletedImageName in DeletedImageNames)
                        {
                            var imageName = deletedImageName.Replace($"{NavigationManager.BaseUri}RoomImages/", "");

                            var result = FileUpload.DeleteFile(imageName);
                            await HotelRoomImagesRepository.DeleteHotelRoomImageByImageUrl(deletedImageName);
                        }
                    }
                    await AddHotelRoomImage(updateRoomResult);
                }
                await JsRUntime.ToastrSuccess("Hotel room updated");
            }
            else
            {
                //create
                HotelRoomModel.Details = await QuillHtml.GetHTML();
                var createdResult = await HotelRoomRepository.CreateHotelRoom(HotelRoomModel);
                await AddHotelRoomImage(createdResult);
                await JsRUntime.ToastrSuccess("Hotel room created");
            }
        }
        catch (Exception ex)
        {

        }

        NavigationManager.NavigateTo("hotel-room");
    }
    //public async void SetHTML()
    //{
    //    if (!string.IsNullOrEmpty(HotelRoomModel.Details))
    //    {
    //        await this.QuillHtml.LoadHTMLContent(HotelRoomModel.Details);
    //    }
    //    StateHasChanged();
    //}
    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        IsImageUploadProcessStarted = true;
        try
        {
            var images = new List<string>();
            if (e.GetMultipleFiles().Count > 0)
            {
                foreach (var file in e.GetMultipleFiles())
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.Name);
                    if (fileInfo.Extension.ToLower() == ".jpg" ||
                        fileInfo.Extension.ToLower() == ".jpeg" ||
                        fileInfo.Extension.ToLower() == ".png")
                    {
                        var uploadedImagePath = await FileUpload.UploadFile(file);
                        images.Add(uploadedImagePath);
                    }
                    else
                    {
                        await JsRUntime.ToastrError("Please select .jpg/.jpeg/.png file only");
                        return;
                    }
                }
                if (images.Any())
                {
                    if (HotelRoomModel.ImageUrls != null && HotelRoomModel.ImageUrls.Any())
                    {
                        HotelRoomModel.ImageUrls.AddRange(images);
                    }
                    else
                    {
                        HotelRoomModel.ImageUrls = new List<string>();
                        HotelRoomModel.ImageUrls.AddRange(images);
                    }
                }
                else
                {
                    await JsRUntime.ToastrError("Image uploading failed");
                    return;
                }
            }
            IsImageUploadProcessStarted = false;
        }
        catch (Exception ex)
        {
            await JsRUntime.ToastrError(ex.Message);
        }
    }
    private async Task AddHotelRoomImage(HotelRoomDTO roomDetails)
    {
        foreach (var imageUrl in HotelRoomModel.ImageUrls)
        {
            if (HotelRoomModel.HotelRoomImages == null || HotelRoomModel.HotelRoomImages.Where(x => x.RoomImageUrl == imageUrl).Count() == 0)
            {
                RoomImage = new HotelRoomImageDTO()
                {
                    RoomId = roomDetails.Id,
                    RoomImageUrl = imageUrl
                };
                await HotelRoomImagesRepository.CreateHotelRoomImage(RoomImage);
            }
        }
    }
    internal async Task DeletePhoto(string imageUrl)
    {
        try
        {
            var imageIndex = HotelRoomModel.ImageUrls.FindIndex(x => x == imageUrl);
            var imageName = imageUrl.Replace($"{NavigationManager.BaseUri}RoomImages/", "");
            if (HotelRoomModel.Id == 0 && Title == "Create")
            {
                var result = FileUpload.DeleteFile(imageName);
            }
            else
            {
                //update
                DeletedImageNames ??= new List<string>();
                DeletedImageNames.Add(imageUrl);
            }
            HotelRoomModel.ImageUrls.RemoveAt(imageIndex);
        }
        catch (Exception ex)
        {
            await JsRUntime.ToastrError(ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRUntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomImagesRepository HotelRoomImagesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
#pragma warning restore 1591