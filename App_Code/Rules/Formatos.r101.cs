using System;
using IXport.Data;
using System.IO;

namespace IXport.Rules
{
    public partial class CategoriesBusinessRules : IXport.Data.BusinessRules
    {
        [Rule("r101")]
        public void r101Implementation(int? ID_Formato, string Descripcion, string externalDocFileName, int? externalDocLength,
            string externalDocContentType, Stream externalDoc)
        {
            PreventDefault();
            string fileName = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                String.Format(@"My External Doc Files\{0}.bin", ID_Formato));
            Stream input = File.OpenRead(fileName);
            input.CopyTo(externalDoc);
            input.Close();
        }
    }
}