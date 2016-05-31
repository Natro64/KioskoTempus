using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;


namespace IXport.Handlers
{
    public class Rol : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            bool flag = false;

            string Email = context.Request.QueryString["EM"];

            context.Response.ContentType = "text/plain";

            using (SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["IXport"].ToString()))
            {
                /* abre la connexion */
                conexion.Open();
                /*Ejecuta el comando */
                using (SqlCommand orden = new SqlCommand(@"SELECT ID_Rol FROM dbo.EmpleadoRol 
                                        WHERE ID_Rol = (SELECT TOP 1(ID_Rol) FROM EmpleadoRol, Empleado 
                                        WHERE Empleado.ID_Empleado = EmpleadoRol.ID_Empleado AND RFC = @Email)
                                        AND ID_Empleado = (SELECT ID_Empleado FROM Empleado WHERE RFC = @Email)", conexion))
                {
                    //@Email 
                    orden.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar));
                    orden.Parameters["@Email"].Value = Email;
                    flag = true;
                    using (SqlDataReader lector = orden.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string Rol = lector[0].ToString();
                            context.Response.Output.Write(Rol);
                        }
                        lector.Close();
                    }
                }
                conexion.Close();
            }

            try
            {
                string strJson = new StreamReader(context.Request.InputStream).ReadToEnd();

                //deserialize the object
                aviso objUsr = Deserialize<aviso>(strJson);
                if (objUsr != null)
                {
                    string titl = objUsr.titulo;
                    string inf = objUsr.informacion;
                    //context.Response.Write(string.Format("Titulo: "+titl+" - Información: "+ti));
                }
                else
                {
                    context.Response.Write("No Data");
                }
            }
            catch (Exception ex)
            {
                context.Response.Write("Error :" + ex.Message);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        // we create a userinfo class to hold the JSON value
        public class aviso
        {
            public string titulo { get; set; }
            public string informacion { get; set; }
        }

        // Converts the specified JSON string to an object of type T
        public T Deserialize<T>(string context)
        {
            string jsonData = context;
            //cast to specified objectType
            var obj = (T)new JavaScriptSerializer().Deserialize<T>(jsonData);
            return obj;
        }
    }
}