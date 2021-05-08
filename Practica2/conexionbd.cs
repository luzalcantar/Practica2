using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Practica2
{
    class conexionbd
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public conexionbd()
        {
            string servidor = "localhost";
            string port = "3306";
            string usuario = "root";
            string password = "root";
            string database = "practica2"; 

            string cadena = "server="+servidor+"; port="+port+"; user id="+ usuario + "; password="+password+"; database="+database+"";

            con = new MySqlConnection(cadena);

            try
            {
                con.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se realizo la conexion: " + e.ToString());
            }


        }
        public string Insertar(string id, string fecha, string nombre, string apellidop, string apellidom, string calle, string no, string colonia)
        {
            string salida = "Registro Insertado con exito";
            try
            {
                DateTime dt = Convert.ToDateTime(fecha);
                string dateFormatted = dt.ToString("yyyy-MM-dd");
                cmd = new MySqlCommand("INSERT INTO distributors (id_distributors, fecha_registro) values ('" + id + "', '" + dateFormatted + "');", con);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("INSERT INTO persons(id_distributors, nombre, apellidoP, apellidoM) values('"+id+"', '"+nombre+"', '"+apellidop+"', '"+apellidom+"');", con);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("INSERT INTO addresses(id_distributors, calle, no_ext, colonia) values('"+id+"', '"+calle+"', '"+no+"', '"+colonia+"');", con);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                salida = "No se inserto: " + e.ToString();
            }
            return salida;
        }
        public int validarID(string id)
        {
            int contador = 0;
            try
            {
 
                cmd = new MySqlCommand("SELECT * FROM distributors where id_distributors='"+id+"';", con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    contador++;
                }
                reader.Close();
                
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se pudo realizar la consulta: " +e.ToString()) ;
            }
            return contador;
        }
        public DataTable consultarID(string id)
        {
            DataTable tabla = new DataTable();
            try {
                cmd = new MySqlCommand("call obtenerDatos('" + id.ToString() + "');", con);
                MySqlDataAdapter datos = new MySqlDataAdapter(cmd);
                datos.Fill(tabla);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se pudo realizar la consulta: " + e.ToString());
            }
            return tabla;
        }
    }
}
