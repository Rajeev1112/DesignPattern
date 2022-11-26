using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Visitor
{
    public class PICDocument
    {
        public List<DocumentPart> parts { get; set; }

        public PICDocument()
        {
            parts = new List<DocumentPart>();
        }

        public void AddPart(DocumentPart part)
        {
            parts.Add(part);
        }

        public void RemovePart(DocumentPart part)
        {
            parts.Remove(part);
        }
        
        public void Open()
        {
            parts.ForEach(part =>
            {
                part.Open();
            });
        }

        public void Save()
        {
            parts.ForEach(part =>
            {
                part.Save();
            });
        }

        public void Dispose()
        {
            parts.ForEach(part =>
            {
                part.Dispose();
            });
        }

        public void Convert(PICDocumentConverter documentConverter)
        {
            parts.ForEach(part =>
            {
                Console.WriteLine(part.Convert(documentConverter));
            });
        }

    }
}
