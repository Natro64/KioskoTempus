using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class ConsumoComedor
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDConsumocomedor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDEmpleado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _theidEmpleadonombrecompleto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaConsumo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaCreacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDComidacomedor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _comida;
        
        public ConsumoComedor()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? IDConsumocomedor
        {
            get
            {
                return _iDConsumocomedor;
            }
            set
            {
                _iDConsumocomedor = value;
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
        public string TheidEmpleadonombrecompleto
        {
            get
            {
                return _theidEmpleadonombrecompleto;
            }
            set
            {
                _theidEmpleadonombrecompleto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? FechaConsumo
        {
            get
            {
                return _fechaConsumo;
            }
            set
            {
                _fechaConsumo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FechaCreacion
        {
            get
            {
                return _fechaCreacion;
            }
            set
            {
                _fechaCreacion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? IDComidacomedor
        {
            get
            {
                return _iDComidacomedor;
            }
            set
            {
                _iDComidacomedor = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? Comida
        {
            get
            {
                return _comida;
            }
            set
            {
                _comida = value;
            }
        }
        
        public static List<IXport.Data.Objects.ConsumoComedor> Select(int? iDConsumocomedor, int? iDEmpleado, string theidEmpleadonombrecompleto, DateTime? fechaConsumo, DateTime? fechaCreacion, int? iDComidacomedor, string creadoPor, int? comida)
        {
            return new ConsumoComedorFactory().Select(iDConsumocomedor, iDEmpleado, theidEmpleadonombrecompleto, fechaConsumo, fechaCreacion, iDComidacomedor, creadoPor, comida);
        }
        
        public static List<IXport.Data.Objects.ConsumoComedor> Select(IXport.Data.Objects.ConsumoComedor qbe)
        {
            return new ConsumoComedorFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.ConsumoComedor> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ConsumoComedorFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.ConsumoComedor> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ConsumoComedorFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.ConsumoComedor> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ConsumoComedorFactory().Select(filter, sort, ConsumoComedorFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.ConsumoComedor> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ConsumoComedorFactory().Select(filter, sort, ConsumoComedorFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.ConsumoComedor> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ConsumoComedorFactory().Select(filter, null, ConsumoComedorFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.ConsumoComedor> Select(string filter, params FieldValue[] parameters)
        {
            return new ConsumoComedorFactory().Select(filter, null, ConsumoComedorFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.ConsumoComedor SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ConsumoComedorFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.ConsumoComedor SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ConsumoComedorFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.ConsumoComedor SelectSingle(int? iDConsumocomedor)
        {
            return new ConsumoComedorFactory().SelectSingle(iDConsumocomedor);
        }
        
        public int Insert()
        {
            return new ConsumoComedorFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ConsumoComedorFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ConsumoComedorFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDConsumocomedor: {0}", this.IDConsumocomedor);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ConsumoComedorFactory
    {
        
        public ConsumoComedorFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ConsumoComedor");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ConsumoComedor");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ConsumoComedor");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ConsumoComedor");
            }
        }
        
        public static ConsumoComedorFactory Create()
        {
            return new ConsumoComedorFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? iDConsumocomedor, int? iDEmpleado, string theidEmpleadonombrecompleto, DateTime? fechaConsumo, DateTime? fechaCreacion, int? iDComidacomedor, string creadoPor, int? comida, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDConsumocomedor.HasValue)
            	filter.Add(("IDConsumocomedor:=" + iDConsumocomedor.Value.ToString()));
            if (iDEmpleado.HasValue)
            	filter.Add(("IDEmpleado:=" + iDEmpleado.Value.ToString()));
            if (!(String.IsNullOrEmpty(theidEmpleadonombrecompleto)))
            	filter.Add(("TheidEmpleadonombrecompleto:*" + theidEmpleadonombrecompleto));
            if (fechaConsumo.HasValue)
            	filter.Add(("FechaConsumo:=" + fechaConsumo.Value.ToString()));
            if (fechaCreacion.HasValue)
            	filter.Add(("FechaCreacion:=" + fechaCreacion.Value.ToString()));
            if (iDComidacomedor.HasValue)
            	filter.Add(("IDComidacomedor:=" + iDComidacomedor.Value.ToString()));
            if (!(String.IsNullOrEmpty(creadoPor)))
            	filter.Add(("CreadoPor:*" + creadoPor));
            if (comida.HasValue)
            	filter.Add(("Comida:=" + comida.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.ConsumoComedor> Select(int? iDConsumocomedor, int? iDEmpleado, string theidEmpleadonombrecompleto, DateTime? fechaConsumo, DateTime? fechaCreacion, int? iDComidacomedor, string creadoPor, int? comida, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDConsumocomedor, iDEmpleado, theidEmpleadonombrecompleto, fechaConsumo, fechaCreacion, iDComidacomedor, creadoPor, comida, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ConsumoComedor", dataView, request);
            return page.ToList<IXport.Data.Objects.ConsumoComedor>();
        }
        
        public List<IXport.Data.Objects.ConsumoComedor> Select(IXport.Data.Objects.ConsumoComedor qbe)
        {
            return Select(qbe.IDConsumocomedor, qbe.IDEmpleado, qbe.TheidEmpleadonombrecompleto, qbe.FechaConsumo, qbe.FechaCreacion, qbe.IDComidacomedor, qbe.CreadoPor, qbe.Comida);
        }
        
        public int SelectCount(int? iDConsumocomedor, int? iDEmpleado, string theidEmpleadonombrecompleto, DateTime? fechaConsumo, DateTime? fechaCreacion, int? iDComidacomedor, string creadoPor, int? comida, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDConsumocomedor, iDEmpleado, theidEmpleadonombrecompleto, fechaConsumo, fechaCreacion, iDComidacomedor, creadoPor, comida, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ConsumoComedor", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.ConsumoComedor> Select(int? iDConsumocomedor, int? iDEmpleado, string theidEmpleadonombrecompleto, DateTime? fechaConsumo, DateTime? fechaCreacion, int? iDComidacomedor, string creadoPor, int? comida)
        {
            return Select(iDConsumocomedor, iDEmpleado, theidEmpleadonombrecompleto, fechaConsumo, fechaCreacion, iDComidacomedor, creadoPor, comida, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.ConsumoComedor SelectSingle(int? iDConsumocomedor)
        {
            List<IXport.Data.Objects.ConsumoComedor> list = Select(iDConsumocomedor, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.ConsumoComedor> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("ConsumoComedor", dataView, request);
            return page.ToList<IXport.Data.Objects.ConsumoComedor>();
        }
        
        public List<IXport.Data.Objects.ConsumoComedor> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.ConsumoComedor> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.ConsumoComedor SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.ConsumoComedor> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.ConsumoComedor theConsumoComedor, IXport.Data.Objects.ConsumoComedor original_ConsumoComedor)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDConsumocomedor", original_ConsumoComedor.IDConsumocomedor, theConsumoComedor.IDConsumocomedor, true));
            values.Add(new FieldValue("IDEmpleado", original_ConsumoComedor.IDEmpleado, theConsumoComedor.IDEmpleado));
            values.Add(new FieldValue("TheidEmpleadonombrecompleto", original_ConsumoComedor.TheidEmpleadonombrecompleto, theConsumoComedor.TheidEmpleadonombrecompleto, true));
            values.Add(new FieldValue("FechaConsumo", original_ConsumoComedor.FechaConsumo, theConsumoComedor.FechaConsumo));
            values.Add(new FieldValue("FechaCreacion", original_ConsumoComedor.FechaCreacion, theConsumoComedor.FechaCreacion));
            values.Add(new FieldValue("IDComidacomedor", original_ConsumoComedor.IDComidacomedor, theConsumoComedor.IDComidacomedor));
            values.Add(new FieldValue("CreadoPor", original_ConsumoComedor.CreadoPor, theConsumoComedor.CreadoPor));
            values.Add(new FieldValue("Comida", original_ConsumoComedor.Comida, theConsumoComedor.Comida));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.ConsumoComedor theConsumoComedor, IXport.Data.Objects.ConsumoComedor original_ConsumoComedor, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "ConsumoComedor";
            args.View = dataView;
            args.Values = CreateFieldValues(theConsumoComedor, original_ConsumoComedor);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("ConsumoComedor", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theConsumoComedor);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.ConsumoComedor theConsumoComedor, IXport.Data.Objects.ConsumoComedor original_ConsumoComedor)
        {
            return ExecuteAction(theConsumoComedor, original_ConsumoComedor, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.ConsumoComedor theConsumoComedor)
        {
            return Update(theConsumoComedor, SelectSingle(theConsumoComedor.IDConsumocomedor));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.ConsumoComedor theConsumoComedor)
        {
            return ExecuteAction(theConsumoComedor, new ConsumoComedor(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.ConsumoComedor theConsumoComedor)
        {
            return ExecuteAction(theConsumoComedor, theConsumoComedor, "Select", "Delete", DeleteView);
        }
    }
}
