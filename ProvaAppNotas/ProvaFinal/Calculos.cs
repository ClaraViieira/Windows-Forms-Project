using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaFinal {
    class Calculos {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public Calculos(double nota1, double nota2, double nota3, double nota4) {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Nota4 = nota4;
        }

        public double Media() {
            double soma = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            return soma;
        }

        public double SomaPar() {
            List<double> list = new List<double> { Nota1, Nota2, Nota3, Nota4 };
            double cont = 0;
            foreach (double nota in list) {
                if (nota % 2 == 0)
                    cont += nota;
            }
            return cont;
        }
        public double SomaImpar() {
            List<double> list = new List<double> { Nota1, Nota2, Nota3, Nota4 };
            double cont = 0;
            foreach (double nota in list) {
                if (nota % 2 != 0)
                    cont += nota;
            }
            return cont;
        }
        public double MaiorIgualSete() {
            List<double> list = new List<double> { Nota1, Nota2, Nota3, Nota4 };
            double cont = 0;
            foreach (double nota in list) {
                if (nota >= 7)
                    cont += 1;
            }
            return cont;
        }

        public double MaiorNota() {
            double maiorNota;
            if (Nota1 > Nota2 && Nota1 > Nota3 && Nota1 > Nota4)
                maiorNota = Nota1;
            else if (Nota2 > Nota1 && Nota2 > Nota3 && Nota2 > Nota4)
                maiorNota = Nota2;
            else if (Nota3 > Nota1 && Nota3 > Nota2 && Nota3 > Nota4)
                maiorNota = Nota3;
            else
                maiorNota = Nota4;
            return maiorNota;

        }

        public double MenorNota() {
            double menorNota;
            if (Nota1 < Nota2 && Nota1 < Nota3 && Nota1 < Nota4)
                menorNota = Nota1;
            else if (Nota2 < Nota1 && Nota2 < Nota3 && Nota2 < Nota4)
                menorNota = Nota2;
            else if (Nota3 < Nota1 && Nota3 < Nota2 && Nota3 < Nota4)
                menorNota = Nota3;
            else
                menorNota = Nota4;
            return menorNota;
        }
    }
}
