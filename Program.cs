using System;
using System.Threading;

class Ali
{
    public static void Main()
    {
        Console.WriteLine("This program prints the output of a multi-threaded program that runs concurrently with the Main thread.");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        Console.WriteLine("Main Started.");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        Thread T1 = new Thread(Thread1);
        T1.Start();

        if (T1.Join(10))
        {
            Console.WriteLine("Thread 1 has Executed Successfully in 10ms.");
        }
        else
        {
            Console.WriteLine("Times Up! The Main Program is not Waiting for Thread 1 Anymore!");
        }
        
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        Thread T2 = new Thread(Thread2);
        T2.Start();

        if (T1.Join(10))
        {
            Console.WriteLine("Thread 2 has Executed Successfully in 10ms.");
        }
        else
        {
            Console.WriteLine("Times Up! The Main Program is not Waiting for Thread 2 Anymore!");
        }

        Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        Console.WriteLine("Main Ended.");
    }

    public static void Thread1()
    {
        Console.WriteLine("Thread 1 Function Print");
    }

    public static void Thread2()
    {
        Console.WriteLine("Thread 2 Function Print");
    }
}