#pragma checksum "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingComponents\TemplatedDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68c03e06e5287ebca66cb68d361731b87a14c14c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class TemplatedDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 1 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingComponents\TemplatedDialog.razor"
 if (Show)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "dialog-container");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingComponents\TemplatedDialog.razor"
                                             Exit

#line default
#line hidden
            ));
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "dialog");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.AddContent(8, 
#line 5 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingComponents\TemplatedDialog.razor"
             ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#line 8 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingComponents\TemplatedDialog.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 10 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingComponents\TemplatedDialog.razor"
       
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public bool Show { get; set; }
    [Parameter] public EventCallback Exit { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
