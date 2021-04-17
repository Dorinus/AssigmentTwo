#pragma checksum "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\Statistics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a47e5d3b1366d0ccedd8826a61bc6978ec3a186b"
// <auto-generated/>
#pragma warning disable 1591
namespace Assigment01.Pages
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
#nullable restore
#line 2 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\Statistics.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\Statistics.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\Statistics.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\Statistics.razor"
           [Authorize(Policy = "LogedIn")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/statistics")]
    public partial class Statistics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Statistics</h3>\r\n\r\n<div id=\"chartdiv\"></div>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\Statistics.razor"
                                          GeneratePieChartBlazor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Generate Pie Chart");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\Statistics.razor"
       
    FamilyInfo familyInfo = new FamilyInfo();
    IList<FamilyInfo> familiesInfos = new List<FamilyInfo>();


    private async Task GeneratePieChartBlazor()
    {
        familiesInfos = familyInfo.GetInfo();
        await JsRuntime.InvokeVoidAsync("GeneratePieChart", familiesInfos);

        foreach (var item in familiesInfos)
        {
            Console.WriteLine(item.Address+ item.NumberOfPeople);
        }
    }
    
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext FileContext { get; set; }
    }
}
#pragma warning restore 1591