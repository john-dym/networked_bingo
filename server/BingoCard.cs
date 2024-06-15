namespace server;

public class BingoCard
{
    private BingoCell[,] _bingoCells = new BingoCell[5,5];

    public BingoCard(int maxNumber = 75)
    {
        FillBingoCells(maxNumber);
    }

    private void FillBingoCells(int maxNumber)
    {
        Random rnd_numbers = new Random();

        for (int x = 0; x < _bingoCells.GetLength(0); x++)
        {
            for (int y = 0; y < _bingoCells.GetLength(1); y++)
            {
                if (_bingoCells[x,y] is null)
                {
                    _bingoCells[x,y] = new BingoCell(rnd_numbers.Next(maxNumber + 1));
                }
            }
        }
        
    }
}

public class BingoCell(int num)
{
    public int Number { get; } = num;

    public bool IsMarked { get; private set; } = false;

    public void MarkCell()
    {
        IsMarked = true;
    }
}