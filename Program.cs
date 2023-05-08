namespace TaskAbstract;
internal class Program
{
    static void Main(string[] args)
    {
        DedektivBook DedektivBook = new DedektivBook(1, 2);
        DedektivBook.OverallPriceOfSehifeler();
        Console.WriteLine(DedektivBook.OverallPriceOfSehifeler());
        DedektivBook DedektivBook = new DedektivBook(2, 1);
        DedektivBook.OverallPriceOfSehifeler();
        Console.WriteLine(DedektivBook.OverallPriceOfSehifeler());
        MotivationBook MotivationBook = new MotivationBook(1, 3);
        MotivationBook.OverallPriceOfSehifeler();
        Console.WriteLine(MotivationBook.OverallPriceOfSehifeler());
    }
}



public abstract class Book
{
    protected int pricePerBook;
    protected int countofSehife; public abstract int OverallPriceOfSehifeler();
    public Book(int countOfSehife, int pricePerBook)
    {
        this.countofSehife = countOfSehife; this.pricePerBook = pricePerBook;
    }
}
public class DedektivBook : Book
{
    public override int OverallPriceOfSehifeler()
    {
        return countofSehife * pricePerBook;
    }
    public DedektivBook(int countOfSehife, int pricePerBook) : base(countOfSehife, pricePerBook)
    {
        this.countofSehife = countOfSehife;
        this.pricePerBook = pricePerBook;
    }
}

public class DedektivBook : Book
{
    public override int OverallPriceOfSehifeler()
    {
        return countofSehife * pricePerBook;
    }
    public DedektivBook(int countOfSehife, int pricePerBook) : base(countOfSehife, pricePerBook)
    {
        this.countofSehife = countOfSehife;
        this.pricePerBook = pricePerBook;
    }
}
public class FairytaleBook : Book
{
    public override int OverallPriceOfSehifeler()
    {
        return countofSehife * pricePerBook;
    }
    public FairytaleBook(int countOfSehife, int pricePerBook) : base(countOfSehife, pricePerBook)
    {
        this.countofSehife = countOfSehife;
        this.pricePerBook = pricePerBook;
    }
}

