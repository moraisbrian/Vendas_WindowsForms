using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVendas.BLL
{
    class VendaItens
    {
        private int _cod;
        private int _codProduto;
        private int _qtd;
        private double _valorUnit;

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

        public int CodProduto
        {
            get
            {
                return _codProduto;
            }

            set
            {
                _codProduto = value;
            }
        }

        public int Qtd
        {
            get
            {
                return _qtd;
            }

            set
            {
                _qtd = value;
            }
        }

        public double ValorUnit
        {
            get
            {
                return _valorUnit;
            }

            set
            {
                _valorUnit = value;
            }
        }
    }
}
