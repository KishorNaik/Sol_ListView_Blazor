using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Sol_Demo.Models;

namespace Sol_Demo.Pages.Demo.Components
{
    public partial class ListView<TItem>
    {
        [Parameter]
        public IEnumerable<TItem> ItemSource { get; set; }

        [Parameter]
        public RenderFragment<TItem> DataTemplate { get; set; }
    }
}