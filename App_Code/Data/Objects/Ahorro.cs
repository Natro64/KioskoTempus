using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Ahorro
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipoahorro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipoahorrodescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDEmpleado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _theidEmpleadonombrecompleto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _otrosAbonos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _otrosCargos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formula;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _cantidad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _saldoInicial;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _status;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _saldoActual;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _total;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modificadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _creadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modificadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDAhorro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cuentaContable;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _observaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formulaSql;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saldarFiniquito;
        
        public Ahorro()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string IDTipoahorro
        {
            get
            {
                return _iDTipoahorro;
            }
            set
            {
                _iDTipoahorro = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDTipoahorrodescripcion
        {
            get
            {
                return _iDTipoahorrodescripcion;
            }
            set
            {
                _iDTipoahorrodescripcion = value;
            }
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? OtrosAbonos
        {
            get
            {
                return _otrosAbonos;
            }
            set
            {
                _otrosAbonos = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? OtrosCargos
        {
            get
            {
                return _otrosCargos;
            }
            set
            {
                _otrosCargos = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Formula
        {
            get
            {
                return _formula;
            }
            set
            {
                _formula = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public short? Cantidad
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? SaldoInicial
        {
            get
            {
                return _saldoInicial;
            }
            set
            {
                _saldoInicial = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public short? Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? SaldoActual
        {
            get
            {
                return _saldoActual;
            }
            set
            {
                _saldoActual = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
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
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? IDAhorro
        {
            get
            {
                return _iDAhorro;
            }
            set
            {
                _iDAhorro = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CuentaContable
        {
            get
            {
                return _cuentaContable;
            }
            set
            {
                _cuentaContable = value;
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
        public string FormulaSql
        {
            get
            {
                return _formulaSql;
            }
            set
            {
                _formulaSql = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaldarFiniquito
        {
            get
            {
                return _saldarFiniquito;
            }
            set
            {
                _saldarFiniquito = value;
            }
        }
        
        public static List<IXport.Data.Objects.Ahorro> Select(
                    string iDTipoahorro, 
                    string iDTipoahorrodescripcion, 
                    int? iDEmpleado, 
                    string theidEmpleadonombrecompleto, 
                    decimal? otrosAbonos, 
                    decimal? otrosCargos, 
                    DateTime? fecha, 
                    short? cantidad, 
                    decimal? saldoInicial, 
                    short? status, 
                    decimal? saldoActual, 
                    decimal? total, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    int? iDAhorro, 
                    string cuentaContable, 
                    string observaciones, 
                    string saldarFiniquito)
        {
            return new AhorroFactory().Select(iDTipoahorro, iDTipoahorrodescripcion, iDEmpleado, theidEmpleadonombrecompleto, otrosAbonos, otrosCargos, fecha, cantidad, saldoInicial, status, saldoActual, total, creadoPor, modificadoPor, creadoEn, modificadoEn, iDAhorro, cuentaContable, observaciones, saldarFiniquito);
        }
        
        public static List<IXport.Data.Objects.Ahorro> Select(IXport.Data.Objects.Ahorro qbe)
        {
            return new AhorroFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.Ahorro> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AhorroFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.Ahorro> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AhorroFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Ahorro> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AhorroFactory().Select(filter, sort, AhorroFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Ahorro> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AhorroFactory().Select(filter, sort, AhorroFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Ahorro> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AhorroFactory().Select(filter, null, AhorroFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Ahorro> Select(string filter, params FieldValue[] parameters)
        {
            return new AhorroFactory().Select(filter, null, AhorroFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Ahorro SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AhorroFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.Ahorro SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AhorroFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Ahorro SelectSingle(int? iDEmpleado, int? iDAhorro)
        {
            return new AhorroFactory().SelectSingle(iDEmpleado, iDAhorro);
        }
        
        public int Insert()
        {
            return new AhorroFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AhorroFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AhorroFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDEmpleado: {0}; IDAhorro: {1}", this.IDEmpleado, this.IDAhorro);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AhorroFactory
    {
        
        public AhorroFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Ahorro");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Ahorro");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Ahorro");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Ahorro");
            }
        }
        
        public static AhorroFactory Create()
        {
            return new AhorroFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    string iDTipoahorro, 
                    string iDTipoahorrodescripcion, 
                    int? iDEmpleado, 
                    string theidEmpleadonombrecompleto, 
                    decimal? otrosAbonos, 
                    decimal? otrosCargos, 
                    DateTime? fecha, 
                    short? cantidad, 
                    decimal? saldoInicial, 
                    short? status, 
                    decimal? saldoActual, 
                    decimal? total, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    int? iDAhorro, 
                    string cuentaContable, 
                    string observaciones, 
                    string saldarFiniquito, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (!(String.IsNullOrEmpty(iDTipoahorro)))
            	filter.Add(("IDTipoahorro:*" + iDTipoahorro));
            if (!(String.IsNullOrEmpty(iDTipoahorrodescripcion)))
            	filter.Add(("IDTipoahorrodescripcion:*" + iDTipoahorrodescripcion));
            if (iDEmpleado.HasValue)
            	filter.Add(("IDEmpleado:=" + iDEmpleado.Value.ToString()));
            if (!(String.IsNullOrEmpty(theidEmpleadonombrecompleto)))
            	filter.Add(("TheidEmpleadonombrecompleto:*" + theidEmpleadonombrecompleto));
            if (otrosAbonos.HasValue)
            	filter.Add(("OtrosAbonos:=" + otrosAbonos.Value.ToString()));
            if (otrosCargos.HasValue)
            	filter.Add(("OtrosCargos:=" + otrosCargos.Value.ToString()));
            if (fecha.HasValue)
            	filter.Add(("Fecha:=" + fecha.Value.ToString()));
            if (cantidad.HasValue)
            	filter.Add(("Cantidad:=" + cantidad.Value.ToString()));
            if (saldoInicial.HasValue)
            	filter.Add(("SaldoInicial:=" + saldoInicial.Value.ToString()));
            if (status.HasValue)
            	filter.Add(("Status:=" + status.Value.ToString()));
            if (saldoActual.HasValue)
            	filter.Add(("SaldoActual:=" + saldoActual.Value.ToString()));
            if (total.HasValue)
            	filter.Add(("Total:=" + total.Value.ToString()));
            if (!(String.IsNullOrEmpty(creadoPor)))
            	filter.Add(("CreadoPor:*" + creadoPor));
            if (!(String.IsNullOrEmpty(modificadoPor)))
            	filter.Add(("ModificadoPor:*" + modificadoPor));
            if (creadoEn.HasValue)
            	filter.Add(("CreadoEn:=" + creadoEn.Value.ToString()));
            if (modificadoEn.HasValue)
            	filter.Add(("ModificadoEn:=" + modificadoEn.Value.ToString()));
            if (iDAhorro.HasValue)
            	filter.Add(("IDAhorro:=" + iDAhorro.Value.ToString()));
            if (!(String.IsNullOrEmpty(cuentaContable)))
            	filter.Add(("CuentaContable:*" + cuentaContable));
            if (!(String.IsNullOrEmpty(observaciones)))
            	filter.Add(("Observaciones:*" + observaciones));
            if (!(String.IsNullOrEmpty(saldarFiniquito)))
            	filter.Add(("SaldarFiniquito:*" + saldarFiniquito));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.Ahorro> Select(
                    string iDTipoahorro, 
                    string iDTipoahorrodescripcion, 
                    int? iDEmpleado, 
                    string theidEmpleadonombrecompleto, 
                    decimal? otrosAbonos, 
                    decimal? otrosCargos, 
                    DateTime? fecha, 
                    short? cantidad, 
                    decimal? saldoInicial, 
                    short? status, 
                    decimal? saldoActual, 
                    decimal? total, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    int? iDAhorro, 
                    string cuentaContable, 
                    string observaciones, 
                    string saldarFiniquito, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDTipoahorro, iDTipoahorrodescripcion, iDEmpleado, theidEmpleadonombrecompleto, otrosAbonos, otrosCargos, fecha, cantidad, saldoInicial, status, saldoActual, total, creadoPor, modificadoPor, creadoEn, modificadoEn, iDAhorro, cuentaContable, observaciones, saldarFiniquito, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Ahorro", dataView, request);
            return page.ToList<IXport.Data.Objects.Ahorro>();
        }
        
        public List<IXport.Data.Objects.Ahorro> Select(IXport.Data.Objects.Ahorro qbe)
        {
            return Select(qbe.IDTipoahorro, qbe.IDTipoahorrodescripcion, qbe.IDEmpleado, qbe.TheidEmpleadonombrecompleto, qbe.OtrosAbonos, qbe.OtrosCargos, qbe.Fecha, qbe.Cantidad, qbe.SaldoInicial, qbe.Status, qbe.SaldoActual, qbe.Total, qbe.CreadoPor, qbe.ModificadoPor, qbe.CreadoEn, qbe.ModificadoEn, qbe.IDAhorro, qbe.CuentaContable, qbe.Observaciones, qbe.SaldarFiniquito);
        }
        
        public int SelectCount(
                    string iDTipoahorro, 
                    string iDTipoahorrodescripcion, 
                    int? iDEmpleado, 
                    string theidEmpleadonombrecompleto, 
                    decimal? otrosAbonos, 
                    decimal? otrosCargos, 
                    DateTime? fecha, 
                    short? cantidad, 
                    decimal? saldoInicial, 
                    short? status, 
                    decimal? saldoActual, 
                    decimal? total, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    int? iDAhorro, 
                    string cuentaContable, 
                    string observaciones, 
                    string saldarFiniquito, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDTipoahorro, iDTipoahorrodescripcion, iDEmpleado, theidEmpleadonombrecompleto, otrosAbonos, otrosCargos, fecha, cantidad, saldoInicial, status, saldoActual, total, creadoPor, modificadoPor, creadoEn, modificadoEn, iDAhorro, cuentaContable, observaciones, saldarFiniquito, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Ahorro", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.Ahorro> Select(
                    string iDTipoahorro, 
                    string iDTipoahorrodescripcion, 
                    int? iDEmpleado, 
                    string theidEmpleadonombrecompleto, 
                    decimal? otrosAbonos, 
                    decimal? otrosCargos, 
                    DateTime? fecha, 
                    short? cantidad, 
                    decimal? saldoInicial, 
                    short? status, 
                    decimal? saldoActual, 
                    decimal? total, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    int? iDAhorro, 
                    string cuentaContable, 
                    string observaciones, 
                    string saldarFiniquito)
        {
            return Select(iDTipoahorro, iDTipoahorrodescripcion, iDEmpleado, theidEmpleadonombrecompleto, otrosAbonos, otrosCargos, fecha, cantidad, saldoInicial, status, saldoActual, total, creadoPor, modificadoPor, creadoEn, modificadoEn, iDAhorro, cuentaContable, observaciones, saldarFiniquito, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.Ahorro SelectSingle(int? iDEmpleado, int? iDAhorro)
        {
            List<IXport.Data.Objects.Ahorro> list = Select(null, null, iDEmpleado, null, null, null, null, null, null, null, null, null, null, null, null, null, iDAhorro, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.Ahorro> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Ahorro", dataView, request);
            return page.ToList<IXport.Data.Objects.Ahorro>();
        }
        
        public List<IXport.Data.Objects.Ahorro> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.Ahorro> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.Ahorro SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.Ahorro> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.Ahorro theAhorro, IXport.Data.Objects.Ahorro original_Ahorro)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDTipoahorro", original_Ahorro.IDTipoahorro, theAhorro.IDTipoahorro));
            values.Add(new FieldValue("IDTipoahorrodescripcion", original_Ahorro.IDTipoahorrodescripcion, theAhorro.IDTipoahorrodescripcion, true));
            values.Add(new FieldValue("IDEmpleado", original_Ahorro.IDEmpleado, theAhorro.IDEmpleado));
            values.Add(new FieldValue("TheidEmpleadonombrecompleto", original_Ahorro.TheidEmpleadonombrecompleto, theAhorro.TheidEmpleadonombrecompleto, true));
            values.Add(new FieldValue("OtrosAbonos", original_Ahorro.OtrosAbonos, theAhorro.OtrosAbonos));
            values.Add(new FieldValue("OtrosCargos", original_Ahorro.OtrosCargos, theAhorro.OtrosCargos));
            values.Add(new FieldValue("Fecha", original_Ahorro.Fecha, theAhorro.Fecha));
            values.Add(new FieldValue("Formula", original_Ahorro.Formula, theAhorro.Formula));
            values.Add(new FieldValue("Cantidad", original_Ahorro.Cantidad, theAhorro.Cantidad));
            values.Add(new FieldValue("SaldoInicial", original_Ahorro.SaldoInicial, theAhorro.SaldoInicial));
            values.Add(new FieldValue("Status", original_Ahorro.Status, theAhorro.Status));
            values.Add(new FieldValue("SaldoActual", original_Ahorro.SaldoActual, theAhorro.SaldoActual));
            values.Add(new FieldValue("Total", original_Ahorro.Total, theAhorro.Total));
            values.Add(new FieldValue("CreadoPor", original_Ahorro.CreadoPor, theAhorro.CreadoPor));
            values.Add(new FieldValue("ModificadoPor", original_Ahorro.ModificadoPor, theAhorro.ModificadoPor));
            values.Add(new FieldValue("CreadoEn", original_Ahorro.CreadoEn, theAhorro.CreadoEn));
            values.Add(new FieldValue("ModificadoEn", original_Ahorro.ModificadoEn, theAhorro.ModificadoEn));
            values.Add(new FieldValue("IDAhorro", original_Ahorro.IDAhorro, theAhorro.IDAhorro, true));
            values.Add(new FieldValue("CuentaContable", original_Ahorro.CuentaContable, theAhorro.CuentaContable));
            values.Add(new FieldValue("Observaciones", original_Ahorro.Observaciones, theAhorro.Observaciones));
            values.Add(new FieldValue("FormulaSql", original_Ahorro.FormulaSql, theAhorro.FormulaSql));
            values.Add(new FieldValue("SaldarFiniquito", original_Ahorro.SaldarFiniquito, theAhorro.SaldarFiniquito));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.Ahorro theAhorro, IXport.Data.Objects.Ahorro original_Ahorro, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Ahorro";
            args.View = dataView;
            args.Values = CreateFieldValues(theAhorro, original_Ahorro);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Ahorro", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAhorro);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.Ahorro theAhorro, IXport.Data.Objects.Ahorro original_Ahorro)
        {
            return ExecuteAction(theAhorro, original_Ahorro, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.Ahorro theAhorro)
        {
            return Update(theAhorro, SelectSingle(theAhorro.IDEmpleado, theAhorro.IDAhorro));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.Ahorro theAhorro)
        {
            return ExecuteAction(theAhorro, new Ahorro(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.Ahorro theAhorro)
        {
            return ExecuteAction(theAhorro, theAhorro, "Select", "Delete", DeleteView);
        }
    }
}
