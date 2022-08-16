Console.WriteLine("Velkommen til mit program :)");
List<Movie> movies = UpdateMovies();
StartMenu(movies);

static List<Movie> UpdateMovies()
{
    List<Movie> updatedMovies = new List<Movie>();

    string[] Movies = File.ReadAllLines(@"C:\Users\phil5520\Desktop\Softwarekonstruktion\S2\Movies.txt");
    for (int i = 0; i < Movies.Length; i++)
    {
        string[] items = Movies[i].Split(",");
        Movie m = new() { Title = items[0], ReleaseYear = Convert.ToInt32(items[1]), Director = items[2], Studio = items[3] };
        updatedMovies.Add(m);
    }
    return updatedMovies;
}

static void StartMenu(List<Movie> movies)
{
    Console.WriteLine("\nHvordan vil du fortsætte?\nA: Lav og gem en ny film\nB: Se alle film\nC: Søg på en films titel\nD: Afslut programmet");
    string input = Console.ReadLine();
    if (input == "A" || input == "a")
    {
        NewMovie(movies);
    }
    if (input == "B" || input == "b")
    {
        ViewAllMovies(movies);
    }
    if (input == "C" || input == "c")
    {
        SearchMovieByTitle(movies);
    }
    if (input == "D" || input == "d")
    {
        Console.WriteLine("Farvel :)");
    }
    else
    {
        StartMenu(movies);
    }
}

static void NewMovie(List<Movie> movies)
{
    Console.WriteLine("\nSkriv titlen på filmen");
    string MovieTitle = Console.ReadLine();
    Console.WriteLine("\nSkriv årstallet filmen blev udgivet i");
    int MovieReleaseYear = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nSkriv filminstruktørens navn");
    string MovieDirector = Console.ReadLine();
    Console.WriteLine("\nSkriv filmselskabets navn");
    string MovieCompany = Console.ReadLine();

    File.AppendAllText(@"C:\Users\phil5520\Desktop\Softwarekonstruktion\S2\Movies.txt", $"\n{MovieTitle}, {MovieReleaseYear}, {MovieDirector}, {MovieCompany}");
    Movie m = new() { Title = MovieTitle, ReleaseYear = MovieReleaseYear, Director = MovieDirector, Studio = MovieCompany };
    movies.Add(m);
    Console.WriteLine("\nSå er det blevet gemt!\n");
}

static void ViewAllMovies(List<Movie> movies)
{
    Console.WriteLine("\nListe over alle film:");
    foreach (var movie in movies)
    {
        Console.WriteLine($"Titel: {movie.Title}\nUdgivelsesår: {movie.ReleaseYear}\nInstruktør: {movie.Director}\nFilmselskab: {movie.Studio}\n");
    }
}

static void SearchMovieByTitle(List<Movie> movies)
{
    Console.WriteLine("Hvilken titel vil du søge efter?");
    string input = Console.ReadLine();
    for (int i = 0; i < movies.Count; i++)
    {
        if (movies[i].Title.ToLower().Contains(input.ToLower()))
        {
            Console.WriteLine($"Fundet!\n\nTitel: {movies[i].Title}\nUdgivelsesår: {movies[i].ReleaseYear}\nInstruktør: {movies[i].Director}\nFilmselskab: {movies[i].Studio}");
        }
        else
        {
            Console.WriteLine("\nJeg fandt ikke noget :(");
            break;
        }
    }
}

public class Movie
{
    private string title;
    private int releaseYear;
    private string director;
    private string studio;

    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            if (value == "." || value == "#")
            {
                throw new ArgumentException("Ikke tilladt titelnavn");
            }
            Title = value;
        }
    }
    public int ReleaseYear
    {
        get
        {
            return releaseYear;
        }
        set
        {
            if (value < 1000)
            {
                throw new ArgumentException("Ugyldigt input");
            }
            ReleaseYear = value;
        }
    }
    public string Director
    {
        get
        {
            return director;
        }
        set
        {
            if (value == "2")
            {
                throw new ArgumentException("Ugyldigt input");
            }
            Director = value;
        }
    }
    public string Studio
    {
        get
        {
            return studio;
        }
        set
        {
            if (value == "2")
            {
                throw new ArgumentException("Ugyldigt input");
            }
            Studio = value;
        }
    }
}