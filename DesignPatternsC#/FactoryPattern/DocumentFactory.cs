using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.FactoryPattern
{
    public class DocumentFactory
    {
        public static IDocument CreateDocument(string documentType)
        {
            switch(documentType.ToLower())
            {
                case "pdf":
                    return new PdfDocument();
                case "word":
                    return new WordDocument();
                case "excel":
                    return new ExcelDocument();
                default:
                    throw new ArgumentException("Invalid Document Type...");
            }
        }
    }
}
