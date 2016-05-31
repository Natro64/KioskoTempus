using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class MenuComedor
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaCreacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaDisponible;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _idmenuComedor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _comida;
        
        public MenuComedor()
        {
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
        public DateTime? FechaDisponible
        {
            get
            {
                return _fechaDisponible;
            }
            set
            {
                _fechaDisponible = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? IdmenuComedor
        {
            get
            {
                return _idmenuComedor;
            }
            set
            {
                _idmenuComedor = value;
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
        
        public static List<IXport.Data.Objects.MenuComedor> Select(DateTime? fechaCreacion, string creadoPor, DateTime? fechaDisponible, int? idmenuComedor, int? comida)
        {
            return new MenuComedorFactory().Select(fechaCreacion, creadoPor, fechaDisponible, idmenuComedor, comida);
        }
        
        public static List<IXport.Data.Objects.MenuComedor> Select(IXport.Data.Objects.MenuComedor qbe)
        {
            return new MenuComedorFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.MenuComedor> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new MenuComedorFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.MenuComedor> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new MenuComedorFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.MenuComedor> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new MenuComedorFactory().Select(filter, sort, MenuComedorFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.MenuComedor> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new MenuComedorFactory().Select(filter, sort, MenuComedorFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.MenuComedor> Select(string filter, BusinessObjectParameters parameters)
        {
            return new MenuComedorFactory().Select(filter, null, MenuComedorFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.MenuComedor> Select(string filter, params FieldValue[] parameters)
        {
            return new MenuComedorFactory().Select(filter, null, MenuComedorFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.MenuComedor SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new MenuComedorFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.MenuComedor SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new MenuComedorFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.MenuComedor SelectSingle(int? idmenuComedor)
        {
            return new MenuComedorFactory().SelectSingle(idmenuComedor);
        }
        
        public int Insert()
        {
            return new MenuComedorFactory().Insert(this);
        }
        
        public int Update()
        {
            return new MenuComedorFactory().Update(this);
        }
        
        public int Delete()
        {
            return new MenuComedorFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IdmenuComedor: {0}", this.IdmenuComedor);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class MenuComedorFactory
    {
        
        public MenuComedorFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("MenuComedor");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("MenuComedor");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("MenuComedor");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("MenuComedor");
            }
        }
        
        public static MenuComedorFactory Create()
        {
            return new MenuComedorFactory();
        }
        
        protected virtual PageRequest CreateRequest(DateTime? fechaCreacion, string creadoPor, DateTime? fechaDisponible, int? idmenuComedor, int? comida, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (fechaCreacion.HasValue)
            	filter.Add(("FechaCreacion:=" + fechaCreacion.Value.ToString()));
            if (!(String.IsNullOrEmpty(creadoPor)))
            	filter.Add(("CreadoPor:*" + creadoPor));
            if (fechaDisponible.HasValue)
            	filter.Add(("FechaDisponible:=" + fechaDisponible.Value.ToString()));
            if (idmenuComedor.HasValue)
            	filter.Add(("IdmenuComedor:=" + idmenuComedor.Value.ToString()));
            if (comida.HasValue)
            	filter.Add(("Comida:=" + comida.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.MenuComedor> Select(DateTime? fechaCreacion, string creadoPor, DateTime? fechaDisponible, int? idmenuComedor, int? comida, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(fechaCreacion, creadoPor, fechaDisponible, idmenuComedor, comida, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MenuComedor", dataView, request);
            return page.ToList<IXport.Data.Objects.MenuComedor>();
        }
        
        public List<IXport.Data.Objects.MenuComedor> Select(IXport.Data.Objects.MenuComedor qbe)
        {
            return Select(qbe.FechaCreacion, qbe.CreadoPor, qbe.FechaDisponible, qbe.IdmenuComedor, qbe.Comida);
        }
        
        public int SelectCount(DateTime? fechaCreacion, string creadoPor, DateTime? fechaDisponible, int? idmenuComedor, int? comida, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(fechaCreacion, creadoPor, fechaDisponible, idmenuComedor, comida, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MenuComedor", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.MenuComedor> Select(DateTime? fechaCreacion, string creadoPor, DateTime? fechaDisponible, int? idmenuComedor, int? comida)
        {
            return Select(fechaCreacion, creadoPor, fechaDisponible, idmenuComedor, comida, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.MenuComedor SelectSingle(int? idmenuComedor)
        {
            List<IXport.Data.Objects.MenuComedor> list = Select(null, null, null, idmenuComedor, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.MenuComedor> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("MenuComedor", dataView, request);
            return page.ToList<IXport.Data.Objects.MenuComedor>();
        }
        
        public List<IXport.Data.Objects.MenuComedor> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.MenuComedor> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.MenuComedor SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.MenuComedor> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.MenuComedor theMenuComedor, IXport.Data.Objects.MenuComedor original_MenuComedor)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("FechaCreacion", original_MenuComedor.FechaCreacion, theMenuComedor.FechaCreacion));
            values.Add(new FieldValue("CreadoPor", original_MenuComedor.CreadoPor, theMenuComedor.CreadoPor));
            values.Add(new FieldValue("FechaDisponible", original_MenuComedor.FechaDisponible, theMenuComedor.FechaDisponible));
            values.Add(new FieldValue("IdmenuComedor", original_MenuComedor.IdmenuComedor, theMenuComedor.IdmenuComedor, true));
            values.Add(new FieldValue("Comida", original_MenuComedor.Comida, theMenuComedor.Comida));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.MenuComedor theMenuComedor, IXport.Data.Objects.MenuComedor original_MenuComedor, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "MenuComedor";
            args.View = dataView;
            args.Values = CreateFieldValues(theMenuComedor, original_MenuComedor);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("MenuComedor", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theMenuComedor);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.MenuComedor theMenuComedor, IXport.Data.Objects.MenuComedor original_MenuComedor)
        {
            return ExecuteAction(theMenuComedor, original_MenuComedor, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.MenuComedor theMenuComedor)
        {
            return Update(theMenuComedor, SelectSingle(theMenuComedor.IdmenuComedor));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.MenuComedor theMenuComedor)
        {
            return ExecuteAction(theMenuComedor, new MenuComedor(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.MenuComedor theMenuComedor)
        {
            return ExecuteAction(theMenuComedor, theMenuComedor, "Select", "Delete", DeleteView);
        }
    }
}
