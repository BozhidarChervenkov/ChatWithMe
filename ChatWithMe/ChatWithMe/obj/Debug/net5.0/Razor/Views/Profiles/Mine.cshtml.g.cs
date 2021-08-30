#pragma checksum "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d0e0b1780f0c4e4463f951b42ec9a6dd29c49db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profiles_Mine), @"mvc.1.0.view", @"/Views/Profiles/Mine.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\_ViewImports.cshtml"
using ChatWithMe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\_ViewImports.cshtml"
using ChatWithMe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\_ViewImports.cshtml"
using ChatWithMe.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\_ViewImports.cshtml"
using ChatWithMe.ViewModels.Posts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\_ViewImports.cshtml"
using ChatWithMe.ViewModels.Profiles;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d0e0b1780f0c4e4463f951b42ec9a6dd29c49db", @"/Views/Profiles/Mine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b9e8b4721bf561121ab806417380a2e9000dd96", @"/Views/_ViewImports.cshtml")]
    public class Views_Profiles_Mine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
  
    ViewData["Title"] = "My Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mb-5\">\r\n    <div class=\"col-md-4\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 141, "\"", 173, 1);
#nullable restore
#line 9 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
WriteAttributeValue("", 147, Model.CustomPofilePicture, 147, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:280px; height:250px;\" class=\"img-thumbnail\">\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n        <h2 class=\"text-center\">");
#nullable restore
#line 12 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
                           Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
                                            Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <div class=\"mt-3\">\r\n            <p class=\"text-center\"><strong>Gender:</strong> ");
#nullable restore
#line 14 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
                                                       Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"text-center\"><strong>Total Friends:</strong> ");
#nullable restore
#line 15 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
                                                              Write(Model.Friends.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"text-center\"><strong>Total friend requests:</strong> ");
#nullable restore
#line 16 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
                                                                      Write(Model.FriendRequestsFromUsers.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"text-center\"><strong>Total sent requests:</strong> ");
#nullable restore
#line 17 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
                                                                    Write(Model.FriendRequestToUsers.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </div>
</div>

<hr>

<h2 class=""mt-5"">Friends:</h2>
<table class=""table table-striped table-dark mb-5"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">First name</th>
            <th scope=""col"">Last name</th>
            <th>Link to profile</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 35 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
         foreach (var friend in Model.Friends)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 38 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
                           Write(friend.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 39 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
               Write(friend.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
               Write(friend.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><button class=\"btn btn-info\">Go to profile</button></td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<h2 class=""mt-5"">Friend Requests:</h2>
<table class=""table table-striped table-dark mb-5"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">First name</th>
            <th scope=""col"">Last name</th>
            <th>Link to profile</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 58 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
         foreach (var friend in Model.FriendRequestsFromUsers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 61 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
                           Write(friend.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 62 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
               Write(friend.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 63 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
               Write(friend.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><button class=\"btn btn-danger\">Accept request</button></td>\r\n            </tr>\r\n");
#nullable restore
#line 66 "D:\Web Projects\ChatWithMe\ChatWithMe\ChatWithMe\Views\Profiles\Mine.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<hr>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591