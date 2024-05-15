using System;
using System;
using System.Diagnostics;

public class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;

    public DateTime StartTime
    {
        get { return startTime; }
    }

    public DateTime EndTime
    {
        get { return endTime; }
    }

    public StopWatch()
    {
        startTime = DateTime.Now;
    }

    public void Start()
    {
        startTime = DateTime.Now;
    }

    public void Stop()
    {
        endTime = DateTime.Now;
    }

    public double GetElapsedTime()
    {
        TimeSpan interval = endTime - startTime;
        return interval.TotalMilliseconds;
    }
}

class Program
{
    static void Main()
    {
        // Create an array of 100,000 numbers to sort
        int[] numbers = new int[100000];
        Random rand = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(100000);
        }

        // Create a Stopwatch object
        StopWatch stopwatch = new StopWatch();

        // Start the stopwatch
        stopwatch.Start();

        // Perform selection sort
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = numbers[minIndex];
            numbers[minIndex] = numbers[i];
            numbers[i] = temp;
        }

        // Stop the stopwatch
        stopwatch.Stop();

        // Output the elapsed time
        Console.WriteLine($"Elapsed time: {stopwatch.GetElapsedTime()} ms");
    }
}
