using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Visitor
{
    public class Header : DocumentPart
    {
        public string Title { get; set; }

        public override string Convert(PICDocumentConverter documentConverter)
        {
            return documentConverter.Convert(this);
        }

        public override void Dispose()
        {
            Console.WriteLine("Header:Dispose");
        }

        public override void Open()
        {
            Console.WriteLine("Header:Open");
        }

        public override void Save()
        {
            Console.WriteLine("Header:Save");
        }
    }
}
