using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

Console.WriteLine("Velkommen til mit program om global opvarmning!\nDu vil få 5 spørgsmål med en række svarmuligheder.\n\n");
StartQuiz(); 

static void StartQuiz()
{
    string input;
    int correctanswers;
    correctanswers = 0;

    Console.WriteLine("Spørgsmål 1: Hvordan påvirker klimaet temperaturen?\n1: Temperaturen ændrer sig ikke\n2: Temperaturen stiger\n3: Temperaturen stiger drastisk\n4: Temperaturen falder\n\nSkriv dit svar");
    input = "unanswered";
    while (true)
    {
        Console.Write("Er svarmulighed 1 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "n")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 2 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "j")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 3 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "j")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 4 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "n")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }

    Console.WriteLine("\nSpørgsmål 2: Hvad er status på isen på antarktis?\n1: Isen smelter\n2: Der kommer for meget is\n3: Global opvarmning påvirker isen\n4: Antarktis findes ikke\n\nSkriv dit svar");
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 1 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "j")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 2 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "n")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 3 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "j")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 4 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "n")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }

    Console.WriteLine("\nSpørgsmål 3: Hvad kan havforsurings følger være?\n1: Det kan ødelægge marine fødekæder\n2: Det kan have store konsekvenser\n3: Det har ingen konsekvenser\n4: Det kan bruges til at masseproducere atomvåben\n\nSkriv dit svar");
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 1 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "j")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 2 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "j")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 3 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "n")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 4 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "n")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }

    Console.WriteLine("\nSpørgsmål 4: Bliver Mars varmere?\n1: Ja, Mars bliver drastisk varmere\n2: Nej, Mars bliver drastisk koldere\n3: Mars er fritaget for temperatur\n4: Nej, der er ingen beviser for opvarming af Mars \n\nSkriv dit svar");
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 1 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "n")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 2 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "n")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 3 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "n")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 4 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "j")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }

    Console.WriteLine("\nSpørgsmål 5: Hvad skyldes global opvarmning?\n1: Faldene reproduktiv adfærd\n2: Høje benzinpriser\n3: Menneskeheden\n4: Satireprogrammer\n\nSkriv dit svar");
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 1 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "n")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 2 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "n")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 3 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "j")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }
    input = "unanswered";
    while (input.ToLower() != "j" || input.ToLower() != "n")
    {
        Console.Write("Er svarmulighed 4 korrekt? [j/n]");
        input = Console.ReadLine();
        if (input.ToLower() == "n")
        {
            correctanswers++;
        }
        if (input.ToLower() == "j" || input.ToLower() == "n")
        {
            break;
        }
    }

    Console.WriteLine($"\n\nDu havde {correctanswers}/20 rigtigt!\nKilde: https://skepticalscience.com/argument.php\n");
    if (correctanswers >= 16)
    {
        Console.WriteLine("Fantastisk arbejde!");
    }
    else if (correctanswers >= 12) 
    {
        Console.WriteLine("Godt arbejde!");
    }
    else
    {
        Console.WriteLine("Plads til at udvide din viden inden for global opvarmning");
    }

    while (true)
    {
        Console.WriteLine("Vil du åbne linket til kilden? [j/n]");
        input = Console.ReadLine();
    
        if (input.ToLower() == "j")
        {
            var uri = "https://skepticalscience.com/argument.php";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
            Console.WriteLine("\nGod læsning! Tak for at bruge mit program :)");
            break;
        }
        if (input.ToLower() == "n")
        {
            while (true)
            {
                Console.WriteLine("Vil du prøve quizzen igen? [j/n]");
                input = Console.ReadLine();
                if (input.ToLower() == "j")
                {
                    StartQuiz();
                    break;
                }
                if (input.ToLower() == "n")
                {
                    Console.WriteLine("\nTak for at bruge mit program! :)");
                    break;
                }
            }
            break;
        }
    }
}