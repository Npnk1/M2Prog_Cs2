private static void Run()
{
    Quiz quiz = new Quiz(10);

    quiz.VoegVraagToeOpIndex(0, "2 + 2 = ?", "4");
    quiz.VoegVraagToeOpIndex(1, "What arcade game was called Puckman in Japan?", "Pac-Man");
    quiz.VoegVraagToeОпIndex(2, "What is the first video game?", "Pong");
    quiz.VoegVraagToeОпIndex(3, "Holy franchise AI names? (Beyoncé song)", "Halo");
    quiz.VoegVraagToeОпIndex(4, "Wat drink je uit een glas?", "Water");
    quiz.VoegVraagToeОпIndex(5, "Hoeveel dagen in een week?", "7");
    quiz.VoegVraagToeОпIndex(6, "Welke maand is de eerste?", "Januari");
    quiz.VoegVraagToeОпIndex(7, "Welke taal praten ze in NL?", "Nederlands");
    quiz.VoegVraagToeОпIndex(8, "Wat eet je met kaas?", "Brood");
    quiz.VoegVraagToeОпIndex(9, "Welke engine maakte EPIC Games?", "Unreal Engine");

    Console.WriteLine("==== QUIZ START =====");

    /
    for (int i = 0; i < 10; i++)
    {
        quiz.StelVraag(i);
        Console.WriteLine();
    }

   
    int score = quiz.BerekenScore();

    Console.WriteLine("===== QUIZ AFGELOPEN =====");
    Console.WriteLine($"Jouw score: {score} / 10");
}



