using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class EmpleadoRol
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDEmpleado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _theidEmpleadonombrecompleto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDRol;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _theidRoldescripcion;
        
        public EmpleadoRol()
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
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? IDRol
        {
            get
            {
                return _iDRol;
            }
            set
            {
                _iDRol = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TheidRoldescripcion
        {
            get
            {
                return _theidRoldescripcion;
            }
            set
            {
                _theidRoldescripcion = value;
            }
        }
        
        public static List<IXport.Data.Objects.EmpleadoRol> Select(int? iDEmpleado, string theidEmpleadonombrecompleto, int? iDRol, string theidRoldescripcion)
        {
            return new EmpleadoRolFactory().Select(iDEmpleado, theidEmpleadonombrecompleto, iDRol, theidRoldescripcion);
        }
        
        public static List<IXport.Data.Objects.EmpleadoRol> Select(IXport.Data.Objects.EmpleadoRol qbe)
        {
            return new EmpleadoRolFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.EmpleadoRol> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new EmpleadoRolFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.EmpleadoRol> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new EmpleadoRolFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.EmpleadoRol> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new EmpleadoRolFactory().Select(filter, sort, EmpleadoRolFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.EmpleadoRol> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new EmpleadoRolFactory().Select(filter, sort, EmpleadoRolFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.EmpleadoRol> Select(string filter, BusinessObjectParameters parameters)
        {
            return new EmpleadoRolFactory().Select(filter, null, EmpleadoRolFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.EmpleadoRol> Select(string filter, params FieldValue[] parameters)
        {
            return new EmpleadoRolFactory().Select(filter, null, EmpleadoRolFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.EmpleadoRol SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new EmpleadoRolFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.EmpleadoRol SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new EmpleadoRolFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.EmpleadoRol SelectSingle(int? iDEmpleado, int? iDRol)
        {
            return new EmpleadoRolFactory().SelectSingle(iDEmpleado, iDRol);
        }
        
        public int Insert()
        {
            return new EmpleadoRolFactory().Insert(this);
        }
        
        public int Update()
        {
            return new EmpleadoRolFactory().Update(this);
        }
        
        public int Delete()
        {
            return new EmpleadoRolFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDEmpleado: {0}; IDRol: {1}", this.IDEmpleado, this.IDRol);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class EmpleadoRolFactory
    {
        
        public EmpleadoRolFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("EmpleadoRol");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("EmpleadoRol");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("EmpleadoRol");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("EmpleadoRol");
            }
        }
        
        public static EmpleadoRolFactory Create()
        {
            return new EmpleadoRolFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? iDEmpleado, string theidEmpleadonombrecompleto, int? iDRol, string theidRoldescripcion, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDEmpleado.HasValue)
            	filter.Add(("IDEmpleado:=" + iDEmpleado.Value.ToString()));
            if (!(String.IsNullOrEmpty(theidEmpleadonombrecompleto)))
            	filter.Add(("TheidEmpleadonombrecompleto:*" + theidEmpleadonombrecompleto));
            if (iDRol.HasValue)
            	filter.Add(("IDRol:=" + iDRol.Value.ToString()));
            if (!(String.IsNullOrEmpty(theidRoldescripcion)))
            	filter.Add(("TheidRoldescripcion:*" + theidRoldescripcion));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.EmpleadoRol> Select(int? iDEmpleado, string theidEmpleadonombrecompleto, int? iDRol, string theidRoldescripcion, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDEmpleado, theidEmpleadonombrecompleto, iDRol, theidRoldescripcion, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("EmpleadoRol", dataView, request);
            return page.ToList<IXport.Data.Objects.EmpleadoRol>();
        }
        
        public List<IXport.Data.Objects.EmpleadoRol> Select(IXport.Data.Objects.EmpleadoRol qbe)
        {
            return Select(qbe.IDEmpleado, qbe.TheidEmpleadonombrecompleto, qbe.IDRol, qbe.TheidRoldescripcion);
        }
        
        public int SelectCount(int? iDEmpleado, string theidEmpleadonombrecompleto, int? iDRol, string theidRoldescripcion, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDEmpleado, theidEmpleadonombrecompleto, iDRol, theidRoldescripcion, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("EmpleadoRol", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.EmpleadoRol> Select(int? iDEmpleado, string theidEmpleadonombrecompleto, int? iDRol, string theidRoldescripcion)
        {
            return Select(iDEmpleado, theidEmpleadonombrecompleto, iDRol, theidRoldescripcion, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.EmpleadoRol SelectSingle(int? iDEmpleado, int? iDRol)
        {
            string emptyTheidEmpleadonombrecompleto = null;
            string emptyTheidRoldescripcion = null;
            List<IXport.Data.Objects.EmpleadoRol> list = Select(iDEmpleado, emptyTheidEmpleadonombrecompleto, iDRol, emptyTheidRoldescripcion);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.EmpleadoRol> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("EmpleadoRol", dataView, request);
            return page.ToList<IXport.Data.Objects.EmpleadoRol>();
        }
        
        public List<IXport.Data.Objects.EmpleadoRol> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.EmpleadoRol> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.EmpleadoRol SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.EmpleadoRol> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.EmpleadoRol theEmpleadoRol, IXport.Data.Objects.EmpleadoRol original_EmpleadoRol)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDEmpleado", original_EmpleadoRol.IDEmpleado, theEmpleadoRol.IDEmpleado));
            values.Add(new FieldValue("TheidEmpleadonombrecompleto", original_EmpleadoRol.TheidEmpleadonombrecompleto, theEmpleadoRol.TheidEmpleadonombrecompleto, true));
            values.Add(new FieldValue("IDRol", original_EmpleadoRol.IDRol, theEmpleadoRol.IDRol));
            values.Add(new FieldValue("TheidRoldescripcion", original_EmpleadoRol.TheidRoldescripcion, theEmpleadoRol.TheidRoldescripcion, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.EmpleadoRol theEmpleadoRol, IXport.Data.Objects.EmpleadoRol original_EmpleadoRol, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "EmpleadoRol";
            args.View = dataView;
            args.Values = CreateFieldValues(theEmpleadoRol, original_EmpleadoRol);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("EmpleadoRol", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theEmpleadoRol);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.EmpleadoRol theEmpleadoRol, IXport.Data.Objects.EmpleadoRol original_EmpleadoRol)
        {
            return ExecuteAction(theEmpleadoRol, original_EmpleadoRol, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.EmpleadoRol theEmpleadoRol)
        {
            return Update(theEmpleadoRol, SelectSingle(theEmpleadoRol.IDEmpleado, theEmpleadoRol.IDRol));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.EmpleadoRol theEmpleadoRol)
        {
            return ExecuteAction(theEmpleadoRol, new EmpleadoRol(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.EmpleadoRol theEmpleadoRol)
        {
            return ExecuteAction(theEmpleadoRol, theEmpleadoRol, "Select", "Delete", DeleteView);
        }
    }
}
