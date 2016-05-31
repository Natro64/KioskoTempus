using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using IXport.Data;

namespace IXport.Rules
{
	public partial class SolicitudesBusinessRules : IXport.Rules.SharedBusinessRules
    {
        /*
        [ControllerAction("Solicitudes", "Select", ActionPhase.Before)]
        public void respondSelect(string RFC_Supervisor)
        {
            using (SqlText orden = new SqlText(@"SELECT [FechaSolicitud], [NombreCompleto], [NombreTabla], [FechaSolicitada], [Cantidad], [Notas] 
                                                FROM [Solicitudes], [Empleado], [TipoSolicitud] 
                                                WHERE [Empleado].[ID_Empleado] = [Solicitudes].[ID_Empleado] 
                                                AND [TipoSolicitud].[ID_TipoSolicitud] = [Solicitudes].[ID_TipoSolicitud]
                                                AND [Empleado].[ID_JefeDirecto] = (SELECT [ID_Empleado] FROM [Empleado] WHERE [RFC] = @BusinessRules_UserName);"))
            {
                orden.AddParameter("@BusinessRules_UserName", RFC_Supervisor);

                string FechaSolicitud = "";
                string Empleado = "";
                string TipoSolicitud = "";
                string FechaSolicitada = "";
                string Cantidad = "";
                string Notas = "";
                orden.ExecuteReader();
                while (orden.Read())
                {
                    FechaSolicitud = orden["FechaSolicitud"].ToString();
                    Empleado = orden["Solicitudes.ID_Empleado"].ToString();
                    TipoSolicitud = orden["ID_TipoSolicitud"].ToString();
                    FechaSolicitada = orden["FechaSolicitada"].ToString();
                    Cantidad = orden["Cantidad"].ToString();
                    Notas = orden["Notas"].ToString();
                }
                orden.Reader.Close();

                string mensaje = (string)orden.ExecuteScalar();
                Result.ShowAlert(mensaje);
            }
        }
        */
    }
}
