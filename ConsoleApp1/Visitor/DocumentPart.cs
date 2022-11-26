using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Visitor
{
    public abstract class DocumentPart
    {
        public abstract void Open();
        public abstract void Save();
        public abstract void Dispose();

        public abstract string Convert(PICDocumentConverter documentConverter);

    }
}
