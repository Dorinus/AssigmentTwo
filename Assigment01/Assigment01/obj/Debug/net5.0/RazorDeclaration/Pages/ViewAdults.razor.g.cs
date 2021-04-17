// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
