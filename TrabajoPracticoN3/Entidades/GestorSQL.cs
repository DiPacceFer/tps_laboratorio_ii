using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class GestorSQL
    {
        private static string connectionString;

        static GestorSQL()
        {
            connectionString = "Server=.;Database=DIV2ASQL;Trusted_Connection=True;";
        }
        public static List<Socio> LeerDatosSocio()
        {
            List<Socio> listado = new List<Socio>();

            try
            {
                string query = "SELECT * FROM listaClub";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int numeroSocio = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        int dni = reader.GetInt32(3);
                        DateTime fechaNac = reader.GetDateTime(4);
                        if ((string)reader[5] == "no")
                        {
                            Socio socio = new Socio(numeroSocio, nombre, apellido, fechaNac, dni);
                            listado.Add(socio);
                        }
                        else
                        {
                            string deporte = (string)reader[5];
                            string categoria = reader.GetString(6);
                            if (deporte == "Rugby")
                            {
                                Rugbier rugbier = new Rugbier(numeroSocio, nombre, apellido, fechaNac, dni, (ECategoriasRugby)(Enum.Parse(typeof(ECategoriasRugby),categoria)));
                                listado.Add(rugbier);
                            }
                            else
                            {
                                Futbolista futbolista = new Futbolista(numeroSocio, nombre, apellido, fechaNac, dni, (ECategoriasFutbol)(Enum.Parse(typeof(ECategoriasFutbol), categoria)));
                                listado.Add(futbolista);
                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
            }
            return listado;
        }
        public static void AltaSocio(Socio socio)
        {
            string query = "insert into listaClub(nombre, apellido, fechaNacimiento, dni, deporte, categoria) values (@nombre,@apellido,@fechaNacimiento,@dni, @deporte, @categoria)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(GestorSQL.connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nombre", socio.Nombre);
                command.Parameters.AddWithValue("apellido", socio.Apellido);
                command.Parameters.AddWithValue("fechaNacimiento", socio.FechaDeNacimiento);
                command.Parameters.AddWithValue("dni", socio.Dni);
                command.Parameters.AddWithValue("Deporte", "no");
                command.Parameters.AddWithValue("Categoria", "no");
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        public static void AltaRugbier(Rugbier rugbier)
        {
            string query = "insert into listaClub(nombre, apellido, fechaNacimiento, dni, deporte, categoria) values (@nombre,@apellido,@fechaNacimiento,@dni, @deporte, @categoria)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(GestorSQL.connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nombre", rugbier.Nombre);
                command.Parameters.AddWithValue("apellido", rugbier.Apellido);
                command.Parameters.AddWithValue("fechaNacimiento", rugbier.FechaDeNacimiento);
                command.Parameters.AddWithValue("dni", rugbier.Dni);
                command.Parameters.AddWithValue("Deporte", (rugbier.Deporte).ToString());
                command.Parameters.AddWithValue("Categoria", (rugbier.Categoria).ToString());
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        public static void AltaFutbolista(Futbolista futbolista)
        {
            string query = "insert into listaClub(nombre, apellido, fechaNacimiento, dni, deporte, categoria) values (@nombre,@apellido,@fechaNacimiento,@dni, @deporte, @categoria)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(GestorSQL.connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nombre", futbolista.Nombre);
                command.Parameters.AddWithValue("apellido", futbolista.Apellido);
                command.Parameters.AddWithValue("fechaNacimiento", futbolista.FechaDeNacimiento);
                command.Parameters.AddWithValue("dni", futbolista.Dni);
                command.Parameters.AddWithValue("Deporte", (futbolista.Deporte).ToString());
                command.Parameters.AddWithValue("Categoria", (futbolista.Categoria).ToString());
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        public static void CrearTablaSocios()
        {
            string query = "use DIV2ASQL create table listaClub(numeroSocio int identity primary key, nombre varchar(50) null, apellido varchar(50) null, dni int, fechaNacimiento date, deporte varchar(50), categoria varchar(50));";
            
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(GestorSQL.connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        public static void CrearTablaPagos()
        {
            string query = "use DIV2ASQL create table listaPagos(idPago int identity primary key, importe float, fechaPago date, numeroSocio int foreign key references listaClub(numeroSocio));";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(GestorSQL.connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        public static void CargarTablaSocios(List<Socio> listadoSocios)
        {
            foreach (Socio item in listadoSocios)
            {
                GestorSQL.AltaSocio(item);
            }
        }
        public static void AltaPago(Pago pago)
        {
            string query = "insert into listaPagos (importe, fechaPago, numeroSocio) values" +
                " (@importe,@fechaPago, @numeroSocio)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(GestorSQL.connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("importe", pago.Importe);
                command.Parameters.AddWithValue("fechaPago", pago.FechaPago);
                command.Parameters.AddWithValue("numeroSocio", pago.Socio.NumeroSocio);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        public static void CargarTablaPagos(List<Pago> listadoPagos)
        {
            foreach (Pago item in listadoPagos)
            {
                GestorSQL.AltaPago(item);
            }
        }
        public static List<Pago> LeerDatosPago()
        {
            List<Pago> listado = new List<Pago>();

            try
            {
                string query = "SELECT * FROM listaPagos left join listaClub on listaPagos.numeroSocio = listaClub.numeroSocio";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        double importe = reader.GetDouble(1);
                        DateTime fechaPago = reader.GetDateTime(2);
                        int numeroSocio = reader.GetInt32(4);
                        string nombreSocio = reader.GetString(5);
                        string apellidoSocio = reader.GetString(6);
                        int dniSocio = reader.GetInt32(7);
                        DateTime fechaNacSocio = reader.GetDateTime(8);

                        Pago pago = new Pago(importe, fechaPago, new Socio(numeroSocio, nombreSocio, apellidoSocio,fechaNacSocio, dniSocio));
                        listado.Add(pago);
                    }
                }

            }
            catch (Exception ex)
            {
            }
            return listado;
        }
        public static bool EliminarSocio(Socio socio)
        {
            bool rta = false;
            string query = "delete from listaClub where numeroSocio = @numeroSocio";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(GestorSQL.connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("numeroSocio", socio.NumeroSocio);
                command.ExecuteNonQuery();
                rta = true;
            }
            catch (SqlException)
            {
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return rta;
        }
        public static void ActualizarDatosSocio(Socio socio)
        {
            string query = "update listaClub set nombre = @nombre, apellido = @apellido, fechaNacimiento = @fechaNacimiento, dni = @dni where numeroSocio = @numeroSocio";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(GestorSQL.connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("numeroSocio", socio.NumeroSocio);
                command.Parameters.AddWithValue("nombre", socio.Nombre);
                command.Parameters.AddWithValue("apellido", socio.Apellido);
                command.Parameters.AddWithValue("fechaNacimiento", socio.FechaDeNacimiento);
                command.Parameters.AddWithValue("dni", socio.Dni);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
