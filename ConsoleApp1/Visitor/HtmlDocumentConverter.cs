using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Visitor
{
    public class HtmlDocumentConverter : PICDocumentConverter
    {
        public override string Convert(Paragraph paragraph)
        {
            return "<p></p>";
        }

        public override string Convert(Link link)
        {
            return "<a ></a>";
        }

        public override string Convert(Header header)
        {
            return "<h ></h>";
        }
    }
}
