using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Negocio
    {
        public Negocio ObtenerDatos()
        {
            Negocio obj = new Negocio();

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "SELECT IdNegocio, Nombre, NIT, Direccion FROM NEGOCIO WHERE IdNegocio = 1 ";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Negocio()
                            {
                                idNegocio = int.Parse(dr["Idnegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                NIT = dr["NIT"].ToString(),
                                Direccion = dr["Direccion"].ToString()
                            };
                        }
                    }

                }
            }
            catch
            {
                obj = new Negocio();
            }


            return obj;
        }


        public bool GuardarDatos(Negocio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();


                    StringBuilder query = new StringBuilder();

                    query.AppendLine("UPDATE NEGOCIO SET Nombre = @nombre,");
                    query.AppendLine("NIT = @Nit,");
                    query.AppendLine("Direccion = @Direccion");
                    //adicional
                    query.AppendLine(" ,PorcentajeRendimientoGeneral = @PorcentajeRendimientoGeneral ");
                    //adicional<.
                    query.AppendLine("WHERE IdNegocio = 1");


                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@Nit", objeto.NIT);
                    cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                    cmd.Parameters.AddWithValue("@PorcentajeRendimientoGeneral", objeto.PorcentajeRendimiento);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo guardar los datos";
                        respuesta = false;
                    }


                }

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;

            }
            return respuesta;

        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] logoBytes = new byte[0];


            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "SELECT Logo FROM NEGOCIO WHERE IdNegocio = 1 ";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            logoBytes = (byte[])dr["Logo"];
                            //obj = new Negocio()
                            //{
                            //    idNegocio = int.Parse(dr["Idnegocio"].ToString()),
                            //    Nombre = dr["Nombre"].ToString(),
                            //    NIT = dr["NIT"].ToString(),
                            //    Direccion = dr["Direccion"].ToString()
                            //};
                        }
                    }


                }

            }
            catch (Exception ex)
            {
                obtenido = false;
                logoBytes = new byte[0];
            }
            return logoBytes;

        }



        public bool ActualizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;
            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();


                    StringBuilder query = new StringBuilder();

                    query.AppendLine("UPDATE NEGOCIO SET Logo = @imagen");
                    query.AppendLine("WHERE IdNegocio = 1");


                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@imagen", image);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el Logo.";
                        respuesta = false;
                    }


                }

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;

            }
            return respuesta;


        }


    }
}
