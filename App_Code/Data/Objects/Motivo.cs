using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Motivo
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDMotivo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;
        
        public Motivo()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? IDMotivo
        {
            get
            {
                return _iDMotivo;
            }
            set
            {
                _iDMotivo = value;
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
        
        public static List<IXport.Data.Objects.Motivo> Select(int? iDMotivo, string descripcion)
        {
            return new MotivoFactory().Select(iDMotivo, descripcion);
        }
        
        public static List<IXport.Data.Objects.Motivo> Select(IXport.Data.Objects.Motivo qbe)
        {
            return new MotivoFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.Motivo> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new MotivoFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.Motivo> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new MotivoFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Motivo> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new MotivoFactory().Select(filter, sort, MotivoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Motivo> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new MotivoFactory().Select(filter, sort, MotivoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Motivo> Select(string filter, BusinessObjectParameters parameters)
        {
            return new MotivoFactory().Select(filter, null, MotivoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Motivo> Select(string filter, params FieldValue[] parameters)
        {
            return new MotivoFactory().Select(filter, null, MotivoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Motivo SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new MotivoFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.Motivo SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new MotivoFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Motivo SelectSingle(int? iDMotivo)
        {
            return new MotivoFactory().SelectSingle(iDMotivo);
        }
        
        public int Insert()
        {
            return new MotivoFactory().Insert(this);
        }
        
        public int Update()
        {
            return new MotivoFactory().Update(this);
        }
        
        public int Delete()
        {
            return new MotivoFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDMotivo: {0}", this.IDMotivo);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class MotivoFactory
    {
        
        public MotivoFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Motivo");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Motivo");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Motivo");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Motivo");
            }
        }
        
        public static MotivoFactory Create()
        {
            return new MotivoFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? iDMotivo, string descripcion, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDMotivo.HasValue)
            	filter.Add(("IDMotivo:=" + iDMotivo.Value.ToString()));
            if (!(String.IsNullOrEmpty(descripcion)))
            	filter.Add(("Descripcion:*" + descripcion));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.Motivo> Select(int? iDMotivo, string descripcion, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDMotivo, descripcion, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Motivo", dataView, request);
            return page.ToList<IXport.Data.Objects.Motivo>();
        }
        
        public List<IXport.Data.Objects.Motivo> Select(IXport.Data.Objects.Motivo qbe)
        {
            return Select(qbe.IDMotivo, qbe.Descripcion);
        }
        
        public int SelectCount(int? iDMotivo, string descripcion, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDMotivo, descripcion, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Motivo", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.Motivo> Select(int? iDMotivo, string descripcion)
        {
            return Select(iDMotivo, descripcion, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.Motivo SelectSingle(int? iDMotivo)
        {
            string emptyDescripcion = null;
            List<IXport.Data.Objects.Motivo> list = Select(iDMotivo, emptyDescripcion);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.Motivo> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Motivo", dataView, request);
            return page.ToList<IXport.Data.Objects.Motivo>();
        }
        
        public List<IXport.Data.Objects.Motivo> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.Motivo> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.Motivo SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.Motivo> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.Motivo theMotivo, IXport.Data.Objects.Motivo original_Motivo)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDMotivo", original_Motivo.IDMotivo, theMotivo.IDMotivo, true));
            values.Add(new FieldValue("Descripcion", original_Motivo.Descripcion, theMotivo.Descripcion));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.Motivo theMotivo, IXport.Data.Objects.Motivo original_Motivo, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Motivo";
            args.View = dataView;
            args.Values = CreateFieldValues(theMotivo, original_Motivo);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Motivo", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theMotivo);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.Motivo theMotivo, IXport.Data.Objects.Motivo original_Motivo)
        {
            return ExecuteAction(theMotivo, original_Motivo, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.Motivo theMotivo)
        {
            return Update(theMotivo, SelectSingle(theMotivo.IDMotivo));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.Motivo theMotivo)
        {
            return ExecuteAction(theMotivo, new Motivo(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.Motivo theMotivo)
        {
            return ExecuteAction(theMotivo, theMotivo, "Select", "Delete", DeleteView);
        }
    }
}
