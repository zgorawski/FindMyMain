using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Routing;

namespace FindMyMain.Extensions
{    
    public static class ImageActionLinkExtension
    {
        public static IHtmlString ImageActionLink(this AjaxHelper helper, string imageUrl, string championName, string actionName, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes = null)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<figure class='championItem'>");
            sb.AppendLine("<img src='" + imageUrl + "' alt='" + championName + "' />");
            sb.AppendLine("<figcaption>" + championName + "</figcaption>");
            sb.AppendLine("</figure>");

            //var stringifiedTag = new HtmlString(sb.ToString());

            //var figureBuilder = new TagBuilder("figure");
            //figureBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            //figureBuilder.AddCssClass("championItem");

            //var imgBuilder = new TagBuilder("img");
            //imgBuilder.MergeAttribute("src", imageUrl);
            //imgBuilder.MergeAttribute("alt", championName);

            //var figcaptionBuilder = new TagBuilder("figcaption");
            //figcaptionBuilder.SetInnerText(championName);

            //figureBuilder.InnerHtml += imgBuilder.ToString(TagRenderMode.SelfClosing);
            //figureBuilder.InnerHtml += figcaptionBuilder.ToString(TagRenderMode.SelfClosing);

            //var stringifiedTag = figureBuilder.ToString(TagRenderMode.SelfClosing);
            
            var link = helper.ActionLink("[replaceme]", actionName, routeValues, ajaxOptions).ToHtmlString();
            return MvcHtmlString.Create(link.Replace("[replaceme]", sb.ToString()));
        }

    }
}