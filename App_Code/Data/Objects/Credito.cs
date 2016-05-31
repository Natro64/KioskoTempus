using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Credito
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDEmpleado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _theidEmpleadonombrecompleto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDCredito;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipoDesc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _inicioDesc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _asignaCredito;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _numCredito;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _valorDesc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _dismTasa;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modificadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _creadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modificadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _observaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _activo;
        
        public Credito()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? IDCredito
        {
            get
            {
                return _iDCredito;
            }
            set
            {
                _iDCredito = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? TipoDesc
        {
            get
            {
                return _tipoDesc;
            }
            set
            {
                _tipoDesc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? Tipo
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? InicioDesc
        {
            get
            {
                return _inicioDesc;
            }
            set
            {
                _inicioDesc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? AsignaCredito
        {
            get
            {
                return _asignaCredito;
            }
            set
            {
                _asignaCredito = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NumCredito
        {
            get
            {
                return _numCredito;
            }
            set
            {
                _numCredito = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? ValorDesc
        {
            get
            {
                return _valorDesc;
            }
            set
            {
                _valorDesc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? DismTasa
        {
            get
            {
                return _dismTasa;
            }
            set
            {
                _dismTasa = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        public DateTime? CreadoEn
        {
            get
            {
                return _creadoEn;
            }
            set
            {
                _creadoEn = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? ModificadoEn
        {
            get
            {
                return _modificadoEn;
            }
            set
            {
                _modificadoEn = value;
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
        public bool? Activo
        {
            get
            {
                return _activo;
            }
            set
            {
                _activo = value;
            }
        }
        
        public static List<IXport.Data.Objects.Credito> Select(
                    int? iDEmpleado, 
                    string theidEmpleadonombrecompleto, 
                    int? iDCredito, 
                    int? tipoDesc, 
                    int? tipo, 
                    DateTime? inicioDesc, 
                    DateTime? asignaCredito, 
                    string numCredito, 
                    decimal? valorDesc, 
                    bool? dismTasa, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string observaciones, 
                    bool? activo)
        {
            return new CreditoFactory().Select(iDEmpleado, theidEmpleadonombrecompleto, iDCredito, tipoDesc, tipo, inicioDesc, asignaCredito, numCredito, valorDesc, dismTasa, creadoPor, modificadoPor, creadoEn, modificadoEn, observaciones, activo);
        }
        
        public static List<IXport.Data.Objects.Credito> Select(IXport.Data.Objects.Credito qbe)
        {
            return new CreditoFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.Credito> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CreditoFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.Credito> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CreditoFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Credito> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CreditoFactory().Select(filter, sort, CreditoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Credito> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CreditoFactory().Select(filter, sort, CreditoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Credito> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CreditoFactory().Select(filter, null, CreditoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Credito> Select(string filter, params FieldValue[] parameters)
        {
            return new CreditoFactory().Select(filter, null, CreditoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Credito SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CreditoFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.Credito SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CreditoFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Credito SelectSingle(int? iDEmpleado, int? iDCredito)
        {
            return new CreditoFactory().SelectSingle(iDEmpleado, iDCredito);
        }
        
        public int Insert()
        {
            return new CreditoFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CreditoFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CreditoFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDEmpleado: {0}; IDCredito: {1}", this.IDEmpleado, this.IDCredito);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CreditoFactory
    {
        
        public CreditoFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Credito");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Credito");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Credito");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Credito");
            }
        }
        
        public static CreditoFactory Create()
        {
            return new CreditoFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? iDEmpleado, 
                    string theidEmpleadonombrecompleto, 
                    int? iDCredito, 
                    int? tipoDesc, 
                    int? tipo, 
                    DateTime? inicioDesc, 
                    DateTime? asignaCredito, 
                    string numCredito, 
                    decimal? valorDesc, 
                    bool? dismTasa, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string observaciones, 
                    bool? activo, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDEmpleado.HasValue)
            	filter.Add(("IDEmpleado:=" + iDEmpleado.Value.ToString()));
            if (!(String.IsNullOrEmpty(theidEmpleadonombrecompleto)))
            	filter.Add(("TheidEmpleadonombrecompleto:*" + theidEmpleadonombrecompleto));
            if (iDCredito.HasValue)
            	filter.Add(("IDCredito:=" + iDCredito.Value.ToString()));
            if (tipoDesc.HasValue)
            	filter.Add(("TipoDesc:=" + tipoDesc.Value.ToString()));
            if (tipo.HasValue)
            	filter.Add(("Tipo:=" + tipo.Value.ToString()));
            if (inicioDesc.HasValue)
            	filter.Add(("InicioDesc:=" + inicioDesc.Value.ToString()));
            if (asignaCredito.HasValue)
            	filter.Add(("AsignaCredito:=" + asignaCredito.Value.ToString()));
            if (!(String.IsNullOrEmpty(numCredito)))
            	filter.Add(("NumCredito:*" + numCredito));
            if (valorDesc.HasValue)
            	filter.Add(("ValorDesc:=" + valorDesc.Value.ToString()));
            if (dismTasa.HasValue)
            	filter.Add(("DismTasa:=" + dismTasa.Value.ToString()));
            if (!(String.IsNullOrEmpty(creadoPor)))
            	filter.Add(("CreadoPor:*" + creadoPor));
            if (!(String.IsNullOrEmpty(modificadoPor)))
            	filter.Add(("ModificadoPor:*" + modificadoPor));
            if (creadoEn.HasValue)
            	filter.Add(("CreadoEn:=" + creadoEn.Value.ToString()));
            if (modificadoEn.HasValue)
            	filter.Add(("ModificadoEn:=" + modificadoEn.Value.ToString()));
            if (!(String.IsNullOrEmpty(observaciones)))
            	filter.Add(("Observaciones:*" + observaciones));
            if (activo.HasValue)
            	filter.Add(("Activo:=" + activo.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.Credito> Select(
                    int? iDEmpleado, 
                    string theidEmpleadonombrecompleto, 
                    int? iDCredito, 
                    int? tipoDesc, 
                    int? tipo, 
                    DateTime? inicioDesc, 
                    DateTime? asignaCredito, 
                    string numCredito, 
                    decimal? valorDesc, 
                    bool? dismTasa, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string observaciones, 
                    bool? activo, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDEmpleado, theidEmpleadonombrecompleto, iDCredito, tipoDesc, tipo, inicioDesc, asignaCredito, numCredito, valorDesc, dismTasa, creadoPor, modificadoPor, creadoEn, modificadoEn, observaciones, activo, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Credito", dataView, request);
            return page.ToList<IXport.Data.Objects.Credito>();
        }
        
        public List<IXport.Data.Objects.Credito> Select(IXport.Data.Objects.Credito qbe)
        {
            return Select(qbe.IDEmpleado, qbe.TheidEmpleadonombrecompleto, qbe.IDCredito, qbe.TipoDesc, qbe.Tipo, qbe.InicioDesc, qbe.AsignaCredito, qbe.NumCredito, qbe.ValorDesc, qbe.DismTasa, qbe.CreadoPor, qbe.ModificadoPor, qbe.CreadoEn, qbe.ModificadoEn, qbe.Observaciones, qbe.Activo);
        }
        
        public int SelectCount(
                    int? iDEmpleado, 
                    string theidEmpleadonombrecompleto, 
                    int? iDCredito, 
                    int? tipoDesc, 
                    int? tipo, 
                    DateTime? inicioDesc, 
                    DateTime? asignaCredito, 
                    string numCredito, 
                    decimal? valorDesc, 
                    bool? dismTasa, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string observaciones, 
                    bool? activo, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDEmpleado, theidEmpleadonombrecompleto, iDCredito, tipoDesc, tipo, inicioDesc, asignaCredito, numCredito, valorDesc, dismTasa, creadoPor, modificadoPor, creadoEn, modificadoEn, observaciones, activo, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Credito", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.Credito> Select(
                    int? iDEmpleado, 
                    string theidEmpleadonombrecompleto, 
                    int? iDCredito, 
                    int? tipoDesc, 
                    int? tipo, 
                    DateTime? inicioDesc, 
                    DateTime? asignaCredito, 
                    string numCredito, 
                    decimal? valorDesc, 
                    bool? dismTasa, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string observaciones, 
                    bool? activo)
        {
            return Select(iDEmpleado, theidEmpleadonombrecompleto, iDCredito, tipoDesc, tipo, inicioDesc, asignaCredito, numCredito, valorDesc, dismTasa, creadoPor, modificadoPor, creadoEn, modificadoEn, observaciones, activo, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.Credito SelectSingle(int? iDEmpleado, int? iDCredito)
        {
            List<IXport.Data.Objects.Credito> list = Select(iDEmpleado, null, iDCredito, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.Credito> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Credito", dataView, request);
            return page.ToList<IXport.Data.Objects.Credito>();
        }
        
        public List<IXport.Data.Objects.Credito> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.Credito> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.Credito SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.Credito> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.Credito theCredito, IXport.Data.Objects.Credito original_Credito)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDEmpleado", original_Credito.IDEmpleado, theCredito.IDEmpleado));
            values.Add(new FieldValue("TheidEmpleadonombrecompleto", original_Credito.TheidEmpleadonombrecompleto, theCredito.TheidEmpleadonombrecompleto, true));
            values.Add(new FieldValue("IDCredito", original_Credito.IDCredito, theCredito.IDCredito, true));
            values.Add(new FieldValue("TipoDesc", original_Credito.TipoDesc, theCredito.TipoDesc));
            values.Add(new FieldValue("Tipo", original_Credito.Tipo, theCredito.Tipo));
            values.Add(new FieldValue("InicioDesc", original_Credito.InicioDesc, theCredito.InicioDesc));
            values.Add(new FieldValue("AsignaCredito", original_Credito.AsignaCredito, theCredito.AsignaCredito));
            values.Add(new FieldValue("NumCredito", original_Credito.NumCredito, theCredito.NumCredito));
            values.Add(new FieldValue("ValorDesc", original_Credito.ValorDesc, theCredito.ValorDesc));
            values.Add(new FieldValue("DismTasa", original_Credito.DismTasa, theCredito.DismTasa));
            values.Add(new FieldValue("CreadoPor", original_Credito.CreadoPor, theCredito.CreadoPor));
            values.Add(new FieldValue("ModificadoPor", original_Credito.ModificadoPor, theCredito.ModificadoPor));
            values.Add(new FieldValue("CreadoEn", original_Credito.CreadoEn, theCredito.CreadoEn));
            values.Add(new FieldValue("ModificadoEn", original_Credito.ModificadoEn, theCredito.ModificadoEn));
            values.Add(new FieldValue("Observaciones", original_Credito.Observaciones, theCredito.Observaciones));
            values.Add(new FieldValue("Activo", original_Credito.Activo, theCredito.Activo));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.Credito theCredito, IXport.Data.Objects.Credito original_Credito, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Credito";
            args.View = dataView;
            args.Values = CreateFieldValues(theCredito, original_Credito);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Credito", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCredito);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.Credito theCredito, IXport.Data.Objects.Credito original_Credito)
        {
            return ExecuteAction(theCredito, original_Credito, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.Credito theCredito)
        {
            return Update(theCredito, SelectSingle(theCredito.IDEmpleado, theCredito.IDCredito));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.Credito theCredito)
        {
            return ExecuteAction(theCredito, new Credito(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.Credito theCredito)
        {
            return ExecuteAction(theCredito, theCredito, "Select", "Delete", DeleteView);
        }
    }
}
