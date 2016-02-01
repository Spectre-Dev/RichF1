using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RichF1.CustomHTMLHelpers
{                           //this is a class I created to build image tags around the image file path for output in the tables
    public static class CustomHtmlHelpers   
    {
        public static IHtmlString Image(this HtmlHelper helper, string src) //taking in the src url/file path
        {
            string AlternateText = "Ahh, Where's me image?"; //this is what I want to display if image loading fails
            if (src != "")                                  //checking to see if the url is null before appending img tags
            {  
                TagBuilder tb = new TagBuilder("img");      //this builds new html tags to wrap the image path string into an image tag
                tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute(src));
                return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing)); //this closes the end of the tag
            }
            return new MvcHtmlString(AlternateText); //if the imge url is null then output my AlternateText string instead
        }
    }
}