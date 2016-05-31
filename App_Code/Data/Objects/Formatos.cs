using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Formatos
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDFormato;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _externalDocFileName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _externalDocLength;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _externalDocContentType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte[] _externalDoc;
        
        public Formatos()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? IDFormato
        {
            get
            {
                return _iDFormato;
            }
            set
            {
                _iDFormato = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ExternalDocFileName
        {
            get
            {
                return _externalDocFileName;
            }
            set
            {
                _externalDocFileName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ExternalDocLength
        {
            get
            {
                return _externalDocLength;
            }
            set
            {
                _externalDocLength = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ExternalDocContentType
        {
            get
            {
                return _externalDocContentType;
            }
            set
            {
                _externalDocContentType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte[] ExternalDoc
        {
            get
            {
                return _externalDoc;
            }
            set
            {
                _externalDoc = value;
            }
        }
        
        public static List<IXport.Data.Objects.Formatos> Select(int? iDFormato, string externalDocFileName, int? externalDocLength, string externalDocContentType, string descripcion)
        {
            return new FormatosFactory().Select(iDFormato, externalDocFileName, externalDocLength, externalDocContentType, descripcion);
        }
        
        public static List<IXport.Data.Objects.Formatos> Select(IXport.Data.Objects.Formatos qbe)
        {
            return new FormatosFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.Formatos> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new FormatosFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.Formatos> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new FormatosFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Formatos> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new FormatosFactory().Select(filter, sort, FormatosFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Formatos> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new FormatosFactory().Select(filter, sort, FormatosFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Formatos> Select(string filter, BusinessObjectParameters parameters)
        {
            return new FormatosFactory().Select(filter, null, FormatosFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Formatos> Select(string filter, params FieldValue[] parameters)
        {
            return new FormatosFactory().Select(filter, null, FormatosFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Formatos SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new FormatosFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.Formatos SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new FormatosFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Formatos SelectSingle(int? iDFormato)
        {
            return new FormatosFactory().SelectSingle(iDFormato);
        }
        
        public int Insert()
        {
            return new FormatosFactory().Insert(this);
        }
        
        public int Update()
        {
            return new FormatosFactory().Update(this);
        }
        
        public int Delete()
        {
            return new FormatosFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDFormato: {0}", this.IDFormato);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class FormatosFactory
    {
        
        public FormatosFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Formatos");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Formatos");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Formatos");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Formatos");
            }
        }
        
        public static FormatosFactory Create()
        {
            return new FormatosFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? iDFormato, string externalDocFileName, int? externalDocLength, string externalDocContentType, string descripcion, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDFormato.HasValue)
            	filter.Add(("IDFormato:=" + iDFormato.Value.ToString()));
            if (!(String.IsNullOrEmpty(externalDocFileName)))
            	filter.Add(("ExternalDocFileName:*" + externalDocFileName));
            if (externalDocLength.HasValue)
            	filter.Add(("ExternalDocLength:=" + externalDocLength.Value.ToString()));
            if (!(String.IsNullOrEmpty(externalDocContentType)))
            	filter.Add(("ExternalDocContentType:*" + externalDocContentType));
            if (!(String.IsNullOrEmpty(descripcion)))
            	filter.Add(("Descripcion:*" + descripcion));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.Formatos> Select(int? iDFormato, string externalDocFileName, int? externalDocLength, string externalDocContentType, string descripcion, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDFormato, externalDocFileName, externalDocLength, externalDocContentType, descripcion, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Formatos", dataView, request);
            return page.ToList<IXport.Data.Objects.Formatos>();
        }
        
        public List<IXport.Data.Objects.Formatos> Select(IXport.Data.Objects.Formatos qbe)
        {
            return Select(qbe.IDFormato, qbe.ExternalDocFileName, qbe.ExternalDocLength, qbe.ExternalDocContentType, qbe.Descripcion);
        }
        
        public int SelectCount(int? iDFormato, string externalDocFileName, int? externalDocLength, string externalDocContentType, string descripcion, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDFormato, externalDocFileName, externalDocLength, externalDocContentType, descripcion, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Formatos", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.Formatos> Select(int? iDFormato, string externalDocFileName, int? externalDocLength, string externalDocContentType, string descripcion)
        {
            return Select(iDFormato, externalDocFileName, externalDocLength, externalDocContentType, descripcion, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.Formatos SelectSingle(int? iDFormato)
        {
            List<IXport.Data.Objects.Formatos> list = Select(iDFormato, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.Formatos> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Formatos", dataView, request);
            return page.ToList<IXport.Data.Objects.Formatos>();
        }
        
        public List<IXport.Data.Objects.Formatos> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.Formatos> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.Formatos SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.Formatos> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.Formatos theFormatos, IXport.Data.Objects.Formatos original_Formatos)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDFormato", original_Formatos.IDFormato, theFormatos.IDFormato, true));
            values.Add(new FieldValue("ExternalDocFileName", original_Formatos.ExternalDocFileName, theFormatos.ExternalDocFileName));
            values.Add(new FieldValue("ExternalDocLength", original_Formatos.ExternalDocLength, theFormatos.ExternalDocLength));
            values.Add(new FieldValue("ExternalDocContentType", original_Formatos.ExternalDocContentType, theFormatos.ExternalDocContentType));
            values.Add(new FieldValue("Descripcion", original_Formatos.Descripcion, theFormatos.Descripcion));
            values.Add(new FieldValue("ExternalDoc", original_Formatos.ExternalDoc, theFormatos.ExternalDoc));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.Formatos theFormatos, IXport.Data.Objects.Formatos original_Formatos, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Formatos";
            args.View = dataView;
            args.Values = CreateFieldValues(theFormatos, original_Formatos);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Formatos", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theFormatos);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.Formatos theFormatos, IXport.Data.Objects.Formatos original_Formatos)
        {
            return ExecuteAction(theFormatos, original_Formatos, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.Formatos theFormatos)
        {
            return Update(theFormatos, SelectSingle(theFormatos.IDFormato));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.Formatos theFormatos)
        {
            return ExecuteAction(theFormatos, new Formatos(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.Formatos theFormatos)
        {
            return ExecuteAction(theFormatos, theFormatos, "Select", "Delete", DeleteView);
        }
    }
}
