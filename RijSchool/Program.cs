using System;

class Program
{
    static void Main()
    {
        Program program = new Program();
        program.Run();
    }

    void Run()
    {
        
        Auto auto1 = new Auto()
        {
            automaat = true,
            merk = "volkswagen",
            kenteken = "AA824H",
            kilometerStand = 20567
        };

        Auto auto2 = new Auto()
        {
            automaat = false,
            merk = "volvo",
            kenteken = "KU786G",
            kilometerStand = 65739
        };

        
        RijLeraar rijLeraar = new RijLeraar()
        {
            naam = "John",
            leeftijd = 30,
            zzp = false
        };

        
        LesPakket lesPakket = new LesPakket()
        {
            automaat = true,
            urenGekocht = 30,
            urenVerbruikt = 10,
            examenPogingen = 0
        };

        TheorieTest theorieTest = new TheorieTest()
        {
            aantalFouten = 0,
            gehaald = false,
            afnameDatum = DateTime.MinValue
        };

        RijTest rijTest = new RijTest()
        {
            gehaald = false,
            afnameDatum = DateTime.MinValue
        };

        
        Student student1 = new Student()
        {
            naam = "Wanda",
            leeftijd = 19,
            lesPakket = lesPakket,
            leraar = rijLeraar,
            theorieTest = theorieTest,
            rijTest = rijTest
        };

        Student student2 = new Student()
        {
            naam = "Mark",
            leeftijd = 21,
            lesPakket = lesPakket,
            leraar = rijLeraar,
            theorieTest = theorieTest,
            rijTest = rijTest
        };

        
        LesUur lesUur1 = new LesUur()
        {
            tijd = 1130,
            auto = auto1,
            rijLeraar = rijLeraar,
            student = student1
        };

        LesUur lesUur2 = new LesUur()
        {
            tijd = 1230,
            auto = auto2,
            rijLeraar = rijLeraar,
            student = student2
        };

        
        Dag dag = new Dag()
        {
            datum = DateTime.Now,
            lesuren = new LesUur[] { lesUur1, lesUur2 }
        };

        
        Console.WriteLine("Debug hier");
    }
}
