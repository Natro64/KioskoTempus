using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class FlujoSolicitud
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDFlujosolicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDFlujosolicitudnotas;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDFlujosolicitudidEmpleadonombrecompleto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDEstatus;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _observaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPor;
        
        public FlujoSolicitud()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? IDFlujosolicitud
        {
            get
            {
                return _iDFlujosolicitud;
            }
            set
            {
                _iDFlujosolicitud = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDFlujosolicitudnotas
        {
            get
            {
                return _iDFlujosolicitudnotas;
            }
            set
            {
                _iDFlujosolicitudnotas = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDFlujosolicitudidEmpleadonombrecompleto
        {
            get
            {
                return _iDFlujosolicitudidEmpleadonombrecompleto;
            }
            set
            {
                _iDFlujosolicitudidEmpleadonombrecompleto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? Fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? IDEstatus
        {
            get
            {
                return _iDEstatus;
            }
            set
            {
                _iDEstatus = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string CreadoPor
        {
            get
            {
                return _creadoPor;
            }
            set
            {
                _creadoPor = value;
            }
        }
        
        public static List<IXport.Data.Objects.FlujoSolicitud> Select(int? iDFlujosolicitud, string iDFlujosolicitudnotas, string iDFlujosolicitudidEmpleadonombrecompleto, DateTime? fecha, int? iDEstatus, string observaciones, string creadoPor)
        {
            return new FlujoSolicitudFactory().Select(iDFlujosolicitud, iDFlujosolicitudnotas, iDFlujosolicitudidEmpleadonombrecompleto, fecha, iDEstatus, observaciones, creadoPor);
        }
        
        public static List<IXport.Data.Objects.FlujoSolicitud> Select(IXport.Data.Objects.FlujoSolicitud qbe)
        {
            return new FlujoSolicitudFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.FlujoSolicitud> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new FlujoSolicitudFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.FlujoSolicitud> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new FlujoSolicitudFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.FlujoSolicitud> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new FlujoSolicitudFactory().Select(filter, sort, FlujoSolicitudFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.FlujoSolicitud> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new FlujoSolicitudFactory().Select(filter, sort, FlujoSolicitudFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.FlujoSolicitud> Select(string filter, BusinessObjectParameters parameters)
        {
            return new FlujoSolicitudFactory().Select(filter, null, FlujoSolicitudFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.FlujoSolicitud> Select(string filter, params FieldValue[] parameters)
        {
            return new FlujoSolicitudFactory().Select(filter, null, FlujoSolicitudFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.FlujoSolicitud SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new FlujoSolicitudFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.FlujoSolicitud SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new FlujoSolicitudFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.FlujoSolicitud SelectSingle(int? iDFlujosolicitud)
        {
            return new FlujoSolicitudFactory().SelectSingle(iDFlujosolicitud);
        }
        
        public int Insert()
        {
            return new FlujoSolicitudFactory().Insert(this);
        }
        
        public int Update()
        {
            return new FlujoSolicitudFactory().Update(this);
        }
        
        public int Delete()
        {
            return new FlujoSolicitudFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDFlujosolicitud: {0}", this.IDFlujosolicitud);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class FlujoSolicitudFactory
    {
        
        public FlujoSolicitudFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("FlujoSolicitud");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("FlujoSolicitud");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("FlujoSolicitud");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("FlujoSolicitud");
            }
        }
        
        public static FlujoSolicitudFactory Create()
        {
            return new FlujoSolicitudFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? iDFlujosolicitud, string iDFlujosolicitudnotas, string iDFlujosolicitudidEmpleadonombrecompleto, DateTime? fecha, int? iDEstatus, string observaciones, string creadoPor, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDFlujosolicitud.HasValue)
            	filter.Add(("IDFlujosolicitud:=" + iDFlujosolicitud.Value.ToString()));
            if (!(String.IsNullOrEmpty(iDFlujosolicitudnotas)))
            	filter.Add(("IDFlujosolicitudnotas:*" + iDFlujosolicitudnotas));
            if (!(String.IsNullOrEmpty(iDFlujosolicitudidEmpleadonombrecompleto)))
            	filter.Add(("IDFlujosolicitudidEmpleadonombrecompleto:*" + iDFlujosolicitudidEmpleadonombrecompleto));
            if (fecha.HasValue)
            	filter.Add(("Fecha:=" + fecha.Value.ToString()));
            if (iDEstatus.HasValue)
            	filter.Add(("IDEstatus:=" + iDEstatus.Value.ToString()));
            if (!(String.IsNullOrEmpty(observaciones)))
            	filter.Add(("Observaciones:*" + observaciones));
            if (!(String.IsNullOrEmpty(creadoPor)))
            	filter.Add(("CreadoPor:*" + creadoPor));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.FlujoSolicitud> Select(int? iDFlujosolicitud, string iDFlujosolicitudnotas, string iDFlujosolicitudidEmpleadonombrecompleto, DateTime? fecha, int? iDEstatus, string observaciones, string creadoPor, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDFlujosolicitud, iDFlujosolicitudnotas, iDFlujosolicitudidEmpleadonombrecompleto, fecha, iDEstatus, observaciones, creadoPor, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("FlujoSolicitud", dataView, request);
            return page.ToList<IXport.Data.Objects.FlujoSolicitud>();
        }
        
        public List<IXport.Data.Objects.FlujoSolicitud> Select(IXport.Data.Objects.FlujoSolicitud qbe)
        {
            return Select(qbe.IDFlujosolicitud, qbe.IDFlujosolicitudnotas, qbe.IDFlujosolicitudidEmpleadonombrecompleto, qbe.Fecha, qbe.IDEstatus, qbe.Observaciones, qbe.CreadoPor);
        }
        
        public int SelectCount(int? iDFlujosolicitud, string iDFlujosolicitudnotas, string iDFlujosolicitudidEmpleadonombrecompleto, DateTime? fecha, int? iDEstatus, string observaciones, string creadoPor, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDFlujosolicitud, iDFlujosolicitudnotas, iDFlujosolicitudidEmpleadonombrecompleto, fecha, iDEstatus, observaciones, creadoPor, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("FlujoSolicitud", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.FlujoSolicitud> Select(int? iDFlujosolicitud, string iDFlujosolicitudnotas, string iDFlujosolicitudidEmpleadonombrecompleto, DateTime? fecha, int? iDEstatus, string observaciones, string creadoPor)
        {
            return Select(iDFlujosolicitud, iDFlujosolicitudnotas, iDFlujosolicitudidEmpleadonombrecompleto, fecha, iDEstatus, observaciones, creadoPor, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.FlujoSolicitud SelectSingle(int? iDFlujosolicitud)
        {
            List<IXport.Data.Objects.FlujoSolicitud> list = Select(iDFlujosolicitud, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.FlujoSolicitud> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("FlujoSolicitud", dataView, request);
            return page.ToList<IXport.Data.Objects.FlujoSolicitud>();
        }
        
        public List<IXport.Data.Objects.FlujoSolicitud> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.FlujoSolicitud> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.FlujoSolicitud SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.FlujoSolicitud> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.FlujoSolicitud theFlujoSolicitud, IXport.Data.Objects.FlujoSolicitud original_FlujoSolicitud)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDFlujosolicitud", original_FlujoSolicitud.IDFlujosolicitud, theFlujoSolicitud.IDFlujosolicitud));
            values.Add(new FieldValue("IDFlujosolicitudnotas", original_FlujoSolicitud.IDFlujosolicitudnotas, theFlujoSolicitud.IDFlujosolicitudnotas, true));
            values.Add(new FieldValue("IDFlujosolicitudidEmpleadonombrecompleto", original_FlujoSolicitud.IDFlujosolicitudidEmpleadonombrecompleto, theFlujoSolicitud.IDFlujosolicitudidEmpleadonombrecompleto, true));
            values.Add(new FieldValue("Fecha", original_FlujoSolicitud.Fecha, theFlujoSolicitud.Fecha));
            values.Add(new FieldValue("IDEstatus", original_FlujoSolicitud.IDEstatus, theFlujoSolicitud.IDEstatus));
            values.Add(new FieldValue("Observaciones", original_FlujoSolicitud.Observaciones, theFlujoSolicitud.Observaciones));
            values.Add(new FieldValue("CreadoPor", original_FlujoSolicitud.CreadoPor, theFlujoSolicitud.CreadoPor));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.FlujoSolicitud theFlujoSolicitud, IXport.Data.Objects.FlujoSolicitud original_FlujoSolicitud, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "FlujoSolicitud";
            args.View = dataView;
            args.Values = CreateFieldValues(theFlujoSolicitud, original_FlujoSolicitud);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("FlujoSolicitud", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theFlujoSolicitud);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.FlujoSolicitud theFlujoSolicitud, IXport.Data.Objects.FlujoSolicitud original_FlujoSolicitud)
        {
            return ExecuteAction(theFlujoSolicitud, original_FlujoSolicitud, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.FlujoSolicitud theFlujoSolicitud)
        {
            return Update(theFlujoSolicitud, SelectSingle(theFlujoSolicitud.IDFlujosolicitud));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.FlujoSolicitud theFlujoSolicitud)
        {
            return ExecuteAction(theFlujoSolicitud, new FlujoSolicitud(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.FlujoSolicitud theFlujoSolicitud)
        {
            return ExecuteAction(theFlujoSolicitud, theFlujoSolicitud, "Select", "Delete", DeleteView);
        }
    }
}
