using System.Text;
using Library;

namespace Program;

class Program
{
    static void Main(string[] args)
    {
        List<IInput> bools= new List<IInput>();
        IInput entrada1 = new BooleanInput(false);
        IInput entrada2 = new BooleanInput(true);
        bools.Add(entrada1);
        bools.Add(entrada2);
        IInput entradaA;
        IInput entradaB;
        IInput entradaC;
        StringBuilder resultado = new StringBuilder();
        resultado.Append("| C || B || A || R |\n");
        foreach(IInput b in bools)
        {
            entradaC = b;
            foreach(IInput b2 in bools)
            {
                entradaB = b2;
                foreach(IInput b3 in bools)
                {
                    entradaA = b3;
                    resultado.Append(GarajeGate.Calculate(entradaA, entradaB, entradaC));
                }
            }
        }
        Printer.Imprimir(resultado);
    }
}
