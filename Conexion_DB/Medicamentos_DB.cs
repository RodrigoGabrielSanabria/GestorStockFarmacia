using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Conexion_DB
{
    public class Medicamentos_DB
    {
        public List<Medicamento> Listar()
        {
            List<Medicamento> list = new List<Medicamento>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS;database=Farmacia_Estrella_DB;User ID=farmacia;Password=admin";

                comando.CommandType = System.Data.CommandType.Text;
                
                comando.CommandText = "SELECT ID, CantidadEnStock, Nombre, PrecioUnitario, PrecioTotal FROM Medicamentos";
                
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader(); 
                
                //Ciclo While para mostrar contenido en DGV

                while (lector.Read) 
                { 
                    Medicamento aux = new Medicamento();

                    aux.id = (int)lector["id"];
                    aux.cantidadStock = lector.GetInt32(0);
                    aux.nombre = lector.GetString(1);
                    aux.precioUnitario = (double)lector.GetDecimal(2);
                    aux.precioTotal = (double)lector.GetDecimal(3);

                    list.Add(aux);
                
                }
                conexion.Close();
                return list;    
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
