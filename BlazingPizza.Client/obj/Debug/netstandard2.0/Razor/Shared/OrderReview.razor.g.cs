#pragma checksum "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\OrderReview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd7ee685727d06c5aa4a3a5c74cf57cf5edc4891"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Shared
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
    public partial class OrderReview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 2 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\OrderReview.razor"
 foreach (var pizza in Order.Pizzas)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "strong");
            __builder.AddMarkupContent(4, "\r\n            ");
            __builder.AddContent(5, 
#line 6 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\OrderReview.razor"
              pizza.Size

#line default
#line hidden
            );
            __builder.AddMarkupContent(6, "\"\r\n            ");
            __builder.AddContent(7, 
#line 7 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\OrderReview.razor"
             pizza.Special.Name

#line default
#line hidden
            );
            __builder.AddMarkupContent(8, "\r\n            ($");
            __builder.AddContent(9, 
#line 8 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\OrderReview.razor"
               pizza.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.AddMarkupContent(10, ")\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.AddContent(13, "    ");
            __builder.OpenElement(14, "ul");
            __builder.AddMarkupContent(15, "\r\n");
#line 13 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\OrderReview.razor"
         foreach (var topping in pizza.Toppings)
        {

#line default
#line hidden
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "li");
            __builder.AddContent(18, "+ ");
            __builder.AddContent(19, 
#line 15 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\OrderReview.razor"
                   topping.Topping.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#line 16 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\OrderReview.razor"
        }

#line default
#line hidden
            __builder.AddContent(21, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#line 18 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\OrderReview.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "p");
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "strong");
            __builder.AddMarkupContent(27, "\r\n        Total price:\r\n        $");
            __builder.AddContent(28, 
#line 23 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\OrderReview.razor"
          Order.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 27 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\OrderReview.razor"
       
    [Parameter]
    public Order Order { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
