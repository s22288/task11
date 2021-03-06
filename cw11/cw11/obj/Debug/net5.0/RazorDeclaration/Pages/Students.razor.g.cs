// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace cw11.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\s22288\Downloads\cw11\cw11\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\s22288\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\s22288\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\s22288\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\s22288\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\s22288\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\s22288\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\s22288\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\s22288\Downloads\cw11\cw11\_Imports.razor"
using cw11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\s22288\Downloads\cw11\cw11\_Imports.razor"
using cw11.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\s22288\Downloads\cw11\cw11\_Imports.razor"
using cw11.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\s22288\Downloads\cw11\cw11\_Imports.razor"
using cw11.Data.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\s22288\Downloads\cw11\cw11\Pages\Students.razor"
       
    public IEnumerable<Student> StudentsList { get; set; }

    protected override void OnInitialized()
    {
        int maxLenght = 10;
        if (StudentService.GetStudents().ToList().Count < 10)
        {
            StudentsList = StudentService.GetStudents();
        }

    }
    private void sortByName()
    {
        StudentsList = StudentsList.OrderBy(s => s.FirstName);
    }
    private void sortByLastName()
    {
        StudentsList = StudentsList.OrderBy(s => s.LastName);
    }
    private void sortByBirthDay()
    {
        StudentsList = StudentsList.OrderBy(s => s.BirthDate);
    }

    private void sortByStudies()
    {
        StudentsList = StudentsList.OrderBy(s => s.Studies);
    }
    private void OpenDetails(int id)
    {
        NavigationManager.NavigateTo($"/students/{id}");
       
        
    }


    private async Task Delete(int id)
    {
        
        if(await js.InvokeAsync<bool>("confirm", "Are you sure?"))
        {
            
            StudentService.DeleteStudent(id);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591
