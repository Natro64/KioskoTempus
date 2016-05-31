using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Vacaciones
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDVacaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDEmpleado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDEmpleadonombrecompleto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _tipoVacacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _anio;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaFin;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _observaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _derechoPago;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _diasPago;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _saldoPago;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _derechoGozo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _diasGoce;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _saldoGoce;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _salDiario;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _derechoPrima;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _diasPrima;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _saldoPrima;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDPrestaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDPeriodo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _movGlobal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaCaptura;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modificadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _creadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modificadoEn;
        
        public Vacaciones()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? IDVacaciones
        {
            get
            {
                return _iDVacaciones;
            }
            set
            {
                _iDVacaciones = value;
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
        public short? TipoVacacion
        {
            get
            {
                return _tipoVacacion;
            }
            set
            {
                _tipoVacacion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public short? Anio
        {
            get
            {
                return _anio;
            }
            set
            {
                _anio = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? FechaFin
        {
            get
            {
                return _fechaFin;
            }
            set
            {
                _fechaFin = value;
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
        public decimal? DerechoPago
        {
            get
            {
                return _derechoPago;
            }
            set
            {
                _derechoPago = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? DiasPago
        {
            get
            {
                return _diasPago;
            }
            set
            {
                _diasPago = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? SaldoPago
        {
            get
            {
                return _saldoPago;
            }
            set
            {
                _saldoPago = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? DerechoGozo
        {
            get
            {
                return _derechoGozo;
            }
            set
            {
                _derechoGozo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? DiasGoce
        {
            get
            {
                return _diasGoce;
            }
            set
            {
                _diasGoce = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? SaldoGoce
        {
            get
            {
                return _saldoGoce;
            }
            set
            {
                _saldoGoce = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? SalDiario
        {
            get
            {
                return _salDiario;
            }
            set
            {
                _salDiario = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? DerechoPrima
        {
            get
            {
                return _derechoPrima;
            }
            set
            {
                _derechoPrima = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? DiasPrima
        {
            get
            {
                return _diasPrima;
            }
            set
            {
                _diasPrima = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? SaldoPrima
        {
            get
            {
                return _saldoPrima;
            }
            set
            {
                _saldoPrima = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string IDPrestaciones
        {
            get
            {
                return _iDPrestaciones;
            }
            set
            {
                _iDPrestaciones = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDPeriodo
        {
            get
            {
                return _iDPeriodo;
            }
            set
            {
                _iDPeriodo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? MovGlobal
        {
            get
            {
                return _movGlobal;
            }
            set
            {
                _movGlobal = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? FechaCaptura
        {
            get
            {
                return _fechaCaptura;
            }
            set
            {
                _fechaCaptura = value;
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
        
        public static List<IXport.Data.Objects.Vacaciones> Select(
                    int? iDVacaciones, 
                    int? iDEmpleado, 
                    string iDEmpleadonombrecompleto, 
                    DateTime? fecha, 
                    short? tipoVacacion, 
                    short? anio, 
                    DateTime? fechaFin, 
                    string observaciones, 
                    decimal? derechoPago, 
                    decimal? diasPago, 
                    decimal? saldoPago, 
                    decimal? derechoGozo, 
                    decimal? diasGoce, 
                    decimal? saldoGoce, 
                    decimal? salDiario, 
                    decimal? derechoPrima, 
                    decimal? diasPrima, 
                    decimal? saldoPrima, 
                    string iDPrestaciones, 
                    string iDPeriodo, 
                    bool? movGlobal, 
                    DateTime? fechaCaptura, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn)
        {
            return new VacacionesFactory().Select(iDVacaciones, iDEmpleado, iDEmpleadonombrecompleto, fecha, tipoVacacion, anio, fechaFin, observaciones, derechoPago, diasPago, saldoPago, derechoGozo, diasGoce, saldoGoce, salDiario, derechoPrima, diasPrima, saldoPrima, iDPrestaciones, iDPeriodo, movGlobal, fechaCaptura, creadoPor, modificadoPor, creadoEn, modificadoEn);
        }
        
        public static List<IXport.Data.Objects.Vacaciones> Select(IXport.Data.Objects.Vacaciones qbe)
        {
            return new VacacionesFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.Vacaciones> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new VacacionesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.Vacaciones> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new VacacionesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Vacaciones> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new VacacionesFactory().Select(filter, sort, VacacionesFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Vacaciones> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new VacacionesFactory().Select(filter, sort, VacacionesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Vacaciones> Select(string filter, BusinessObjectParameters parameters)
        {
            return new VacacionesFactory().Select(filter, null, VacacionesFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Vacaciones> Select(string filter, params FieldValue[] parameters)
        {
            return new VacacionesFactory().Select(filter, null, VacacionesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Vacaciones SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new VacacionesFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.Vacaciones SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new VacacionesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Vacaciones SelectSingle(int? iDVacaciones, int? iDEmpleado)
        {
            return new VacacionesFactory().SelectSingle(iDVacaciones, iDEmpleado);
        }
        
        public int Insert()
        {
            return new VacacionesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new VacacionesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new VacacionesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDVacaciones: {0}; IDEmpleado: {1}", this.IDVacaciones, this.IDEmpleado);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class VacacionesFactory
    {
        
        public VacacionesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Vacaciones");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Vacaciones");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Vacaciones");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Vacaciones");
            }
        }
        
        public static VacacionesFactory Create()
        {
            return new VacacionesFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? iDVacaciones, 
                    int? iDEmpleado, 
                    string iDEmpleadonombrecompleto, 
                    DateTime? fecha, 
                    short? tipoVacacion, 
                    short? anio, 
                    DateTime? fechaFin, 
                    string observaciones, 
                    decimal? derechoPago, 
                    decimal? diasPago, 
                    decimal? saldoPago, 
                    decimal? derechoGozo, 
                    decimal? diasGoce, 
                    decimal? saldoGoce, 
                    decimal? salDiario, 
                    decimal? derechoPrima, 
                    decimal? diasPrima, 
                    decimal? saldoPrima, 
                    string iDPrestaciones, 
                    string iDPeriodo, 
                    bool? movGlobal, 
                    DateTime? fechaCaptura, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDVacaciones.HasValue)
            	filter.Add(("IDVacaciones:=" + iDVacaciones.Value.ToString()));
            if (iDEmpleado.HasValue)
            	filter.Add(("IDEmpleado:=" + iDEmpleado.Value.ToString()));
            if (!(String.IsNullOrEmpty(iDEmpleadonombrecompleto)))
            	filter.Add(("IDEmpleadonombrecompleto:*" + iDEmpleadonombrecompleto));
            if (fecha.HasValue)
            	filter.Add(("Fecha:=" + fecha.Value.ToString()));
            if (tipoVacacion.HasValue)
            	filter.Add(("TipoVacacion:=" + tipoVacacion.Value.ToString()));
            if (anio.HasValue)
            	filter.Add(("Anio:=" + anio.Value.ToString()));
            if (fechaFin.HasValue)
            	filter.Add(("FechaFin:=" + fechaFin.Value.ToString()));
            if (!(String.IsNullOrEmpty(observaciones)))
            	filter.Add(("Observaciones:*" + observaciones));
            if (derechoPago.HasValue)
            	filter.Add(("DerechoPago:=" + derechoPago.Value.ToString()));
            if (diasPago.HasValue)
            	filter.Add(("DiasPago:=" + diasPago.Value.ToString()));
            if (saldoPago.HasValue)
            	filter.Add(("SaldoPago:=" + saldoPago.Value.ToString()));
            if (derechoGozo.HasValue)
            	filter.Add(("DerechoGozo:=" + derechoGozo.Value.ToString()));
            if (diasGoce.HasValue)
            	filter.Add(("DiasGoce:=" + diasGoce.Value.ToString()));
            if (saldoGoce.HasValue)
            	filter.Add(("SaldoGoce:=" + saldoGoce.Value.ToString()));
            if (salDiario.HasValue)
            	filter.Add(("SalDiario:=" + salDiario.Value.ToString()));
            if (derechoPrima.HasValue)
            	filter.Add(("DerechoPrima:=" + derechoPrima.Value.ToString()));
            if (diasPrima.HasValue)
            	filter.Add(("DiasPrima:=" + diasPrima.Value.ToString()));
            if (saldoPrima.HasValue)
            	filter.Add(("SaldoPrima:=" + saldoPrima.Value.ToString()));
            if (!(String.IsNullOrEmpty(iDPrestaciones)))
            	filter.Add(("IDPrestaciones:*" + iDPrestaciones));
            if (!(String.IsNullOrEmpty(iDPeriodo)))
            	filter.Add(("IDPeriodo:*" + iDPeriodo));
            if (movGlobal.HasValue)
            	filter.Add(("MovGlobal:=" + movGlobal.Value.ToString()));
            if (fechaCaptura.HasValue)
            	filter.Add(("FechaCaptura:=" + fechaCaptura.Value.ToString()));
            if (!(String.IsNullOrEmpty(creadoPor)))
            	filter.Add(("CreadoPor:*" + creadoPor));
            if (!(String.IsNullOrEmpty(modificadoPor)))
            	filter.Add(("ModificadoPor:*" + modificadoPor));
            if (creadoEn.HasValue)
            	filter.Add(("CreadoEn:=" + creadoEn.Value.ToString()));
            if (modificadoEn.HasValue)
            	filter.Add(("ModificadoEn:=" + modificadoEn.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.Vacaciones> Select(
                    int? iDVacaciones, 
                    int? iDEmpleado, 
                    string iDEmpleadonombrecompleto, 
                    DateTime? fecha, 
                    short? tipoVacacion, 
                    short? anio, 
                    DateTime? fechaFin, 
                    string observaciones, 
                    decimal? derechoPago, 
                    decimal? diasPago, 
                    decimal? saldoPago, 
                    decimal? derechoGozo, 
                    decimal? diasGoce, 
                    decimal? saldoGoce, 
                    decimal? salDiario, 
                    decimal? derechoPrima, 
                    decimal? diasPrima, 
                    decimal? saldoPrima, 
                    string iDPrestaciones, 
                    string iDPeriodo, 
                    bool? movGlobal, 
                    DateTime? fechaCaptura, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDVacaciones, iDEmpleado, iDEmpleadonombrecompleto, fecha, tipoVacacion, anio, fechaFin, observaciones, derechoPago, diasPago, saldoPago, derechoGozo, diasGoce, saldoGoce, salDiario, derechoPrima, diasPrima, saldoPrima, iDPrestaciones, iDPeriodo, movGlobal, fechaCaptura, creadoPor, modificadoPor, creadoEn, modificadoEn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Vacaciones", dataView, request);
            return page.ToList<IXport.Data.Objects.Vacaciones>();
        }
        
        public List<IXport.Data.Objects.Vacaciones> Select(IXport.Data.Objects.Vacaciones qbe)
        {
            return Select(qbe.IDVacaciones, qbe.IDEmpleado, qbe.IDEmpleadonombrecompleto, qbe.Fecha, qbe.TipoVacacion, qbe.Anio, qbe.FechaFin, qbe.Observaciones, qbe.DerechoPago, qbe.DiasPago, qbe.SaldoPago, qbe.DerechoGozo, qbe.DiasGoce, qbe.SaldoGoce, qbe.SalDiario, qbe.DerechoPrima, qbe.DiasPrima, qbe.SaldoPrima, qbe.IDPrestaciones, qbe.IDPeriodo, qbe.MovGlobal, qbe.FechaCaptura, qbe.CreadoPor, qbe.ModificadoPor, qbe.CreadoEn, qbe.ModificadoEn);
        }
        
        public int SelectCount(
                    int? iDVacaciones, 
                    int? iDEmpleado, 
                    string iDEmpleadonombrecompleto, 
                    DateTime? fecha, 
                    short? tipoVacacion, 
                    short? anio, 
                    DateTime? fechaFin, 
                    string observaciones, 
                    decimal? derechoPago, 
                    decimal? diasPago, 
                    decimal? saldoPago, 
                    decimal? derechoGozo, 
                    decimal? diasGoce, 
                    decimal? saldoGoce, 
                    decimal? salDiario, 
                    decimal? derechoPrima, 
                    decimal? diasPrima, 
                    decimal? saldoPrima, 
                    string iDPrestaciones, 
                    string iDPeriodo, 
                    bool? movGlobal, 
                    DateTime? fechaCaptura, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDVacaciones, iDEmpleado, iDEmpleadonombrecompleto, fecha, tipoVacacion, anio, fechaFin, observaciones, derechoPago, diasPago, saldoPago, derechoGozo, diasGoce, saldoGoce, salDiario, derechoPrima, diasPrima, saldoPrima, iDPrestaciones, iDPeriodo, movGlobal, fechaCaptura, creadoPor, modificadoPor, creadoEn, modificadoEn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Vacaciones", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.Vacaciones> Select(
                    int? iDVacaciones, 
                    int? iDEmpleado, 
                    string iDEmpleadonombrecompleto, 
                    DateTime? fecha, 
                    short? tipoVacacion, 
                    short? anio, 
                    DateTime? fechaFin, 
                    string observaciones, 
                    decimal? derechoPago, 
                    decimal? diasPago, 
                    decimal? saldoPago, 
                    decimal? derechoGozo, 
                    decimal? diasGoce, 
                    decimal? saldoGoce, 
                    decimal? salDiario, 
                    decimal? derechoPrima, 
                    decimal? diasPrima, 
                    decimal? saldoPrima, 
                    string iDPrestaciones, 
                    string iDPeriodo, 
                    bool? movGlobal, 
                    DateTime? fechaCaptura, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn)
        {
            return Select(iDVacaciones, iDEmpleado, iDEmpleadonombrecompleto, fecha, tipoVacacion, anio, fechaFin, observaciones, derechoPago, diasPago, saldoPago, derechoGozo, diasGoce, saldoGoce, salDiario, derechoPrima, diasPrima, saldoPrima, iDPrestaciones, iDPeriodo, movGlobal, fechaCaptura, creadoPor, modificadoPor, creadoEn, modificadoEn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.Vacaciones SelectSingle(int? iDVacaciones, int? iDEmpleado)
        {
            List<IXport.Data.Objects.Vacaciones> list = Select(iDVacaciones, iDEmpleado, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.Vacaciones> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Vacaciones", dataView, request);
            return page.ToList<IXport.Data.Objects.Vacaciones>();
        }
        
        public List<IXport.Data.Objects.Vacaciones> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.Vacaciones> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.Vacaciones SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.Vacaciones> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.Vacaciones theVacaciones, IXport.Data.Objects.Vacaciones original_Vacaciones)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDVacaciones", original_Vacaciones.IDVacaciones, theVacaciones.IDVacaciones, true));
            values.Add(new FieldValue("IDEmpleado", original_Vacaciones.IDEmpleado, theVacaciones.IDEmpleado));
            values.Add(new FieldValue("IDEmpleadonombrecompleto", original_Vacaciones.IDEmpleadonombrecompleto, theVacaciones.IDEmpleadonombrecompleto, true));
            values.Add(new FieldValue("Fecha", original_Vacaciones.Fecha, theVacaciones.Fecha));
            values.Add(new FieldValue("TipoVacacion", original_Vacaciones.TipoVacacion, theVacaciones.TipoVacacion));
            values.Add(new FieldValue("Anio", original_Vacaciones.Anio, theVacaciones.Anio));
            values.Add(new FieldValue("FechaFin", original_Vacaciones.FechaFin, theVacaciones.FechaFin));
            values.Add(new FieldValue("Observaciones", original_Vacaciones.Observaciones, theVacaciones.Observaciones));
            values.Add(new FieldValue("DerechoPago", original_Vacaciones.DerechoPago, theVacaciones.DerechoPago));
            values.Add(new FieldValue("DiasPago", original_Vacaciones.DiasPago, theVacaciones.DiasPago));
            values.Add(new FieldValue("SaldoPago", original_Vacaciones.SaldoPago, theVacaciones.SaldoPago));
            values.Add(new FieldValue("DerechoGozo", original_Vacaciones.DerechoGozo, theVacaciones.DerechoGozo));
            values.Add(new FieldValue("DiasGoce", original_Vacaciones.DiasGoce, theVacaciones.DiasGoce));
            values.Add(new FieldValue("SaldoGoce", original_Vacaciones.SaldoGoce, theVacaciones.SaldoGoce));
            values.Add(new FieldValue("SalDiario", original_Vacaciones.SalDiario, theVacaciones.SalDiario));
            values.Add(new FieldValue("DerechoPrima", original_Vacaciones.DerechoPrima, theVacaciones.DerechoPrima));
            values.Add(new FieldValue("DiasPrima", original_Vacaciones.DiasPrima, theVacaciones.DiasPrima));
            values.Add(new FieldValue("SaldoPrima", original_Vacaciones.SaldoPrima, theVacaciones.SaldoPrima));
            values.Add(new FieldValue("IDPrestaciones", original_Vacaciones.IDPrestaciones, theVacaciones.IDPrestaciones));
            values.Add(new FieldValue("IDPeriodo", original_Vacaciones.IDPeriodo, theVacaciones.IDPeriodo));
            values.Add(new FieldValue("MovGlobal", original_Vacaciones.MovGlobal, theVacaciones.MovGlobal));
            values.Add(new FieldValue("FechaCaptura", original_Vacaciones.FechaCaptura, theVacaciones.FechaCaptura));
            values.Add(new FieldValue("CreadoPor", original_Vacaciones.CreadoPor, theVacaciones.CreadoPor));
            values.Add(new FieldValue("ModificadoPor", original_Vacaciones.ModificadoPor, theVacaciones.ModificadoPor));
            values.Add(new FieldValue("CreadoEn", original_Vacaciones.CreadoEn, theVacaciones.CreadoEn));
            values.Add(new FieldValue("ModificadoEn", original_Vacaciones.ModificadoEn, theVacaciones.ModificadoEn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.Vacaciones theVacaciones, IXport.Data.Objects.Vacaciones original_Vacaciones, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Vacaciones";
            args.View = dataView;
            args.Values = CreateFieldValues(theVacaciones, original_Vacaciones);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Vacaciones", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theVacaciones);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.Vacaciones theVacaciones, IXport.Data.Objects.Vacaciones original_Vacaciones)
        {
            return ExecuteAction(theVacaciones, original_Vacaciones, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.Vacaciones theVacaciones)
        {
            return Update(theVacaciones, SelectSingle(theVacaciones.IDVacaciones, theVacaciones.IDEmpleado));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.Vacaciones theVacaciones)
        {
            return ExecuteAction(theVacaciones, new Vacaciones(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.Vacaciones theVacaciones)
        {
            return ExecuteAction(theVacaciones, theVacaciones, "Select", "Delete", DeleteView);
        }
    }
}
