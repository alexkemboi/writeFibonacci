using System;
class Program
{
    static int[] writeFibonacciSeries(int noOfTerms)
    {
        int[] Series = new int[noOfTerms];
        int firstTerm = 1;
        int secondTerm =1;
        Series[0] = firstTerm;
        Series[1] = secondTerm;
        int nextTerm = 0;
        for (int i = 2; i < noOfTerms; i++)
        {
            nextTerm = firstTerm + secondTerm;
            Series[i] = nextTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
        return Series;
    }
    static void Main(string[] args)
    {
        int noOfTerms = 0;
        Console.WriteLine("Enter the legth of fibonancci series");
        noOfTerms=Convert.ToInt32(Console.ReadLine());
        int[] solution = writeFibonacciSeries(noOfTerms);
        foreach (int i in solution)
        {
            Console.Write(i+" ");
        }
    }
}