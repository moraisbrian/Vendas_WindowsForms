using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVendas.BLL
{
    class Venda
    {
        private int _cod;
        private int _codCliente;
        private DateTime _dataVenda;

        public int Cod
        {
            get
            {
                return _cod;
            }

            set
            {
                _cod = value;
            }
        }

        public int CodCliente
        {
            get
            {
                return _codCliente;
            }

            set
            {
                _codCliente = value;
            }
        }

        public DateTime DataVenda
        {
            get
            {
                return _dataVenda;
            }

            set
            {
                _dataVenda = value;
            }
        }

        private List<VendaItens> listaDeItens = new List<VendaItens>();
        public List<VendaItens> ListaDeItens
        {
            get { return listaDeItens; }
            set { listaDeItens = value; }
        }
    }
}
