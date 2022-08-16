static void MyMethod(int input1, int input2)
{
    Console.WriteLine("Regneart: plus");
    Console.WriteLine($"{input1 + input2}");
    Console.WriteLine("Regneart: minus");
    Console.WriteLine($"{input1 - input2}");
    Console.WriteLine("Regneart: gange");
    Console.WriteLine($"{input1 * input2}");
    Console.WriteLine("Regneart: divider");
    Console.WriteLine($"{input1 / input2}");
    Console.WriteLine("Regneart: modulus");
    Console.WriteLine($"{input1 % input2}");
}

{
    Console.WriteLine("Indtast et tal");
    int input1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Indtast næste tal");
    int input2 = Convert.ToInt32(Console.ReadLine());
    MyMethod(input1, input2);
}