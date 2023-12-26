namespace State;

public partial class CandyMachine
{
    public int CandyLeft { get; private set; }
    private IState? _state;

    public CandyMachine(int сandyCount)
    {
        CandyLeft = сandyCount;
        _state = CandyLeft > 0 ? new NoQuarters(this) : new SoldOut(this);
    }

    private void SetState(IState state)
    {
        _state = state ?? throw new ArgumentNullException(nameof(state));
    }

    public void EjectQuarter()
    {
        _state?.EjectQuarter();
    }

    public void InsertQuarter()
    {
        _state?.InsertQuarter();
    }

    public void TurnCrank()
    {
        _state?.TurnCrank();
        Dispense();
    }
    
    private void Dispense()
    {
        _state?.Dispense();
    }
}