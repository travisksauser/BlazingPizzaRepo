#pragma checksum "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\SignInOptions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "960223e2add0904ff30620568fe76c4e833a2373"
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
    public partial class SignInOptions : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dialog-container");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 1 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\SignInOptions.razor"
                                         Exit

#line default
#line hidden
            ));
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "dialog");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 2 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\SignInOptions.razor"
                                   Continue

#line default
#line hidden
            ));
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "dialog-title btn-close-cnt");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\SignInOptions.razor"
                                                           Continue

#line default
#line hidden
            ));
            __builder.AddMarkupContent(11, "\r\n            \r\n            ");
            __builder.AddMarkupContent(12, "<h2>Sign in</h2>\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "class", "signin-close");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 7 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\SignInOptions.razor"
                                                   Exit

#line default
#line hidden
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, @"<form class=""dialog-signin-body"">            
            <div class=""signin-row"">
                <div class=""signin-vl"">
                    <span class=""signin-vl-innertext"">or</span>
                </div>

                <div class=""signin-col"">
                    <button type=""button"" class=""loginBtn loginBtn--facebook"">Login with Facebook</button>
                    <button type=""button"" class=""loginBtn loginBtn--google"">Login with Google</button>
                    <button type=""button"" class=""loginBtn loginBtn--twitter"">Login with Twitter</button>
                </div>

                <div class=""signin-col"">
                    <div class=""hide-md-lg"">
                        <p>Or sign in manually:</p>
                    </div>

                    <input type=""text"" name=""username"" placeholder=""Username"" required>
                    <input type=""password"" name=""password"" placeholder=""Password"" required>
                    <input type=""submit"" value=""Login"">
                </div>
            </div>
        </form>

        ");
            __builder.AddMarkupContent(22, "<div class=\"dialog-buttons\">\r\n            <button class=\"btn btn-outline-dark mr-auto\">Sign up</button>\r\n            <button class=\"btn btn-outline-dark ml-auto\">Forgot password?</button>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.AddMarkupContent(25, "<style>\r\n    * {\r\n        box-sizing: border-box;\r\n    }\r\n\r\n    input,\r\n    .btn-signin {\r\n        width: 100%;\r\n        padding: 12px;\r\n        border: 1px thin black;\r\n        border-radius: 4px;\r\n        margin: 5px 0;\r\n        opacity: 0.85;\r\n        display: inline-block;\r\n        font-size: 17px;\r\n        line-height: 20px;\r\n        text-decoration: none;\r\n    }\r\n\r\n        input:hover,\r\n        .btn-signin:hover {\r\n            opacity: 1;\r\n        }\r\n\r\n        input[type=submit] {\r\n            background-color: #4CAF50;\r\n            border: 1px thin black;\r\n            border-radius: 4px;\r\n            color: white;\r\n            cursor: pointer;\r\n        }\r\n\r\n            input[type=submit]:hover {\r\n                background-color: #45a049;\r\n            }\r\n\r\n    .signin-col {\r\n        float: left;\r\n        width: 50%;\r\n        margin: auto;\r\n        padding: 0 50px;\r\n        margin-top: 6px;\r\n        flex: 25%;\r\n    }\r\n\r\n    .signin-row:after {\r\n        content: \"\";\r\n        display: table;\r\n        clear: both;\r\n        display: flex;\r\n        flex-wrap: wrap;\r\n    }\r\n\r\n    .signin-vl {\r\n        position: absolute;\r\n        left: 50%;\r\n        transform: translate(-50%);\r\n        border: 1px solid #ddd;\r\n        height: 185px;\r\n    }\r\n\r\n    .signin-vl-innertext {\r\n        position: absolute;\r\n        top: 50%;\r\n        transform: translate(-50%, -50%);\r\n        background-color: white;\r\n        border: 1px solid #ccc;\r\n        border-radius: 20%;\r\n        padding: 8px 10px;\r\n    }\r\n\r\n    .hide-md-lg {\r\n        display: none;\r\n    }\r\n\r\n    @media screen and (max-width: 650px) {\r\n        .signin-col {\r\n            width: 100%;\r\n            margin-top: 0;\r\n        }\r\n\r\n        .signin-row {\r\n            flex-direction: column;\r\n        }\r\n\r\n        .signin-vl {\r\n            display: none;\r\n        }\r\n\r\n        .hide-md-lg {\r\n            display: block;\r\n            text-align: center;\r\n        }\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#line 138 "C:\dev\blazor-workshop-master\save-points\00-Starting-point\BlazingPizza.Client\Shared\SignInOptions.razor"
       
    [Parameter]
    public EventCallback Continue { get; set; }

    [Parameter]
    public EventCallback Exit { get; set; }

    [Parameter]
    public UserInfo UserInfo { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
