using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC {
    class IMC {
        public string CalculoIMC(double altura, double peso) {
            double resultado = peso / (altura * altura);
            if (resultado < 17.0) 
                return "Classificação: Muito abaixo do peso";
            else if (resultado < 18.49)
                return "Classificação: Abaixo do peso";
            else if (resultado < 24.99)
                return "Classificação: Peso normal";
            else if (resultado < 29.99)
                return "Classificação: Acima do Peso";
            else if (resultado < 34.99)
                return "Classificação: Obesidade I";
            else if (resultado < 39.99)
                return "Classfificação: Obesidade II (severa)";
            else
                return "Classificação: Obesidade III (móbida)";
        }
    }
}
