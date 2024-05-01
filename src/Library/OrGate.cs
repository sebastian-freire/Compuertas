namespace Library;

public class OrGate: IInput
{
    public List<IInput> orInput = new List<IInput>();
    public void AddInput(IInput entrada)
    {
        orInput.Add(entrada);
    }
    public bool GetResult()
    {   
        bool bool1 = orInput[0].GetResult();
        bool bool2 = orInput[1].GetResult();
        bool devolver = bool1 || bool2;
        return devolver;
    }
}