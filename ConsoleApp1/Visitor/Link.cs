using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Visitor
{
    public class Link : DocumentPart
    {
        public string Url { get; set; }
        public string LinkText { get; set; }

        public override string Convert(PICDocumentConverter documentConverter)
        {
            return documentConverter.Convert(this);
        }

        public override void Dispose()
        {
            Console.WriteLine("Link:Dispose");
        }

        public override void Open()
        {
            Console.WriteLine("Link:Open");
        }

        public override void Save()
        {
            Console.WriteLine("Link:Save");
        }
    }
}
