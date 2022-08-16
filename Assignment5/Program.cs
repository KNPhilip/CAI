static void DisplayMenu()
{
    Console.WriteLine("Hvad vil du nu?\nA: Se alt indhold i din tekstfil\nB: Skriv og gem noget i tekstfilen\nC: Afslut programmet");
    string input = Console.ReadLine();
    if (input == "a" || input == "A")
    {
        DisplayTextFileContet();
    }
    if (input == "b" || input == "B")
    {
        AddContentToTextFile();
    }
    if (input == "c" || input == "C")
    {
    }
    else
    {
        DisplayMenu();
    }
}
static void DisplayTextFileContet()
{
    string text = System.IO.File.ReadAllText(@"C:\Users\phil5520\Desktop\Softwarekonstruktion\S2\Kompetencetest Resultat.txt");
    Console.WriteLine($"\nHer er indholdet i din tekstfil:\n{text}\n\nSLUT\n");
}
static void AddContentToTextFile()
{
    Console.WriteLine("\nSkriv noget tekst der skal gemmes");
    string input = Console.ReadLine();
    File.AppendAllText(@"C:\Users\phil5520\Desktop\Softwarekonstruktion\S2\Kompetencetest Resultat.txt", $"\n{input}");
    Console.WriteLine("\nSå er det blevet gemt!\n");
}
{
    Console.WriteLine("Velkommen til mit program!");
    DisplayMenu();
}