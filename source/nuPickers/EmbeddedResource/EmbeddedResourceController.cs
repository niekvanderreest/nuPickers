﻿namespace nuPickers.EmbeddedResource
{
    using System.Web;
    using System.Web.Mvc;
    using Umbraco.Core;

    /// <summary>
    /// Handles returning embedded resource files (html, css, js, png)
    /// </summary>
    public class EmbeddedResourceController : Controller
    {
        public ActionResult GetSharedResource(string folder, string file)
        {
            string fileName = file.TrimEnd(".nu");
            var resourceStream = EmbeddedResourceHelper.GetResource("nuPickers.Shared." + folder + "." + fileName);
            
            if (resourceStream != null)
            {
                return new FileStreamResult(resourceStream, GetMimeType(fileName)); ;
            }

            return this.HttpNotFound();
        }

        private string GetMimeType(string resource)
        {
            var mimeType = MimeMapping.GetMimeMapping(resource);
            return mimeType ?? "text";
        }
    }
}
