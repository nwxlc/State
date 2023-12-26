namespace State;

public partial class CandyMachine
{
    protected class Sold : IState
    {
        private CandyMachine _mashine;

        public Sold(CandyMachine candy)
        {
            _mashine = candy ?? throw new ArgumentNullException(nameof(candy));
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Ничего не произошло");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Ничего не произошло");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Ничего не произошло");
        }

        public void Dispense()
        {
            Console.WriteLine("Конфета выдана");
            _mashine.SetState(_mashine.CandyLeft-- > 0 ? new NoQuarters(_mashine) : new SoldOut(_mashine));
        }
    }
    
}