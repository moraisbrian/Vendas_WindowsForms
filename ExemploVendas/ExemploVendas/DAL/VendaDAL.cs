using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ExemploVendas.DAL
{
    class VendaDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Venda v)
        {
            //Cadastro do cabeçalho da venda
            int chaveGerada;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Venda       
                                    (CodCli, DataVenda)
                                VALUES 
                                    (@codCli, getdate());
                                
                                SELECT SCOPE_IDENTITY();";
            cmd.Parameters.AddWithValue("@codCli", v.CodCliente);
            chaveGerada = Convert.ToInt16(cmd.ExecuteScalar());

            SqlCommand cmdItens = new SqlCommand();
            cmdItens.Connection = con.Conectar();
            cmdItens.CommandText = @"INSERT INTO VendaItens
                                        (CodVenda, CodProd, Qtd, ValorUnit)
                                    VALUES
                                        (@codVenda, @codProd, @qtd, @valorUnit)";
            cmdItens.Parameters.Add("@codVenda", SqlDbType.Int);
            cmdItens.Parameters.Add("@codProd", SqlDbType.Int);
            cmdItens.Parameters.Add("@qtd", SqlDbType.Int);
            cmdItens.Parameters.Add("@valorUnit", SqlDbType.Money);

            //Cadastro dos Itens da Venda
            foreach (BLL.VendaItens item in v.ListaDeItens)
            {
                cmdItens.Parameters["@codVenda"].Value = chaveGerada;
                cmdItens.Parameters["@codProd"].Value = item.CodProduto;
                cmdItens.Parameters["@qtd"].Value = item.Qtd;
                cmdItens.Parameters["@valorUnit"].Value = item.ValorUnit;
                cmdItens.ExecuteNonQuery(); //Cadastrar o Item
            }

            con.Desconectar();

            
        }
    }
}
