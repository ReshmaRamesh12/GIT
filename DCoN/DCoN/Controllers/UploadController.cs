using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace DCoN.Controllers
{
    public class UploadController : ApiController
    {
        public IHttpActionResult Index(string fileName)
        {
            var path = Path.Combine(@"C:\DCoN\DCoN\DCoN\Inputs\", fileName);
            using (var fileStream = File.Create(path))
            {
                var bytes = new byte[] { 1, 2, 3, 4 };
                //input.CopyTo(fileStream);
                fileStream.Write(bytes,0,4);
            }
            Storage.Storage.InputFileName = fileName;

            return Ok();
        }
    }
}
