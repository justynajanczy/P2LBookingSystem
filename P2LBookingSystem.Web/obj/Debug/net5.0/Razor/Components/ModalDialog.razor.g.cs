#pragma checksum "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a575e6579f4455eeb480cf940463dc14247661f4"
// <auto-generated/>
#pragma warning disable 1591
namespace P2LBookingSystem.Web.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\_Imports.razor"
using P2LBookingSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\_Imports.razor"
using P2LBookingSystem.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class ModalDialog : ModelDialogBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "id", "myModal");
            __builder.AddAttribute(3, "style", "display:block; background-color: rgba(10,10,10,.8)");
            __builder.AddAttribute(4, "aria-modal", "true");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.OpenElement(12, "h4");
            __builder.AddAttribute(13, "class", "modal-title");
            __builder.AddContent(14, "Booking Resource ");
            __builder.AddContent(15, 
#nullable restore
#line 7 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                                                          Resource.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "close");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                                                               ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(25);
            __builder.AddAttribute(26, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                                  newBooking

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(28);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label for=\"datefrom\">Date from: </label>\r\n                        ");
                __Blazor.P2LBookingSystem.Web.Components.ModalDialog.TypeInference.CreateInputDate_0(__builder2, 33, 34, "datefrom", 35, "form-control valid", 36, 
#nullable restore
#line 15 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                                                                                         newBooking.DateFrom

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBooking.DateFrom = __value, newBooking.DateFrom)), 38, () => newBooking.DateFrom);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "<label for=\"dateto\">Date to: </label>\r\n                        ");
                __Blazor.P2LBookingSystem.Web.Components.ModalDialog.TypeInference.CreateInputDate_1(__builder2, 43, 44, "dateto", 45, "form-control valid", 46, 
#nullable restore
#line 19 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                                                                                       newBooking.DateTo

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBooking.DateTo = __value, newBooking.DateTo)), 48, () => newBooking.DateTo);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "<p>Quantity: </p>\r\n                        ");
                __Blazor.P2LBookingSystem.Web.Components.ModalDialog.TypeInference.CreateInputNumber_2(__builder2, 53, 54, "form-control", 55, 
#nullable restore
#line 23 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                                                                       newBooking.BookedQuantity

#line default
#line hidden
#nullable disable
                , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBooking.BookedQuantity = __value, newBooking.BookedQuantity)), 57, () => newBooking.BookedQuantity);
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __Blazor.P2LBookingSystem.Web.Components.ModalDialog.TypeInference.CreateValidationMessage_3(__builder2, 59, 60, 
#nullable restore
#line 24 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                                                  () => newBooking.BookedQuantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "div");
#nullable restore
#line 28 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                     switch (TextType)
                    {
                        case StatusOfText.Success:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "style", "color: green");
            __builder.AddContent(65, 
#nullable restore
#line 31 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                                                       Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 32 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                            break;
                        case StatusOfText.Error:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "style", "color: red");
            __builder.AddContent(68, 
#nullable restore
#line 34 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                                                     Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 35 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                            break;
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "modal-footer");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "type", "button");
            __builder.AddAttribute(74, "class", "btn btn-primary");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\STUDIA\P2LBookingSystem\P2LBookingSystem.Web\Components\ModalDialog.razor"
                                                                         ModalBook

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(76, "Book");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.P2LBookingSystem.Web.Components.ModalDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
