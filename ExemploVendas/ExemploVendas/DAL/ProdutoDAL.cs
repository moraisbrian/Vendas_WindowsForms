using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ExemploVendas.DAL
{
    class ProdutoDAL
    {
        Conexao con = new Conexao();
        public DataTable Consultar(BLL.Produto p)
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Cod,
                                    Descricao,
                                    ValorUnit,
                                    Qtd
                                FROM
                                    Produto
                                WHERE
                                    Descricao like @descricao";
            cmd.Parameters.AddWithValue("@descricao", p.Descricao + "%");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();

            return dt;
        }

        public DataTable Consultar()
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Cod,
                                    Descricao,
                                    ValorUnit,
                                    Qtd
                                FROM
                                    Produto";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();

            return dt;
        }
    }
}
