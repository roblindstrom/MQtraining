#pragma checksum "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\CreateItem\CreateItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4235a8a8a8221b10e4291653b04bb7601f3ce9ac"
// <auto-generated/>
#pragma warning disable 1591
namespace MQtraining.UI.Pages.CreateItem
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/createitem")]
    public partial class CreateItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateItem</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\CreateItem\CreateItem.razor"
                  ItemRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\CreateItem\CreateItem.razor"
                                               HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label for=\"name\">name: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "lastName");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "placeholder", "Enter name");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\CreateItem\CreateItem.razor"
                                                                    ItemRequest.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ItemRequest.Name = __value, ItemRequest.Name))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ItemRequest.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __Blazor.MQtraining.UI.Pages.CreateItem.CreateItem.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 13 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\CreateItem\CreateItem.razor"
                                  () => ItemRequest.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "<label for=\"price\">price: </label>\r\n        ");
                __Blazor.MQtraining.UI.Pages.CreateItem.CreateItem.TypeInference.CreateInputNumber_1(__builder2, 26, 27, "firstName", 28, "form-control", 29, "Enter price", 30, 
#nullable restore
#line 18 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\CreateItem\CreateItem.razor"
                                                                       ItemRequest.Price

#line default
#line hidden
#nullable disable
                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ItemRequest.Price = __value, ItemRequest.Price)), 32, () => ItemRequest.Price);
                __builder2.AddMarkupContent(33, "\r\n        ");
                __Blazor.MQtraining.UI.Pages.CreateItem.CreateItem.TypeInference.CreateValidationMessage_2(__builder2, 34, 35, 
#nullable restore
#line 19 "C:\Users\Pontus\Desktop\MqMedRob\MQtraining\MQtraining.UI\Pages\CreateItem\CreateItem.razor"
                                  () => ItemRequest.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n    \r\n    ");
                __builder2.AddMarkupContent(37, "<button type=\"submit\" class=\"btn btn-primary\">Save product</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.MQtraining.UI.Pages.CreateItem.CreateItem
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
