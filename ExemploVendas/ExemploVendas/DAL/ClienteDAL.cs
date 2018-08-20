using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ExemploVendas.DAL
{
    class ClienteDAL
    {
        Conexao con = new Conexao();
        public DataTable Consultar()
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Cod,
                                    Nome
                                FROM
                                    Cliente";            
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();

            return dt;
        }

        public DataTable Consultar(BLL.Cliente c)
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Cod,
                                    Nome
                                FROM
                                    Cliente
                                WHERE
                                    Nome like @nome";
            cmd.Parameters.AddWithValue("@nome", c.Nome + "%");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();

            return dt;
        }
    }
}
