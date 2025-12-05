class QuizVraagAntwoord
{
    internal QuizVraag vraag;
    internal bool goed;

    
    internal QuizVraagAntwoord()
    {

    }

    
    internal QuizVraagAntwoord(QuizVraag vraag, bool goed)
    {
        this.vraag = vraag; 
        this.goed = goed;
    }
}
