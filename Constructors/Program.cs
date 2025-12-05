class Program
{
    static void Main()
    {
        Run();
    }

    private static void Run()
    {
        
        QuizVraag quizVraag = new QuizVraag("Wat is de hoofdstad van Nederland?", "Amsterdam");

       
        Quiz quiz = new Quiz();
        quiz.vragen = new QuizVraag[] { quizVraag };
        quiz.ingevuldeAntwoorden = new QuizVraagAntwoord[1];

       
        quiz.ingevuldeAntwoorden[0] = new QuizVraagAntwoord(quizVraag, true);
    }
}
class QuizVraag
{
    internal string vraag;
    internal string antwoord;

    
    internal QuizVraag(string vraag, string antwoord)
    {
        this.vraag = vraag;        
        this.antwoord = antwoord;   
    }
}
class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;
}
class QuizVraagAntwoord
{
    internal QuizVraag vraag;
    internal bool goed;

    
    internal QuizVraagAntwoord(QuizVraag vraag, bool goed)
    {
        this.vraag = vraag;
        this.goe d = goed;
    }
}
