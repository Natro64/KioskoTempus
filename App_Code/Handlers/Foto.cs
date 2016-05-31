using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.IO;
using System.Web.UI;

namespace IXport.Handlers
{
    public class Foto: IHttpHandler
    {
        /// <summary>
        /// You will need to configure this handler in the Web.config file of your 
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public bool IsReusable
        {
            // Return false in case your Managed Handler cannot be reused for another request.
            // Usually this would be false in case you have some state information preserved per request.
            get { return true;  }
        }

        public void ProcessRequest(HttpContext context)
        {
            //write your handler implementation here.
            ;

            string Order = context.Request.QueryString["Order"];

            string IdOrder = "0";

            switch (Order)
            {
                /*Pagina Index Portada Perfil -------------------------------------------------------------------------------------- */
                case "1":   {   IdOrder = "1";  Imagen(context, IdOrder); }
                    break;
                case "2":   {   IdOrder = "2";  Imagen(context, IdOrder); }
                    break;
                case "3":   {   IdOrder = "3";  Imagen(context, IdOrder); }
                    break;
                case "4":   {   IdOrder = "4";  Imagen(context, IdOrder); }
                    break;
                case "5":   {   IdOrder = "5";  Imagen(context, IdOrder); }
                    break;
            }
        }

        public void Imagen(HttpContext context, string Id)
        {
            /* Hace la conexion */
            string Title, Info;

            bool flag = false;

            string Identificador = Id;

            using (SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["IXport"].ToString()))
            {
                /* abre la conexion */
                conexion.Open();
                /*Ejecuta el stored procedure */
                using (SqlCommand orden = new SqlCommand("EXEC dbo.PROC_AVISO_Avisos " + Identificador.ToString(), conexion))
                {
                    flag = true;
                    using (SqlDataReader lector = orden.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            if (lector["image"] != System.DBNull.Value)
                            {
                                Byte[] imagen = new Byte[2];
                                imagen = (Byte[])lector[2];
                                context.Response.ContentType = lector[3].ToString();
                                context.Response.OutputStream.Write(imagen, 0, imagen.Length);
                            }
                            else
                            {
                                context.Response.ContentType = "image/png";
                                context.Response.WriteFile("touch/images/Default.png");
                            }
                        }
                        lector.Close();
                    }
                }
                conexion.Close();
            }
        }
    }
    #endregion
}