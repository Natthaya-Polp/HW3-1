using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<char> Input = new Queue<char>();
        Queue<char> Output = new Queue<char>();
        Start(Input, Output);
    }

    static void Start( Queue<char> Input, Queue<char> Output )
    {
        char start = 'x';
        
        while (start == 'x' || start == 'J' || start == 'G' || start == 'O' || start == 'R' )
        {
            char input = char.Parse(Console.ReadLine());
            Input.Push(input);

            if ( input == 'J' )
            {
                JasmineCondition(Input, Output);
            }
            else if ( input == 'G' )
            {
                GlobeAmaranthCondition(Input, Output);
            }
            else if ( input == 'O' )
            {
                OrchidCondition(Input, Output);
            }
            else if ( input == 'R' )
            {
                RoseCondition(Input, Output);
            }
            else
            {
                Print(Output);
            }
        }
    }

    static void JasmineCondition( Queue<char> Input, Queue<char> Output )
    {
        int i = Input.GetLength();

        if ( Input.Get(i-1) == 'R' )
        {
            if ( Input.Get(i-2) == 'J' )
            {
                Console.Write("Invalid pattern.\n");
                Start(Input, Output);
            }
            else
            {
                Output.Push('J');
            }
        }
        else
        {
            Output.Push('J');
        }
    }

    static void GlobeAmaranthCondition( Queue<char> Input, Queue<char> Output )
    {
        int i = Input.GetLength();
        
        if ( Input.Get(i-1) == 'R' )
        {
            if ( Input.Get(i-2) == 'G' )
            {
                Console.Write("Invalid pattern.\n");
                Start(Input, Output);
            }
            else
            {
                Output.Push('G');
            }
        }

        if ( Input.Get(i-2) == 'G' && Input.Get(i-3) == 'G' && Input.Get(i-4) == 'G' )
        {
            Console.Write("Invalid pattern.\n");
            Start(Input, Output);
        }
        else
        {
            Output.Push('G');
        }
    }

    static void OrchidCondition( Queue<char> Input, Queue<char> Output )
    {
        int i = Input.GetLength();
        
        if ( Input.Get(i-1) == 'R' )
        {
            if ( Input.Get(i-2) == 'O' )
            {
                Console.Write("Invalid pattern.\n");
                Start(Input, Output);
            }
            else
            {
                Output.Push('O');
            }
        }
        else
        {
            Output.Push('O');
        }
    }

    static void RoseCondition( Queue<char> Input, Queue<char> Output )
    {
        int i = Input.GetLength();
        
        if ( i == 1 )
        {
            Console.Write("Invalid pattern.\n");
            Start(Input, Output);
        }
        else
        {
            Output.Push('R');
        }
    }

    static void Print(Queue<char> Output)
    {
        for ( int i = 0; i < Output.GetLength(); i++)
        {
            Console.Write(Output.Get(i));
        }

        Console.ReadLine();
    }
}