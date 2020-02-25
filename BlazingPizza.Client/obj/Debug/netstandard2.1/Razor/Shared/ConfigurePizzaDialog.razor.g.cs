#pragma checksum "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3e554f96cfaac6b2f622d9ded3db5da86a31552"
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
    public partial class ConfigurePizzaDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dialog-container");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                         Exit

#line default
#line hidden
            ));
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "dialog");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 4 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                   Continue

#line default
#line hidden
            ));
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "dialog-title");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 5 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                             Continue

#line default
#line hidden
            ));
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "h2");
            __builder.AddContent(13, 
#line 6 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                 Pizza.Special.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.AddContent(15, 
#line 7 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
             Pizza.Special.Description

#line default
#line hidden
            );
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "form");
            __builder.AddAttribute(19, "class", "dialog-body");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 9 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                             Continue

#line default
#line hidden
            ));
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<label>Size:</label>\r\n                ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "range");
            __builder.AddAttribute(27, "min", 
#line 12 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                          Pizza.MinimumSize

#line default
#line hidden
            );
            __builder.AddAttribute(28, "max", 
#line 12 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                   Pizza.MaximumSize

#line default
#line hidden
            );
            __builder.AddAttribute(29, "step", "1");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 12 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                                                       Pizza.Size

#line default
#line hidden
            ));
            __builder.AddAttribute(31, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pizza.Size = __value, Pizza.Size));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "class", "size-label");
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.AddContent(36, 
#line 14 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                      Pizza.Size

#line default
#line hidden
            );
            __builder.AddContent(37, "\" ($");
            __builder.AddContent(38, 
#line 14 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                       Pizza.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.AddMarkupContent(39, ")\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.AddMarkupContent(44, "<label>Extra Toppings:</label>\r\n");
#line 19 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                 if (toppings == null)
                {

#line default
#line hidden
            __builder.AddContent(45, "                    ");
            __builder.OpenElement(46, "select");
            __builder.AddAttribute(47, "class", "custom-select");
            __builder.AddAttribute(48, "disabled", true);
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "option");
            __builder.AddContent(51, "(loading...)");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#line 24 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }
                else if (Pizza.Toppings.Count >= 6)
                {

#line default
#line hidden
            __builder.AddContent(54, "                    ");
            __builder.AddMarkupContent(55, "<div>(maximum reached)</div>\r\n");
#line 28 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }
                else
                {

#line default
#line hidden
            __builder.AddContent(56, "                    ");
            __builder.OpenElement(57, "select");
            __builder.AddAttribute(58, "class", "custom-select");
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 31 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                              ToppingSelected

#line default
#line hidden
            ));
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.OpenElement(61, "option");
            __builder.AddAttribute(62, "value", "-1");
            __builder.AddAttribute(63, "disabled", true);
            __builder.AddAttribute(64, "selected", true);
            __builder.AddContent(65, "(select)");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#line 33 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                         for (var i = 0; i < toppings.Count; i++)
                        {

#line default
#line hidden
            __builder.AddContent(67, "                            ");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", 
#line 35 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                            i

#line default
#line hidden
            );
            __builder.AddContent(70, 
#line 35 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                toppings[i].Name

#line default
#line hidden
            );
            __builder.AddContent(71, " - ($");
            __builder.AddContent(72, 
#line 35 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                       toppings[i].GetFormattedPrice()

#line default
#line hidden
            );
            __builder.AddContent(73, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#line 36 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                        }

#line default
#line hidden
            __builder.AddContent(75, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
#line 38 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }

#line default
#line hidden
            __builder.AddContent(77, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "toppings");
            __builder.AddMarkupContent(81, "\r\n");
#line 41 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                 foreach (var topping in Pizza.Toppings)
                {

#line default
#line hidden
            __builder.AddContent(82, "                    ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "topping");
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.AddContent(86, 
#line 44 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                         topping.Topping.Name

#line default
#line hidden
            );
            __builder.AddMarkupContent(87, "\r\n                        ");
            __builder.OpenElement(88, "span");
            __builder.AddAttribute(89, "class", "topping-price");
            __builder.AddContent(90, 
#line 45 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                     topping.Topping.GetFormattedPrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                        ");
            __builder.OpenElement(92, "button");
            __builder.AddAttribute(93, "type", "button");
            __builder.AddAttribute(94, "class", "delete-topping");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 46 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                                 () => RemoveTopping(topping.Topping)

#line default
#line hidden
            ));
            __builder.AddContent(96, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
#line 48 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }

#line default
#line hidden
            __builder.AddContent(99, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "dialog-buttons");
            __builder.AddMarkupContent(104, "\r\n            ");
            __builder.OpenElement(105, "button");
            __builder.AddAttribute(106, "class", "btn btn-danger mr-auto");
            __builder.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 52 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                              OnCancel

#line default
#line hidden
            ));
            __builder.AddContent(108, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n            ");
            __builder.OpenElement(110, "span");
            __builder.AddAttribute(111, "class", "mr-center");
            __builder.AddMarkupContent(112, "\r\n                Price: ");
            __builder.OpenElement(113, "span");
            __builder.AddAttribute(114, "class", "price");
            __builder.AddContent(115, 
#line 54 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                             Pizza.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n            ");
            __builder.OpenElement(118, "button");
            __builder.AddAttribute(119, "class", "btn btn-success ml-auto");
            __builder.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 56 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                               OnConfirm

#line default
#line hidden
            ));
            __builder.AddContent(121, "Order >");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 61 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
       
    [Parameter]
    public Pizza Pizza { get; set; }

    [Parameter]
    public EventCallback OnCancel { get; set; }

    [Parameter]
    public EventCallback OnConfirm { get; set; }

    [Parameter]
    public EventCallback Continue { get; set; }

    [Parameter]
    public EventCallback Exit { get; set; }

    List<Topping> toppings;

    protected async override Task OnInitializedAsync()
    {
        toppings = await HttpClient.GetJsonAsync<List<Topping>>("toppings");
    }

    void ToppingSelected(ChangeEventArgs e)
    {
        if (int.TryParse((string)e.Value, out var index) && index >= 0)
        {
            AddTopping(toppings[index]);
        }
    }

    void AddTopping(Topping topping)
    {
        if (Pizza.Toppings.Find(pt => pt.Topping == topping) == null)
        {
            Pizza.Toppings.Add(new PizzaTopping() { Topping = topping });
        }
    }

    void RemoveTopping(Topping topping)
    {
        Pizza.Toppings.RemoveAll(pt => pt.Topping == topping);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591