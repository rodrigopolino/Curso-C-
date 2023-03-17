using System;
using System.Globalization;

namespace Aula4 {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) { //void mexe na caixa certa - não rtona nada como saida
            Quantidade += quantidade;
        }
        
        public void RemoverProdutos(int quantidade) { //void mexe na caixa certa - não rtona nada como saida
            Quantidade -= quantidade;
        }

        public override string ToString() { //override veio de outra classe
            return Nome + 
                   ", $ " 
                   + Preco.ToString("F2", CultureInfo.CurrentCulture)
                   + ", "
                   + Quantidade
                   + " unidades, Total: $ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.CurrentCulture);
        }

    }
}
