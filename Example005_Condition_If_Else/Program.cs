Console.Write ("Введите имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine ("Уррааа, " + username.ToUpper());
}
else
{
    Console.WriteLine ("Привет, " + username);
}