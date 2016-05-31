using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Concepto
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _iDConcepto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _alias;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _activo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipoconcepto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _theidTipoconceptodescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _imprimirRecibo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _imprimirListado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mensual;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDFiltro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _gravaImss;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _gravaIsr;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formula;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formulaIsr;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formulaExento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formulaImpresion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cuentaContable;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _conceptoSat;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notas;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _ordenCalculo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _importeMinimo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _importeMaximo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _texto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _numero;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modificadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _creadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modificadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _acumulaPtu;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _gravaIsn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formulaSql;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formulaIsrsql;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formulaExentoSql;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _formulaImpresionSql;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cuentaContable2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _referenciaConcepto;
        
        public Concepto()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public short? IDConcepto
        {
            get
            {
                return _iDConcepto;
            }
            set
            {
                _iDConcepto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Alias
        {
            get
            {
                return _alias;
            }
            set
            {
                _alias = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string IDTipoconcepto
        {
            get
            {
                return _iDTipoconcepto;
            }
            set
            {
                _iDTipoconcepto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TheidTipoconceptodescripcion
        {
            get
            {
                return _theidTipoconceptodescripcion;
            }
            set
            {
                _theidTipoconceptodescripcion = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? ImprimirRecibo
        {
            get
            {
                return _imprimirRecibo;
            }
            set
            {
                _imprimirRecibo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? ImprimirListado
        {
            get
            {
                return _imprimirListado;
            }
            set
            {
                _imprimirListado = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? Mensual
        {
            get
            {
                return _mensual;
            }
            set
            {
                _mensual = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDFiltro
        {
            get
            {
                return _iDFiltro;
            }
            set
            {
                _iDFiltro = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? GravaImss
        {
            get
            {
                return _gravaImss;
            }
            set
            {
                _gravaImss = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? GravaIsr
        {
            get
            {
                return _gravaIsr;
            }
            set
            {
                _gravaIsr = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FormulaIsr
        {
            get
            {
                return _formulaIsr;
            }
            set
            {
                _formulaIsr = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FormulaExento
        {
            get
            {
                return _formulaExento;
            }
            set
            {
                _formulaExento = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FormulaImpresion
        {
            get
            {
                return _formulaImpresion;
            }
            set
            {
                _formulaImpresion = value;
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
        public int? ConceptoSat
        {
            get
            {
                return _conceptoSat;
            }
            set
            {
                _conceptoSat = value;
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
        public short? OrdenCalculo
        {
            get
            {
                return _ordenCalculo;
            }
            set
            {
                _ordenCalculo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? ImporteMinimo
        {
            get
            {
                return _importeMinimo;
            }
            set
            {
                _importeMinimo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? ImporteMaximo
        {
            get
            {
                return _importeMaximo;
            }
            set
            {
                _importeMaximo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Texto
        {
            get
            {
                return _texto;
            }
            set
            {
                _texto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
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
        public bool? AcumulaPtu
        {
            get
            {
                return _acumulaPtu;
            }
            set
            {
                _acumulaPtu = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? GravaIsn
        {
            get
            {
                return _gravaIsn;
            }
            set
            {
                _gravaIsn = value;
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
        public string FormulaIsrsql
        {
            get
            {
                return _formulaIsrsql;
            }
            set
            {
                _formulaIsrsql = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FormulaExentoSql
        {
            get
            {
                return _formulaExentoSql;
            }
            set
            {
                _formulaExentoSql = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FormulaImpresionSql
        {
            get
            {
                return _formulaImpresionSql;
            }
            set
            {
                _formulaImpresionSql = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CuentaContable2
        {
            get
            {
                return _cuentaContable2;
            }
            set
            {
                _cuentaContable2 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ReferenciaConcepto
        {
            get
            {
                return _referenciaConcepto;
            }
            set
            {
                _referenciaConcepto = value;
            }
        }
        
        public static List<IXport.Data.Objects.Concepto> Select(
                    short? iDConcepto, 
                    string alias, 
                    bool? activo, 
                    string iDTipoconcepto, 
                    string theidTipoconceptodescripcion, 
                    string descripcion, 
                    bool? imprimirRecibo, 
                    bool? imprimirListado, 
                    bool? mensual, 
                    string iDFiltro, 
                    bool? gravaImss, 
                    bool? gravaIsr, 
                    string cuentaContable, 
                    int? conceptoSat, 
                    short? ordenCalculo, 
                    decimal? importeMinimo, 
                    decimal? importeMaximo, 
                    string texto, 
                    decimal? numero, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    bool? acumulaPtu, 
                    bool? gravaIsn, 
                    string cuentaContable2, 
                    int? referenciaConcepto)
        {
            return new ConceptoFactory().Select(iDConcepto, alias, activo, iDTipoconcepto, theidTipoconceptodescripcion, descripcion, imprimirRecibo, imprimirListado, mensual, iDFiltro, gravaImss, gravaIsr, cuentaContable, conceptoSat, ordenCalculo, importeMinimo, importeMaximo, texto, numero, creadoPor, modificadoPor, creadoEn, modificadoEn, acumulaPtu, gravaIsn, cuentaContable2, referenciaConcepto);
        }
        
        public static List<IXport.Data.Objects.Concepto> Select(IXport.Data.Objects.Concepto qbe)
        {
            return new ConceptoFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.Concepto> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ConceptoFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.Concepto> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ConceptoFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Concepto> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ConceptoFactory().Select(filter, sort, ConceptoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Concepto> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ConceptoFactory().Select(filter, sort, ConceptoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Concepto> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ConceptoFactory().Select(filter, null, ConceptoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Concepto> Select(string filter, params FieldValue[] parameters)
        {
            return new ConceptoFactory().Select(filter, null, ConceptoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Concepto SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ConceptoFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.Concepto SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ConceptoFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Concepto SelectSingle(short? iDConcepto)
        {
            return new ConceptoFactory().SelectSingle(iDConcepto);
        }
        
        public int Insert()
        {
            return new ConceptoFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ConceptoFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ConceptoFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDConcepto: {0}", this.IDConcepto);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ConceptoFactory
    {
        
        public ConceptoFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Concepto");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Concepto");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Concepto");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Concepto");
            }
        }
        
        public static ConceptoFactory Create()
        {
            return new ConceptoFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    short? iDConcepto, 
                    string alias, 
                    bool? activo, 
                    string iDTipoconcepto, 
                    string theidTipoconceptodescripcion, 
                    string descripcion, 
                    bool? imprimirRecibo, 
                    bool? imprimirListado, 
                    bool? mensual, 
                    string iDFiltro, 
                    bool? gravaImss, 
                    bool? gravaIsr, 
                    string cuentaContable, 
                    int? conceptoSat, 
                    short? ordenCalculo, 
                    decimal? importeMinimo, 
                    decimal? importeMaximo, 
                    string texto, 
                    decimal? numero, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    bool? acumulaPtu, 
                    bool? gravaIsn, 
                    string cuentaContable2, 
                    int? referenciaConcepto, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDConcepto.HasValue)
            	filter.Add(("IDConcepto:=" + iDConcepto.Value.ToString()));
            if (!(String.IsNullOrEmpty(alias)))
            	filter.Add(("Alias:*" + alias));
            if (activo.HasValue)
            	filter.Add(("Activo:=" + activo.Value.ToString()));
            if (!(String.IsNullOrEmpty(iDTipoconcepto)))
            	filter.Add(("IDTipoconcepto:*" + iDTipoconcepto));
            if (!(String.IsNullOrEmpty(theidTipoconceptodescripcion)))
            	filter.Add(("TheidTipoconceptodescripcion:*" + theidTipoconceptodescripcion));
            if (!(String.IsNullOrEmpty(descripcion)))
            	filter.Add(("Descripcion:*" + descripcion));
            if (imprimirRecibo.HasValue)
            	filter.Add(("ImprimirRecibo:=" + imprimirRecibo.Value.ToString()));
            if (imprimirListado.HasValue)
            	filter.Add(("ImprimirListado:=" + imprimirListado.Value.ToString()));
            if (mensual.HasValue)
            	filter.Add(("Mensual:=" + mensual.Value.ToString()));
            if (!(String.IsNullOrEmpty(iDFiltro)))
            	filter.Add(("IDFiltro:*" + iDFiltro));
            if (gravaImss.HasValue)
            	filter.Add(("GravaImss:=" + gravaImss.Value.ToString()));
            if (gravaIsr.HasValue)
            	filter.Add(("GravaIsr:=" + gravaIsr.Value.ToString()));
            if (!(String.IsNullOrEmpty(cuentaContable)))
            	filter.Add(("CuentaContable:*" + cuentaContable));
            if (conceptoSat.HasValue)
            	filter.Add(("ConceptoSat:=" + conceptoSat.Value.ToString()));
            if (ordenCalculo.HasValue)
            	filter.Add(("OrdenCalculo:=" + ordenCalculo.Value.ToString()));
            if (importeMinimo.HasValue)
            	filter.Add(("ImporteMinimo:=" + importeMinimo.Value.ToString()));
            if (importeMaximo.HasValue)
            	filter.Add(("ImporteMaximo:=" + importeMaximo.Value.ToString()));
            if (!(String.IsNullOrEmpty(texto)))
            	filter.Add(("Texto:*" + texto));
            if (numero.HasValue)
            	filter.Add(("Numero:=" + numero.Value.ToString()));
            if (!(String.IsNullOrEmpty(creadoPor)))
            	filter.Add(("CreadoPor:*" + creadoPor));
            if (!(String.IsNullOrEmpty(modificadoPor)))
            	filter.Add(("ModificadoPor:*" + modificadoPor));
            if (creadoEn.HasValue)
            	filter.Add(("CreadoEn:=" + creadoEn.Value.ToString()));
            if (modificadoEn.HasValue)
            	filter.Add(("ModificadoEn:=" + modificadoEn.Value.ToString()));
            if (acumulaPtu.HasValue)
            	filter.Add(("AcumulaPtu:=" + acumulaPtu.Value.ToString()));
            if (gravaIsn.HasValue)
            	filter.Add(("GravaIsn:=" + gravaIsn.Value.ToString()));
            if (!(String.IsNullOrEmpty(cuentaContable2)))
            	filter.Add(("CuentaContable2:*" + cuentaContable2));
            if (referenciaConcepto.HasValue)
            	filter.Add(("ReferenciaConcepto:=" + referenciaConcepto.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.Concepto> Select(
                    short? iDConcepto, 
                    string alias, 
                    bool? activo, 
                    string iDTipoconcepto, 
                    string theidTipoconceptodescripcion, 
                    string descripcion, 
                    bool? imprimirRecibo, 
                    bool? imprimirListado, 
                    bool? mensual, 
                    string iDFiltro, 
                    bool? gravaImss, 
                    bool? gravaIsr, 
                    string cuentaContable, 
                    int? conceptoSat, 
                    short? ordenCalculo, 
                    decimal? importeMinimo, 
                    decimal? importeMaximo, 
                    string texto, 
                    decimal? numero, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    bool? acumulaPtu, 
                    bool? gravaIsn, 
                    string cuentaContable2, 
                    int? referenciaConcepto, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDConcepto, alias, activo, iDTipoconcepto, theidTipoconceptodescripcion, descripcion, imprimirRecibo, imprimirListado, mensual, iDFiltro, gravaImss, gravaIsr, cuentaContable, conceptoSat, ordenCalculo, importeMinimo, importeMaximo, texto, numero, creadoPor, modificadoPor, creadoEn, modificadoEn, acumulaPtu, gravaIsn, cuentaContable2, referenciaConcepto, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Concepto", dataView, request);
            return page.ToList<IXport.Data.Objects.Concepto>();
        }
        
        public List<IXport.Data.Objects.Concepto> Select(IXport.Data.Objects.Concepto qbe)
        {
            return Select(qbe.IDConcepto, qbe.Alias, qbe.Activo, qbe.IDTipoconcepto, qbe.TheidTipoconceptodescripcion, qbe.Descripcion, qbe.ImprimirRecibo, qbe.ImprimirListado, qbe.Mensual, qbe.IDFiltro, qbe.GravaImss, qbe.GravaIsr, qbe.CuentaContable, qbe.ConceptoSat, qbe.OrdenCalculo, qbe.ImporteMinimo, qbe.ImporteMaximo, qbe.Texto, qbe.Numero, qbe.CreadoPor, qbe.ModificadoPor, qbe.CreadoEn, qbe.ModificadoEn, qbe.AcumulaPtu, qbe.GravaIsn, qbe.CuentaContable2, qbe.ReferenciaConcepto);
        }
        
        public int SelectCount(
                    short? iDConcepto, 
                    string alias, 
                    bool? activo, 
                    string iDTipoconcepto, 
                    string theidTipoconceptodescripcion, 
                    string descripcion, 
                    bool? imprimirRecibo, 
                    bool? imprimirListado, 
                    bool? mensual, 
                    string iDFiltro, 
                    bool? gravaImss, 
                    bool? gravaIsr, 
                    string cuentaContable, 
                    int? conceptoSat, 
                    short? ordenCalculo, 
                    decimal? importeMinimo, 
                    decimal? importeMaximo, 
                    string texto, 
                    decimal? numero, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    bool? acumulaPtu, 
                    bool? gravaIsn, 
                    string cuentaContable2, 
                    int? referenciaConcepto, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDConcepto, alias, activo, iDTipoconcepto, theidTipoconceptodescripcion, descripcion, imprimirRecibo, imprimirListado, mensual, iDFiltro, gravaImss, gravaIsr, cuentaContable, conceptoSat, ordenCalculo, importeMinimo, importeMaximo, texto, numero, creadoPor, modificadoPor, creadoEn, modificadoEn, acumulaPtu, gravaIsn, cuentaContable2, referenciaConcepto, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Concepto", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.Concepto> Select(
                    short? iDConcepto, 
                    string alias, 
                    bool? activo, 
                    string iDTipoconcepto, 
                    string theidTipoconceptodescripcion, 
                    string descripcion, 
                    bool? imprimirRecibo, 
                    bool? imprimirListado, 
                    bool? mensual, 
                    string iDFiltro, 
                    bool? gravaImss, 
                    bool? gravaIsr, 
                    string cuentaContable, 
                    int? conceptoSat, 
                    short? ordenCalculo, 
                    decimal? importeMinimo, 
                    decimal? importeMaximo, 
                    string texto, 
                    decimal? numero, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    bool? acumulaPtu, 
                    bool? gravaIsn, 
                    string cuentaContable2, 
                    int? referenciaConcepto)
        {
            return Select(iDConcepto, alias, activo, iDTipoconcepto, theidTipoconceptodescripcion, descripcion, imprimirRecibo, imprimirListado, mensual, iDFiltro, gravaImss, gravaIsr, cuentaContable, conceptoSat, ordenCalculo, importeMinimo, importeMaximo, texto, numero, creadoPor, modificadoPor, creadoEn, modificadoEn, acumulaPtu, gravaIsn, cuentaContable2, referenciaConcepto, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.Concepto SelectSingle(short? iDConcepto)
        {
            List<IXport.Data.Objects.Concepto> list = Select(iDConcepto, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.Concepto> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Concepto", dataView, request);
            return page.ToList<IXport.Data.Objects.Concepto>();
        }
        
        public List<IXport.Data.Objects.Concepto> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.Concepto> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.Concepto SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.Concepto> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.Concepto theConcepto, IXport.Data.Objects.Concepto original_Concepto)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDConcepto", original_Concepto.IDConcepto, theConcepto.IDConcepto));
            values.Add(new FieldValue("Alias", original_Concepto.Alias, theConcepto.Alias));
            values.Add(new FieldValue("Activo", original_Concepto.Activo, theConcepto.Activo));
            values.Add(new FieldValue("IDTipoconcepto", original_Concepto.IDTipoconcepto, theConcepto.IDTipoconcepto));
            values.Add(new FieldValue("TheidTipoconceptodescripcion", original_Concepto.TheidTipoconceptodescripcion, theConcepto.TheidTipoconceptodescripcion, true));
            values.Add(new FieldValue("Descripcion", original_Concepto.Descripcion, theConcepto.Descripcion));
            values.Add(new FieldValue("ImprimirRecibo", original_Concepto.ImprimirRecibo, theConcepto.ImprimirRecibo));
            values.Add(new FieldValue("ImprimirListado", original_Concepto.ImprimirListado, theConcepto.ImprimirListado));
            values.Add(new FieldValue("Mensual", original_Concepto.Mensual, theConcepto.Mensual));
            values.Add(new FieldValue("IDFiltro", original_Concepto.IDFiltro, theConcepto.IDFiltro));
            values.Add(new FieldValue("GravaImss", original_Concepto.GravaImss, theConcepto.GravaImss));
            values.Add(new FieldValue("GravaIsr", original_Concepto.GravaIsr, theConcepto.GravaIsr));
            values.Add(new FieldValue("Formula", original_Concepto.Formula, theConcepto.Formula));
            values.Add(new FieldValue("FormulaIsr", original_Concepto.FormulaIsr, theConcepto.FormulaIsr));
            values.Add(new FieldValue("FormulaExento", original_Concepto.FormulaExento, theConcepto.FormulaExento));
            values.Add(new FieldValue("FormulaImpresion", original_Concepto.FormulaImpresion, theConcepto.FormulaImpresion));
            values.Add(new FieldValue("CuentaContable", original_Concepto.CuentaContable, theConcepto.CuentaContable));
            values.Add(new FieldValue("ConceptoSat", original_Concepto.ConceptoSat, theConcepto.ConceptoSat));
            values.Add(new FieldValue("Notas", original_Concepto.Notas, theConcepto.Notas));
            values.Add(new FieldValue("OrdenCalculo", original_Concepto.OrdenCalculo, theConcepto.OrdenCalculo));
            values.Add(new FieldValue("ImporteMinimo", original_Concepto.ImporteMinimo, theConcepto.ImporteMinimo));
            values.Add(new FieldValue("ImporteMaximo", original_Concepto.ImporteMaximo, theConcepto.ImporteMaximo));
            values.Add(new FieldValue("Texto", original_Concepto.Texto, theConcepto.Texto));
            values.Add(new FieldValue("Numero", original_Concepto.Numero, theConcepto.Numero));
            values.Add(new FieldValue("CreadoPor", original_Concepto.CreadoPor, theConcepto.CreadoPor));
            values.Add(new FieldValue("ModificadoPor", original_Concepto.ModificadoPor, theConcepto.ModificadoPor));
            values.Add(new FieldValue("CreadoEn", original_Concepto.CreadoEn, theConcepto.CreadoEn));
            values.Add(new FieldValue("ModificadoEn", original_Concepto.ModificadoEn, theConcepto.ModificadoEn));
            values.Add(new FieldValue("AcumulaPtu", original_Concepto.AcumulaPtu, theConcepto.AcumulaPtu));
            values.Add(new FieldValue("GravaIsn", original_Concepto.GravaIsn, theConcepto.GravaIsn));
            values.Add(new FieldValue("FormulaSql", original_Concepto.FormulaSql, theConcepto.FormulaSql));
            values.Add(new FieldValue("FormulaIsrsql", original_Concepto.FormulaIsrsql, theConcepto.FormulaIsrsql));
            values.Add(new FieldValue("FormulaExentoSql", original_Concepto.FormulaExentoSql, theConcepto.FormulaExentoSql));
            values.Add(new FieldValue("FormulaImpresionSql", original_Concepto.FormulaImpresionSql, theConcepto.FormulaImpresionSql));
            values.Add(new FieldValue("CuentaContable2", original_Concepto.CuentaContable2, theConcepto.CuentaContable2));
            values.Add(new FieldValue("ReferenciaConcepto", original_Concepto.ReferenciaConcepto, theConcepto.ReferenciaConcepto));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.Concepto theConcepto, IXport.Data.Objects.Concepto original_Concepto, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Concepto";
            args.View = dataView;
            args.Values = CreateFieldValues(theConcepto, original_Concepto);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Concepto", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theConcepto);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.Concepto theConcepto, IXport.Data.Objects.Concepto original_Concepto)
        {
            return ExecuteAction(theConcepto, original_Concepto, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.Concepto theConcepto)
        {
            return Update(theConcepto, SelectSingle(theConcepto.IDConcepto));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.Concepto theConcepto)
        {
            return ExecuteAction(theConcepto, new Concepto(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.Concepto theConcepto)
        {
            return ExecuteAction(theConcepto, theConcepto, "Select", "Delete", DeleteView);
        }
    }
}
