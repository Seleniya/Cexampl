Console.Write("Как вас зовут?");
string username = Console.ReadLine()!;

if(username == "Маша")
{
    Console.WriteLine("Супер! Это Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
