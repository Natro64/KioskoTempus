using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class RbTabla
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tblCodigo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tblNombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tblAlias;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tblDescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tblNumregxavance;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tblImportable;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tblLlave;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tblCampodescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _tblBitacora;
        
        public RbTabla()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? TblCodigo
        {
            get
            {
                return _tblCodigo;
            }
            set
            {
                _tblCodigo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public string TblNombre
        {
            get
            {
                return _tblNombre;
            }
            set
            {
                _tblNombre = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string TblAlias
        {
            get
            {
                return _tblAlias;
            }
            set
            {
                _tblAlias = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TblDescripcion
        {
            get
            {
                return _tblDescripcion;
            }
            set
            {
                _tblDescripcion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? TblNumregxavance
        {
            get
            {
                return _tblNumregxavance;
            }
            set
            {
                _tblNumregxavance = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TblImportable
        {
            get
            {
                return _tblImportable;
            }
            set
            {
                _tblImportable = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TblLlave
        {
            get
            {
                return _tblLlave;
            }
            set
            {
                _tblLlave = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TblCampodescripcion
        {
            get
            {
                return _tblCampodescripcion;
            }
            set
            {
                _tblCampodescripcion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? TblBitacora
        {
            get
            {
                return _tblBitacora;
            }
            set
            {
                _tblBitacora = value;
            }
        }
        
        public static List<IXport.Data.Objects.RbTabla> Select(int? tblCodigo, string tblNombre, string tblAlias, string tblDescripcion, int? tblNumregxavance, string tblImportable, string tblLlave, string tblCampodescripcion, bool? tblBitacora)
        {
            return new RbTablaFactory().Select(tblCodigo, tblNombre, tblAlias, tblDescripcion, tblNumregxavance, tblImportable, tblLlave, tblCampodescripcion, tblBitacora);
        }
        
        public static List<IXport.Data.Objects.RbTabla> Select(IXport.Data.Objects.RbTabla qbe)
        {
            return new RbTablaFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.RbTabla> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new RbTablaFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.RbTabla> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new RbTablaFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.RbTabla> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new RbTablaFactory().Select(filter, sort, RbTablaFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.RbTabla> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new RbTablaFactory().Select(filter, sort, RbTablaFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.RbTabla> Select(string filter, BusinessObjectParameters parameters)
        {
            return new RbTablaFactory().Select(filter, null, RbTablaFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.RbTabla> Select(string filter, params FieldValue[] parameters)
        {
            return new RbTablaFactory().Select(filter, null, RbTablaFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.RbTabla SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new RbTablaFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.RbTabla SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new RbTablaFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.RbTabla SelectSingle(string tblNombre)
        {
            return new RbTablaFactory().SelectSingle(tblNombre);
        }
        
        public int Insert()
        {
            return new RbTablaFactory().Insert(this);
        }
        
        public int Update()
        {
            return new RbTablaFactory().Update(this);
        }
        
        public int Delete()
        {
            return new RbTablaFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("TblNombre: {0}", this.TblNombre);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class RbTablaFactory
    {
        
        public RbTablaFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("RbTabla");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("RbTabla");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("RbTabla");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("RbTabla");
            }
        }
        
        public static RbTablaFactory Create()
        {
            return new RbTablaFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? tblCodigo, string tblNombre, string tblAlias, string tblDescripcion, int? tblNumregxavance, string tblImportable, string tblLlave, string tblCampodescripcion, bool? tblBitacora, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (tblCodigo.HasValue)
            	filter.Add(("TblCodigo:=" + tblCodigo.Value.ToString()));
            if (tblNombre != null)
            	filter.Add(("TblNombre:=" + tblNombre));
            if (!(String.IsNullOrEmpty(tblAlias)))
            	filter.Add(("TblAlias:*" + tblAlias));
            if (!(String.IsNullOrEmpty(tblDescripcion)))
            	filter.Add(("TblDescripcion:*" + tblDescripcion));
            if (tblNumregxavance.HasValue)
            	filter.Add(("TblNumregxavance:=" + tblNumregxavance.Value.ToString()));
            if (!(String.IsNullOrEmpty(tblImportable)))
            	filter.Add(("TblImportable:*" + tblImportable));
            if (!(String.IsNullOrEmpty(tblLlave)))
            	filter.Add(("TblLlave:*" + tblLlave));
            if (!(String.IsNullOrEmpty(tblCampodescripcion)))
            	filter.Add(("TblCampodescripcion:*" + tblCampodescripcion));
            if (tblBitacora.HasValue)
            	filter.Add(("TblBitacora:=" + tblBitacora.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.RbTabla> Select(int? tblCodigo, string tblNombre, string tblAlias, string tblDescripcion, int? tblNumregxavance, string tblImportable, string tblLlave, string tblCampodescripcion, bool? tblBitacora, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(tblCodigo, tblNombre, tblAlias, tblDescripcion, tblNumregxavance, tblImportable, tblLlave, tblCampodescripcion, tblBitacora, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("RbTabla", dataView, request);
            return page.ToList<IXport.Data.Objects.RbTabla>();
        }
        
        public List<IXport.Data.Objects.RbTabla> Select(IXport.Data.Objects.RbTabla qbe)
        {
            return Select(qbe.TblCodigo, qbe.TblNombre, qbe.TblAlias, qbe.TblDescripcion, qbe.TblNumregxavance, qbe.TblImportable, qbe.TblLlave, qbe.TblCampodescripcion, qbe.TblBitacora);
        }
        
        public int SelectCount(int? tblCodigo, string tblNombre, string tblAlias, string tblDescripcion, int? tblNumregxavance, string tblImportable, string tblLlave, string tblCampodescripcion, bool? tblBitacora, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(tblCodigo, tblNombre, tblAlias, tblDescripcion, tblNumregxavance, tblImportable, tblLlave, tblCampodescripcion, tblBitacora, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("RbTabla", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.RbTabla> Select(int? tblCodigo, string tblNombre, string tblAlias, string tblDescripcion, int? tblNumregxavance, string tblImportable, string tblLlave, string tblCampodescripcion, bool? tblBitacora)
        {
            return Select(tblCodigo, tblNombre, tblAlias, tblDescripcion, tblNumregxavance, tblImportable, tblLlave, tblCampodescripcion, tblBitacora, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.RbTabla SelectSingle(string tblNombre)
        {
            List<IXport.Data.Objects.RbTabla> list = Select(null, tblNombre, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.RbTabla> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("RbTabla", dataView, request);
            return page.ToList<IXport.Data.Objects.RbTabla>();
        }
        
        public List<IXport.Data.Objects.RbTabla> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.RbTabla> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.RbTabla SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.RbTabla> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.RbTabla theRbTabla, IXport.Data.Objects.RbTabla original_RbTabla)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TblCodigo", original_RbTabla.TblCodigo, theRbTabla.TblCodigo, true));
            values.Add(new FieldValue("TblNombre", original_RbTabla.TblNombre, theRbTabla.TblNombre));
            values.Add(new FieldValue("TblAlias", original_RbTabla.TblAlias, theRbTabla.TblAlias));
            values.Add(new FieldValue("TblDescripcion", original_RbTabla.TblDescripcion, theRbTabla.TblDescripcion));
            values.Add(new FieldValue("TblNumregxavance", original_RbTabla.TblNumregxavance, theRbTabla.TblNumregxavance));
            values.Add(new FieldValue("TblImportable", original_RbTabla.TblImportable, theRbTabla.TblImportable));
            values.Add(new FieldValue("TblLlave", original_RbTabla.TblLlave, theRbTabla.TblLlave));
            values.Add(new FieldValue("TblCampodescripcion", original_RbTabla.TblCampodescripcion, theRbTabla.TblCampodescripcion));
            values.Add(new FieldValue("TblBitacora", original_RbTabla.TblBitacora, theRbTabla.TblBitacora));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.RbTabla theRbTabla, IXport.Data.Objects.RbTabla original_RbTabla, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "RbTabla";
            args.View = dataView;
            args.Values = CreateFieldValues(theRbTabla, original_RbTabla);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("RbTabla", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theRbTabla);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.RbTabla theRbTabla, IXport.Data.Objects.RbTabla original_RbTabla)
        {
            return ExecuteAction(theRbTabla, original_RbTabla, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.RbTabla theRbTabla)
        {
            return Update(theRbTabla, SelectSingle(theRbTabla.TblNombre));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.RbTabla theRbTabla)
        {
            return ExecuteAction(theRbTabla, new RbTabla(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.RbTabla theRbTabla)
        {
            return ExecuteAction(theRbTabla, theRbTabla, "Select", "Delete", DeleteView);
        }
    }
}
