using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Visitor
{
    public abstract class PICDocumentConverter
    {
        public abstract string Convert(Paragraph paragraph);
        public abstract string Convert(Link link);
        public abstract string Convert(Header header);
    }
}
