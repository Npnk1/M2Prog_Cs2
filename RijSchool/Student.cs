internal class Student
{
    internal string naam = string.Empty;
    internal int leeftijd;
    internal LesPakket lesPakket = new();
    internal RijLeraar? leraar;
    internal TheorieTest? theorieTest;
    internal RijTest? rijTest;
}
