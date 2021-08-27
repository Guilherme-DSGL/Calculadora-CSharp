using System;

namespace ArrayList {
    class Program {
        static void Main(string[] args) {
            string eq = Console.ReadLine();
            int i = 1, j = 1, aux = 0;
            double resultado = 0;
            String[] op = new String[100];
            String[] vetor = new string[100];
            double[] vetor2 = new double[100];

            foreach (var carac in eq) {
                if (carac == '+' || carac == '-' || carac == '/' || carac == '*') {
                    op[j] = Convert.ToString(carac);
                    j++;
                    i++;
                }
                else {
                    vetor[i] = $"{vetor[i]}{carac}";
                    vetor2[i] = double.Parse(vetor[i]);
                    //Console.WriteLine("" + vetor[i]);
                    //Console.WriteLine(vetor2[i]);
                }
            }
            for (int k = 1; k <= j; k++) {
                if (aux == 0) {
                    switch (op[k]) {
                        case "+":
                            resultado = vetor2[k] + vetor2[k + 1];
                            break;
                        case "-":
                            resultado = vetor2[k] - vetor2[k + 1];
                            break;
                        case "*":
                            resultado = vetor2[k] * vetor2[k + 1];
                            break;

                        case "/":
                            resultado = vetor2[k] / vetor2[k + 1];
                            break;
                    }
                    aux = 1;
                }
                else {
                    switch (op[k]) {
                        case "+":
                            resultado = resultado + vetor2[k + 1];
                            break;
                        case "-":
                            resultado = resultado - vetor2[k + 1];
                            break;
                        case "*":
                            resultado = resultado * vetor2[k + 1];
                            break;
                        case "/":
                            resultado = resultado / vetor2[k + 1];
                            break;
                    }
                }
            }
            Console.WriteLine(resultado);
        }
    }
}
