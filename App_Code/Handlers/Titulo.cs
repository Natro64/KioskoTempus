using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;


namespace IXport.Handlers
{
    public class Titulo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //write your handler implementation here.
            ;
            string Num = context.Request.QueryString["Num"];

            string IdOrder = "0";

            switch (Num)
            {
                /*Pagina Index Portada Perfil -------*/
                case "1":
                    { IdOrder = "1"; Avisos(context, IdOrder); }
                    break;
                case "2":
                    { IdOrder = "2"; Avisos(context, IdOrder); }
                    break;
                case "3":
                    { IdOrder = "3"; Avisos(context, IdOrder); }
                    break;
                case "4":
                    { IdOrder = "4"; Avisos(context, IdOrder); }
                    break;
                case "5":
                    { IdOrder = "5"; Avisos(context, IdOrder); }
                    break;
            }
        }

        string ti;
        public void Avisos(HttpContext context, string Id)
        {
            bool flag = false;

            context.Response.ContentType = "text/plain";

            string Identificador = Id;

            using (SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["IXport"].ToString()))
            {
                /* abre la connexion */
                conexion.Open();
                /*Ejecuta el stored procedure */
                using (SqlCommand orden = new SqlCommand("EXEC dbo.PROC_AVISO_Avisos " + Identificador, conexion))
                {
                    flag = true;
                    using (SqlDataReader lector = orden.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string Title = lector[0].ToString();
                            context.Response.Output.Write(Title);
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