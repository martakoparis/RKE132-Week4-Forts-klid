
Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine($"cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess, enter number one to three.");

    int userNymber = Int32.Parse(Console.ReadLine());

    if (userNymber = cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("oops, try again.");
    }
   
}

Console.WriteLine("Have a nice day");
