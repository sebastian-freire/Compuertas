using System.Text;

namespace Library;

public class GarajeGate
{
    public static StringBuilder Calculate(IInput entradaA, IInput entradaB, IInput entradaC)
    {
        StringBuilder devolver = new StringBuilder();
        AndGate and1 = new AndGate();
        and1.AddInput(entradaA);
        and1.AddInput(entradaB);
        NotGate not1 = new NotGate();
        NotGate not2 = new NotGate();
        not1.AddInput(entradaB);
        not2.AddInput(entradaA);
        AndGate and2 = new AndGate();
        and2.AddInput(not1);
        and2.AddInput(not2);
        OrGate or1 = new OrGate();
        or1.AddInput(and1);
        or1.AddInput(and2);
        AndGate and3 = new AndGate();
        and3.AddInput(or1);
        and3.AddInput(entradaC);
        List<IInput> inputs = new List<IInput>();
        inputs.Add(entradaC);
        inputs.Add(entradaB);
        inputs.Add(entradaA);
        inputs.Add(and3);
        foreach (IInput input in inputs)
        {
            if (input.GetResult() == true)
            {
            devolver.Append("| 1 |");     
            }
            else
            {
            devolver.Append("| 0 |");  
            }
        }
        devolver.Append("\n");
        return devolver;
        
    }
}