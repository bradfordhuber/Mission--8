#pragma checksum "C:\Users\strik\OneDrive\Documents\GitHub\Mission--8\Mission-8\Mission 7\Mission 7\Pages\Admin\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edaf52304b4b987d48028942ade45a33db8810f5"
// <auto-generated/>
#pragma warning disable 1591
namespace Mission_7.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\strik\OneDrive\Documents\GitHub\Mission--8\Mission-8\Mission 7\Mission 7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\strik\OneDrive\Documents\GitHub\Mission--8\Mission-8\Mission 7\Mission 7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\strik\OneDrive\Documents\GitHub\Mission--8\Mission-8\Mission 7\Mission 7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\strik\OneDrive\Documents\GitHub\Mission--8\Mission-8\Mission 7\Mission 7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\strik\OneDrive\Documents\GitHub\Mission--8\Mission-8\Mission 7\Mission 7\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\strik\OneDrive\Documents\GitHub\Mission--8\Mission-8\Mission 7\Mission 7\Pages\Admin\_Imports.razor"
using Mission_7.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"bg-info text-white p-2\">\r\n    <span class=\"navbar-brand m-lg-2\">Book Store Admin</span>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row p-2");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-3");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            __builder.AddAttribute(11, "class", "btn btn-block btn-outline-primary");
            __builder.AddAttribute(12, "href", "/admin/books");
            __builder.AddAttribute(13, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(14, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "C:\Users\strik\OneDrive\Documents\GitHub\Mission--8\Mission-8\Mission 7\Mission 7\Pages\Admin\AdminLayout.razor"
                                                                 NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(16, "Books");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "class", "btn btn-block btn-outline-primary");
            __builder.AddAttribute(20, "href", "/admin/payments");
            __builder.AddAttribute(21, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(22, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 15 "C:\Users\strik\OneDrive\Documents\GitHub\Mission--8\Mission-8\Mission 7\Mission 7\Pages\Admin\AdminLayout.razor"
                                                                 NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(24, "Payments");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.AddContent(30, 
#nullable restore
#line 21 "C:\Users\strik\OneDrive\Documents\GitHub\Mission--8\Mission-8\Mission 7\Mission 7\Pages\Admin\AdminLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
