using System;
using System.Configuration;
using System.Configuration.Provider;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using System.Web;
using System.Web.Security;
using IXport.Data;

namespace IXport.Security
{
	public partial class ApplicationRoleProvider : ApplicationRoleProviderBase
    {
    }
    
    public enum RoleProviderSqlStatement
    {
        
        AddUserToRole,
        
        CreateRole,
        
        DeleteRole,
        
        DeleteRoleUsers,
        
        GetAllRoles,
        
        GetRolesForUser,
        
        GetUsersInRole,
        
        IsUserInRole,
        
        RemoveUserFromRole,
        
        RoleExists,
        
        FindUsersInRole,
    }
    
    public class ApplicationRoleProviderBase : RoleProvider
    {
        
        protected static SortedDictionary<RoleProviderSqlStatement, string> Statements = new SortedDictionary<RoleProviderSqlStatement, string>();
        
        private ConnectionStringSettings _connectionStringSettings;
        
        private bool _writeExceptionsToEventLog;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _applicationName;
        
        static ApplicationRoleProviderBase()
        {
            Statements[RoleProviderSqlStatement.AddUserToRole] = "\r\ninsert into EmpleadoRol(ID_Empleado, ID_Rol) \r\nvalues (\r\n     (select ID_Emplea" +
                "do from Empleado where RFC=@UserName) \r\n    ,(select ID_Rol from Rol where Descr" +
                "ipcion=@RoleName)\r\n    \r\n)";
            Statements[RoleProviderSqlStatement.CreateRole] = "insert into Rol (Descripcion) values (@RoleName)";
            Statements[RoleProviderSqlStatement.DeleteRole] = "delete from Rol where Descripcion = @RoleName";
            Statements[RoleProviderSqlStatement.DeleteRoleUsers] = "delete from EmpleadoRol where ID_Rol in (select ID_Rol from Rol where Descripcion" +
                " = @RoleName)";
            Statements[RoleProviderSqlStatement.GetAllRoles] = "select Descripcion RoleName from Rol";
            Statements[RoleProviderSqlStatement.GetRolesForUser] = "\r\nselect Roles.Descripcion RoleName from Rol Roles \r\ninner join EmpleadoRol UserR" +
                "oles on Roles.ID_Rol = UserRoles.ID_Rol \r\ninner join Empleado Users on Users.ID_" +
                "Empleado = UserRoles.ID_Empleado\r\nwhere Users.RFC = @UserName";
            Statements[RoleProviderSqlStatement.GetUsersInRole] = "select RFC UserName from Empleado where ID_Empleado in (select ID_Empleado from E" +
                "mpleadoRol where ID_Rol in (select ID_Rol from Rol where Descripcion = @RoleName" +
                "))";
            Statements[RoleProviderSqlStatement.IsUserInRole] = "\r\nselect count(*) from EmpleadoRol\r\nwhere\r\n    ID_Empleado in (select ID_Empleado" +
                " from Empleado where RFC = @UserName) and \r\n    ID_Rol in (select ID_Rol from Ro" +
                "l where Descripcion = @RoleName)";
            Statements[RoleProviderSqlStatement.RemoveUserFromRole] = "\r\ndelete from EmpleadoRol\r\nwhere\r\n   ID_Empleado in (select ID_Empleado from Empl" +
                "eado where RFC = @UserName) and\r\n   ID_Rol in (select ID_Rol from Rol where Desc" +
                "ripcion = @RoleName)";
            Statements[RoleProviderSqlStatement.RoleExists] = "select count(*) from Rol where Descripcion = @RoleName";
            Statements[RoleProviderSqlStatement.FindUsersInRole] = "\r\nselect Users.RFC UserName from Empleado Users\r\ninner join EmpleadoRol UserRoles" +
                " on Users.ID_Empleado= UserRoles.ID_Empleado \r\ninner join Rol Roles on UserRoles" +
                ".ID_Rol = Roles.ID_Rol\r\nwhere \r\n\tUsers.RFC like @UserName and \r\n\tRoles.Descripci" +
                "on = @RoleName";
        }
        
        public virtual ConnectionStringSettings ConnectionStringSettings
        {
            get
            {
                return _connectionStringSettings;
            }
        }
        
        public bool WriteExceptionsToEventLog
        {
            get
            {
                return _writeExceptionsToEventLog;
            }
        }
        
        public override string ApplicationName
        {
            get
            {
                return this._applicationName;
            }
            set
            {
                this._applicationName = value;
            }
        }
        
        protected virtual SqlStatement CreateSqlStatement(RoleProviderSqlStatement command)
        {
            SqlText sql = new SqlText(Statements[command], ConnectionStringSettings.Name);
            sql.Command.CommandText = sql.Command.CommandText.Replace("@", sql.ParameterMarker);
            if (sql.Command.CommandText.Contains((sql.ParameterMarker + "ApplicationName")))
            	sql.AssignParameter("ApplicationName", ApplicationName);
            sql.Name = ("IXport Application Role Provider - " + command.ToString());
            sql.WriteExceptionsToEventLog = WriteExceptionsToEventLog;
            return sql;
        }
        
        public override void Initialize(string name, NameValueCollection config)
        {
            if (config == null)
            	throw new ArgumentNullException("config");
            if (String.IsNullOrEmpty(name))
            	name = "IXportApplicationRoleProvider";
            if (String.IsNullOrEmpty(config["description"]))
            {
                config.Remove("description");
                config.Add("description", "IXport application role provider");
            }
            base.Initialize(name, config);
            _applicationName = config["applicationName"];
            if (String.IsNullOrEmpty(_applicationName))
            	_applicationName = System.Web.Hosting.HostingEnvironment.ApplicationVirtualPath;
            _writeExceptionsToEventLog = "true".Equals(config["writeExceptionsToEventLog"], StringComparison.CurrentCulture);
            _connectionStringSettings = ConfigurationManager.ConnectionStrings[config["connectionStringName"]];
            if ((_connectionStringSettings == null) || String.IsNullOrEmpty(_connectionStringSettings.ConnectionString))
            	throw new ProviderException("Connection string cannot be blank.");
        }
        
        public override void AddUsersToRoles(string[] usernames, string[] rolenames)
        {
            foreach (string rolename in rolenames)
            	if (!(RoleExists(rolename)))
                	throw new ProviderException(String.Format("Role name \'{0}\' not found.", rolename));
            foreach (string username in usernames)
            {
                if (username.Contains(","))
                	throw new ArgumentException("User names cannot contain commas.");
                foreach (string rolename in rolenames)
                	if (IsUserInRole(username, rolename))
                    	throw new ProviderException(String.Format("User \'{0}\' is already in role \'{1}\'.", username, rolename));
            }
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.AddUserToRole))
            	foreach (string username in usernames)
                {
                    ForgetUserRoles(username);
                    foreach (string rolename in rolenames)
                    {
                        sql.AssignParameter("UserName", username);
                        sql.AssignParameter("RoleName", rolename);
                        sql.ExecuteNonQuery();
                    }
                }
        }
        
        public override void CreateRole(string rolename)
        {
            if (rolename.Contains(","))
            	throw new ArgumentException("Role names cannot contain commas.");
            if (RoleExists(rolename))
            	throw new ProviderException("Role already exists.");
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.CreateRole))
            {
                sql.AssignParameter("RoleName", rolename);
                sql.ExecuteNonQuery();
            }
        }
        
        public override bool DeleteRole(string rolename, bool throwOnPopulatedRole)
        {
            if (!(RoleExists(rolename)))
            	throw new ProviderException("Role does not exist.");
            if (throwOnPopulatedRole && (GetUsersInRole(rolename).Length > 0))
            	throw new ProviderException("Cannot delete a pouplated role.");
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.DeleteRole))
            {
                using (SqlStatement sql2 = CreateSqlStatement(RoleProviderSqlStatement.DeleteRoleUsers))
                {
                    sql2.AssignParameter("RoleName", rolename);
                    sql2.ExecuteNonQuery();
                }
                sql.AssignParameter("RoleName", rolename);
                sql.ExecuteNonQuery();
            }
            return true;
        }
        
        public override string[] GetAllRoles()
        {
            List<string> roles = new List<string>();
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.GetAllRoles))
            	while (sql.Read())
                	roles.Add(Convert.ToString(sql["RoleName"]));
            return roles.ToArray();
        }
        
        public override string[] GetRolesForUser(string username)
        {
            List<string> roles = null;
            string userRolesKey = String.Format("ApplicationRoleProvider_{0}_Roles", username);
            bool contextIsAvailable = (HttpContext.Current != null);
            if (contextIsAvailable)
            	roles = ((List<string>)(HttpContext.Current.Items[userRolesKey]));
            if (roles == null)
            {
                roles = new List<string>();
                using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.GetRolesForUser))
                {
                    sql.AssignParameter("UserName", username);
                    while (sql.Read())
                    	roles.Add(Convert.ToString(sql["RoleName"]));
                    if (contextIsAvailable)
                    	HttpContext.Current.Items[userRolesKey] = roles;
                }
            }
            return roles.ToArray();
        }
        
        public virtual void ForgetUserRoles(string username)
        {
            if (HttpContext.Current != null)
            	HttpContext.Current.Items.Remove(String.Format("ApplicationRoleProvider_{0}_Roles", username));
        }
        
        public override string[] GetUsersInRole(string rolename)
        {
            List<string> users = new List<string>();
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.GetUsersInRole))
            {
                sql.AssignParameter("RoleName", rolename);
                while (sql.Read())
                	users.Add(Convert.ToString(sql["UserName"]));
            }
            return users.ToArray();
        }
        
        public override bool IsUserInRole(string username, string rolename)
        {
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.IsUserInRole))
            {
                sql.AssignParameter("UserName", username);
                sql.AssignParameter("RoleName", rolename);
                return (Convert.ToInt32(sql.ExecuteScalar()) > 0);
            }
        }
        
        public override void RemoveUsersFromRoles(string[] usernames, string[] rolenames)
        {
            foreach (string rolename in rolenames)
            	if (!(RoleExists(rolename)))
                	throw new ProviderException(String.Format("Role \'{0}\' not found.", rolename));
            foreach (string username in usernames)
            	foreach (string rolename in rolenames)
                	if (!(IsUserInRole(username, rolename)))
                    	throw new ProviderException(String.Format("User \'{0}\' is not in role \'{1}\'.", username, rolename));
            foreach (string username in usernames)
            {
                ForgetUserRoles(username);
                foreach (string rolename in rolenames)
                	using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.RemoveUserFromRole))
                    {
                        sql.AssignParameter("UserName", username);
                        sql.AssignParameter("RoleName", rolename);
                        sql.ExecuteNonQuery();
                    }
            }
        }
        
        public override bool RoleExists(string rolename)
        {
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.RoleExists))
            {
                sql.AssignParameter("RoleName", rolename);
                return (Convert.ToInt32(sql.ExecuteScalar()) > 0);
            }
        }
        
        public override string[] FindUsersInRole(string rolename, string usernameToMatch)
        {
            List<string> users = new List<string>();
            using (SqlStatement sql = CreateSqlStatement(RoleProviderSqlStatement.FindUsersInRole))
            {
                sql.AssignParameter("UserName", usernameToMatch);
                sql.AssignParameter("RoleName", rolename);
                while (sql.Read())
                	users.Add(Convert.ToString(sql["UserName"]));
            }
            return users.ToArray();
        }
    }
}
