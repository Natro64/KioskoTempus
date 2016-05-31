using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class TipoConcepto
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipoconcepto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _ordenCalculo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _generaAcumulado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _tipoSat;
        
        public TipoConcepto()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        public byte? OrdenCalculo
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? GeneraAcumulado
        {
            get
            {
                return _generaAcumulado;
            }
            set
            {
                _generaAcumulado = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte? TipoSat
        {
            get
            {
                return _tipoSat;
            }
            set
            {
                _tipoSat = value;
            }
        }
        
        public static List<IXport.Data.Objects.TipoConcepto> Select(string iDTipoconcepto, string descripcion, byte? ordenCalculo, bool? generaAcumulado, byte? tipoSat)
        {
            return new TipoConceptoFactory().Select(iDTipoconcepto, descripcion, ordenCalculo, generaAcumulado, tipoSat);
        }
        
        public static List<IXport.Data.Objects.TipoConcepto> Select(IXport.Data.Objects.TipoConcepto qbe)
        {
            return new TipoConceptoFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.TipoConcepto> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new TipoConceptoFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.TipoConcepto> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new TipoConceptoFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.TipoConcepto> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new TipoConceptoFactory().Select(filter, sort, TipoConceptoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.TipoConcepto> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new TipoConceptoFactory().Select(filter, sort, TipoConceptoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.TipoConcepto> Select(string filter, BusinessObjectParameters parameters)
        {
            return new TipoConceptoFactory().Select(filter, null, TipoConceptoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.TipoConcepto> Select(string filter, params FieldValue[] parameters)
        {
            return new TipoConceptoFactory().Select(filter, null, TipoConceptoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.TipoConcepto SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new TipoConceptoFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.TipoConcepto SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new TipoConceptoFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.TipoConcepto SelectSingle(string iDTipoconcepto)
        {
            return new TipoConceptoFactory().SelectSingle(iDTipoconcepto);
        }
        
        public int Insert()
        {
            return new TipoConceptoFactory().Insert(this);
        }
        
        public int Update()
        {
            return new TipoConceptoFactory().Update(this);
        }
        
        public int Delete()
        {
            return new TipoConceptoFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDTipoconcepto: {0}", this.IDTipoconcepto);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class TipoConceptoFactory
    {
        
        public TipoConceptoFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("TipoConcepto");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("TipoConcepto");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("TipoConcepto");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("TipoConcepto");
            }
        }
        
        public static TipoConceptoFactory Create()
        {
            return new TipoConceptoFactory();
        }
        
        protected virtual PageRequest CreateRequest(string iDTipoconcepto, string descripcion, byte? ordenCalculo, bool? generaAcumulado, byte? tipoSat, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDTipoconcepto != null)
            	filter.Add(("IDTipoconcepto:=" + iDTipoconcepto));
            if (!(String.IsNullOrEmpty(descripcion)))
            	filter.Add(("Descripcion:*" + descripcion));
            if (ordenCalculo.HasValue)
            	filter.Add(("OrdenCalculo:=" + ordenCalculo.Value.ToString()));
            if (generaAcumulado.HasValue)
            	filter.Add(("GeneraAcumulado:=" + generaAcumulado.Value.ToString()));
            if (tipoSat.HasValue)
            	filter.Add(("TipoSat:=" + tipoSat.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.TipoConcepto> Select(string iDTipoconcepto, string descripcion, byte? ordenCalculo, bool? generaAcumulado, byte? tipoSat, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDTipoconcepto, descripcion, ordenCalculo, generaAcumulado, tipoSat, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TipoConcepto", dataView, request);
            return page.ToList<IXport.Data.Objects.TipoConcepto>();
        }
        
        public List<IXport.Data.Objects.TipoConcepto> Select(IXport.Data.Objects.TipoConcepto qbe)
        {
            return Select(qbe.IDTipoconcepto, qbe.Descripcion, qbe.OrdenCalculo, qbe.GeneraAcumulado, qbe.TipoSat);
        }
        
        public int SelectCount(string iDTipoconcepto, string descripcion, byte? ordenCalculo, bool? generaAcumulado, byte? tipoSat, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDTipoconcepto, descripcion, ordenCalculo, generaAcumulado, tipoSat, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TipoConcepto", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.TipoConcepto> Select(string iDTipoconcepto, string descripcion, byte? ordenCalculo, bool? generaAcumulado, byte? tipoSat)
        {
            return Select(iDTipoconcepto, descripcion, ordenCalculo, generaAcumulado, tipoSat, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.TipoConcepto SelectSingle(string iDTipoconcepto)
        {
            List<IXport.Data.Objects.TipoConcepto> list = Select(iDTipoconcepto, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.TipoConcepto> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("TipoConcepto", dataView, request);
            return page.ToList<IXport.Data.Objects.TipoConcepto>();
        }
        
        public List<IXport.Data.Objects.TipoConcepto> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.TipoConcepto> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.TipoConcepto SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.TipoConcepto> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.TipoConcepto theTipoConcepto, IXport.Data.Objects.TipoConcepto original_TipoConcepto)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDTipoconcepto", original_TipoConcepto.IDTipoconcepto, theTipoConcepto.IDTipoconcepto));
            values.Add(new FieldValue("Descripcion", original_TipoConcepto.Descripcion, theTipoConcepto.Descripcion));
            values.Add(new FieldValue("OrdenCalculo", original_TipoConcepto.OrdenCalculo, theTipoConcepto.OrdenCalculo));
            values.Add(new FieldValue("GeneraAcumulado", original_TipoConcepto.GeneraAcumulado, theTipoConcepto.GeneraAcumulado));
            values.Add(new FieldValue("TipoSat", original_TipoConcepto.TipoSat, theTipoConcepto.TipoSat));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.TipoConcepto theTipoConcepto, IXport.Data.Objects.TipoConcepto original_TipoConcepto, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "TipoConcepto";
            args.View = dataView;
            args.Values = CreateFieldValues(theTipoConcepto, original_TipoConcepto);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("TipoConcepto", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theTipoConcepto);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.TipoConcepto theTipoConcepto, IXport.Data.Objects.TipoConcepto original_TipoConcepto)
        {
            return ExecuteAction(theTipoConcepto, original_TipoConcepto, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.TipoConcepto theTipoConcepto)
        {
            return Update(theTipoConcepto, SelectSingle(theTipoConcepto.IDTipoconcepto));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.TipoConcepto theTipoConcepto)
        {
            return ExecuteAction(theTipoConcepto, new TipoConcepto(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.TipoConcepto theTipoConcepto)
        {
            return ExecuteAction(theTipoConcepto, theTipoConcepto, "Select", "Delete", DeleteView);
        }
    }
}
