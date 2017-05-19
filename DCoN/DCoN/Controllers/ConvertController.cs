using System.Web.Http;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Net.Http;
using System.Web.Http.Results;
using System;

namespace DCoN.Controllers
{
    public class ConvertController : ApiController
    {

        string FileInputUrl = System.Configuration.ConfigurationManager.AppSettings["ImagePublishUrl"];
        string FileOutUrl = System.Configuration.ConfigurationManager.AppSettings["FileOutUrl"];

        public IHttpActionResult Index(string fileName)
        {
            try
            {
                Document m = new Document();

                var path = System.IO.Path.Combine(FileInputUrl, fileName);
                m.LoadFromFile(path);
                var outputFileName = fileName + "_Converted.PDF";
                var outputFilepath = System.IO.Path.Combine(FileOutUrl, outputFileName);
                m.SaveToFile(outputFilepath, Spire.Doc.FileFormat.PDF);
                return new ResponseMessageResult(new HttpResponseMessage
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Content = new StringContent(outputFileName)
                });
            }
            catch (Exception ex)
            {
                return new ResponseMessageResult(new HttpResponseMessage
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Content = new StringContent("Something went wrong")
                });
            }
        }

        public IHttpActionResult FileCreate()
        {          
                Document m = new Document();
            Paragraph ph = m.AddSection().AddParagraph();
            ph.AppendText(" This is a Sample Document. ");
            ph.AppendText("Created by - Vikram , Reshma , Sujoy , Mukesh , Azeeb . ");
            ph.AppendText(" This file will be Converted to PDF ");
            var Filepath = System.IO.Path.Combine(FileInputUrl, "Sample.Doc");
            m.SaveToFile(Filepath, FileFormat.Doc);           
            return Ok();
        }
    }
}
 