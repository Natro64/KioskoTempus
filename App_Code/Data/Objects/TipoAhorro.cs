using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class TipoAhorro
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipoahorro;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcionBilingue;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _numero;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _texto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _iDConcepto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDConceptoalias;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDConceptoidTipoconceptodescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _iDConcepto2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDConcepto2alias;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDConcepto2idTipoconceptodescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _saldarFiniquito;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _autoAlta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modificadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _creadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modificadoEn;
        
        public TipoAhorro()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        public string IDConceptoalias
        {
            get
            {
                return _iDConceptoalias;
            }
            set
            {
                _iDConceptoalias = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDConceptoidTipoconceptodescripcion
        {
            get
            {
                return _iDConceptoidTipoconceptodescripcion;
            }
            set
            {
                _iDConceptoidTipoconceptodescripcion = value;
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
        public short? SaldarFiniquito
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public short? AutoAlta
        {
            get
            {
                return _autoAlta;
            }
            set
            {
                _autoAlta = value;
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
        
        public static List<IXport.Data.Objects.TipoAhorro> Select(
                    string iDTipoahorro, 
                    string descripcion, 
                    string descripcionBilingue, 
                    decimal? numero, 
                    string texto, 
                    short? iDConcepto, 
                    string iDConceptoalias, 
                    string iDConceptoidTipoconceptodescripcion, 
                    short? iDConcepto2, 
                    string iDConcepto2alias, 
                    string iDConcepto2idTipoconceptodescripcion, 
                    short? saldarFiniquito, 
                    short? autoAlta, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn)
        {
            return new TipoAhorroFactory().Select(iDTipoahorro, descripcion, descripcionBilingue, numero, texto, iDConcepto, iDConceptoalias, iDConceptoidTipoconceptodescripcion, iDConcepto2, iDConcepto2alias, iDConcepto2idTipoconceptodescripcion, saldarFiniquito, autoAlta, creadoPor, modificadoPor, creadoEn, modificadoEn);
        }
        
        public static List<IXport.Data.Objects.TipoAhorro> Select(IXport.Data.Objects.TipoAhorro qbe)
        {
            return new TipoAhorroFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.TipoAhorro> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new TipoAhorroFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.TipoAhorro> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new TipoAhorroFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.TipoAhorro> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new TipoAhorroFactory().Select(filter, sort, TipoAhorroFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.TipoAhorro> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new TipoAhorroFactory().Select(filter, sort, TipoAhorroFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.TipoAhorro> Select(string filter, BusinessObjectParameters parameters)
        {
            return new TipoAhorroFactory().Select(filter, null, TipoAhorroFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.TipoAhorro> Select(string filter, params FieldValue[] parameters)
        {
            return new TipoAhorroFactory().Select(filter, null, TipoAhorroFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.TipoAhorro SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new TipoAhorroFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.TipoAhorro SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new TipoAhorroFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.TipoAhorro SelectSingle(string iDTipoahorro)
        {
            return new TipoAhorroFactory().SelectSingle(iDTipoahorro);
        }
        
        public int Insert()
        {
            return new TipoAhorroFactory().Insert(this);
        }
        
        public int Update()
        {
            return new TipoAhorroFactory().Update(this);
        }
        
        public int Delete()
        {
            return new TipoAhorroFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDTipoahorro: {0}", this.IDTipoahorro);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class TipoAhorroFactory
    {
        
        public TipoAhorroFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("TipoAhorro");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("TipoAhorro");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("TipoAhorro");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("TipoAhorro");
            }
        }
        
        public static TipoAhorroFactory Create()
        {
            return new TipoAhorroFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    string iDTipoahorro, 
                    string descripcion, 
                    string descripcionBilingue, 
                    decimal? numero, 
                    string texto, 
                    short? iDConcepto, 
                    string iDConceptoalias, 
                    string iDConceptoidTipoconceptodescripcion, 
                    short? iDConcepto2, 
                    string iDConcepto2alias, 
                    string iDConcepto2idTipoconceptodescripcion, 
                    short? saldarFiniquito, 
                    short? autoAlta, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDTipoahorro != null)
            	filter.Add(("IDTipoahorro:=" + iDTipoahorro));
            if (!(String.IsNullOrEmpty(descripcion)))
            	filter.Add(("Descripcion:*" + descripcion));
            if (!(String.IsNullOrEmpty(descripcionBilingue)))
            	filter.Add(("DescripcionBilingue:*" + descripcionBilingue));
            if (numero.HasValue)
            	filter.Add(("Numero:=" + numero.Value.ToString()));
            if (!(String.IsNullOrEmpty(texto)))
            	filter.Add(("Texto:*" + texto));
            if (iDConcepto.HasValue)
            	filter.Add(("IDConcepto:=" + iDConcepto.Value.ToString()));
            if (!(String.IsNullOrEmpty(iDConceptoalias)))
            	filter.Add(("IDConceptoalias:*" + iDConceptoalias));
            if (!(String.IsNullOrEmpty(iDConceptoidTipoconceptodescripcion)))
            	filter.Add(("IDConceptoidTipoconceptodescripcion:*" + iDConceptoidTipoconceptodescripcion));
            if (iDConcepto2.HasValue)
            	filter.Add(("IDConcepto2:=" + iDConcepto2.Value.ToString()));
            if (!(String.IsNullOrEmpty(iDConcepto2alias)))
            	filter.Add(("IDConcepto2alias:*" + iDConcepto2alias));
            if (!(String.IsNullOrEmpty(iDConcepto2idTipoconceptodescripcion)))
            	filter.Add(("IDConcepto2idTipoconceptodescripcion:*" + iDConcepto2idTipoconceptodescripcion));
            if (saldarFiniquito.HasValue)
            	filter.Add(("SaldarFiniquito:=" + saldarFiniquito.Value.ToString()));
            if (autoAlta.HasValue)
            	filter.Add(("AutoAlta:=" + autoAlta.Value.ToString()));
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
        public List<IXport.Data.Objects.TipoAhorro> Select(
                    string iDTipoahorro, 
                    string descripcion, 
                    string descripcionBilingue, 
                    decimal? numero, 
                    string texto, 
                    short? iDConcepto, 
                    string iDConceptoalias, 
                    string iDConceptoidTipoconceptodescripcion, 
                    short? iDConcepto2, 
                    string iDConcepto2alias, 
                    string iDConcepto2idTipoconceptodescripcion, 
                    short? saldarFiniquito, 
                    short? autoAlta, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDTipoahorro, descripcion, descripcionBilingue, numero, texto, iDConcepto, iDConceptoalias, iDConceptoidTipoconceptodescripcion, iDConcepto2, iDConcepto2alias, iDConcepto2idTipoconceptodescripcion, saldarFiniquito, autoAlta, creadoPor, modificadoPor, creadoEn, modificadoEn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TipoAhorro", dataView, request);
            return page.ToList<IXport.Data.Objects.TipoAhorro>();
        }
        
        public List<IXport.Data.Objects.TipoAhorro> Select(IXport.Data.Objects.TipoAhorro qbe)
        {
            return Select(qbe.IDTipoahorro, qbe.Descripcion, qbe.DescripcionBilingue, qbe.Numero, qbe.Texto, qbe.IDConcepto, qbe.IDConceptoalias, qbe.IDConceptoidTipoconceptodescripcion, qbe.IDConcepto2, qbe.IDConcepto2alias, qbe.IDConcepto2idTipoconceptodescripcion, qbe.SaldarFiniquito, qbe.AutoAlta, qbe.CreadoPor, qbe.ModificadoPor, qbe.CreadoEn, qbe.ModificadoEn);
        }
        
        public int SelectCount(
                    string iDTipoahorro, 
                    string descripcion, 
                    string descripcionBilingue, 
                    decimal? numero, 
                    string texto, 
                    short? iDConcepto, 
                    string iDConceptoalias, 
                    string iDConceptoidTipoconceptodescripcion, 
                    short? iDConcepto2, 
                    string iDConcepto2alias, 
                    string iDConcepto2idTipoconceptodescripcion, 
                    short? saldarFiniquito, 
                    short? autoAlta, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDTipoahorro, descripcion, descripcionBilingue, numero, texto, iDConcepto, iDConceptoalias, iDConceptoidTipoconceptodescripcion, iDConcepto2, iDConcepto2alias, iDConcepto2idTipoconceptodescripcion, saldarFiniquito, autoAlta, creadoPor, modificadoPor, creadoEn, modificadoEn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TipoAhorro", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.TipoAhorro> Select(
                    string iDTipoahorro, 
                    string descripcion, 
                    string descripcionBilingue, 
                    decimal? numero, 
                    string texto, 
                    short? iDConcepto, 
                    string iDConceptoalias, 
                    string iDConceptoidTipoconceptodescripcion, 
                    short? iDConcepto2, 
                    string iDConcepto2alias, 
                    string iDConcepto2idTipoconceptodescripcion, 
                    short? saldarFiniquito, 
                    short? autoAlta, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn)
        {
            return Select(iDTipoahorro, descripcion, descripcionBilingue, numero, texto, iDConcepto, iDConceptoalias, iDConceptoidTipoconceptodescripcion, iDConcepto2, iDConcepto2alias, iDConcepto2idTipoconceptodescripcion, saldarFiniquito, autoAlta, creadoPor, modificadoPor, creadoEn, modificadoEn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.TipoAhorro SelectSingle(string iDTipoahorro)
        {
            List<IXport.Data.Objects.TipoAhorro> list = Select(iDTipoahorro, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.TipoAhorro> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("TipoAhorro", dataView, request);
            return page.ToList<IXport.Data.Objects.TipoAhorro>();
        }
        
        public List<IXport.Data.Objects.TipoAhorro> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.TipoAhorro> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.TipoAhorro SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.TipoAhorro> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.TipoAhorro theTipoAhorro, IXport.Data.Objects.TipoAhorro original_TipoAhorro)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDTipoahorro", original_TipoAhorro.IDTipoahorro, theTipoAhorro.IDTipoahorro));
            values.Add(new FieldValue("Descripcion", original_TipoAhorro.Descripcion, theTipoAhorro.Descripcion));
            values.Add(new FieldValue("DescripcionBilingue", original_TipoAhorro.DescripcionBilingue, theTipoAhorro.DescripcionBilingue));
            values.Add(new FieldValue("Numero", original_TipoAhorro.Numero, theTipoAhorro.Numero));
            values.Add(new FieldValue("Texto", original_TipoAhorro.Texto, theTipoAhorro.Texto));
            values.Add(new FieldValue("IDConcepto", original_TipoAhorro.IDConcepto, theTipoAhorro.IDConcepto));
            values.Add(new FieldValue("IDConceptoalias", original_TipoAhorro.IDConceptoalias, theTipoAhorro.IDConceptoalias, true));
            values.Add(new FieldValue("IDConceptoidTipoconceptodescripcion", original_TipoAhorro.IDConceptoidTipoconceptodescripcion, theTipoAhorro.IDConceptoidTipoconceptodescripcion, true));
            values.Add(new FieldValue("IDConcepto2", original_TipoAhorro.IDConcepto2, theTipoAhorro.IDConcepto2));
            values.Add(new FieldValue("IDConcepto2alias", original_TipoAhorro.IDConcepto2alias, theTipoAhorro.IDConcepto2alias, true));
            values.Add(new FieldValue("IDConcepto2idTipoconceptodescripcion", original_TipoAhorro.IDConcepto2idTipoconceptodescripcion, theTipoAhorro.IDConcepto2idTipoconceptodescripcion, true));
            values.Add(new FieldValue("SaldarFiniquito", original_TipoAhorro.SaldarFiniquito, theTipoAhorro.SaldarFiniquito));
            values.Add(new FieldValue("AutoAlta", original_TipoAhorro.AutoAlta, theTipoAhorro.AutoAlta));
            values.Add(new FieldValue("CreadoPor", original_TipoAhorro.CreadoPor, theTipoAhorro.CreadoPor));
            values.Add(new FieldValue("ModificadoPor", original_TipoAhorro.ModificadoPor, theTipoAhorro.ModificadoPor));
            values.Add(new FieldValue("CreadoEn", original_TipoAhorro.CreadoEn, theTipoAhorro.CreadoEn));
            values.Add(new FieldValue("ModificadoEn", original_TipoAhorro.ModificadoEn, theTipoAhorro.ModificadoEn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.TipoAhorro theTipoAhorro, IXport.Data.Objects.TipoAhorro original_TipoAhorro, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "TipoAhorro";
            args.View = dataView;
            args.Values = CreateFieldValues(theTipoAhorro, original_TipoAhorro);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("TipoAhorro", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theTipoAhorro);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.TipoAhorro theTipoAhorro, IXport.Data.Objects.TipoAhorro original_TipoAhorro)
        {
            return ExecuteAction(theTipoAhorro, original_TipoAhorro, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.TipoAhorro theTipoAhorro)
        {
            return Update(theTipoAhorro, SelectSingle(theTipoAhorro.IDTipoahorro));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.TipoAhorro theTipoAhorro)
        {
            return ExecuteAction(theTipoAhorro, new TipoAhorro(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.TipoAhorro theTipoAhorro)
        {
            return ExecuteAction(theTipoAhorro, theTipoAhorro, "Select", "Delete", DeleteView);
        }
    }
}
