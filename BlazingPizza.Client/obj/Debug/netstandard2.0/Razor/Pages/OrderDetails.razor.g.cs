#pragma checksum "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c0fd77c96f4973219ec62cfba91b8ebc375513c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 10 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
#line 11 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary.Map;

#line default
#line hidden
#line 12 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\_Imports.razor"
using BlazingComponents;

#line default
#line hidden
#line 2 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
using System.Threading;

#line default
#line hidden
#line 5 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/myorders/{orderId:int}")]
    public partial class OrderDetails : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n");
#line 8 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
     if (invalidOrder)
    {


#line default
#line hidden
            __builder.AddContent(3, "        ");
            __builder.AddMarkupContent(4, "<h2>Nope</h2>\r\n        ");
            __builder.AddMarkupContent(5, "<p>Sorry, this order could not be loaded.</p>\r\n        ");
            __builder.AddMarkupContent(6, "<a class=\"btn btn-outline-danger\" href=\"/checkout\">Try again</a>\r\n");
#line 14 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"

    }
    else if (orderWithStatus == null)
    {
        

#line default
#line hidden
            __builder.AddContent(7, "Loading...");
#line 18 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                               
    }
     else
    {

#line default
#line hidden
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "track-order");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "track-order-title");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "h2");
            __builder.AddMarkupContent(16, "\r\n                    Order placed ");
            __builder.AddContent(17, 
#line 25 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                                  orderWithStatus.Order.CreatedTime.ToLongDateString()

#line default
#line hidden
            );
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "p");
            __builder.AddAttribute(21, "class", "ml-auto mb-0");
            __builder.AddMarkupContent(22, "\r\n                    Status: ");
            __builder.OpenElement(23, "strong");
            __builder.AddContent(24, 
#line 28 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                                     orderWithStatus.StatusText

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "track-order-body");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "track-order-details");
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenComponent<BlazingPizza.Client.Shared.OrderReview>(34);
            __builder.AddAttribute(35, "Order", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Order>(
#line 34 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                                         orderWithStatus.Order

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "track-order-map");
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenComponent<BlazingPizza.ComponentsLibrary.Map.Map>(41);
            __builder.AddAttribute(42, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 37 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                               12

#line default
#line hidden
            ));
            __builder.AddAttribute(43, "Markers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazingPizza.ComponentsLibrary.Map.Marker>>(
#line 37 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                                            orderWithStatus.MapMarkers

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#line 41 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 44 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
       
    [Parameter] public int OrderId { get; set; }

    OrderWithStatus orderWithStatus;
    bool invalidOrder;
    CancellationTokenSource pollingCancellationToken;

    protected override void OnParametersSet() // component lifecycle method, component first initiated and parameters change value
    {
        // If we were already polling for a different order, stop doing so
        pollingCancellationToken?.Cancel();

        // Start a new poll loop
        PollForUpdates();
    }

    private async void PollForUpdates()
    {
        pollingCancellationToken = new CancellationTokenSource();
        while (!pollingCancellationToken.IsCancellationRequested)
        {
            try
            {
                invalidOrder = false;
                orderWithStatus = await HttpClient.GetJsonAsync<OrderWithStatus>($"orders/{OrderId}");
            }
            catch (Exception ex)
            {
                invalidOrder = true;
                pollingCancellationToken.Cancel();
                Console.Error.WriteLine(ex);
            }

            StateHasChanged();
        }
    }

    void IDisposable.Dispose()
    {
        pollingCancellationToken?.Cancel();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
