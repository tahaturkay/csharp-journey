Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your surname: ");
string surName = Console.ReadLine();

int dateOfBirth;
while (true)
{
    Console.Write("Enter your birth year: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out dateOfBirth))
    {
        break;  // Geçerli girdi, döngüden çık
    }
    Console.WriteLine("Invalid input, please try again.");
}


Console.Write("Enter your job: ");
string job = Console.ReadLine();

Console.Write("Enter your city: ");
string city = Console.ReadLine();

string mail;
while (true)
{
    Console.Write("Enter your e-mail: ");
    mail = Console.ReadLine();
    if(mail.Contains("@") && mail.Contains("."))
    {
        break;
    }
    Console.WriteLine("This e-mail format is not valid.");
}

string fullName = $"{name} {surName.ToUpper()}";
int currentYear = DateTime.Now.Year;
int age = currentYear - dateOfBirth;

Console.WriteLine("==============================");
Console.WriteLine("========   Cardvisit  ========");
Console.WriteLine("==============================");
Console.WriteLine($"Fullname:    {fullName}");
Console.WriteLine($"Age:         {age}");
Console.WriteLine($"Job: {job}");
Console.WriteLine($"City:        {city}");
Console.WriteLine($"E-mail:      {mail}");
