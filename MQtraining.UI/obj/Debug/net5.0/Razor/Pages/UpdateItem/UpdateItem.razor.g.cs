#pragma checksum "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\UpdateItem\UpdateItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ae2aa3576f9d3a87667055369ee525eca769e08"
// <auto-generated/>
#pragma warning disable 1591
namespace MQtraining.UI.Pages.UpdateItem
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/itemedit/{ItemId:guid}")]
    public partial class UpdateItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>UpdateItem</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "section");
            __builder.OpenElement(2, "h1");
            __builder.AddAttribute(3, "class", "page-title");
            __builder.AddContent(4, "Details for ");
            __builder.AddContent(5, 
#nullable restore
#line 8 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\UpdateItem\UpdateItem.razor"
                                        ItemResponse.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.AddContent(7, 
#nullable restore
#line 8 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\UpdateItem\UpdateItem.razor"
                                                           ItemResponse.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\UpdateItem\UpdateItem.razor"
                      ItemResponse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\UpdateItem\UpdateItem.razor"
                                                    HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddContent(18, 
#nullable restore
#line 16 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\UpdateItem\UpdateItem.razor"
             ItemId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group row");
                __builder2.AddMarkupContent(22, "<label for=\"Name\" class=\"col-sm-3\">Name: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "Name");
                __builder2.AddAttribute(25, "class", "form-control col-sm-8");
                __builder2.AddAttribute(26, "placeholder", "Enter item name");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\UpdateItem\UpdateItem.razor"
                                               ItemResponse.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ItemResponse.Name = __value, ItemResponse.Name))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ItemResponse.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __Blazor.MQtraining.UI.Pages.UpdateItem.UpdateItem.TypeInference.CreateValidationMessage_0(__builder2, 31, 32, 
#nullable restore
#line 21 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\UpdateItem\UpdateItem.razor"
                                      () => ItemResponse.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group row");
                __builder2.AddMarkupContent(36, "<label for=\"Price\" class=\"col-sm-3\">Price: </label>\r\n            ");
                __Blazor.MQtraining.UI.Pages.UpdateItem.UpdateItem.TypeInference.CreateInputNumber_1(__builder2, 37, 38, "price", 39, "form-control col-sm-8", 40, "Enter item price", 41, 
#nullable restore
#line 26 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\UpdateItem\UpdateItem.razor"
                                                                                ItemResponse.Price

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ItemResponse.Price = __value, ItemResponse.Price)), 43, () => ItemResponse.Price);
                __builder2.AddMarkupContent(44, "\r\n            ");
                __Blazor.MQtraining.UI.Pages.UpdateItem.UpdateItem.TypeInference.CreateValidationMessage_2(__builder2, 45, 46, 
#nullable restore
#line 27 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\UpdateItem\UpdateItem.razor"
                                      () => ItemResponse.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n        ");
                __builder2.OpenElement(48, "button");
                __builder2.AddAttribute(49, "type", "submit");
                __builder2.AddAttribute(50, "class", "btn btn-primary");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Robin\source\repos\MQtraining\MQtraining.UI\Pages\UpdateItem\UpdateItem.razor"
                                                                () => HandleValidSubmit()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(52, "Save item");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.MQtraining.UI.Pages.UpdateItem.UpdateItem
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