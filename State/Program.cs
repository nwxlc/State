using State;

CandyMachine candyMachine = new(5);
candyMachine.InsertQuarter();
candyMachine.TurnCrank();

candyMachine.InsertQuarter();
candyMachine.TurnCrank();

candyMachine.InsertQuarter();
candyMachine.EjectQuarter();
Console.WriteLine();

candyMachine.InsertQuarter();
candyMachine.TurnCrank();
candyMachine.InsertQuarter();
candyMachine.TurnCrank();
candyMachine.InsertQuarter();
candyMachine.TurnCrank();

candyMachine.InsertQuarter();
candyMachine.TurnCrank();

Console.WriteLine($"Осталось конфет: {candyMachine.CandyLeft}");