#pragma checksum "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowSpecificOrder\ShowSpecificOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d4de858481c74b1d63817cd263084876612fb7b"
// <auto-generated/>
#pragma warning disable 1591
namespace MQtraining.UI.Pages.ShowSpecificOrder
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\_Imports.razor"
using MQtraining.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\_Imports.razor"
using MQtraining.UI.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/order/{OrderId:guid}")]
    public partial class ShowSpecificOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ShowSpecificOrder</h3>");
#nullable restore
#line 7 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowSpecificOrder\ShowSpecificOrder.razor"
 if (OrderResponse == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowSpecificOrder\ShowSpecificOrder.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "tr");
#nullable restore
#line 15 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowSpecificOrder\ShowSpecificOrder.razor"
         foreach (var lineItem in OrderResponse.LineItems)
         {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "td");
            __builder.AddContent(4, 
#nullable restore
#line 18 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowSpecificOrder\ShowSpecificOrder.razor"
                 lineItem.Item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowSpecificOrder\ShowSpecificOrder.razor"

         }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowSpecificOrder\ShowSpecificOrder.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
