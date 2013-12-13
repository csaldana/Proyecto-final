using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Proyecto
{
    public class Registros : MySql
    {
        public Registros()
        {
        }
        public ArrayList Mostrar()
        {
            this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), this.myConnection);

            MySqlDataReader myReader = myCommand.ExecuteReader();

            ArrayList registros = new ArrayList();
            while (myReader.Read())
            {

                registro registro = new registro();
                registro.id = myReader["id"].ToString();
                registro.Nombre = myReader["Nombre"].ToString();
                registro.Apell_P = myReader["Apellp"].ToString();
                registro.Apell_M = myReader["Apellm"].ToString();
                registro.Estado = myReader["Estado"].ToString();
                registro.Municipio = myReader["Nunicipio"].ToString();
                registro.Colonia = myReader["Colonia"].ToString();
                registro.Calle = myReader["Calle"].ToString();
                registro.NumExt = myReader["NumExt"].ToString();
                registro.NumInt = myReader["NumInt"].ToString();
                registro.Telefono = myReader["Telefono"].ToString();
                registro.Correo = myReader["Correo"].ToString();
                registro.CP = myReader["CP"].ToString();
                registros.Add(registro);

            }
            myReader.Close();
            myReader = null;
            myCommand.Dispose();
            myCommand = null;
            this.cerrarConexion();
            return registros;

        }
        public bool insertarRegistroNuevo(string id, string nombre, string apellp, string apellm, string estado,string municipio, string colonia, string calle, string numext, string numint, string cp, string telefono, string correo){
        

            this.abrirConexion();
            string sql = "INSERT INTO `cliente` (`id_cliente`, `Nombre`,`Apell_p`,`Apell_m`, `Estado`,`Municipio`,`Colonia`, `Calle`,`NumExt`,`NumInt`, `CP`,`Telefono`,`Correo`) VALUES ('" + id + "', '" + nombre + "','"+apellp+"','" +apellm + "', '" + estado + "','"+ municipio +"','" + colonia + "', '" + calle + "','"+ numext +"','" + numext + "', '" + cp + "','"+ telefono +"','"+correo+"')";
            int afectadas = this.ejecutarComando(sql);
            this.cerrarConexion();
            return (afectadas > 0);
        }
        public bool insertarRegistroAgente(string id, string nombre, string apellp, string apellm, string telefono, string correo)
        {
        	this.abrirConexion();
        	string sql = "INSERT INTO `agente`(`id_agente`,`Nombre`,`Apell_P`,`Apell_M`,`Telefono`,`Correo`) VALUES ('" + id + "', '" +  nombre + "','" + apellp + "','"+ apellm + "','"+ telefono +"','"+ correo +"')";
        	int afectadas = this.ejecutarComando(sql);
        	this.cerrarConexion();
        	return (afectadas > 0);
        }
        public bool insertarRegistroPoliza(string id_poliza,string id_agente, string id_companias, string id_cliente, string nomcliente, string apell_p,string apell_m,string calle,string numext,string numint,string municipio,string estado,string colonia,string telefono,string cp,string rfc,string correo,string nomcompani,string nomagente,string clavevehiculo,string marca, string  tipo,string modelo,string serie,string placas){
        	this.abrirConexion();
        	string sql = "INSERT INTO `poliza`(`id_Poliza`,`id_Agente`,`id_Companias`,`id_Cliente`,`NomCliente`,`Apell_p`,`Apell_m`,`Calle`,`NumExt`,`NumInt`,`Municipio`,`Estado`,`Colonia`,`Telefono`,`CP`,`RFC`,`Nomcompani`,`NomAgente`,`Clavevehiculo`,`Marca`,`Tipo`,`Modelo`,`Serie`,`Placas`) VALUES ('"+id_poliza+"','"+id_agente+"','"+id_companias+"','"+id_cliente+"','"+nomcliente+"','"+apell_p+"','"+apell_m+"','"+calle+"','"+numext+"','"+numint+"','"+municipio+"','"+estado+"','"+colonia+"','"+telefono+"','"+cp+"','"+rfc+"','"+nomcompani+"','"+nomagente+"','"+clavevehiculo+"','"+marca+"','"+tipo+"','"+modelo+"','"+serie+"','"+placas+"')";
        		int afectadas = this.ejecutarComando(sql);
        	this.cerrarConexion();
        	return (afectadas >0);
        }
        public bool insertarRegistroCompanias(string id_companias, string nombre, string telefono, string correo, string tiposeguro, string covertura, string precio){
        	this.abrirConexion();
        	string sql = "INSERT INTO `Companias`(`id_Companias`,`Nombre`,`Telefono`,`Correo`,`TipoSeguro`,`Covertura`,`Precio`) VALUES ('"+id_companias+"','"+nombre+"','"+telefono+"','"+correo+"','"+tiposeguro+"','"+covertura+"','"+precio+"')";
        	int afectadas = this.ejecutarComando(sql);
        	this.cerrarConexion();
        	return (afectadas > 0);
        }
        public void editarNombreRegistro(string id, string nombre)
        {
            this.abrirConexion();
            string sql = "UPDATE `cliente` SET `nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
            this.ejecutarComando(sql);
            this.cerrarConexion();
        }
        public void editarapellidosRegistro(string apellp, string apellm)
        {

            int id = 20;
            this.abrirConexion();
            string sql = "UPDATE `cliente` SET `apellp`,`apellm`='" + apellp + "','" + apellm + "' WHERE (`id`='" + id + "')";
            this.ejecutarComando(sql);
            this.cerrarConexion();
        }
         public void editarEstadoMunicipio(string estado, string municipio)
        {
            int id = 20;
            this.abrirConexion();
            string sql = "UPDATE `direccion` SET `estado`,`municipio`='" + estado + "','" + municipio + "' WHERE (`id`='" + id + "')";
            this.cerrarConexion();
        }
       
        public void editarColonia(string id, string colonia)
        {
            
            this.abrirConexion();
            string sql = "UPDATE `cliente` SET `colonia`='" + colonia + "' WHERE (`id`='" + id + "')";
            this.ejecutarComando(sql);
            this.cerrarConexion();
        }
        public void editarNumeroIntExtCodigoPos(int id, string numInt, string numExt, string cp)
        {
            
            this.abrirConexion();
            string sql = "UPDATE `cliente` SET `numInt`,`numExt`,`CP`='" + numExt + "','" + numInt + "','"+ cp +"' WHERE (`id`='" + id + "')";
            this.ejecutarComando(sql);
            this.cerrarConexion();
        }
        public void editarTelefonoCorreo(string telefono, string correo)
        {
            int id = 20;
            this.abrirConexion();
            string sql = "UPDATE `cliente` SET `Telefono`,`Correo`='" + telefono + "','" + correo + "' WHERE (`id`='" + id + "')";
            this.ejecutarComando(sql);
            this.abrirConexion();
        }
       
 
        public bool eliminarRegistroPorId(string id)
        {
            this.abrirConexion();
            string sql = "DELETE FROM `cliente` WHERE (`id_Cliente`='" + id + "')";
            int afectadas = this.ejecutarComando(sql);
            this.cerrarConexion();
            return (afectadas > 0);
        }
         public bool eliminarAgentePorId(string id)
        {
            this.abrirConexion();
            string sql = "DELETE FROM `Agente` WHERE (`id_Agente`='" + id + "')";
            int afectadas = this.ejecutarComando(sql);
            this.cerrarConexion();
            return (afectadas > 0);
        }
         public bool eliminarCompaniaPorId(string id){
         	this.abrirConexion();
         	string sql = "DELETE FROM `Companias` WHERE(`id_Companias`='"+ id +"')";
         	int afectadas = this.ejecutarComando(sql);
         	this.cerrarConexion();
         	return (afectadas > 0);
         }

        public bool existeCodigo(string codigo)
        {
            this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM cliente WHERE codigo = '" + codigo + "'",
                                                      this.myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();
            return myReader.HasRows;
        }

        public registro obtenerPorid(string id)
        {
        	 
        	this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM cliente WHERE id_Cliente = '" + id + "'",
                                                      this.myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();
            registro registro = new registro();
            if (myReader.HasRows)
            {
                myReader.Read();
                
                registro.id = myReader["id_Cliente"].ToString();
                registro.Nombre = myReader["Nombre"].ToString();
                registro.Apell_P = myReader["Apell_P"].ToString();
                registro.Apell_M = myReader["Apell_M"].ToString();
                registro.Estado = myReader["Estado"].ToString();
                registro.Municipio = myReader["Municipio"].ToString();
                registro.Colonia = myReader["Colonia"].ToString();
                registro.Calle = myReader["Calle"].ToString();
                registro.NumExt = myReader["NumExt"].ToString();
                registro.NumInt = myReader["numInt"].ToString();
                registro.CP = myReader["CP"].ToString();
                registro.Telefono = myReader["Telefono"].ToString();
                registro.Correo = myReader["Correo"].ToString();
                registro.RFC = myReader["RFC"].ToString();
            }
            
            myReader.Close();
            myReader = null;
            myCommand.Dispose();
            myCommand = null;
            this.cerrarConexion();
            return registro;
        
        }

        private int ejecutarComando(string sql)
        {
            MySqlCommand myCommand = new MySqlCommand(sql, this.myConnection);
            int afectadas = myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            myCommand = null;
            return afectadas;
        }

        private string querySelect()
        {
            return "SELECT *" + "FROM agenciaseguro";
        }
    }
}

