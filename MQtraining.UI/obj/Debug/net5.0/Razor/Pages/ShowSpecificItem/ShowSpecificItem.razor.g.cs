#pragma checksum "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\ShowSpecificItem\ShowSpecificItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ade69fac809c12b2a0b84ba5f740a9ebab0fca4f"
// <auto-generated/>
#pragma warning disable 1591
namespace MQtraining.UI.Pages.ShowSpecificItem
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\_Imports.razor"
using MQtraining.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\_Imports.razor"
using MQtraining.UI.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/items/{ItemId:guid}")]
    public partial class ShowSpecificItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\ShowSpecificItem\ShowSpecificItem.razor"
 if (ItemResponse == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\ShowSpecificItem\ShowSpecificItem.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "tr");
            __builder.OpenElement(2, "td");
            __builder.AddContent(3, 
#nullable restore
#line 13 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\ShowSpecificItem\ShowSpecificItem.razor"
         ItemId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 16 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\ShowSpecificItem\ShowSpecificItem.razor"
         ItemResponse.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 19 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\ShowSpecificItem\ShowSpecificItem.razor"
         ItemResponse.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\ShowSpecificItem\ShowSpecificItem.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
