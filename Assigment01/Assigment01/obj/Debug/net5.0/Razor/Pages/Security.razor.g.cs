#pragma checksum "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\Security.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8af098e1c90db6be53b8aa84d364fdcaff8258ec"
// <auto-generated/>
#pragma warning disable 1591
namespace SecurityComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\_Imports.razor"
using Assigment01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\_Imports.razor"
using Assigment01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Security")]
    public partial class Security : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "h3");
                __builder2.AddContent(3, "Hello ");
                __builder2.AddContent(4, 
#nullable restore
#line 5 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\Security.razor"
               context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(5, " ");
                __builder2.OpenElement(6, "h5");
                __builder2.AddContent(7, "Your security level is ");
                __builder2.AddContent(8, 
#nullable restore
#line 5 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\Security.razor"
                                                                           context.User.FindFirst(claim => claim.Type.Equals("Level")).Value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.AddMarkupContent(10, "<p>This piece of text is visible for level 0 and above</p>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(11);
            __builder.AddAttribute(12, "Policy", "SecurityLevel2");
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "<p>This piece of text is visible for level 2 and above</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(16);
            __builder.AddAttribute(17, "Policy", "SecurityLevel4");
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "<p>This is visible for level 4 and above</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591