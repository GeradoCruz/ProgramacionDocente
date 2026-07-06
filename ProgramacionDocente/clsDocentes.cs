using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionDocente
{
    internal class clsDocentes
    {
        private MySqlDataAdapter consulta;
        private DataTable tabla;

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionDB = new clsConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {
                    string sql = "SELECT D.claveDocente AS Clave, " +
                                 "D.nombreDocente AS Docente, " +
                                 "D.puesto AS Puesto, " +
                                 "D.telefono AS Telefono, " +
                                 "D.correo AS Correo, " +
                                 "D.idUsuario, "+
                                 "U.nombreUsuario AS Usuario, " +
                                 "U.password AS Password, " +
                                 "U.perfil AS Perfil " +
                                 "FROM tbldocentes D " +
                                 "INNER JOIN tblusuarios U ON D.idUsuario = U.idUsuario; ";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la tabla " + ex.Message);
            }
            return tabla;
        }
    }
}
