using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Rewrite.Internal.ApacheModRewrite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstRazorPage.Pages.TagHelpers
{
    [HtmlTargetElement(Attributes = nameof(Condition))]
    public class ConditionTagHelper:TagHelper
    {
        public bool Condition { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Condition)
            {
                //EVITA EL RENDERIZADO DEL HTML SI LA CONDICION ES FALSA
                output.SuppressOutput();
            }
        }
    }
}
