#pragma checksum "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\MyOrders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bd596b3cfe6fdaf15152467fb85905f46d295e3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazingPizza.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 9 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#line 11 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
#line 12 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary.Map;

#line default
#line hidden
#line 13 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using BlazingComponents;

#line default
#line hidden
#line 3 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\MyOrders.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/myorders")]
    public partial class MyOrders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 32 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\MyOrders.razor"
       
    List<OrderWithStatus> ordersWithStatus;

    Task<List<OrderWithStatus>> LoadOrders()
    {
        return HttpClient.GetJsonAsync<List<OrderWithStatus>>("orders");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
