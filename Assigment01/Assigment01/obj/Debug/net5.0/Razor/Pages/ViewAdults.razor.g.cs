#pragma checksum "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8738d2e9f3fbc39d6aa8f6f542098b3e29103351"
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
#line 2 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAdults")]
    public partial class ViewAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ViewAdults</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, " Filter by User Id: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                                                        (arg) => FilterId(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, " Filter by First Name: ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "search");
            __builder.AddAttribute(12, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                                                           (arg) => FilterFirstName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, " Filter by Second Name: ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "search");
            __builder.AddAttribute(19, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                                                            (arg) => FilterLastName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-outline-light");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                                                  () => Reset()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "<i class=\"oi oi-pencil\"></i> Reset ");
            __builder.CloseElement();
#nullable restore
#line 15 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
 if (showAdults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<p><em>Loading...</em></p>");
#nullable restore
#line 20 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
}
else if (!showAdults.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<p><em>No Adults items exist. Please add some.</em></p>");
#nullable restore
#line 26 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "table");
            __builder.AddAttribute(29, "class", "table");
            __builder.AddMarkupContent(30, @"<thead><tr><th>ID</th>
            <th>First Name</th>
            <th>Second Name</th>


            <th>Age</th>
            <th>HairColor</th>
            <th>EyeColor</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>

            <th>Job Title</th>
            <th>Salary</th></tr></thead>
        ");
            __builder.OpenElement(31, "tbody");
#nullable restore
#line 51 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
         foreach (var adult in showAdults)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "tr");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 54 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                     adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 55 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                     adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 56 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                     adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 58 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                     adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 59 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                     adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 60 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                     adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 61 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                     adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 62 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                     adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 63 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                     adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 64 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                 if (adult.JobTitle != null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 66 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                         adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 67 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                         adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 68 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "<td>No Work</td>\r\n                    ");
            __builder.AddMarkupContent(65, "<td>No Salary</td>");
#nullable restore
#line 73 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 76 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(66, "\r\n        }\r\n        }\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 82 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "D:\dotNetProjects\AssigmentTwo\Assigment01\Assigment01\Pages\ViewAdults.razor"
       
    private IList<Adult> adults;
    private IList<Adult> showAdults;


    protected override async Task OnInitializedAsync()
    {


        Console.WriteLine("Here");
        adults = await FetchAdultsAsync();
        Console.WriteLine(adults);
        showAdults = adults;
    }

    private void FilterId(ChangeEventArgs changeEventArgs)
    {
        int? filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        if (filterById != null)
        {
            showAdults = showAdults.Where(t => t.Id == filterById).ToList();
        }
        else
        {
            showAdults = adults;
        }
    }

    private void FilterFirstName(ChangeEventArgs changeEventArgs)
    {
        String? filterByFirstName = null;
        try
        {
            filterByFirstName = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
        }
        if (filterByFirstName != null)
        {
            showAdults = showAdults.Where(t => t.FirstName.Contains(filterByFirstName)).ToList();
        }
        else
        {
            showAdults = adults;
        }
    }

    private void FilterLastName(ChangeEventArgs changeEventArgs)
    {
        String? filterBySecondName = null;
        try
        {
            filterBySecondName = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
        }
        if (filterBySecondName != null)
        {
            showAdults = showAdults.Where(t => t.LastName.Contains(filterBySecondName)).ToList();
        }

        else
        {
            showAdults = adults;
        }
    }

    private void Reset()
    {
        showAdults = adults;
    }

    public async static Task<IList<Adult>> FetchAdultsAsync()
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:5003/Adults");
        if (!responseMessage.IsSuccessStatusCode)
            throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        string result = await responseMessage.Content.ReadAsStringAsync();
        IList<Adult> adults = JsonSerializer.Deserialize<IList<Adult>>(result,
            new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
        return adults;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext FileContext { get; set; }
    }
}
#pragma warning restore 1591
