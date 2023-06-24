Console.Write ("Введите имя: ");
string? username = Console.ReadLine();
if (username?.ToLower() == "aleks")
{
    Console.WriteLine ("Уррааа, " + username.ToUpper());
}
else
{
    Console.WriteLine ("Приветик, " + username);
}