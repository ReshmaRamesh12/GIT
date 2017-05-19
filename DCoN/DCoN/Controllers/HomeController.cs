using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Spire.Doc.Documents;
using Spire.Doc;
using Spire.Pdf;

namespace DCoN.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Document m = new Document();
            //////  m.LoadFromFile(@"C:\Users\TEMP.HONEYWE-DCBB4V5\Documents\INPUT_file\MyDoc.docx");

            ////m.LoadFromFile(@"C:\DCoN\DCoN\DCoN\Inputs\MyDoc.docx");
            ////m.SaveToFile("Convert.PDF", FileFormat.PDF);

            //////    System.Diagnostics.Process.Start("");

            //Paragraph nn = m.AddSection().AddParagraph();

            //nn.AppendText("aghgdshgashd");

            //m.SaveToFile(@"C:\DCoN\DCoN\DCoN\Inputs\sample1.doc", Spire.Doc.FileFormat.Doc);
            //m.LoadFromFile(@"C:\DCoN\DCoN\DCoN\Inputs\sample1.doc");
            //m.SaveToFile(@"C:\DCoN\DCoN\DCoN\Inputs\Convert.PDF", Spire.Doc.FileFormat.PDF);
            //ViewBag.Title = "Home Page";

            return View();
        }
    }
}
