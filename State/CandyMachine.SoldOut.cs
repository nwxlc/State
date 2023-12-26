namespace State;

public partial class CandyMachine
{
    protected class SoldOut : IState
    {
        private CandyMachine _mashine;

        public SoldOut(CandyMachine candy)
        {
            _mashine = candy;
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Монета возвращена");
        }

        public void InsertQuarter()
        {
            EjectQuarter();
        }

        public void TurnCrank()
        {
            Console.WriteLine("Ничего не произошло");
        }
        public void Dispense()
        {
            Console.WriteLine("Ничего не произошло");
        }
    }
}