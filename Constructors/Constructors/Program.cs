private static void Run()
{
    Quiz quiz = new Quiz(10);

  
    QuizVraag q0 = new QuizVraag("2 + 2 = ?", "4");
    quiz.VoegVraagToeOpIndex(0, q0);

   
    quiz.VoegVraagToeOpIndex(1, "What arcade game was called Puckman in Japan?", "Answer: Pac-Man");
    quiz.VoegVraagToeOpIndex(2, "What is thought to be the first video game, created in 1958 and becoming popular in the 1970s?", "Pong");
    quiz.VoegVraagToeOpIndex(3, "Mendicant Bias and Offensive Bias are fictional AIs in what "holy" video game franchise that shares its name with a Beyonce´ song?", " Halo");
    quiz.VoegVraagToeOpIndex(4, "Wat drink je uit een glas?", "Water");
    quiz.VoegVraagToeOpIndex(5, "Hoeveel dagen in een week?", "7");
    quiz.VoegVraagToeOpIndex(6, "Welke maand is de eerste?", "Januari");
    quiz.VoegVraagToeOpIndex(7, "Welke taal praten ze in NL?", "Nederlands");
    quiz.VoegVraagToeOpIndex(8, "What is the name of the twin brother of Solid Snake, the protagonist of the Metal Gear franchise?", "Liquid Snake");
    quiz.VoegVraagToeOpIndex(9, "The company that created Fortnite, EPIC, also created a game engine that is licensed to other game creators named what?", "Unreal Engine");


    
}


