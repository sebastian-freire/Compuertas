namespace Library;

public class NotGate: IInput
{
    public List<IInput> notInput = new List<IInput>();
    public void AddInput(IInput entrada)
    {
        notInput.Add(entrada);
    }
    public bool GetResult()
    {   
        bool bool1 = notInput[0].GetResult();
        bool devolver = !bool1;
        return devolver;
    }
}

