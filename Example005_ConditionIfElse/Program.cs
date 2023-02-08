Console.Write("Enter user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
    Console.WriteLine("Hey!! Masha here!!");
}
else
{
    Console.Write($"Hi! {username}");
}