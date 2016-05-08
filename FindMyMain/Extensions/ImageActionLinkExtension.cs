using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Routing;

namespace FindMyMain.Extensions
{    
    public static class ImageActionLinkExtension
    {
        public static IHtmlString ImageActionLink(this AjaxHelper helper, string imageUrl, string championName, int championId, string actionName, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes = null)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<figure class='championItem' id='champion" + championId.ToString() + "'>");
            sb.AppendLine("<img src='" + imageUrl + "' alt='" + championName + "' />");
            sb.AppendLine("<figcaption>" + championName + "</figcaption>");
            sb.AppendLine("</figure>");
            
            var link = helper.ActionLink("[replaceme]", actionName, routeValues, ajaxOptions).ToHtmlString();
            return MvcHtmlString.Create(link.Replace("[replaceme]", sb.ToString()));
        }

    }
}