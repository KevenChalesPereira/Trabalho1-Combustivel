﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1
{
    internal class Carro
    {
        public string tipo_car { get; set; }
        public double con_eta { get; set; } = 0;
        public double con_gas { get; set; } = 0;

      
       public void editar_dados(double gas, double eta)
        {
            this.con_eta = eta;
            this.con_gas = gas;
        }
    }

}
