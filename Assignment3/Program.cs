bool win;
win = false;
while (win == false)
{
    Random rnd = new Random();
    int count = rnd.Next(1, 10);
    Console.WriteLine("Indtast et tal, og se om du kan ramme det rigtige tal fra 1 til 10");
    int result = Convert.ToInt32(Console.ReadLine());
    if (result == count)
    {
        win = true;
        Console.WriteLine("Du vandt!");
    }
    else
    {
        Console.WriteLine("Prøv igen..");
    }
}