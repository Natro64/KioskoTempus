using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class TipoSolicitud
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDTiposolicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombreTabla;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombretablatblAlias;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _observaciones;
        
        public TipoSolicitud()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? IDTiposolicitud
        {
            get
            {
                return _iDTiposolicitud;
            }
            set
            {
                _iDTiposolicitud = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        public string NombreTabla
        {
            get
            {
                return _nombreTabla;
            }
            set
            {
                _nombreTabla = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NombretablatblAlias
        {
            get
            {
                return _nombretablatblAlias;
            }
            set
            {
                _nombretablatblAlias = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Observaciones
        {
            get
            {
                return _observaciones;
            }
            set
            {
                _observaciones = value;
            }
        }
        
        public static List<IXport.Data.Objects.TipoSolicitud> Select(int? iDTiposolicitud, string descripcion, string nombreTabla, string nombretablatblAlias, string observaciones)
        {
            return new TipoSolicitudFactory().Select(iDTiposolicitud, descripcion, nombreTabla, nombretablatblAlias, observaciones);
        }
        
        public static List<IXport.Data.Objects.TipoSolicitud> Select(IXport.Data.Objects.TipoSolicitud qbe)
        {
            return new TipoSolicitudFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.TipoSolicitud> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new TipoSolicitudFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.TipoSolicitud> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new TipoSolicitudFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.TipoSolicitud> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new TipoSolicitudFactory().Select(filter, sort, TipoSolicitudFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.TipoSolicitud> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new TipoSolicitudFactory().Select(filter, sort, TipoSolicitudFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.TipoSolicitud> Select(string filter, BusinessObjectParameters parameters)
        {
            return new TipoSolicitudFactory().Select(filter, null, TipoSolicitudFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.TipoSolicitud> Select(string filter, params FieldValue[] parameters)
        {
            return new TipoSolicitudFactory().Select(filter, null, TipoSolicitudFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.TipoSolicitud SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new TipoSolicitudFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.TipoSolicitud SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new TipoSolicitudFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.TipoSolicitud SelectSingle(int? iDTiposolicitud)
        {
            return new TipoSolicitudFactory().SelectSingle(iDTiposolicitud);
        }
        
        public int Insert()
        {
            return new TipoSolicitudFactory().Insert(this);
        }
        
        public int Update()
        {
            return new TipoSolicitudFactory().Update(this);
        }
        
        public int Delete()
        {
            return new TipoSolicitudFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDTiposolicitud: {0}", this.IDTiposolicitud);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class TipoSolicitudFactory
    {
        
        public TipoSolicitudFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("TipoSolicitud");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("TipoSolicitud");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("TipoSolicitud");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("TipoSolicitud");
            }
        }
        
        public static TipoSolicitudFactory Create()
        {
            return new TipoSolicitudFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? iDTiposolicitud, string descripcion, string nombreTabla, string nombretablatblAlias, string observaciones, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDTiposolicitud.HasValue)
            	filter.Add(("IDTiposolicitud:=" + iDTiposolicitud.Value.ToString()));
            if (!(String.IsNullOrEmpty(descripcion)))
            	filter.Add(("Descripcion:*" + descripcion));
            if (!(String.IsNullOrEmpty(nombreTabla)))
            	filter.Add(("NombreTabla:*" + nombreTabla));
            if (!(String.IsNullOrEmpty(nombretablatblAlias)))
            	filter.Add(("NombretablatblAlias:*" + nombretablatblAlias));
            if (!(String.IsNullOrEmpty(observaciones)))
            	filter.Add(("Observaciones:*" + observaciones));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.TipoSolicitud> Select(int? iDTiposolicitud, string descripcion, string nombreTabla, string nombretablatblAlias, string observaciones, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDTiposolicitud, descripcion, nombreTabla, nombretablatblAlias, observaciones, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TipoSolicitud", dataView, request);
            return page.ToList<IXport.Data.Objects.TipoSolicitud>();
        }
        
        public List<IXport.Data.Objects.TipoSolicitud> Select(IXport.Data.Objects.TipoSolicitud qbe)
        {
            return Select(qbe.IDTiposolicitud, qbe.Descripcion, qbe.NombreTabla, qbe.NombretablatblAlias, qbe.Observaciones);
        }
        
        public int SelectCount(int? iDTiposolicitud, string descripcion, string nombreTabla, string nombretablatblAlias, string observaciones, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDTiposolicitud, descripcion, nombreTabla, nombretablatblAlias, observaciones, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TipoSolicitud", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.TipoSolicitud> Select(int? iDTiposolicitud, string descripcion, string nombreTabla, string nombretablatblAlias, string observaciones)
        {
            return Select(iDTiposolicitud, descripcion, nombreTabla, nombretablatblAlias, observaciones, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.TipoSolicitud SelectSingle(int? iDTiposolicitud)
        {
            List<IXport.Data.Objects.TipoSolicitud> list = Select(iDTiposolicitud, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.TipoSolicitud> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("TipoSolicitud", dataView, request);
            return page.ToList<IXport.Data.Objects.TipoSolicitud>();
        }
        
        public List<IXport.Data.Objects.TipoSolicitud> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.TipoSolicitud> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.TipoSolicitud SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.TipoSolicitud> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.TipoSolicitud theTipoSolicitud, IXport.Data.Objects.TipoSolicitud original_TipoSolicitud)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDTiposolicitud", original_TipoSolicitud.IDTiposolicitud, theTipoSolicitud.IDTiposolicitud, true));
            values.Add(new FieldValue("Descripcion", original_TipoSolicitud.Descripcion, theTipoSolicitud.Descripcion));
            values.Add(new FieldValue("NombreTabla", original_TipoSolicitud.NombreTabla, theTipoSolicitud.NombreTabla));
            values.Add(new FieldValue("NombretablatblAlias", original_TipoSolicitud.NombretablatblAlias, theTipoSolicitud.NombretablatblAlias, true));
            values.Add(new FieldValue("Observaciones", original_TipoSolicitud.Observaciones, theTipoSolicitud.Observaciones));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.TipoSolicitud theTipoSolicitud, IXport.Data.Objects.TipoSolicitud original_TipoSolicitud, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "TipoSolicitud";
            args.View = dataView;
            args.Values = CreateFieldValues(theTipoSolicitud, original_TipoSolicitud);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("TipoSolicitud", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theTipoSolicitud);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.TipoSolicitud theTipoSolicitud, IXport.Data.Objects.TipoSolicitud original_TipoSolicitud)
        {
            return ExecuteAction(theTipoSolicitud, original_TipoSolicitud, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.TipoSolicitud theTipoSolicitud)
        {
            return Update(theTipoSolicitud, SelectSingle(theTipoSolicitud.IDTiposolicitud));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.TipoSolicitud theTipoSolicitud)
        {
            return ExecuteAction(theTipoSolicitud, new TipoSolicitud(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.TipoSolicitud theTipoSolicitud)
        {
            return ExecuteAction(theTipoSolicitud, theTipoSolicitud, "Select", "Delete", DeleteView);
        }
    }
}
