using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Rol
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDRol;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;
        
        public Rol()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        
        public static List<IXport.Data.Objects.Rol> Select(int? iDRol, string descripcion)
        {
            return new RolFactory().Select(iDRol, descripcion);
        }
        
        public static List<IXport.Data.Objects.Rol> Select(IXport.Data.Objects.Rol qbe)
        {
            return new RolFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.Rol> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new RolFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.Rol> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new RolFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Rol> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new RolFactory().Select(filter, sort, RolFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Rol> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new RolFactory().Select(filter, sort, RolFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Rol> Select(string filter, BusinessObjectParameters parameters)
        {
            return new RolFactory().Select(filter, null, RolFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Rol> Select(string filter, params FieldValue[] parameters)
        {
            return new RolFactory().Select(filter, null, RolFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Rol SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new RolFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.Rol SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new RolFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Rol SelectSingle(int? iDRol)
        {
            return new RolFactory().SelectSingle(iDRol);
        }
        
        public int Insert()
        {
            return new RolFactory().Insert(this);
        }
        
        public int Update()
        {
            return new RolFactory().Update(this);
        }
        
        public int Delete()
        {
            return new RolFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDRol: {0}", this.IDRol);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class RolFactory
    {
        
        public RolFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Rol");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Rol");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Rol");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Rol");
            }
        }
        
        public static RolFactory Create()
        {
            return new RolFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? iDRol, string descripcion, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDRol.HasValue)
            	filter.Add(("IDRol:=" + iDRol.Value.ToString()));
            if (!(String.IsNullOrEmpty(descripcion)))
            	filter.Add(("Descripcion:*" + descripcion));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.Rol> Select(int? iDRol, string descripcion, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDRol, descripcion, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Rol", dataView, request);
            return page.ToList<IXport.Data.Objects.Rol>();
        }
        
        public List<IXport.Data.Objects.Rol> Select(IXport.Data.Objects.Rol qbe)
        {
            return Select(qbe.IDRol, qbe.Descripcion);
        }
        
        public int SelectCount(int? iDRol, string descripcion, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iDRol, descripcion, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Rol", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.Rol> Select(int? iDRol, string descripcion)
        {
            return Select(iDRol, descripcion, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.Rol SelectSingle(int? iDRol)
        {
            string emptyDescripcion = null;
            List<IXport.Data.Objects.Rol> list = Select(iDRol, emptyDescripcion);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.Rol> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Rol", dataView, request);
            return page.ToList<IXport.Data.Objects.Rol>();
        }
        
        public List<IXport.Data.Objects.Rol> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.Rol> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.Rol SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.Rol> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.Rol theRol, IXport.Data.Objects.Rol original_Rol)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDRol", original_Rol.IDRol, theRol.IDRol, true));
            values.Add(new FieldValue("Descripcion", original_Rol.Descripcion, theRol.Descripcion));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.Rol theRol, IXport.Data.Objects.Rol original_Rol, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Rol";
            args.View = dataView;
            args.Values = CreateFieldValues(theRol, original_Rol);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Rol", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theRol);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.Rol theRol, IXport.Data.Objects.Rol original_Rol)
        {
            return ExecuteAction(theRol, original_Rol, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.Rol theRol)
        {
            return Update(theRol, SelectSingle(theRol.IDRol));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.Rol theRol)
        {
            return ExecuteAction(theRol, new Rol(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.Rol theRol)
        {
            return ExecuteAction(theRol, theRol, "Select", "Delete", DeleteView);
        }
    }
}
