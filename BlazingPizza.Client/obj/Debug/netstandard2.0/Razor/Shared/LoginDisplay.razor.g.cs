#pragma checksum "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4710f74562eb41da7056d82a29e44e16b284500"
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
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "user-info");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.AddMarkupContent(6, "<text>Checking...</text>\r\n        ");
            }
            ));
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n            <img src=\"img/user.svg\">\r\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddMarkupContent(10, "\r\n                ");
                __builder2.OpenElement(11, "span");
                __builder2.AddAttribute(12, "class", "username");
                __builder2.AddContent(13, 
#line 10 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\LoginDisplay.razor"
                                        context.User.Identity.Name

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.AddMarkupContent(15, "<a class=\"sign-out\" href=\"user/signout\">Sign out</a>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
            }
            ));
            __builder.AddAttribute(17, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenElement(19, "a");
                __builder2.AddAttribute(20, "class", "sign-in");
                __builder2.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 15 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\LoginDisplay.razor"
                                           () => OnClick.InvokeAsync(true)

#line default
#line hidden
                ));
                __builder2.AddContent(22, "Sign in");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 20 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\LoginDisplay.razor"
       
    
    [Parameter]
    public EventCallback<bool> OnClick { get; set; }
    #region
    

#line default
#line hidden
#line 28 "C:\dev\blazor-workshop-master\save-points\BlazingPizza\BlazingPizza.Client\Shared\LoginDisplay.razor"
                                                                    
    //public event Action<bool> OnLoginClick;

    // NotifyService class communication
    //protected async void ShowSignInOptions()
    //{
    //    OrderState.showingSignInOptions = true;
    //    await NotifierService.Update();
    //}
    #endregion

#line default
#line hidden
    }
}
#pragma warning restore 1591
