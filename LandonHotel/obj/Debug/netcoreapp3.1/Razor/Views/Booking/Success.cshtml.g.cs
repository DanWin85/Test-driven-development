#pragma checksum "F:\Semister 2 2023\D202 Software Process\ASP.NET TDD\LandonHotel\Views\Booking\Success.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7f23ccfa5a2446e3c9e97724f0de3fb22615008e70862b4cf29ca9ddc99b5cc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Success), @"mvc.1.0.view", @"/Views/Booking/Success.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Semister 2 2023\D202 Software Process\ASP.NET TDD\LandonHotel\Views\_ViewImports.cshtml"
using LandonHotel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7f23ccfa5a2446e3c9e97724f0de3fb22615008e70862b4cf29ca9ddc99b5cc5", @"/Views/Booking/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"92ad751f5e98b7bde5a2dc52df7707ee3421910a9c009bfd6d62122166ce052f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Booking_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LandonHotel.Models.BookingViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Semister 2 2023\D202 Software Process\ASP.NET TDD\LandonHotel\Views\Booking\Success.cshtml"
  
    ViewData["Title"] = "Book Now";
    Html.Html5DateRenderingMode = Html5DateRenderingMode.Rfc3339;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""scene"" id=""welcome"">
    <article class=""content"">
        <div class=""gallery"">
            <img src=""/images/hotel/intro_room.jpg"" alt=""Intro Gallery Room Sample Pictures"">
            <img src=""/images/hotel/intro_pool.jpg"" alt=""Intro Gallery Pool Sample Pictures"">
            <img src=""/images/hotel/intro_dining.jpg"" alt=""Intro Gallery Dining Sample Pictures"">
            <img src=""/images/hotel/intro_attractions.jpg"" alt=""Intro Gallery Attractions Sample Pictures"">
            <img class=""hidesm"" src=""/images/hotel/intro_wedding.jpg"" alt=""Intro Gallery Dining Sample Pictures"">
        </div>
        <h1>Your booking was successful</h1>
        <sub>See you soon</sub>
    </article>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LandonHotel.Models.BookingViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
