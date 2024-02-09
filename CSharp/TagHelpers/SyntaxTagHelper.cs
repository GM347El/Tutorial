using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CSharp.TagHelpers
{
    [HtmlTargetElement("syntax")]   //  this line is not needed
    public class SyntaxTagHelper:TagHelper
    {
        public string language { get; set; }="";
        public override void Process(TagHelperContext context,TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent($"<pre><code class=\"{language}\">");
            output.PostContent.SetHtmlContent("</code></pre>");
        } 
    }
}
