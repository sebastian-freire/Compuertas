namespace Library;

public class BooleanInput: IInput
{
    public bool valor;
    public BooleanInput(bool pvalor)
    {
        this.valor = pvalor;
    }

    public bool GetResult()
    {
        return valor;
    }

}