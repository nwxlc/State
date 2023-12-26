namespace State;

public partial class CandyMachine
{
    protected class NoQuarters : IState
    {
        private CandyMachine _mashine;

        public NoQuarters(CandyMachine candy)
        {
            _mashine = candy ?? throw new ArgumentNullException(nameof(candy));
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Нет монетки");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Монетка вставлена");
            _mashine.SetState(new HasQuarters(_mashine));
        }

        public void TurnCrank()
        {
            Console.WriteLine("Конфета не выдана, не вставлена монетка");
        }

        public void Dispense()
        {
            Console.WriteLine("Ничего не произошло");
        }
    }
}