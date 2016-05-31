using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class PrecioComida
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _iDPreciocomida;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _precio;
        
        public PrecioComida()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public byte? IDPreciocomida
        {
            get
            {
                return _iDPreciocomida;
            }
            set
            {
                _iDPreciocomida = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }
        
        public static List<IXport.Data.Objects.PrecioComida> Select(byte? iDPreciocomida, string tipo, decimal? precio)
        {
            return new PrecioComidaFactory().Select(iDPreciocomida, tipo, precio);
        }
        
        public static List<IXport.Data.Objects.PrecioComida> Select(IXport.Data.Objects.PrecioComida qbe)
        {
            return new PrecioComidaFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.PrecioComida> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new PrecioComidaFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.PrecioComida> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new PrecioComidaFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.PrecioComida> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new PrecioComidaFactory().Select(filter, sort, PrecioComidaFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.PrecioComida> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new PrecioComidaFactory().Select(filter, sort, PrecioComidaFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.PrecioComida> Select(string filter, BusinessObjectParameters parameters)
        {
            return new PrecioComidaFactory().Select(filter, null, PrecioComidaFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.PrecioComida> Select(string filter, params FieldValue[] parameters)
        {
            return new PrecioComidaFactory().Select(filter, null, PrecioComidaFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.PrecioComida SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new PrecioComidaFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.PrecioComida SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new PrecioComidaFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.PrecioComida SelectSingle(byte? iDPreciocomida)
        {
            return new PrecioComidaFactory().SelectSingle(iDPreciocomida);
        }
        
        public int Insert()
        {
            return new PrecioComidaFactory().Insert(this);
        }
        
        public int Update()
        {
            return new PrecioComidaFactory().Update(this);
        }
        
        public int Delete()
        {
            return new PrecioComidaFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDPreciocomida: {0}", this.IDPreciocomida);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class PrecioComidaFactory
    {
        
        public PrecioComidaFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("PrecioComida");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("PrecioComida");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("PrecioComida");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("PrecioComida");
            }
        }
        
        public static PrecioComidaFactory Create()
        {
            return new PrecioComidaFactory();
        }
        
        protected virtual PageRequest CreateRequest(byte? iDPreciocomida, string tipo, decimal? precio, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDPreciocomida.HasValue)
            	filter.Add(("IDPreciocomida:=" + iDPreciocomida.Value.ToString()));
            if (!(String.IsNullOrEmpty(tipo)))
            	filter.Add(("Tipo:*" + tipo));
            if (precio.HasValue)
            	filter.Add(("Precio:=" + precio.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.PrecioComida> Select(byte? iDPreciocomida, string tipo, decimal? precio, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDPreciocomida, tipo, precio, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("PrecioComida", dataView, request);
            return page.ToList<IXport.Data.Objects.PrecioComida>();
        }
        
        public List<IXport.Data.Objects.PrecioComida> Select(IXport.Data.Objects.PrecioComida qbe)
        {
            return Select(qbe.IDPreciocomida, qbe.Tipo, qbe.Precio);
        }
        
        public int SelectCount(byte? iDPreciocomida, string tipo, decimal? precio, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDPreciocomida, tipo, precio, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("PrecioComida", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.PrecioComida> Select(byte? iDPreciocomida, string tipo, decimal? precio)
        {
            return Select(iDPreciocomida, tipo, precio, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.PrecioComida SelectSingle(byte? iDPreciocomida)
        {
            string emptyTipo = null;
            decimal? emptyPrecio = null;
            List<IXport.Data.Objects.PrecioComida> list = Select(iDPreciocomida, emptyTipo, emptyPrecio);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.PrecioComida> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("PrecioComida", dataView, request);
            return page.ToList<IXport.Data.Objects.PrecioComida>();
        }
        
        public List<IXport.Data.Objects.PrecioComida> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.PrecioComida> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.PrecioComida SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.PrecioComida> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.PrecioComida thePrecioComida, IXport.Data.Objects.PrecioComida original_PrecioComida)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDPreciocomida", original_PrecioComida.IDPreciocomida, thePrecioComida.IDPreciocomida, true));
            values.Add(new FieldValue("Tipo", original_PrecioComida.Tipo, thePrecioComida.Tipo));
            values.Add(new FieldValue("Precio", original_PrecioComida.Precio, thePrecioComida.Precio));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.PrecioComida thePrecioComida, IXport.Data.Objects.PrecioComida original_PrecioComida, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "PrecioComida";
            args.View = dataView;
            args.Values = CreateFieldValues(thePrecioComida, original_PrecioComida);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("PrecioComida", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(thePrecioComida);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.PrecioComida thePrecioComida, IXport.Data.Objects.PrecioComida original_PrecioComida)
        {
            return ExecuteAction(thePrecioComida, original_PrecioComida, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.PrecioComida thePrecioComida)
        {
            return Update(thePrecioComida, SelectSingle(thePrecioComida.IDPreciocomida));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.PrecioComida thePrecioComida)
        {
            return ExecuteAction(thePrecioComida, new PrecioComida(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.PrecioComida thePrecioComida)
        {
            return ExecuteAction(thePrecioComida, thePrecioComida, "Select", "Delete", DeleteView);
        }
    }
}
