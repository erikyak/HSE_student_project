public class ObservableInt
{ 
    public event System.Action<int> OnValueChanged;
    
    private int _value;

    public int Value
    {
        get => _value;
        set
        {
          _value = value;
          OnValueChanged?.Invoke(_value);
        }
    }

    public ObservableInt(int value)
    {
        Value = value;
    }
    public ObservableInt() : this(0) { }
}
