using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class TipoPrestamo
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipoprestamo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipoprestamodescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipoprestamoidConceptoalias;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipoprestamoidConceptoidTipoconceptodescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipoprestamoidConcepto2alias;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipoprestamoidConcepto2idTipoconceptodescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcionBilingue;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _iDConcepto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _theidConceptoalias;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _theidConceptoidTipoconceptodescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _iDConcepto2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDConcepto2alias;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDConcepto2idTipoconceptodescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _saldarEnFiniquito;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _altaAutomatica;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _numero;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _texto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modificadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _creadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modificadoEn;
        
        public TipoPrestamo()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        public string IDTipoprestamodescripcion
        {
            get
            {
                return _iDTipoprestamodescripcion;
            }
            set
            {
                _iDTipoprestamodescripcion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDTipoprestamoidConceptoalias
        {
            get
            {
                return _iDTipoprestamoidConceptoalias;
            }
            set
            {
                _iDTipoprestamoidConceptoalias = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDTipoprestamoidConceptoidTipoconceptodescripcion
        {
            get
            {
                return _iDTipoprestamoidConceptoidTipoconceptodescripcion;
            }
            set
            {
                _iDTipoprestamoidConceptoidTipoconceptodescripcion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDTipoprestamoidConcepto2alias
        {
            get
            {
                return _iDTipoprestamoidConcepto2alias;
            }
            set
            {
                _iDTipoprestamoidConcepto2alias = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDTipoprestamoidConcepto2idTipoconceptodescripcion
        {
            get
            {
                return _iDTipoprestamoidConcepto2idTipoconceptodescripcion;
            }
            set
            {
                _iDTipoprestamoidConcepto2idTipoconceptodescripcion = value;
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
        public string DescripcionBilingue
        {
            get
            {
                return _descripcionBilingue;
            }
            set
            {
                _descripcionBilingue = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TheidConceptoalias
        {
            get
            {
                return _theidConceptoalias;
            }
            set
            {
                _theidConceptoalias = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TheidConceptoidTipoconceptodescripcion
        {
            get
            {
                return _theidConceptoidTipoconceptodescripcion;
            }
            set
            {
                _theidConceptoidTipoconceptodescripcion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public short? IDConcepto2
        {
            get
            {
                return _iDConcepto2;
            }
            set
            {
                _iDConcepto2 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDConcepto2alias
        {
            get
            {
                return _iDConcepto2alias;
            }
            set
            {
                _iDConcepto2alias = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDConcepto2idTipoconceptodescripcion
        {
            get
            {
                return _iDConcepto2idTipoconceptodescripcion;
            }
            set
            {
                _iDConcepto2idTipoconceptodescripcion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public short? SaldarEnFiniquito
        {
            get
            {
                return _saldarEnFiniquito;
            }
            set
            {
                _saldarEnFiniquito = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public short? AltaAutomatica
        {
            get
            {
                return _altaAutomatica;
            }
            set
            {
                _altaAutomatica = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        public static List<IXport.Data.Objects.TipoPrestamo> Select(
                    string iDTipoprestamo, 
                    string iDTipoprestamodescripcion, 
                    string iDTipoprestamoidConceptoalias, 
                    string iDTipoprestamoidConceptoidTipoconceptodescripcion, 
                    string iDTipoprestamoidConcepto2alias, 
                    string iDTipoprestamoidConcepto2idTipoconceptodescripcion, 
                    string descripcion, 
                    string descripcionBilingue, 
                    short? iDConcepto, 
                    string theidConceptoalias, 
                    string theidConceptoidTipoconceptodescripcion, 
                    short? iDConcepto2, 
                    string iDConcepto2alias, 
                    string iDConcepto2idTipoconceptodescripcion, 
                    short? saldarEnFiniquito, 
                    short? altaAutomatica, 
                    decimal? numero, 
                    string texto, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn)
        {
            return new TipoPrestamoFactory().Select(iDTipoprestamo, iDTipoprestamodescripcion, iDTipoprestamoidConceptoalias, iDTipoprestamoidConceptoidTipoconceptodescripcion, iDTipoprestamoidConcepto2alias, iDTipoprestamoidConcepto2idTipoconceptodescripcion, descripcion, descripcionBilingue, iDConcepto, theidConceptoalias, theidConceptoidTipoconceptodescripcion, iDConcepto2, iDConcepto2alias, iDConcepto2idTipoconceptodescripcion, saldarEnFiniquito, altaAutomatica, numero, texto, creadoPor, modificadoPor, creadoEn, modificadoEn);
        }
        
        public static List<IXport.Data.Objects.TipoPrestamo> Select(IXport.Data.Objects.TipoPrestamo qbe)
        {
            return new TipoPrestamoFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.TipoPrestamo> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new TipoPrestamoFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.TipoPrestamo> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new TipoPrestamoFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.TipoPrestamo> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new TipoPrestamoFactory().Select(filter, sort, TipoPrestamoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.TipoPrestamo> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new TipoPrestamoFactory().Select(filter, sort, TipoPrestamoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.TipoPrestamo> Select(string filter, BusinessObjectParameters parameters)
        {
            return new TipoPrestamoFactory().Select(filter, null, TipoPrestamoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.TipoPrestamo> Select(string filter, params FieldValue[] parameters)
        {
            return new TipoPrestamoFactory().Select(filter, null, TipoPrestamoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.TipoPrestamo SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new TipoPrestamoFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.TipoPrestamo SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new TipoPrestamoFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.TipoPrestamo SelectSingle(string iDTipoprestamo)
        {
            return new TipoPrestamoFactory().SelectSingle(iDTipoprestamo);
        }
        
        public int Insert()
        {
            return new TipoPrestamoFactory().Insert(this);
        }
        
        public int Update()
        {
            return new TipoPrestamoFactory().Update(this);
        }
        
        public int Delete()
        {
            return new TipoPrestamoFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDTipoprestamo: {0}", this.IDTipoprestamo);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class TipoPrestamoFactory
    {
        
        public TipoPrestamoFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("TipoPrestamo");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("TipoPrestamo");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("TipoPrestamo");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("TipoPrestamo");
            }
        }
        
        public static TipoPrestamoFactory Create()
        {
            return new TipoPrestamoFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    string iDTipoprestamo, 
                    string iDTipoprestamodescripcion, 
                    string iDTipoprestamoidConceptoalias, 
                    string iDTipoprestamoidConceptoidTipoconceptodescripcion, 
                    string iDTipoprestamoidConcepto2alias, 
                    string iDTipoprestamoidConcepto2idTipoconceptodescripcion, 
                    string descripcion, 
                    string descripcionBilingue, 
                    short? iDConcepto, 
                    string theidConceptoalias, 
                    string theidConceptoidTipoconceptodescripcion, 
                    short? iDConcepto2, 
                    string iDConcepto2alias, 
                    string iDConcepto2idTipoconceptodescripcion, 
                    short? saldarEnFiniquito, 
                    short? altaAutomatica, 
                    decimal? numero, 
                    string texto, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDTipoprestamo != null)
            	filter.Add(("IDTipoprestamo:=" + iDTipoprestamo));
            if (!(String.IsNullOrEmpty(iDTipoprestamodescripcion)))
            	filter.Add(("IDTipoprestamodescripcion:*" + iDTipoprestamodescripcion));
            if (!(String.IsNullOrEmpty(iDTipoprestamoidConceptoalias)))
            	filter.Add(("IDTipoprestamoidConceptoalias:*" + iDTipoprestamoidConceptoalias));
            if (!(String.IsNullOrEmpty(iDTipoprestamoidConceptoidTipoconceptodescripcion)))
            	filter.Add(("IDTipoprestamoidConceptoidTipoconceptodescripcion:*" + iDTipoprestamoidConceptoidTipoconceptodescripcion));
            if (!(String.IsNullOrEmpty(iDTipoprestamoidConcepto2alias)))
            	filter.Add(("IDTipoprestamoidConcepto2alias:*" + iDTipoprestamoidConcepto2alias));
            if (!(String.IsNullOrEmpty(iDTipoprestamoidConcepto2idTipoconceptodescripcion)))
            	filter.Add(("IDTipoprestamoidConcepto2idTipoconceptodescripcion:*" + iDTipoprestamoidConcepto2idTipoconceptodescripcion));
            if (!(String.IsNullOrEmpty(descripcion)))
            	filter.Add(("Descripcion:*" + descripcion));
            if (!(String.IsNullOrEmpty(descripcionBilingue)))
            	filter.Add(("DescripcionBilingue:*" + descripcionBilingue));
            if (iDConcepto.HasValue)
            	filter.Add(("IDConcepto:=" + iDConcepto.Value.ToString()));
            if (!(String.IsNullOrEmpty(theidConceptoalias)))
            	filter.Add(("TheidConceptoalias:*" + theidConceptoalias));
            if (!(String.IsNullOrEmpty(theidConceptoidTipoconceptodescripcion)))
            	filter.Add(("TheidConceptoidTipoconceptodescripcion:*" + theidConceptoidTipoconceptodescripcion));
            if (iDConcepto2.HasValue)
            	filter.Add(("IDConcepto2:=" + iDConcepto2.Value.ToString()));
            if (!(String.IsNullOrEmpty(iDConcepto2alias)))
            	filter.Add(("IDConcepto2alias:*" + iDConcepto2alias));
            if (!(String.IsNullOrEmpty(iDConcepto2idTipoconceptodescripcion)))
            	filter.Add(("IDConcepto2idTipoconceptodescripcion:*" + iDConcepto2idTipoconceptodescripcion));
            if (saldarEnFiniquito.HasValue)
            	filter.Add(("SaldarEnFiniquito:=" + saldarEnFiniquito.Value.ToString()));
            if (altaAutomatica.HasValue)
            	filter.Add(("AltaAutomatica:=" + altaAutomatica.Value.ToString()));
            if (numero.HasValue)
            	filter.Add(("Numero:=" + numero.Value.ToString()));
            if (!(String.IsNullOrEmpty(texto)))
            	filter.Add(("Texto:*" + texto));
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
        public List<IXport.Data.Objects.TipoPrestamo> Select(
                    string iDTipoprestamo, 
                    string iDTipoprestamodescripcion, 
                    string iDTipoprestamoidConceptoalias, 
                    string iDTipoprestamoidConceptoidTipoconceptodescripcion, 
                    string iDTipoprestamoidConcepto2alias, 
                    string iDTipoprestamoidConcepto2idTipoconceptodescripcion, 
                    string descripcion, 
                    string descripcionBilingue, 
                    short? iDConcepto, 
                    string theidConceptoalias, 
                    string theidConceptoidTipoconceptodescripcion, 
                    short? iDConcepto2, 
                    string iDConcepto2alias, 
                    string iDConcepto2idTipoconceptodescripcion, 
                    short? saldarEnFiniquito, 
                    short? altaAutomatica, 
                    decimal? numero, 
                    string texto, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDTipoprestamo, iDTipoprestamodescripcion, iDTipoprestamoidConceptoalias, iDTipoprestamoidConceptoidTipoconceptodescripcion, iDTipoprestamoidConcepto2alias, iDTipoprestamoidConcepto2idTipoconceptodescripcion, descripcion, descripcionBilingue, iDConcepto, theidConceptoalias, theidConceptoidTipoconceptodescripcion, iDConcepto2, iDConcepto2alias, iDConcepto2idTipoconceptodescripcion, saldarEnFiniquito, altaAutomatica, numero, texto, creadoPor, modificadoPor, creadoEn, modificadoEn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TipoPrestamo", dataView, request);
            return page.ToList<IXport.Data.Objects.TipoPrestamo>();
        }
        
        public List<IXport.Data.Objects.TipoPrestamo> Select(IXport.Data.Objects.TipoPrestamo qbe)
        {
            return Select(qbe.IDTipoprestamo, qbe.IDTipoprestamodescripcion, qbe.IDTipoprestamoidConceptoalias, qbe.IDTipoprestamoidConceptoidTipoconceptodescripcion, qbe.IDTipoprestamoidConcepto2alias, qbe.IDTipoprestamoidConcepto2idTipoconceptodescripcion, qbe.Descripcion, qbe.DescripcionBilingue, qbe.IDConcepto, qbe.TheidConceptoalias, qbe.TheidConceptoidTipoconceptodescripcion, qbe.IDConcepto2, qbe.IDConcepto2alias, qbe.IDConcepto2idTipoconceptodescripcion, qbe.SaldarEnFiniquito, qbe.AltaAutomatica, qbe.Numero, qbe.Texto, qbe.CreadoPor, qbe.ModificadoPor, qbe.CreadoEn, qbe.ModificadoEn);
        }
        
        public int SelectCount(
                    string iDTipoprestamo, 
                    string iDTipoprestamodescripcion, 
                    string iDTipoprestamoidConceptoalias, 
                    string iDTipoprestamoidConceptoidTipoconceptodescripcion, 
                    string iDTipoprestamoidConcepto2alias, 
                    string iDTipoprestamoidConcepto2idTipoconceptodescripcion, 
                    string descripcion, 
                    string descripcionBilingue, 
                    short? iDConcepto, 
                    string theidConceptoalias, 
                    string theidConceptoidTipoconceptodescripcion, 
                    short? iDConcepto2, 
                    string iDConcepto2alias, 
                    string iDConcepto2idTipoconceptodescripcion, 
                    short? saldarEnFiniquito, 
                    short? altaAutomatica, 
                    decimal? numero, 
                    string texto, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDTipoprestamo, iDTipoprestamodescripcion, iDTipoprestamoidConceptoalias, iDTipoprestamoidConceptoidTipoconceptodescripcion, iDTipoprestamoidConcepto2alias, iDTipoprestamoidConcepto2idTipoconceptodescripcion, descripcion, descripcionBilingue, iDConcepto, theidConceptoalias, theidConceptoidTipoconceptodescripcion, iDConcepto2, iDConcepto2alias, iDConcepto2idTipoconceptodescripcion, saldarEnFiniquito, altaAutomatica, numero, texto, creadoPor, modificadoPor, creadoEn, modificadoEn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TipoPrestamo", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.TipoPrestamo> Select(
                    string iDTipoprestamo, 
                    string iDTipoprestamodescripcion, 
                    string iDTipoprestamoidConceptoalias, 
                    string iDTipoprestamoidConceptoidTipoconceptodescripcion, 
                    string iDTipoprestamoidConcepto2alias, 
                    string iDTipoprestamoidConcepto2idTipoconceptodescripcion, 
                    string descripcion, 
                    string descripcionBilingue, 
                    short? iDConcepto, 
                    string theidConceptoalias, 
                    string theidConceptoidTipoconceptodescripcion, 
                    short? iDConcepto2, 
                    string iDConcepto2alias, 
                    string iDConcepto2idTipoconceptodescripcion, 
                    short? saldarEnFiniquito, 
                    short? altaAutomatica, 
                    decimal? numero, 
                    string texto, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn)
        {
            return Select(iDTipoprestamo, iDTipoprestamodescripcion, iDTipoprestamoidConceptoalias, iDTipoprestamoidConceptoidTipoconceptodescripcion, iDTipoprestamoidConcepto2alias, iDTipoprestamoidConcepto2idTipoconceptodescripcion, descripcion, descripcionBilingue, iDConcepto, theidConceptoalias, theidConceptoidTipoconceptodescripcion, iDConcepto2, iDConcepto2alias, iDConcepto2idTipoconceptodescripcion, saldarEnFiniquito, altaAutomatica, numero, texto, creadoPor, modificadoPor, creadoEn, modificadoEn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.TipoPrestamo SelectSingle(string iDTipoprestamo)
        {
            List<IXport.Data.Objects.TipoPrestamo> list = Select(iDTipoprestamo, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.TipoPrestamo> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("TipoPrestamo", dataView, request);
            return page.ToList<IXport.Data.Objects.TipoPrestamo>();
        }
        
        public List<IXport.Data.Objects.TipoPrestamo> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.TipoPrestamo> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.TipoPrestamo SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.TipoPrestamo> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.TipoPrestamo theTipoPrestamo, IXport.Data.Objects.TipoPrestamo original_TipoPrestamo)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDTipoprestamo", original_TipoPrestamo.IDTipoprestamo, theTipoPrestamo.IDTipoprestamo));
            values.Add(new FieldValue("IDTipoprestamodescripcion", original_TipoPrestamo.IDTipoprestamodescripcion, theTipoPrestamo.IDTipoprestamodescripcion, true));
            values.Add(new FieldValue("IDTipoprestamoidConceptoalias", original_TipoPrestamo.IDTipoprestamoidConceptoalias, theTipoPrestamo.IDTipoprestamoidConceptoalias, true));
            values.Add(new FieldValue("IDTipoprestamoidConceptoidTipoconceptodescripcion", original_TipoPrestamo.IDTipoprestamoidConceptoidTipoconceptodescripcion, theTipoPrestamo.IDTipoprestamoidConceptoidTipoconceptodescripcion, true));
            values.Add(new FieldValue("IDTipoprestamoidConcepto2alias", original_TipoPrestamo.IDTipoprestamoidConcepto2alias, theTipoPrestamo.IDTipoprestamoidConcepto2alias, true));
            values.Add(new FieldValue("IDTipoprestamoidConcepto2idTipoconceptodescripcion", original_TipoPrestamo.IDTipoprestamoidConcepto2idTipoconceptodescripcion, theTipoPrestamo.IDTipoprestamoidConcepto2idTipoconceptodescripcion, true));
            values.Add(new FieldValue("Descripcion", original_TipoPrestamo.Descripcion, theTipoPrestamo.Descripcion));
            values.Add(new FieldValue("DescripcionBilingue", original_TipoPrestamo.DescripcionBilingue, theTipoPrestamo.DescripcionBilingue));
            values.Add(new FieldValue("IDConcepto", original_TipoPrestamo.IDConcepto, theTipoPrestamo.IDConcepto));
            values.Add(new FieldValue("TheidConceptoalias", original_TipoPrestamo.TheidConceptoalias, theTipoPrestamo.TheidConceptoalias, true));
            values.Add(new FieldValue("TheidConceptoidTipoconceptodescripcion", original_TipoPrestamo.TheidConceptoidTipoconceptodescripcion, theTipoPrestamo.TheidConceptoidTipoconceptodescripcion, true));
            values.Add(new FieldValue("IDConcepto2", original_TipoPrestamo.IDConcepto2, theTipoPrestamo.IDConcepto2));
            values.Add(new FieldValue("IDConcepto2alias", original_TipoPrestamo.IDConcepto2alias, theTipoPrestamo.IDConcepto2alias, true));
            values.Add(new FieldValue("IDConcepto2idTipoconceptodescripcion", original_TipoPrestamo.IDConcepto2idTipoconceptodescripcion, theTipoPrestamo.IDConcepto2idTipoconceptodescripcion, true));
            values.Add(new FieldValue("SaldarEnFiniquito", original_TipoPrestamo.SaldarEnFiniquito, theTipoPrestamo.SaldarEnFiniquito));
            values.Add(new FieldValue("AltaAutomatica", original_TipoPrestamo.AltaAutomatica, theTipoPrestamo.AltaAutomatica));
            values.Add(new FieldValue("Numero", original_TipoPrestamo.Numero, theTipoPrestamo.Numero));
            values.Add(new FieldValue("Texto", original_TipoPrestamo.Texto, theTipoPrestamo.Texto));
            values.Add(new FieldValue("CreadoPor", original_TipoPrestamo.CreadoPor, theTipoPrestamo.CreadoPor));
            values.Add(new FieldValue("ModificadoPor", original_TipoPrestamo.ModificadoPor, theTipoPrestamo.ModificadoPor));
            values.Add(new FieldValue("CreadoEn", original_TipoPrestamo.CreadoEn, theTipoPrestamo.CreadoEn));
            values.Add(new FieldValue("ModificadoEn", original_TipoPrestamo.ModificadoEn, theTipoPrestamo.ModificadoEn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.TipoPrestamo theTipoPrestamo, IXport.Data.Objects.TipoPrestamo original_TipoPrestamo, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "TipoPrestamo";
            args.View = dataView;
            args.Values = CreateFieldValues(theTipoPrestamo, original_TipoPrestamo);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("TipoPrestamo", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theTipoPrestamo);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.TipoPrestamo theTipoPrestamo, IXport.Data.Objects.TipoPrestamo original_TipoPrestamo)
        {
            return ExecuteAction(theTipoPrestamo, original_TipoPrestamo, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.TipoPrestamo theTipoPrestamo)
        {
            return Update(theTipoPrestamo, SelectSingle(theTipoPrestamo.IDTipoprestamo));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.TipoPrestamo theTipoPrestamo)
        {
            return ExecuteAction(theTipoPrestamo, new TipoPrestamo(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.TipoPrestamo theTipoPrestamo)
        {
            return ExecuteAction(theTipoPrestamo, theTipoPrestamo, "Select", "Delete", DeleteView);
        }
    }
}
