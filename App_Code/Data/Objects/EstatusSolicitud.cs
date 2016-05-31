using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class EstatusSolicitud
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _iDEstatussolicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;
        
        public EstatusSolicitud()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public byte? IDEstatussolicitud
        {
            get
            {
                return _iDEstatussolicitud;
            }
            set
            {
                _iDEstatussolicitud = value;
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
        
        public static List<IXport.Data.Objects.EstatusSolicitud> Select(byte? iDEstatussolicitud, string descripcion)
        {
            return new EstatusSolicitudFactory().Select(iDEstatussolicitud, descripcion);
        }
        
        public static List<IXport.Data.Objects.EstatusSolicitud> Select(IXport.Data.Objects.EstatusSolicitud qbe)
        {
            return new EstatusSolicitudFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.EstatusSolicitud> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new EstatusSolicitudFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.EstatusSolicitud> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new EstatusSolicitudFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.EstatusSolicitud> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new EstatusSolicitudFactory().Select(filter, sort, EstatusSolicitudFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.EstatusSolicitud> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new EstatusSolicitudFactory().Select(filter, sort, EstatusSolicitudFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.EstatusSolicitud> Select(string filter, BusinessObjectParameters parameters)
        {
            return new EstatusSolicitudFactory().Select(filter, null, EstatusSolicitudFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.EstatusSolicitud> Select(string filter, params FieldValue[] parameters)
        {
            return new EstatusSolicitudFactory().Select(filter, null, EstatusSolicitudFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.EstatusSolicitud SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new EstatusSolicitudFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.EstatusSolicitud SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new EstatusSolicitudFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.EstatusSolicitud SelectSingle(byte? iDEstatussolicitud)
        {
            return new EstatusSolicitudFactory().SelectSingle(iDEstatussolicitud);
        }
        
        public int Insert()
        {
            return new EstatusSolicitudFactory().Insert(this);
        }
        
        public int Update()
        {
            return new EstatusSolicitudFactory().Update(this);
        }
        
        public int Delete()
        {
            return new EstatusSolicitudFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDEstatussolicitud: {0}", this.IDEstatussolicitud);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class EstatusSolicitudFactory
    {
        
        public EstatusSolicitudFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("EstatusSolicitud");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("EstatusSolicitud");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("EstatusSolicitud");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("EstatusSolicitud");
            }
        }
        
        public static EstatusSolicitudFactory Create()
        {
            return new EstatusSolicitudFactory();
        }
        
        protected virtual PageRequest CreateRequest(byte? iDEstatussolicitud, string descripcion, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDEstatussolicitud.HasValue)
            	filter.Add(("IDEstatussolicitud:=" + iDEstatussolicitud.Value.ToString()));
            if (!(String.IsNullOrEmpty(descripcion)))
            	filter.Add(("Descripcion:*" + descripcion));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.EstatusSolicitud> Select(byte? iDEstatussolicitud, string descripcion, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDEstatussolicitud, descripcion, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("EstatusSolicitud", dataView, request);
            return page.ToList<IXport.Data.Objects.EstatusSolicitud>();
        }
        
        public List<IXport.Data.Objects.EstatusSolicitud> Select(IXport.Data.Objects.EstatusSolicitud qbe)
        {
            return Select(qbe.IDEstatussolicitud, qbe.Descripcion);
        }
        
        public int SelectCount(byte? iDEstatussolicitud, string descripcion, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDEstatussolicitud, descripcion, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("EstatusSolicitud", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.EstatusSolicitud> Select(byte? iDEstatussolicitud, string descripcion)
        {
            return Select(iDEstatussolicitud, descripcion, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.EstatusSolicitud SelectSingle(byte? iDEstatussolicitud)
        {
            string emptyDescripcion = null;
            List<IXport.Data.Objects.EstatusSolicitud> list = Select(iDEstatussolicitud, emptyDescripcion);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.EstatusSolicitud> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("EstatusSolicitud", dataView, request);
            return page.ToList<IXport.Data.Objects.EstatusSolicitud>();
        }
        
        public List<IXport.Data.Objects.EstatusSolicitud> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.EstatusSolicitud> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.EstatusSolicitud SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.EstatusSolicitud> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.EstatusSolicitud theEstatusSolicitud, IXport.Data.Objects.EstatusSolicitud original_EstatusSolicitud)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDEstatussolicitud", original_EstatusSolicitud.IDEstatussolicitud, theEstatusSolicitud.IDEstatussolicitud, true));
            values.Add(new FieldValue("Descripcion", original_EstatusSolicitud.Descripcion, theEstatusSolicitud.Descripcion));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.EstatusSolicitud theEstatusSolicitud, IXport.Data.Objects.EstatusSolicitud original_EstatusSolicitud, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "EstatusSolicitud";
            args.View = dataView;
            args.Values = CreateFieldValues(theEstatusSolicitud, original_EstatusSolicitud);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("EstatusSolicitud", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theEstatusSolicitud);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.EstatusSolicitud theEstatusSolicitud, IXport.Data.Objects.EstatusSolicitud original_EstatusSolicitud)
        {
            return ExecuteAction(theEstatusSolicitud, original_EstatusSolicitud, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.EstatusSolicitud theEstatusSolicitud)
        {
            return Update(theEstatusSolicitud, SelectSingle(theEstatusSolicitud.IDEstatussolicitud));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.EstatusSolicitud theEstatusSolicitud)
        {
            return ExecuteAction(theEstatusSolicitud, new EstatusSolicitud(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.EstatusSolicitud theEstatusSolicitud)
        {
            return ExecuteAction(theEstatusSolicitud, theEstatusSolicitud, "Select", "Delete", DeleteView);
        }
    }
}
