#pragma checksum "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ad8e67e71f16fb0ece3f6a0efeae3f2575765c7"
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
#line 10 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
     if (invalidOrder)
    {

#line default
#line hidden
            __builder.AddContent(3, "        ");
            __builder.AddMarkupContent(4, "<h2>Nope</h2>\r\n        ");
            __builder.AddMarkupContent(5, "<p>Sorry, this order could not be loaded.</p>\r\n");
#line 18 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
           
    }
    else if (orderWithStatus == null)
    {
        

#line default
#line hidden
            __builder.AddContent(6, "Loading...");
#line 22 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                               
    }
    else
    {

#line default
#line hidden
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "track-order");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "track-order-title");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "h2");
            __builder.AddMarkupContent(15, "\r\n                    Order placed ");
            __builder.AddContent(16, 
#line 29 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                                  orderWithStatus.Order.CreatedTime.ToLongDateString()

#line default
#line hidden
            );
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", "ml-auto mb-0");
            __builder.AddMarkupContent(21, "\r\n                    Status: ");
            __builder.OpenElement(22, "strong");
            __builder.AddContent(23, 
#line 32 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                                     orderWithStatus.StatusText

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "track-order-body");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "track-order-details");
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenComponent<BlazingPizza.Client.Shared.OrderReview>(33);
            __builder.AddAttribute(34, "Order", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Order>(
#line 38 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                                         orderWithStatus.Order

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "track-order-map");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenComponent<BlazingPizza.ComponentsLibrary.Map.Map>(40);
            __builder.AddAttribute(41, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#line 41 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                               12

#line default
#line hidden
            ));
            __builder.AddAttribute(42, "Markers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazingPizza.ComponentsLibrary.Map.Marker>>(
#line 41 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                                            orderWithStatus.MapMarkers

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#line 45 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 48 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Pages\OrderDetails.razor"
       
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
