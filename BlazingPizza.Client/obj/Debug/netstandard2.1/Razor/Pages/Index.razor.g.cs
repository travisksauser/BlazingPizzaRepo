#pragma checksum "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8296d0f30988b7a0491d664ebf71957e58b6176f"
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
#line 1 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 9 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#line 10 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pizza-cards");
            __builder.AddMarkupContent(5, "\r\n");
#line 9 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
         if (specials != null)
        {
            

#line default
#line hidden
#line 11 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
             foreach (var special in specials)
            {

#line default
#line hidden
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 13 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                () => OrderState.ShowConfigurePizzaDialog(special)

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#line 13 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                                                                                                    special.ImageUrl

#line default
#line hidden
            ) + "\')");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "pizza-info");
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "class", "title");
            __builder.AddContent(16, 
#line 15 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                             special.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.AddContent(18, 
#line 16 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                         special.Description

#line default
#line hidden
            );
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "class", "price");
            __builder.AddContent(22, 
#line 17 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                             special.GetFormattedBasePrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#line 20 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
            }

#line default
#line hidden
#line 20 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
             
        }

#line default
#line hidden
            __builder.AddContent(26, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "sidebar");
            __builder.AddMarkupContent(31, "\r\n");
#line 26 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
     if (OrderState.Order.Pizzas.Any())
    {

#line default
#line hidden
            __builder.AddContent(32, "        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "order-contents");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.AddMarkupContent(36, "<h2>Your order</h2>\r\n\r\n");
#line 31 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
             foreach (var configuredPizza in OrderState.Order.Pizzas)
            {

#line default
#line hidden
            __builder.AddContent(37, "                ");
            __builder.OpenComponent<BlazingPizza.Client.Shared.ConfiguredPizzaItem>(38);
            __builder.AddAttribute(39, "Pizza", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Pizza>(
#line 33 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                            configuredPizza

#line default
#line hidden
            ));
            __builder.AddAttribute(40, "OnRemoved", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 33 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                                                          () => OrderState.RemoveConfiguredPizza(configuredPizza)

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n");
#line 34 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
            }

#line default
#line hidden
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#line 36 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
            __builder.AddContent(44, "        ");
            __builder.AddMarkupContent(45, "<div class=\"empty-cart\">Choose a pizza<br>to get started</div>\r\n");
#line 40 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
    }

#line default
#line hidden
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "order-total" + " " + (
#line 42 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                              OrderState.Order.Pizzas.Any() ? "" : "hidden"

#line default
#line hidden
            ));
            __builder.AddMarkupContent(49, "\r\n        Total:\r\n        ");
            __builder.OpenElement(50, "span");
            __builder.AddAttribute(51, "class", "total-price");
            __builder.AddContent(52, 
#line 44 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                   OrderState.Order.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "a");
            __builder.AddAttribute(55, "href", "checkout");
            __builder.AddAttribute(56, "class", "btn btn-warning");
            __builder.AddAttribute(57, "disabled", 
#line 45 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                                               OrderState.Order.Pizzas.Count == 0

#line default
#line hidden
            );
            __builder.AddMarkupContent(58, "\r\n            Order >\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n");
#line 51 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
 if (OrderState.showingConfigureDialog)
{

#line default
#line hidden
            __builder.AddContent(62, "    ");
            __builder.OpenComponent<BlazingPizza.Client.Shared.ConfigurePizzaDialog>(63);
            __builder.AddAttribute(64, "Pizza", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Pizza>(
#line 53 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                 OrderState.configuringPizza

#line default
#line hidden
            ));
            __builder.AddAttribute(65, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 54 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                    OrderState.CancelConfigurePizzaDialog

#line default
#line hidden
            )));
            __builder.AddAttribute(66, "OnConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 55 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                     OrderState.ConfirmConfigurePizzaDialog

#line default
#line hidden
            )));
            __builder.AddAttribute(67, "Exit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 56 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                OrderState.ExitConfigurePizzaDialog

#line default
#line hidden
            )));
            __builder.AddAttribute(68, "Continue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 57 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
                                    OrderState.ContinueConfigurePizzaDialog

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n");
#line 58 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 60 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
       

    List<PizzaSpecial> specials;

    //public bool showSignIn = false;

    protected async override Task OnInitializedAsync()
    {
        specials = await HttpClient.GetJsonAsync<List<PizzaSpecial>>("specials");

        //NotifierService.Notify += OnNotify;
    }

    #region
    //Cascading Parameter Communication
    //NotifyService class Communication
    //@if (showSignIn)
    

#line default
#line hidden
#line 79 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Pages\Index.razor"
       
    //[CascadingParameter] MainLayout MainLayout { get; set; }
    //protected override void OnAfterRender(bool firstRender)
    //{
    //    if (firstRender)
    //    {
    //        Console.WriteLine("OnAfterRender");
    //        Console.WriteLine(this.MainLayout.LoginDisplay);
    //        this.MainLayout.LoginDisplay.OnLoginClick += OnLoginClick;
    //    }
    //}

    //private void OnLoginClick(bool show)
    //{
    //    showSignIn = show;
    //    this.StateHasChanged();
    //}
    #endregion
    #region

    //NotifyService Class communication

    ////public async Task OnNotify()
    ////{
    ////    await InvokeAsync(() =>
    ////    {
    ////        StateHasChanged();
    ////    });
    ////}

    ////public void Dispose()
    ////{
    ////    NotifierService.Notify -= OnNotify;
    ////}
    #endregion

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotifierService NotifierService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderState OrderState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
