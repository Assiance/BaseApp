using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace BaseApp.Web.Helpers
{
    public static class JavascriptHelper
    {
        public static IHtmlString Json(this HtmlHelper helper, object obj)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new JsonConverter[]
				{
					new StringEnumConverter(), 
				},
                StringEscapeHandling = StringEscapeHandling.EscapeHtml
            };

            return MvcHtmlString.Create(JsonConvert.SerializeObject(obj, settings));
        }
    }
}