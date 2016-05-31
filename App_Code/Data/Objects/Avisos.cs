using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Avisos
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tituloAvisos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _informacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaCreacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _idavisos;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte[] _image;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _imageFileName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _imageContentType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _imageLength;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _duracion;
        
        public Avisos()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string TituloAvisos
        {
            get
            {
                return _tituloAvisos;
            }
            set
            {
                _tituloAvisos = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Informacion
        {
            get
            {
                return _informacion;
            }
            set
            {
                _informacion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? FechaCreacion
        {
            get
            {
                return _fechaCreacion;
            }
            set
            {
                _fechaCreacion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? Idavisos
        {
            get
            {
                return _idavisos;
            }
            set
            {
                _idavisos = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public byte? Duracion
        {
            get
            {
                return _duracion;
            }
            set
            {
                _duracion = value;
            }
        }
        
        public static List<IXport.Data.Objects.Avisos> Select(string tituloAvisos, DateTime? fechaCreacion, string creadoPor, int? idavisos, string imageFileName, string imageContentType, int? imageLength, byte? duracion)
        {
            return new AvisosFactory().Select(tituloAvisos, fechaCreacion, creadoPor, idavisos, imageFileName, imageContentType, imageLength, duracion);
        }
        
        public static List<IXport.Data.Objects.Avisos> Select(IXport.Data.Objects.Avisos qbe)
        {
            return new AvisosFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.Avisos> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AvisosFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.Avisos> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AvisosFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Avisos> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AvisosFactory().Select(filter, sort, AvisosFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Avisos> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AvisosFactory().Select(filter, sort, AvisosFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Avisos> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AvisosFactory().Select(filter, null, AvisosFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Avisos> Select(string filter, params FieldValue[] parameters)
        {
            return new AvisosFactory().Select(filter, null, AvisosFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Avisos SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AvisosFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.Avisos SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AvisosFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Avisos SelectSingle(int? idavisos)
        {
            return new AvisosFactory().SelectSingle(idavisos);
        }
        
        public int Insert()
        {
            return new AvisosFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AvisosFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AvisosFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Idavisos: {0}", this.Idavisos);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AvisosFactory
    {
        
        public AvisosFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Avisos");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Avisos");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Avisos");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Avisos");
            }
        }
        
        public static AvisosFactory Create()
        {
            return new AvisosFactory();
        }
        
        protected virtual PageRequest CreateRequest(string tituloAvisos, DateTime? fechaCreacion, string creadoPor, int? idavisos, string imageFileName, string imageContentType, int? imageLength, byte? duracion, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (!(String.IsNullOrEmpty(tituloAvisos)))
            	filter.Add(("TituloAvisos:*" + tituloAvisos));
            if (fechaCreacion.HasValue)
            	filter.Add(("FechaCreacion:=" + fechaCreacion.Value.ToString()));
            if (!(String.IsNullOrEmpty(creadoPor)))
            	filter.Add(("CreadoPor:*" + creadoPor));
            if (idavisos.HasValue)
            	filter.Add(("Idavisos:=" + idavisos.Value.ToString()));
            if (!(String.IsNullOrEmpty(imageFileName)))
            	filter.Add(("ImageFileName:*" + imageFileName));
            if (!(String.IsNullOrEmpty(imageContentType)))
            	filter.Add(("ImageContentType:*" + imageContentType));
            if (imageLength.HasValue)
            	filter.Add(("ImageLength:=" + imageLength.Value.ToString()));
            if (duracion.HasValue)
            	filter.Add(("Duracion:=" + duracion.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.Avisos> Select(string tituloAvisos, DateTime? fechaCreacion, string creadoPor, int? idavisos, string imageFileName, string imageContentType, int? imageLength, byte? duracion, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(tituloAvisos, fechaCreacion, creadoPor, idavisos, imageFileName, imageContentType, imageLength, duracion, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Avisos", dataView, request);
            return page.ToList<IXport.Data.Objects.Avisos>();
        }
        
        public List<IXport.Data.Objects.Avisos> Select(IXport.Data.Objects.Avisos qbe)
        {
            return Select(qbe.TituloAvisos, qbe.FechaCreacion, qbe.CreadoPor, qbe.Idavisos, qbe.ImageFileName, qbe.ImageContentType, qbe.ImageLength, qbe.Duracion);
        }
        
        public int SelectCount(string tituloAvisos, DateTime? fechaCreacion, string creadoPor, int? idavisos, string imageFileName, string imageContentType, int? imageLength, byte? duracion, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(tituloAvisos, fechaCreacion, creadoPor, idavisos, imageFileName, imageContentType, imageLength, duracion, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Avisos", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.Avisos> Select(string tituloAvisos, DateTime? fechaCreacion, string creadoPor, int? idavisos, string imageFileName, string imageContentType, int? imageLength, byte? duracion)
        {
            return Select(tituloAvisos, fechaCreacion, creadoPor, idavisos, imageFileName, imageContentType, imageLength, duracion, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.Avisos SelectSingle(int? idavisos)
        {
            List<IXport.Data.Objects.Avisos> list = Select(null, null, null, idavisos, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.Avisos> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Avisos", dataView, request);
            return page.ToList<IXport.Data.Objects.Avisos>();
        }
        
        public List<IXport.Data.Objects.Avisos> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.Avisos> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.Avisos SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.Avisos> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.Avisos theAvisos, IXport.Data.Objects.Avisos original_Avisos)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TituloAvisos", original_Avisos.TituloAvisos, theAvisos.TituloAvisos));
            values.Add(new FieldValue("Informacion", original_Avisos.Informacion, theAvisos.Informacion));
            values.Add(new FieldValue("FechaCreacion", original_Avisos.FechaCreacion, theAvisos.FechaCreacion));
            values.Add(new FieldValue("CreadoPor", original_Avisos.CreadoPor, theAvisos.CreadoPor));
            values.Add(new FieldValue("Idavisos", original_Avisos.Idavisos, theAvisos.Idavisos, true));
            values.Add(new FieldValue("Image", original_Avisos.Image, theAvisos.Image));
            values.Add(new FieldValue("ImageFileName", original_Avisos.ImageFileName, theAvisos.ImageFileName));
            values.Add(new FieldValue("ImageContentType", original_Avisos.ImageContentType, theAvisos.ImageContentType));
            values.Add(new FieldValue("ImageLength", original_Avisos.ImageLength, theAvisos.ImageLength));
            values.Add(new FieldValue("Duracion", original_Avisos.Duracion, theAvisos.Duracion));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.Avisos theAvisos, IXport.Data.Objects.Avisos original_Avisos, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Avisos";
            args.View = dataView;
            args.Values = CreateFieldValues(theAvisos, original_Avisos);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Avisos", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAvisos);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.Avisos theAvisos, IXport.Data.Objects.Avisos original_Avisos)
        {
            return ExecuteAction(theAvisos, original_Avisos, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.Avisos theAvisos)
        {
            return Update(theAvisos, SelectSingle(theAvisos.Idavisos));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.Avisos theAvisos)
        {
            return ExecuteAction(theAvisos, new Avisos(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.Avisos theAvisos)
        {
            return ExecuteAction(theAvisos, theAvisos, "Select", "Delete", DeleteView);
        }
    }
}
