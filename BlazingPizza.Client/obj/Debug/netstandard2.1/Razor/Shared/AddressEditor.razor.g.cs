#pragma checksum "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55acc93941fff0b8d70df87055e4226e821c46e8"
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
    public partial class AddressEditor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-field");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<label>Full Name:</label>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
            __builder.AddAttribute(7, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 5 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
                                Address.Name

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.Name = __value, Address.Name))));
            __builder.AddAttribute(9, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Address.Name));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n        ");
            __Blazor.BlazingPizza.Client.Shared.AddressEditor.TypeInference.CreateValidationMessage_0(__builder, 11, 12, 
#line 6 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
                                  () => Address.Name

#line default
#line hidden
            );
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-field");
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.AddMarkupContent(19, "<label>Address Line 1:</label>\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
            __builder.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 13 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
                                Address.Line1

#line default
#line hidden
            ));
            __builder.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.Line1 = __value, Address.Line1))));
            __builder.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Address.Line1));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __Blazor.BlazingPizza.Client.Shared.AddressEditor.TypeInference.CreateValidationMessage_1(__builder, 27, 28, 
#line 14 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
                                  () => Address.Line1

#line default
#line hidden
            );
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-field");
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.AddMarkupContent(35, "<label>Line 2:</label>\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
            __builder.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 21 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
                                Address.Line2

#line default
#line hidden
            ));
            __builder.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.Line2 = __value, Address.Line2))));
            __builder.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Address.Line2));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n        ");
            __Blazor.BlazingPizza.Client.Shared.AddressEditor.TypeInference.CreateValidationMessage_2(__builder, 43, 44, 
#line 22 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
                                  () => Address.Line2

#line default
#line hidden
            );
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-field");
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.AddMarkupContent(51, "<label>City:</label>\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(54);
            __builder.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 29 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
                                Address.City

#line default
#line hidden
            ));
            __builder.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.City = __value, Address.City))));
            __builder.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Address.City));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n        ");
            __Blazor.BlazingPizza.Client.Shared.AddressEditor.TypeInference.CreateValidationMessage_3(__builder, 59, 60, 
#line 30 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
                                  () => Address.City

#line default
#line hidden
            );
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-field");
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.AddMarkupContent(67, "<label>Region:</label>\r\n    ");
            __builder.OpenElement(68, "div");
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
            __builder.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 37 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
                                Address.Region

#line default
#line hidden
            ));
            __builder.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.Region = __value, Address.Region))));
            __builder.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Address.Region));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n        ");
            __Blazor.BlazingPizza.Client.Shared.AddressEditor.TypeInference.CreateValidationMessage_4(__builder, 75, 76, 
#line 38 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
                                  () => Address.Region

#line default
#line hidden
            );
            __builder.AddMarkupContent(77, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "form-field");
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.AddMarkupContent(83, "<label>Postal code:</label>\r\n    ");
            __builder.OpenElement(84, "div");
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(86);
            __builder.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 45 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
                                Address.PostalCode

#line default
#line hidden
            ));
            __builder.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Address.PostalCode = __value, Address.PostalCode))));
            __builder.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Address.PostalCode));
            __builder.CloseComponent();
            __builder.AddMarkupContent(90, "\r\n        ");
            __Blazor.BlazingPizza.Client.Shared.AddressEditor.TypeInference.CreateValidationMessage_5(__builder, 91, 92, 
#line 46 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
                                  () => Address.PostalCode

#line default
#line hidden
            );
            __builder.AddMarkupContent(93, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 50 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\AddressEditor.razor"
       

    [Parameter]
    public Address Address { get; set; }


#line default
#line hidden
    }
}
namespace __Blazor.BlazingPizza.Client.Shared.AddressEditor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
