namespace Library;

public class AndGate: IInput
{
    public List<IInput> andInput = new List<IInput>();
    public AndGate()
    {
        andInput = new List<IInput>();
    }
    public void AddInput(IInput entrada)
    {
        andInput.Add(entrada);
    }
    public bool GetResult()
    {   
        bool bool1 = andInput[0].GetResult();
        bool bool2 = andInput[1].GetResult();
        bool devolver = bool1 && bool2;
        return devolver;
    }
}