using System.Collections.Generic;

Questions question1 = new()
{
    Question = "Spørgsmål 1: Hvordan påvirker klimaet temperaturen?\n",
    Choices = new[] { "1. Temperaturen ændrer sig ikke\n", "2. Temperaturen stiger\n", "3. Temperaturen stiger drastisk\n", "4. Temperaturen falder\n" },
    Answers = new[] { false, true, true, false }
};
Questions question2 = new()
{
    Question = "Spørgsmål 2: Hvad er status på isen på antarktis?\n",
    Choices = new[] { "1. Isen smelter\n", "2. Der kommer for meget is\n", "3. Global opvarmning påvirker isen\n", "4. Antarktis findes ikke\n"},
    Answers = new[] { true, false, true, false }
};
Questions question3 = new()
{
    Question = "Spørgsmål 3: Hvad kan havforsurings følger være?\n",
    Choices = new[] { "1. Det kan ødelægge marine fødekæder\n", "2. Det kan have store konsekvenser\n", "3. Det har ingen konsekvenser\n", "4. Det kan bruges til at masseproducere atomvåben\n" },
    Answers = new[] { true, true, false, false }
};
Questions question4 = new()
{
    Question = "Spørgsmål 4: Bliver Mars varmere?\n",
    Choices = new[] { "1. Ja, Mars bliver drastisk varmere\n2. Nej, Mars bliver drastisk koldere\n3. Mars er fritaget for temperatur\n4. Nej, der er ingen beviser for opvarming af Mars\n" },
    Answers = new[] { false, false, false, true }
};
Questions question5 = new()
{
    Question = "Spørgsmål 5: Hvad skyldes global opvarmning?\n",
    Choices = new[] { "1. Faldene reproduktiv adfærd\n", "2. Høje benzinpriser\n", "3: Menneskeheden\n", "4: Satireprogrammer\n" },
    Answers = new[] { false, false, true, false }
};

AskQuestions(question1);

static void AskQuestions(List<Questions> questions)
{

}

public class Questions
{
    public string Question { get; set; }
    public string[] Choices { get; set; }
    public bool[] Answers { get; set; }
}