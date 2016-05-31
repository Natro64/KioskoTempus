using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Solicitudes
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDSolicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaSolicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDEmpleado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombreCompleto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDTiposolicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _theidTiposolicitudobservaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaSolicitada;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _observaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modificadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaModificacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDJefe;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDMotivo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _iDEstatussolicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currentUserName;
        
        public Solicitudes()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? IDSolicitud
        {
            get
            {
                return _iDSolicitud;
            }
            set
            {
                _iDSolicitud = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? FechaSolicitud
        {
            get
            {
                return _fechaSolicitud;
            }
            set
            {
                _fechaSolicitud = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? IDEmpleado
        {
            get
            {
                return _iDEmpleado;
            }
            set
            {
                _iDEmpleado = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NombreCompleto
        {
            get
            {
                return _nombreCompleto;
            }
            set
            {
                _nombreCompleto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        public string TheidTiposolicitudobservaciones
        {
            get
            {
                return _theidTiposolicitudobservaciones;
            }
            set
            {
                _theidTiposolicitudobservaciones = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? FechaSolicitada
        {
            get
            {
                return _fechaSolicitada;
            }
            set
            {
                _fechaSolicitada = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Notas
        {
            get
            {
                return _notas;
            }
            set
            {
                _notas = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ModificadoPor
        {
            get
            {
                return _modificadoPor;
            }
            set
            {
                _modificadoPor = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FechaModificacion
        {
            get
            {
                return _fechaModificacion;
            }
            set
            {
                _fechaModificacion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? IDJefe
        {
            get
            {
                return _iDJefe;
            }
            set
            {
                _iDJefe = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? IDMotivo
        {
            get
            {
                return _iDMotivo;
            }
            set
            {
                _iDMotivo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public byte? IDEstatussolicitud
        {
            get
            {
                return _iDEstatussolicitud;
            }
            set
            {
                _iDEstatussolicitud = value;
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
        public string CurrentUserName
        {
            get
            {
                return _currentUserName;
            }
            set
            {
                _currentUserName = value;
            }
        }
        
        public static List<IXport.Data.Objects.Solicitudes> Select(
                    int? iDSolicitud, 
                    DateTime? fechaSolicitud, 
                    int? iDEmpleado, 
                    string nombreCompleto, 
                    int? iDTiposolicitud, 
                    string theidTiposolicitudobservaciones, 
                    DateTime? fechaSolicitada, 
                    decimal? cantidad, 
                    string notas, 
                    string observaciones, 
                    string modificadoPor, 
                    DateTime? fechaModificacion, 
                    int? iDJefe, 
                    int? iDMotivo, 
                    byte? iDEstatussolicitud, 
                    string descripcion)
        {
            return new SolicitudesFactory().Select(iDSolicitud, fechaSolicitud, iDEmpleado, nombreCompleto, iDTiposolicitud, theidTiposolicitudobservaciones, fechaSolicitada, cantidad, notas, observaciones, modificadoPor, fechaModificacion, iDJefe, iDMotivo, iDEstatussolicitud, descripcion);
        }
        
        public static List<IXport.Data.Objects.Solicitudes> Select(IXport.Data.Objects.Solicitudes qbe)
        {
            return new SolicitudesFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.Solicitudes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new SolicitudesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.Solicitudes> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new SolicitudesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Solicitudes> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new SolicitudesFactory().Select(filter, sort, SolicitudesFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Solicitudes> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new SolicitudesFactory().Select(filter, sort, SolicitudesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Solicitudes> Select(string filter, BusinessObjectParameters parameters)
        {
            return new SolicitudesFactory().Select(filter, null, SolicitudesFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Solicitudes> Select(string filter, params FieldValue[] parameters)
        {
            return new SolicitudesFactory().Select(filter, null, SolicitudesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Solicitudes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new SolicitudesFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.Solicitudes SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new SolicitudesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Solicitudes SelectSingle(int? iDSolicitud)
        {
            return new SolicitudesFactory().SelectSingle(iDSolicitud);
        }
        
        public int Insert()
        {
            return new SolicitudesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new SolicitudesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new SolicitudesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDSolicitud: {0}", this.IDSolicitud);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class SolicitudesFactory
    {
        
        public SolicitudesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Solicitudes");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Solicitudes");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Solicitudes");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Solicitudes");
            }
        }
        
        public static SolicitudesFactory Create()
        {
            return new SolicitudesFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? iDSolicitud, 
                    DateTime? fechaSolicitud, 
                    int? iDEmpleado, 
                    string nombreCompleto, 
                    int? iDTiposolicitud, 
                    string theidTiposolicitudobservaciones, 
                    DateTime? fechaSolicitada, 
                    decimal? cantidad, 
                    string notas, 
                    string observaciones, 
                    string modificadoPor, 
                    DateTime? fechaModificacion, 
                    int? iDJefe, 
                    int? iDMotivo, 
                    byte? iDEstatussolicitud, 
                    string descripcion, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDSolicitud.HasValue)
            	filter.Add(("IDSolicitud:=" + iDSolicitud.Value.ToString()));
            if (fechaSolicitud.HasValue)
            	filter.Add(("FechaSolicitud:=" + fechaSolicitud.Value.ToString()));
            if (iDEmpleado.HasValue)
            	filter.Add(("IDEmpleado:=" + iDEmpleado.Value.ToString()));
            if (!(String.IsNullOrEmpty(nombreCompleto)))
            	filter.Add(("NombreCompleto:*" + nombreCompleto));
            if (iDTiposolicitud.HasValue)
            	filter.Add(("IDTiposolicitud:=" + iDTiposolicitud.Value.ToString()));
            if (!(String.IsNullOrEmpty(theidTiposolicitudobservaciones)))
            	filter.Add(("TheidTiposolicitudobservaciones:*" + theidTiposolicitudobservaciones));
            if (fechaSolicitada.HasValue)
            	filter.Add(("FechaSolicitada:=" + fechaSolicitada.Value.ToString()));
            if (cantidad.HasValue)
            	filter.Add(("Cantidad:=" + cantidad.Value.ToString()));
            if (!(String.IsNullOrEmpty(notas)))
            	filter.Add(("Notas:*" + notas));
            if (!(String.IsNullOrEmpty(observaciones)))
            	filter.Add(("Observaciones:*" + observaciones));
            if (!(String.IsNullOrEmpty(modificadoPor)))
            	filter.Add(("ModificadoPor:*" + modificadoPor));
            if (fechaModificacion.HasValue)
            	filter.Add(("FechaModificacion:=" + fechaModificacion.Value.ToString()));
            if (iDJefe.HasValue)
            	filter.Add(("IDJefe:=" + iDJefe.Value.ToString()));
            if (iDMotivo.HasValue)
            	filter.Add(("IDMotivo:=" + iDMotivo.Value.ToString()));
            if (iDEstatussolicitud.HasValue)
            	filter.Add(("IDEstatussolicitud:=" + iDEstatussolicitud.Value.ToString()));
            if (!(String.IsNullOrEmpty(descripcion)))
            	filter.Add(("Descripcion:*" + descripcion));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.Solicitudes> Select(
                    int? iDSolicitud, 
                    DateTime? fechaSolicitud, 
                    int? iDEmpleado, 
                    string nombreCompleto, 
                    int? iDTiposolicitud, 
                    string theidTiposolicitudobservaciones, 
                    DateTime? fechaSolicitada, 
                    decimal? cantidad, 
                    string notas, 
                    string observaciones, 
                    string modificadoPor, 
                    DateTime? fechaModificacion, 
                    int? iDJefe, 
                    int? iDMotivo, 
                    byte? iDEstatussolicitud, 
                    string descripcion, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDSolicitud, fechaSolicitud, iDEmpleado, nombreCompleto, iDTiposolicitud, theidTiposolicitudobservaciones, fechaSolicitada, cantidad, notas, observaciones, modificadoPor, fechaModificacion, iDJefe, iDMotivo, iDEstatussolicitud, descripcion, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Solicitudes", dataView, request);
            return page.ToList<IXport.Data.Objects.Solicitudes>();
        }
        
        public List<IXport.Data.Objects.Solicitudes> Select(IXport.Data.Objects.Solicitudes qbe)
        {
            return Select(qbe.IDSolicitud, qbe.FechaSolicitud, qbe.IDEmpleado, qbe.NombreCompleto, qbe.IDTiposolicitud, qbe.TheidTiposolicitudobservaciones, qbe.FechaSolicitada, qbe.Cantidad, qbe.Notas, qbe.Observaciones, qbe.ModificadoPor, qbe.FechaModificacion, qbe.IDJefe, qbe.IDMotivo, qbe.IDEstatussolicitud, qbe.Descripcion);
        }
        
        public int SelectCount(
                    int? iDSolicitud, 
                    DateTime? fechaSolicitud, 
                    int? iDEmpleado, 
                    string nombreCompleto, 
                    int? iDTiposolicitud, 
                    string theidTiposolicitudobservaciones, 
                    DateTime? fechaSolicitada, 
                    decimal? cantidad, 
                    string notas, 
                    string observaciones, 
                    string modificadoPor, 
                    DateTime? fechaModificacion, 
                    int? iDJefe, 
                    int? iDMotivo, 
                    byte? iDEstatussolicitud, 
                    string descripcion, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDSolicitud, fechaSolicitud, iDEmpleado, nombreCompleto, iDTiposolicitud, theidTiposolicitudobservaciones, fechaSolicitada, cantidad, notas, observaciones, modificadoPor, fechaModificacion, iDJefe, iDMotivo, iDEstatussolicitud, descripcion, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Solicitudes", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.Solicitudes> Select(
                    int? iDSolicitud, 
                    DateTime? fechaSolicitud, 
                    int? iDEmpleado, 
                    string nombreCompleto, 
                    int? iDTiposolicitud, 
                    string theidTiposolicitudobservaciones, 
                    DateTime? fechaSolicitada, 
                    decimal? cantidad, 
                    string notas, 
                    string observaciones, 
                    string modificadoPor, 
                    DateTime? fechaModificacion, 
                    int? iDJefe, 
                    int? iDMotivo, 
                    byte? iDEstatussolicitud, 
                    string descripcion)
        {
            return Select(iDSolicitud, fechaSolicitud, iDEmpleado, nombreCompleto, iDTiposolicitud, theidTiposolicitudobservaciones, fechaSolicitada, cantidad, notas, observaciones, modificadoPor, fechaModificacion, iDJefe, iDMotivo, iDEstatussolicitud, descripcion, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.Solicitudes SelectSingle(int? iDSolicitud)
        {
            List<IXport.Data.Objects.Solicitudes> list = Select(iDSolicitud, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.Solicitudes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Solicitudes", dataView, request);
            return page.ToList<IXport.Data.Objects.Solicitudes>();
        }
        
        public List<IXport.Data.Objects.Solicitudes> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.Solicitudes> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.Solicitudes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.Solicitudes> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.Solicitudes theSolicitudes, IXport.Data.Objects.Solicitudes original_Solicitudes)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDSolicitud", original_Solicitudes.IDSolicitud, theSolicitudes.IDSolicitud));
            values.Add(new FieldValue("FechaSolicitud", original_Solicitudes.FechaSolicitud, theSolicitudes.FechaSolicitud));
            values.Add(new FieldValue("IDEmpleado", original_Solicitudes.IDEmpleado, theSolicitudes.IDEmpleado));
            values.Add(new FieldValue("NombreCompleto", original_Solicitudes.NombreCompleto, theSolicitudes.NombreCompleto, true));
            values.Add(new FieldValue("IDTiposolicitud", original_Solicitudes.IDTiposolicitud, theSolicitudes.IDTiposolicitud));
            values.Add(new FieldValue("TheidTiposolicitudobservaciones", original_Solicitudes.TheidTiposolicitudobservaciones, theSolicitudes.TheidTiposolicitudobservaciones, true));
            values.Add(new FieldValue("FechaSolicitada", original_Solicitudes.FechaSolicitada, theSolicitudes.FechaSolicitada));
            values.Add(new FieldValue("Cantidad", original_Solicitudes.Cantidad, theSolicitudes.Cantidad));
            values.Add(new FieldValue("Notas", original_Solicitudes.Notas, theSolicitudes.Notas));
            values.Add(new FieldValue("Observaciones", original_Solicitudes.Observaciones, theSolicitudes.Observaciones));
            values.Add(new FieldValue("ModificadoPor", original_Solicitudes.ModificadoPor, theSolicitudes.ModificadoPor));
            values.Add(new FieldValue("FechaModificacion", original_Solicitudes.FechaModificacion, theSolicitudes.FechaModificacion));
            values.Add(new FieldValue("IDJefe", original_Solicitudes.IDJefe, theSolicitudes.IDJefe));
            values.Add(new FieldValue("IDMotivo", original_Solicitudes.IDMotivo, theSolicitudes.IDMotivo));
            values.Add(new FieldValue("IDEstatussolicitud", original_Solicitudes.IDEstatussolicitud, theSolicitudes.IDEstatussolicitud));
            values.Add(new FieldValue("Descripcion", original_Solicitudes.Descripcion, theSolicitudes.Descripcion));
            values.Add(new FieldValue("CurrentUserName", original_Solicitudes.CurrentUserName, theSolicitudes.CurrentUserName, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.Solicitudes theSolicitudes, IXport.Data.Objects.Solicitudes original_Solicitudes, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Solicitudes";
            args.View = dataView;
            args.Values = CreateFieldValues(theSolicitudes, original_Solicitudes);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Solicitudes", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theSolicitudes);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.Solicitudes theSolicitudes, IXport.Data.Objects.Solicitudes original_Solicitudes)
        {
            return ExecuteAction(theSolicitudes, original_Solicitudes, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.Solicitudes theSolicitudes)
        {
            return Update(theSolicitudes, SelectSingle(theSolicitudes.IDSolicitud));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.Solicitudes theSolicitudes)
        {
            return ExecuteAction(theSolicitudes, new Solicitudes(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.Solicitudes theSolicitudes)
        {
            return ExecuteAction(theSolicitudes, theSolicitudes, "Select", "Delete", DeleteView);
        }
    }
}
