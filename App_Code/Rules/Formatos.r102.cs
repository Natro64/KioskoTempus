using System;
using IXport.Data;
using System.IO;

namespace IXport.Rules
{
    public partial class CategoriesBusinessRules : IXport.Data.BusinessRules
    {
        [Rule("r102")]
        public void r102Implementation(int? ID_Formato, string Descripcion, string externalDocFileName, int? externalDocLength,
            string externalDocContentType, Stream externalDoc)
        {
            if (!String.IsNullOrEmpty(externalDocFileName))
                UpdateFieldValue("ExternalDoc", ID_Formato);
            else
                UpdateFieldValue("ExternalDoc", String.Format("null|{0}", ID_Formato));
        }
    }
}