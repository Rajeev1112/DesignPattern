using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Visitor
{
    public class Paragraph : DocumentPart
    {
        public string Content { get; set; }

        public override string Convert(PICDocumentConverter documentConverter)
        {
            return documentConverter.Convert(this);
        }

        public override void Dispose()
        {
            Console.WriteLine("Paragraph:Dispose");
        }

        public override void Open()
        {
            Console.WriteLine("Paragraph:Open");
        }

        public override void Save()
        {
            Console.WriteLine("Paragraph:Save");
        }
    }
}
