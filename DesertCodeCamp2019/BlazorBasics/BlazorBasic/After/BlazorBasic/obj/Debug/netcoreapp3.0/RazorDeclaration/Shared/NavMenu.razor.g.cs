#pragma checksum "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\BlazorBasic\After\BlazorBasic\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30150f5e335a10b466def3be989cdc12dc6ed8e7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorBasic.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\BlazorBasic\After\BlazorBasic\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\BlazorBasic\After\BlazorBasic\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\BlazorBasic\After\BlazorBasic\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\BlazorBasic\After\BlazorBasic\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\BlazorBasic\After\BlazorBasic\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\BlazorBasic\After\BlazorBasic\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\BlazorBasic\After\BlazorBasic\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\BlazorBasic\After\BlazorBasic\_Imports.razor"
using BlazorBasic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\BlazorBasic\After\BlazorBasic\_Imports.razor"
using BlazorBasic.Shared;

#line default
#line hidden
#nullable disable
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\BlazorBasic\After\BlazorBasic\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
