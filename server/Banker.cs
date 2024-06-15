namespace server;

public class Banker
{
    private Random _numberBasket;
    public List<int> CalledNumbers;
    private int _maxMaxNumber;

    public Banker(int maxNumber = 75)
    {
        _maxMaxNumber = maxNumber;
        _numberBasket = new Random();
        CalledNumbers = new List<int>(_maxMaxNumber);
    }
    public int GetNumber()
    {
        while (true)
        {
            int number = _numberBasket.Next(_maxMaxNumber) + 1;
            if (!CalledNumbers.Contains(number))
            {
                CalledNumbers.Add(number);
                return number;
                break;
            }
        }
    }

    public void ResetGame()
    {
        _numberBasket = new Random();
        CalledNumbers = new List<int>();
    }
}