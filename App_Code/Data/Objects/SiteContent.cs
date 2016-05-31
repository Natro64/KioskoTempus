using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class SiteContent
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _siteContentID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fileName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _path;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contentType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _length;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte[] _data;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _text;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roles;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roleExceptions;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _users;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _userExceptions;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _schedule;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _scheduleExceptions;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cacheProfile;
        
        public SiteContent()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? SiteContentID
        {
            get
            {
                return _siteContentID;
            }
            set
            {
                _siteContentID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ContentType
        {
            get
            {
                return _contentType;
            }
            set
            {
                _contentType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte[] Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Roles
        {
            get
            {
                return _roles;
            }
            set
            {
                _roles = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RoleExceptions
        {
            get
            {
                return _roleExceptions;
            }
            set
            {
                _roleExceptions = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string UserExceptions
        {
            get
            {
                return _userExceptions;
            }
            set
            {
                _userExceptions = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Schedule
        {
            get
            {
                return _schedule;
            }
            set
            {
                _schedule = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ScheduleExceptions
        {
            get
            {
                return _scheduleExceptions;
            }
            set
            {
                _scheduleExceptions = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CacheProfile
        {
            get
            {
                return _cacheProfile;
            }
            set
            {
                _cacheProfile = value;
            }
        }
        
        public static List<IXport.Data.Objects.SiteContent> Select(System.Guid? siteContentID, string fileName, string path, string contentType, int? length, string roles, string roleExceptions, string users, string userExceptions, string schedule, string scheduleExceptions, string cacheProfile)
        {
            return new SiteContentFactory().Select(siteContentID, fileName, path, contentType, length, roles, roleExceptions, users, userExceptions, schedule, scheduleExceptions, cacheProfile);
        }
        
        public static List<IXport.Data.Objects.SiteContent> Select(IXport.Data.Objects.SiteContent qbe)
        {
            return new SiteContentFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.SiteContent> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new SiteContentFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.SiteContent> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new SiteContentFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.SiteContent> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new SiteContentFactory().Select(filter, sort, SiteContentFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.SiteContent> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new SiteContentFactory().Select(filter, sort, SiteContentFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.SiteContent> Select(string filter, BusinessObjectParameters parameters)
        {
            return new SiteContentFactory().Select(filter, null, SiteContentFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.SiteContent> Select(string filter, params FieldValue[] parameters)
        {
            return new SiteContentFactory().Select(filter, null, SiteContentFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.SiteContent SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new SiteContentFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.SiteContent SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new SiteContentFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.SiteContent SelectSingle(System.Guid? siteContentID)
        {
            return new SiteContentFactory().SelectSingle(siteContentID);
        }
        
        public int Insert()
        {
            return new SiteContentFactory().Insert(this);
        }
        
        public int Update()
        {
            return new SiteContentFactory().Update(this);
        }
        
        public int Delete()
        {
            return new SiteContentFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("SiteContentID: {0}", this.SiteContentID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class SiteContentFactory
    {
        
        public SiteContentFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("SiteContent");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("SiteContent");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("SiteContent");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("SiteContent");
            }
        }
        
        public static SiteContentFactory Create()
        {
            return new SiteContentFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? siteContentID, string fileName, string path, string contentType, int? length, string roles, string roleExceptions, string users, string userExceptions, string schedule, string scheduleExceptions, string cacheProfile, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (siteContentID.HasValue)
            	filter.Add(("SiteContentID:=" + siteContentID.Value.ToString()));
            if (!(String.IsNullOrEmpty(fileName)))
            	filter.Add(("FileName:*" + fileName));
            if (!(String.IsNullOrEmpty(path)))
            	filter.Add(("Path:*" + path));
            if (!(String.IsNullOrEmpty(contentType)))
            	filter.Add(("ContentType:*" + contentType));
            if (length.HasValue)
            	filter.Add(("Length:=" + length.Value.ToString()));
            if (!(String.IsNullOrEmpty(roles)))
            	filter.Add(("Roles:*" + roles));
            if (!(String.IsNullOrEmpty(roleExceptions)))
            	filter.Add(("RoleExceptions:*" + roleExceptions));
            if (!(String.IsNullOrEmpty(users)))
            	filter.Add(("Users:*" + users));
            if (!(String.IsNullOrEmpty(userExceptions)))
            	filter.Add(("UserExceptions:*" + userExceptions));
            if (!(String.IsNullOrEmpty(schedule)))
            	filter.Add(("Schedule:*" + schedule));
            if (!(String.IsNullOrEmpty(scheduleExceptions)))
            	filter.Add(("ScheduleExceptions:*" + scheduleExceptions));
            if (!(String.IsNullOrEmpty(cacheProfile)))
            	filter.Add(("CacheProfile:*" + cacheProfile));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.SiteContent> Select(
                    System.Guid? siteContentID, 
                    string fileName, 
                    string path, 
                    string contentType, 
                    int? length, 
                    string roles, 
                    string roleExceptions, 
                    string users, 
                    string userExceptions, 
                    string schedule, 
                    string scheduleExceptions, 
                    string cacheProfile, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(siteContentID, fileName, path, contentType, length, roles, roleExceptions, users, userExceptions, schedule, scheduleExceptions, cacheProfile, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("SiteContent", dataView, request);
            return page.ToList<IXport.Data.Objects.SiteContent>();
        }
        
        public List<IXport.Data.Objects.SiteContent> Select(IXport.Data.Objects.SiteContent qbe)
        {
            return Select(qbe.SiteContentID, qbe.FileName, qbe.Path, qbe.ContentType, qbe.Length, qbe.Roles, qbe.RoleExceptions, qbe.Users, qbe.UserExceptions, qbe.Schedule, qbe.ScheduleExceptions, qbe.CacheProfile);
        }
        
        public int SelectCount(
                    System.Guid? siteContentID, 
                    string fileName, 
                    string path, 
                    string contentType, 
                    int? length, 
                    string roles, 
                    string roleExceptions, 
                    string users, 
                    string userExceptions, 
                    string schedule, 
                    string scheduleExceptions, 
                    string cacheProfile, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(siteContentID, fileName, path, contentType, length, roles, roleExceptions, users, userExceptions, schedule, scheduleExceptions, cacheProfile, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("SiteContent", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.SiteContent> Select(System.Guid? siteContentID, string fileName, string path, string contentType, int? length, string roles, string roleExceptions, string users, string userExceptions, string schedule, string scheduleExceptions, string cacheProfile)
        {
            return Select(siteContentID, fileName, path, contentType, length, roles, roleExceptions, users, userExceptions, schedule, scheduleExceptions, cacheProfile, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.SiteContent SelectSingle(System.Guid? siteContentID)
        {
            List<IXport.Data.Objects.SiteContent> list = Select(siteContentID, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.SiteContent> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("SiteContent", dataView, request);
            return page.ToList<IXport.Data.Objects.SiteContent>();
        }
        
        public List<IXport.Data.Objects.SiteContent> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.SiteContent> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.SiteContent SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.SiteContent> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.SiteContent theSiteContent, IXport.Data.Objects.SiteContent original_SiteContent)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("SiteContentID", original_SiteContent.SiteContentID, theSiteContent.SiteContentID));
            values.Add(new FieldValue("FileName", original_SiteContent.FileName, theSiteContent.FileName));
            values.Add(new FieldValue("Path", original_SiteContent.Path, theSiteContent.Path));
            values.Add(new FieldValue("ContentType", original_SiteContent.ContentType, theSiteContent.ContentType));
            values.Add(new FieldValue("Length", original_SiteContent.Length, theSiteContent.Length));
            values.Add(new FieldValue("Data", original_SiteContent.Data, theSiteContent.Data));
            values.Add(new FieldValue("Text", original_SiteContent.Text, theSiteContent.Text));
            values.Add(new FieldValue("Roles", original_SiteContent.Roles, theSiteContent.Roles));
            values.Add(new FieldValue("RoleExceptions", original_SiteContent.RoleExceptions, theSiteContent.RoleExceptions));
            values.Add(new FieldValue("Users", original_SiteContent.Users, theSiteContent.Users));
            values.Add(new FieldValue("UserExceptions", original_SiteContent.UserExceptions, theSiteContent.UserExceptions));
            values.Add(new FieldValue("Schedule", original_SiteContent.Schedule, theSiteContent.Schedule));
            values.Add(new FieldValue("ScheduleExceptions", original_SiteContent.ScheduleExceptions, theSiteContent.ScheduleExceptions));
            values.Add(new FieldValue("CacheProfile", original_SiteContent.CacheProfile, theSiteContent.CacheProfile));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.SiteContent theSiteContent, IXport.Data.Objects.SiteContent original_SiteContent, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "SiteContent";
            args.View = dataView;
            args.Values = CreateFieldValues(theSiteContent, original_SiteContent);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("SiteContent", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theSiteContent);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.SiteContent theSiteContent, IXport.Data.Objects.SiteContent original_SiteContent)
        {
            return ExecuteAction(theSiteContent, original_SiteContent, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.SiteContent theSiteContent)
        {
            return Update(theSiteContent, SelectSingle(theSiteContent.SiteContentID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.SiteContent theSiteContent)
        {
            return ExecuteAction(theSiteContent, new SiteContent(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.SiteContent theSiteContent)
        {
            return ExecuteAction(theSiteContent, theSiteContent, "Select", "Delete", DeleteView);
        }
    }
}
