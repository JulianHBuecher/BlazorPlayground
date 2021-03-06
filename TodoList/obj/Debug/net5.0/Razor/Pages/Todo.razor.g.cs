#pragma checksum "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2f938de9b10286b360dc1b16e5983f7e8d02fa8"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\_Imports.razor"
using TodoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\_Imports.razor"
using TodoList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\_Imports.razor"
using TodoList.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Todo (");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\Pages\Todo.razor"
           todos.Count(todo => !todo.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "ul");
            __Blazor.TodoList.Pages.Todo.TypeInference.CreateVirtualize_0(__builder, 6, 7, 
#nullable restore
#line 6 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\Pages\Todo.razor"
                                      todos

#line default
#line hidden
#nullable disable
            , 8, (todo) => (__builder2) => {
                __builder2.OpenElement(9, "li");
                __builder2.OpenElement(10, "input");
                __builder2.AddAttribute(11, "type", "checkbox");
                __builder2.AddAttribute(12, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\Pages\Todo.razor"
                                          todo.IsDone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.IsDone = __value, todo.IsDone));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\Pages\Todo.razor"
                          todo.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.Title = __value, todo.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "placeholder", "Something to do...");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\Pages\Todo.razor"
                                               newTodoTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodoTitle = __value, newTodoTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-primary");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\Pages\Todo.razor"
                                          AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Add todo");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Julian\source\repos\HelloWorldBlazorApp\TodoList\Pages\Todo.razor"
       
    // Blazor uses in standard mode the open iconic icons

    private IList<TodoItem> todos = new List<TodoItem>();
    private string newTodoTitle;
    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodoTitle))
        {
            todos.Add(new TodoItem
            {
                Title = newTodoTitle,
                IsDone = false
            });
            newTodoTitle = string.Empty;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TodoList.Pages.Todo
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateVirtualize_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.ICollection<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
