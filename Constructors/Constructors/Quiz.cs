class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;

    internal Quiz()
    {
    }

    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen];
        ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
    }

    internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        vragen[index] = vraag;
    }

    internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        QuizVraag nieuweVraag = new QuizVraag(vraag, antwoord);
        VoegVraagToeOpIndex(index, nieuweVraag);
    }

   
    internal int BerekenScore()
    {
        int score = 0;

        for (int i = 0; i < ingevuldeAntwoorden.Length; i++)
        {
            if (ingevuldeAntwoorden[i] != null && ingevuldeAntwoorden[i].goed)
            {
                score++;
            }
        }

        return score;
    }

  
    internal void StelVraag(int index)
    {
        QuizVraag vraag = vragen[index];

        QuizVraagAntwoord quizVraagAntwoord = new QuizVraagAntwoord(vraag);

        Console.WriteLine(vraag.vraag);

        string spelerAntwoord = Console.ReadLine();

        if (spelerAntwoord.ToLower().Trim() == vraag.antwoord.ToLower().Trim())
        {
            quizVraagAntwoord.goed = true;
            Console.WriteLine("Goed! ✔");
        }
        else
        {
            quizVraagAntwoord.goed = false;
            Console.WriteLine($"Fout! ✘ Het juiste antwoord was: {vraag.antwoord}");
        }

        ingevuldeAntwoorden[index] = quizVraagAntwoord;
    }
}


