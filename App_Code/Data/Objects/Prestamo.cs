using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Prestamo
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _referencia;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipoprestamo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _theidTipoprestamodescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDEmpleado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDEmpleadonombrecompleto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _abonos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cargos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaInicio;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formulaDescuento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _importe;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _noAbonos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _saldoInicial;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _estatus;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _total;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _saldo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modificadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _creadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modificadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDPrestamo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cuentaContable;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _observaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formulaDescuentoSql;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saldarFiniquito;
        
        public Prestamo()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Referencia
        {
            get
            {
                return _referencia;
            }
            set
            {
                _referencia = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string IDTipoprestamo
        {
            get
            {
                return _iDTipoprestamo;
            }
            set
            {
                _iDTipoprestamo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TheidTipoprestamodescripcion
        {
            get
            {
                return _theidTipoprestamodescripcion;
            }
            set
            {
                _theidTipoprestamodescripcion = value;
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
        public string IDEmpleadonombrecompleto
        {
            get
            {
                return _iDEmpleadonombrecompleto;
            }
            set
            {
                _iDEmpleadonombrecompleto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Abonos
        {
            get
            {
                return _abonos;
            }
            set
            {
                _abonos = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Cargos
        {
            get
            {
                return _cargos;
            }
            set
            {
                _cargos = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? FechaInicio
        {
            get
            {
                return _fechaInicio;
            }
            set
            {
                _fechaInicio = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FormulaDescuento
        {
            get
            {
                return _formulaDescuento;
            }
            set
            {
                _formulaDescuento = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Importe
        {
            get
            {
                return _importe;
            }
            set
            {
                _importe = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? NoAbonos
        {
            get
            {
                return _noAbonos;
            }
            set
            {
                _noAbonos = value;
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
        public short? Estatus
        {
            get
            {
                return _estatus;
            }
            set
            {
                _estatus = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
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
        public int? IDPrestamo
        {
            get
            {
                return _iDPrestamo;
            }
            set
            {
                _iDPrestamo = value;
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
        public string FormulaDescuentoSql
        {
            get
            {
                return _formulaDescuentoSql;
            }
            set
            {
                _formulaDescuentoSql = value;
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
        
        public static List<IXport.Data.Objects.Prestamo> Select(
                    string referencia, 
                    string iDTipoprestamo, 
                    string theidTipoprestamodescripcion, 
                    int? iDEmpleado, 
                    string iDEmpleadonombrecompleto, 
                    decimal? abonos, 
                    decimal? cargos, 
                    DateTime? fechaInicio, 
                    decimal? importe, 
                    int? noAbonos, 
                    decimal? saldoInicial, 
                    short? estatus, 
                    decimal? total, 
                    decimal? saldo, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    int? iDPrestamo, 
                    string cuentaContable, 
                    string observaciones, 
                    string saldarFiniquito)
        {
            return new PrestamoFactory().Select(referencia, iDTipoprestamo, theidTipoprestamodescripcion, iDEmpleado, iDEmpleadonombrecompleto, abonos, cargos, fechaInicio, importe, noAbonos, saldoInicial, estatus, total, saldo, creadoPor, modificadoPor, creadoEn, modificadoEn, iDPrestamo, cuentaContable, observaciones, saldarFiniquito);
        }
        
        public static List<IXport.Data.Objects.Prestamo> Select(IXport.Data.Objects.Prestamo qbe)
        {
            return new PrestamoFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.Prestamo> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new PrestamoFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.Prestamo> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new PrestamoFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Prestamo> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new PrestamoFactory().Select(filter, sort, PrestamoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Prestamo> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new PrestamoFactory().Select(filter, sort, PrestamoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Prestamo> Select(string filter, BusinessObjectParameters parameters)
        {
            return new PrestamoFactory().Select(filter, null, PrestamoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Prestamo> Select(string filter, params FieldValue[] parameters)
        {
            return new PrestamoFactory().Select(filter, null, PrestamoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Prestamo SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new PrestamoFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.Prestamo SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new PrestamoFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Prestamo SelectSingle(int? iDEmpleado, int? iDPrestamo)
        {
            return new PrestamoFactory().SelectSingle(iDEmpleado, iDPrestamo);
        }
        
        public int Insert()
        {
            return new PrestamoFactory().Insert(this);
        }
        
        public int Update()
        {
            return new PrestamoFactory().Update(this);
        }
        
        public int Delete()
        {
            return new PrestamoFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDEmpleado: {0}; IDPrestamo: {1}", this.IDEmpleado, this.IDPrestamo);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class PrestamoFactory
    {
        
        public PrestamoFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Prestamo");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Prestamo");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Prestamo");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Prestamo");
            }
        }
        
        public static PrestamoFactory Create()
        {
            return new PrestamoFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    string referencia, 
                    string iDTipoprestamo, 
                    string theidTipoprestamodescripcion, 
                    int? iDEmpleado, 
                    string iDEmpleadonombrecompleto, 
                    decimal? abonos, 
                    decimal? cargos, 
                    DateTime? fechaInicio, 
                    decimal? importe, 
                    int? noAbonos, 
                    decimal? saldoInicial, 
                    short? estatus, 
                    decimal? total, 
                    decimal? saldo, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    int? iDPrestamo, 
                    string cuentaContable, 
                    string observaciones, 
                    string saldarFiniquito, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (!(String.IsNullOrEmpty(referencia)))
            	filter.Add(("Referencia:*" + referencia));
            if (!(String.IsNullOrEmpty(iDTipoprestamo)))
            	filter.Add(("IDTipoprestamo:*" + iDTipoprestamo));
            if (!(String.IsNullOrEmpty(theidTipoprestamodescripcion)))
            	filter.Add(("TheidTipoprestamodescripcion:*" + theidTipoprestamodescripcion));
            if (iDEmpleado.HasValue)
            	filter.Add(("IDEmpleado:=" + iDEmpleado.Value.ToString()));
            if (!(String.IsNullOrEmpty(iDEmpleadonombrecompleto)))
            	filter.Add(("IDEmpleadonombrecompleto:*" + iDEmpleadonombrecompleto));
            if (abonos.HasValue)
            	filter.Add(("Abonos:=" + abonos.Value.ToString()));
            if (cargos.HasValue)
            	filter.Add(("Cargos:=" + cargos.Value.ToString()));
            if (fechaInicio.HasValue)
            	filter.Add(("FechaInicio:=" + fechaInicio.Value.ToString()));
            if (importe.HasValue)
            	filter.Add(("Importe:=" + importe.Value.ToString()));
            if (noAbonos.HasValue)
            	filter.Add(("NoAbonos:=" + noAbonos.Value.ToString()));
            if (saldoInicial.HasValue)
            	filter.Add(("SaldoInicial:=" + saldoInicial.Value.ToString()));
            if (estatus.HasValue)
            	filter.Add(("Estatus:=" + estatus.Value.ToString()));
            if (total.HasValue)
            	filter.Add(("Total:=" + total.Value.ToString()));
            if (saldo.HasValue)
            	filter.Add(("Saldo:=" + saldo.Value.ToString()));
            if (!(String.IsNullOrEmpty(creadoPor)))
            	filter.Add(("CreadoPor:*" + creadoPor));
            if (!(String.IsNullOrEmpty(modificadoPor)))
            	filter.Add(("ModificadoPor:*" + modificadoPor));
            if (creadoEn.HasValue)
            	filter.Add(("CreadoEn:=" + creadoEn.Value.ToString()));
            if (modificadoEn.HasValue)
            	filter.Add(("ModificadoEn:=" + modificadoEn.Value.ToString()));
            if (iDPrestamo.HasValue)
            	filter.Add(("IDPrestamo:=" + iDPrestamo.Value.ToString()));
            if (!(String.IsNullOrEmpty(cuentaContable)))
            	filter.Add(("CuentaContable:*" + cuentaContable));
            if (!(String.IsNullOrEmpty(observaciones)))
            	filter.Add(("Observaciones:*" + observaciones));
            if (!(String.IsNullOrEmpty(saldarFiniquito)))
            	filter.Add(("SaldarFiniquito:*" + saldarFiniquito));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.Prestamo> Select(
                    string referencia, 
                    string iDTipoprestamo, 
                    string theidTipoprestamodescripcion, 
                    int? iDEmpleado, 
                    string iDEmpleadonombrecompleto, 
                    decimal? abonos, 
                    decimal? cargos, 
                    DateTime? fechaInicio, 
                    decimal? importe, 
                    int? noAbonos, 
                    decimal? saldoInicial, 
                    short? estatus, 
                    decimal? total, 
                    decimal? saldo, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    int? iDPrestamo, 
                    string cuentaContable, 
                    string observaciones, 
                    string saldarFiniquito, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(referencia, iDTipoprestamo, theidTipoprestamodescripcion, iDEmpleado, iDEmpleadonombrecompleto, abonos, cargos, fechaInicio, importe, noAbonos, saldoInicial, estatus, total, saldo, creadoPor, modificadoPor, creadoEn, modificadoEn, iDPrestamo, cuentaContable, observaciones, saldarFiniquito, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Prestamo", dataView, request);
            return page.ToList<IXport.Data.Objects.Prestamo>();
        }
        
        public List<IXport.Data.Objects.Prestamo> Select(IXport.Data.Objects.Prestamo qbe)
        {
            return Select(qbe.Referencia, qbe.IDTipoprestamo, qbe.TheidTipoprestamodescripcion, qbe.IDEmpleado, qbe.IDEmpleadonombrecompleto, qbe.Abonos, qbe.Cargos, qbe.FechaInicio, qbe.Importe, qbe.NoAbonos, qbe.SaldoInicial, qbe.Estatus, qbe.Total, qbe.Saldo, qbe.CreadoPor, qbe.ModificadoPor, qbe.CreadoEn, qbe.ModificadoEn, qbe.IDPrestamo, qbe.CuentaContable, qbe.Observaciones, qbe.SaldarFiniquito);
        }
        
        public int SelectCount(
                    string referencia, 
                    string iDTipoprestamo, 
                    string theidTipoprestamodescripcion, 
                    int? iDEmpleado, 
                    string iDEmpleadonombrecompleto, 
                    decimal? abonos, 
                    decimal? cargos, 
                    DateTime? fechaInicio, 
                    decimal? importe, 
                    int? noAbonos, 
                    decimal? saldoInicial, 
                    short? estatus, 
                    decimal? total, 
                    decimal? saldo, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    int? iDPrestamo, 
                    string cuentaContable, 
                    string observaciones, 
                    string saldarFiniquito, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(referencia, iDTipoprestamo, theidTipoprestamodescripcion, iDEmpleado, iDEmpleadonombrecompleto, abonos, cargos, fechaInicio, importe, noAbonos, saldoInicial, estatus, total, saldo, creadoPor, modificadoPor, creadoEn, modificadoEn, iDPrestamo, cuentaContable, observaciones, saldarFiniquito, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Prestamo", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.Prestamo> Select(
                    string referencia, 
                    string iDTipoprestamo, 
                    string theidTipoprestamodescripcion, 
                    int? iDEmpleado, 
                    string iDEmpleadonombrecompleto, 
                    decimal? abonos, 
                    decimal? cargos, 
                    DateTime? fechaInicio, 
                    decimal? importe, 
                    int? noAbonos, 
                    decimal? saldoInicial, 
                    short? estatus, 
                    decimal? total, 
                    decimal? saldo, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    int? iDPrestamo, 
                    string cuentaContable, 
                    string observaciones, 
                    string saldarFiniquito)
        {
            return Select(referencia, iDTipoprestamo, theidTipoprestamodescripcion, iDEmpleado, iDEmpleadonombrecompleto, abonos, cargos, fechaInicio, importe, noAbonos, saldoInicial, estatus, total, saldo, creadoPor, modificadoPor, creadoEn, modificadoEn, iDPrestamo, cuentaContable, observaciones, saldarFiniquito, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.Prestamo SelectSingle(int? iDEmpleado, int? iDPrestamo)
        {
            List<IXport.Data.Objects.Prestamo> list = Select(null, null, null, iDEmpleado, null, null, null, null, null, null, null, null, null, null, null, null, null, null, iDPrestamo, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.Prestamo> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Prestamo", dataView, request);
            return page.ToList<IXport.Data.Objects.Prestamo>();
        }
        
        public List<IXport.Data.Objects.Prestamo> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.Prestamo> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.Prestamo SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.Prestamo> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.Prestamo thePrestamo, IXport.Data.Objects.Prestamo original_Prestamo)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Referencia", original_Prestamo.Referencia, thePrestamo.Referencia));
            values.Add(new FieldValue("IDTipoprestamo", original_Prestamo.IDTipoprestamo, thePrestamo.IDTipoprestamo));
            values.Add(new FieldValue("TheidTipoprestamodescripcion", original_Prestamo.TheidTipoprestamodescripcion, thePrestamo.TheidTipoprestamodescripcion, true));
            values.Add(new FieldValue("IDEmpleado", original_Prestamo.IDEmpleado, thePrestamo.IDEmpleado));
            values.Add(new FieldValue("IDEmpleadonombrecompleto", original_Prestamo.IDEmpleadonombrecompleto, thePrestamo.IDEmpleadonombrecompleto, true));
            values.Add(new FieldValue("Abonos", original_Prestamo.Abonos, thePrestamo.Abonos));
            values.Add(new FieldValue("Cargos", original_Prestamo.Cargos, thePrestamo.Cargos));
            values.Add(new FieldValue("FechaInicio", original_Prestamo.FechaInicio, thePrestamo.FechaInicio));
            values.Add(new FieldValue("FormulaDescuento", original_Prestamo.FormulaDescuento, thePrestamo.FormulaDescuento));
            values.Add(new FieldValue("Importe", original_Prestamo.Importe, thePrestamo.Importe));
            values.Add(new FieldValue("NoAbonos", original_Prestamo.NoAbonos, thePrestamo.NoAbonos));
            values.Add(new FieldValue("SaldoInicial", original_Prestamo.SaldoInicial, thePrestamo.SaldoInicial));
            values.Add(new FieldValue("Estatus", original_Prestamo.Estatus, thePrestamo.Estatus));
            values.Add(new FieldValue("Total", original_Prestamo.Total, thePrestamo.Total));
            values.Add(new FieldValue("Saldo", original_Prestamo.Saldo, thePrestamo.Saldo));
            values.Add(new FieldValue("CreadoPor", original_Prestamo.CreadoPor, thePrestamo.CreadoPor));
            values.Add(new FieldValue("ModificadoPor", original_Prestamo.ModificadoPor, thePrestamo.ModificadoPor));
            values.Add(new FieldValue("CreadoEn", original_Prestamo.CreadoEn, thePrestamo.CreadoEn));
            values.Add(new FieldValue("ModificadoEn", original_Prestamo.ModificadoEn, thePrestamo.ModificadoEn));
            values.Add(new FieldValue("IDPrestamo", original_Prestamo.IDPrestamo, thePrestamo.IDPrestamo, true));
            values.Add(new FieldValue("CuentaContable", original_Prestamo.CuentaContable, thePrestamo.CuentaContable));
            values.Add(new FieldValue("Observaciones", original_Prestamo.Observaciones, thePrestamo.Observaciones));
            values.Add(new FieldValue("FormulaDescuentoSql", original_Prestamo.FormulaDescuentoSql, thePrestamo.FormulaDescuentoSql));
            values.Add(new FieldValue("SaldarFiniquito", original_Prestamo.SaldarFiniquito, thePrestamo.SaldarFiniquito));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.Prestamo thePrestamo, IXport.Data.Objects.Prestamo original_Prestamo, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Prestamo";
            args.View = dataView;
            args.Values = CreateFieldValues(thePrestamo, original_Prestamo);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Prestamo", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(thePrestamo);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.Prestamo thePrestamo, IXport.Data.Objects.Prestamo original_Prestamo)
        {
            return ExecuteAction(thePrestamo, original_Prestamo, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.Prestamo thePrestamo)
        {
            return Update(thePrestamo, SelectSingle(thePrestamo.IDEmpleado, thePrestamo.IDPrestamo));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.Prestamo thePrestamo)
        {
            return ExecuteAction(thePrestamo, new Prestamo(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.Prestamo thePrestamo)
        {
            return ExecuteAction(thePrestamo, thePrestamo, "Select", "Delete", DeleteView);
        }
    }
}
