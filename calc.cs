using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1
{
    internal class Calc
    {
        public string calcular(double gas, double eta, double v_gas, double v_eta)
        {
            double conta = 0;
            string resposta = "";

            if (gas != 0 && eta != 0)
            {
                conta = eta / gas;


            }
            else
            {
                conta = 0.7;

            }
            conta = v_gas * conta;

            if (v_eta == conta)
                resposta = "Não existe variação de preço";

            else if (v_eta < conta)
               resposta = "Esta compensando o Etanol";
            else
                resposta = "Esta compensando a Gasolina";

            return resposta;
        }

       
    }
}
