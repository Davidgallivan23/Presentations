#pragma checksum "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\Hosted\ClientSide\ClientSide\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "431e65b7b718b433ace4f0ee82c668c3507103a0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ClientSide.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\Hosted\ClientSide\ClientSide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\Hosted\ClientSide\ClientSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\Hosted\ClientSide\ClientSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\Hosted\ClientSide\ClientSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\Hosted\ClientSide\ClientSide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\Hosted\ClientSide\ClientSide\_Imports.razor"
using ClientSide;

#line default
#line hidden
#line 7 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\Hosted\ClientSide\ClientSide\_Imports.razor"
using ClientSide.Shared;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 28 "D:\CodingWithDavid\Conferences\Presentations\DesertCodeCamp2019\BlazorBasics\Hosted\ClientSide\ClientSide\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
