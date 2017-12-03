using System;
using System.Web.Mvc;

namespace MVCAngularJS.Helpers
{
    public static class HTMLHelpers
    {
        public static MvcHtmlString Titles(this HtmlHelper helper)
        {
            var titles = string.Join("','", Enum.GetNames(typeof(Models.Titles)));
            string script = string.Format(@"<script>var titles =  ['{0}']</script>", titles);
            return new MvcHtmlString(script);
        }

        public static MvcHtmlString AddressStates(this HtmlHelper helper)
        {
            var addressStates = string.Join("','", Enum.GetNames(typeof(Models.AddressStates)));
            string script = string.Format(@"<script>var addressStates =  ['{0}']</script>", addressStates);
            return new MvcHtmlString(script);
        }
    }
}