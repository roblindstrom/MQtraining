#pragma checksum "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowAllOrders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "168c882553a712eae68ecd3053049d84ac072864"
// <auto-generated/>
#pragma warning disable 1591
namespace MQtraining.UI.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Orders")]
    public partial class ShowAllOrders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ShowAllOrders</h3>");
#nullable restore
#line 5 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowAllOrders.razor"
 if (Orders == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowAllOrders.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Order ID</th>\r\n                <th>Password</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 20 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowAllOrders.razor"
             foreach (var order in Orders)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 24 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowAllOrders.razor"
                        order.OrderId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 27 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowAllOrders.razor"
                         order.Password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowAllOrders.razor"
             }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\ShowAllOrders.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
