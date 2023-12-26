namespace State;

public partial class CandyMachine
{
    protected class HasQuarters : IState
    {
        private CandyMachine _mashine;

        public HasQuarters(CandyMachine candy)
        {
            _mashine = candy ?? throw new ArgumentNullException(nameof(candy));
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Монетка возвращена");
            _mashine.SetState(new NoQuarters(_mashine));
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Монетка уже вставлена");
            _mashine.SetState(new Sold(_mashine));
        }

        public void TurnCrank()
        {
            _mashine.Dispense();
            _mashine.SetState(new Sold(_mashine));
        }

        public void Dispense()
        {
            Console.WriteLine("Ничего не произошло");
        }
    }
}