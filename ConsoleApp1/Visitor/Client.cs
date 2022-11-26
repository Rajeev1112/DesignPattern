using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Visitor
{
    public class Client
    {
        public void Execute()
        {
            PICDocument document = new PICDocument();
            DocumentPart header = new Visitor.Header();
            DocumentPart link = new Link();
            DocumentPart paragraph1 = new Paragraph();
            DocumentPart paragraph2 = new Paragraph();
            DocumentPart paragraph3 = new Paragraph();

            document.AddPart(header);
            document.AddPart(paragraph1);
            document.AddPart(paragraph2);
            document.AddPart(paragraph3);
            document.AddPart(link);


            document.Open();
            document.Save();
            document.Dispose();

            PICDocumentConverter converter = new HtmlDocumentConverter();
            document.Convert(converter);
        }
       
    }
}
