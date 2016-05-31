using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Comida
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _platillo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _tipo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte[] _image;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _imageFileName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _imageContentType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _imageLength;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _idcomida;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo1;
        
        public Comida()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Platillo
        {
            get
            {
                return _platillo;
            }
            set
            {
                _platillo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        public byte? Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte[] Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImageFileName
        {
            get
            {
                return _imageFileName;
            }
            set
            {
                _imageFileName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImageContentType
        {
            get
            {
                return _imageContentType;
            }
            set
            {
                _imageContentType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ImageLength
        {
            get
            {
                return _imageLength;
            }
            set
            {
                _imageLength = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? Idcomida
        {
            get
            {
                return _idcomida;
            }
            set
            {
                _idcomida = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Tipo1
        {
            get
            {
                return _tipo1;
            }
            set
            {
                _tipo1 = value;
            }
        }
        
        public static List<IXport.Data.Objects.Comida> Select(string platillo, byte? tipo, string imageFileName, string imageContentType, int? imageLength, int? idcomida, string tipo1)
        {
            return new ComidaFactory().Select(platillo, tipo, imageFileName, imageContentType, imageLength, idcomida, tipo1);
        }
        
        public static List<IXport.Data.Objects.Comida> Select(IXport.Data.Objects.Comida qbe)
        {
            return new ComidaFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.Comida> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ComidaFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.Comida> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ComidaFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Comida> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ComidaFactory().Select(filter, sort, ComidaFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Comida> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ComidaFactory().Select(filter, sort, ComidaFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Comida> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ComidaFactory().Select(filter, null, ComidaFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Comida> Select(string filter, params FieldValue[] parameters)
        {
            return new ComidaFactory().Select(filter, null, ComidaFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Comida SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ComidaFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.Comida SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ComidaFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Comida SelectSingle(int? idcomida)
        {
            return new ComidaFactory().SelectSingle(idcomida);
        }
        
        public int Insert()
        {
            return new ComidaFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ComidaFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ComidaFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Idcomida: {0}", this.Idcomida);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ComidaFactory
    {
        
        public ComidaFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Comida");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Comida");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Comida");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Comida");
            }
        }
        
        public static ComidaFactory Create()
        {
            return new ComidaFactory();
        }
        
        protected virtual PageRequest CreateRequest(string platillo, byte? tipo, string imageFileName, string imageContentType, int? imageLength, int? idcomida, string tipo1, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (!(String.IsNullOrEmpty(platillo)))
            	filter.Add(("Platillo:*" + platillo));
            if (tipo.HasValue)
            	filter.Add(("Tipo:=" + tipo.Value.ToString()));
            if (!(String.IsNullOrEmpty(imageFileName)))
            	filter.Add(("ImageFileName:*" + imageFileName));
            if (!(String.IsNullOrEmpty(imageContentType)))
            	filter.Add(("ImageContentType:*" + imageContentType));
            if (imageLength.HasValue)
            	filter.Add(("ImageLength:=" + imageLength.Value.ToString()));
            if (idcomida.HasValue)
            	filter.Add(("Idcomida:=" + idcomida.Value.ToString()));
            if (!(String.IsNullOrEmpty(tipo1)))
            	filter.Add(("Tipo1:*" + tipo1));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.Comida> Select(string platillo, byte? tipo, string imageFileName, string imageContentType, int? imageLength, int? idcomida, string tipo1, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(platillo, tipo, imageFileName, imageContentType, imageLength, idcomida, tipo1, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Comida", dataView, request);
            return page.ToList<IXport.Data.Objects.Comida>();
        }
        
        public List<IXport.Data.Objects.Comida> Select(IXport.Data.Objects.Comida qbe)
        {
            return Select(qbe.Platillo, qbe.Tipo, qbe.ImageFileName, qbe.ImageContentType, qbe.ImageLength, qbe.Idcomida, qbe.Tipo1);
        }
        
        public int SelectCount(string platillo, byte? tipo, string imageFileName, string imageContentType, int? imageLength, int? idcomida, string tipo1, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(platillo, tipo, imageFileName, imageContentType, imageLength, idcomida, tipo1, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Comida", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.Comida> Select(string platillo, byte? tipo, string imageFileName, string imageContentType, int? imageLength, int? idcomida, string tipo1)
        {
            return Select(platillo, tipo, imageFileName, imageContentType, imageLength, idcomida, tipo1, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.Comida SelectSingle(int? idcomida)
        {
            List<IXport.Data.Objects.Comida> list = Select(null, null, null, null, null, idcomida, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.Comida> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Comida", dataView, request);
            return page.ToList<IXport.Data.Objects.Comida>();
        }
        
        public List<IXport.Data.Objects.Comida> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.Comida> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.Comida SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.Comida> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.Comida theComida, IXport.Data.Objects.Comida original_Comida)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Platillo", original_Comida.Platillo, theComida.Platillo));
            values.Add(new FieldValue("Descripcion", original_Comida.Descripcion, theComida.Descripcion));
            values.Add(new FieldValue("Tipo", original_Comida.Tipo, theComida.Tipo));
            values.Add(new FieldValue("Image", original_Comida.Image, theComida.Image));
            values.Add(new FieldValue("ImageFileName", original_Comida.ImageFileName, theComida.ImageFileName));
            values.Add(new FieldValue("ImageContentType", original_Comida.ImageContentType, theComida.ImageContentType));
            values.Add(new FieldValue("ImageLength", original_Comida.ImageLength, theComida.ImageLength));
            values.Add(new FieldValue("Idcomida", original_Comida.Idcomida, theComida.Idcomida, true));
            values.Add(new FieldValue("Tipo1", original_Comida.Tipo1, theComida.Tipo1, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.Comida theComida, IXport.Data.Objects.Comida original_Comida, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Comida";
            args.View = dataView;
            args.Values = CreateFieldValues(theComida, original_Comida);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Comida", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theComida);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.Comida theComida, IXport.Data.Objects.Comida original_Comida)
        {
            return ExecuteAction(theComida, original_Comida, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.Comida theComida)
        {
            return Update(theComida, SelectSingle(theComida.Idcomida));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.Comida theComida)
        {
            return ExecuteAction(theComida, new Comida(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.Comida theComida)
        {
            return ExecuteAction(theComida, theComida, "Select", "Delete", DeleteView);
        }
    }
}
