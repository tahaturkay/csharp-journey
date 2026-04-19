// if-else

using System.Drawing;

Console.Write("Enter your age: ");
int yas = int.Parse(Console.ReadLine()); // Try to use "TryParse" it is healthier.

if (yas < 0)
{
    Console.WriteLine("Invalid age");
}
else if(yas < 18)
{
    Console.WriteLine("Child");
}
else if(yas < 65)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Old");
}

// Ternary operations

bool hasLicence = yas>=18;
string message = hasLicence ? "You can have licence" : "You can't have licence";
Console.WriteLine($"Status: {message}");

// Logic operations
int exam1 = 50;
int exam2 = 75;
bool satisfiedAttendance = true;

if(satisfiedAttendance && exam1 > 40 && exam2 > 40)
{
    Console.WriteLine("You passed!"); // I wish real life was easy as it is.
}
if((satisfiedAttendance && exam1>60) || exam2 > 70)
{
    Console.WriteLine("You can apply for assistanship!");
}
// Short-circuit evaluation is, when left part is satisfied and no need to check rest, system just skips it.
// It will be used in null referance exceptions later.


// Switch statment

int day;
while (true)
{
    Console.Write("Day number (1-7): ");
    string dayEntered = Console.ReadLine();
    if(int.TryParse(dayEntered, out day))
    {
        if(day >= 1 && day <= 7)
        {
            break;
        }
        Console.WriteLine("Please enter valid day number");
    }
    else
    {
        Console.WriteLine("Please enter valid format(number)");
    }
}
Console.WriteLine($"Day: {day}"); // Testing TryParse

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tueasday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
    case 7:
        Console.WriteLine("Weekend");
        break;
    default:
        Console.WriteLine("Invalid Day");
        break;
}

// Modern switch

string dayName = day switch // it assigned to a variable (in classic switch we can't do that)
{
    1 => "Monday", // "=>" is a lambda
    2 => "Tuesday",
    3 => "Wednesday",
    4 => "Thursday",
    5 => "Friday",
    6 or 7 => "Weekend", // we combined 6 and 7 with "or"
    _ => "Invalid Day"
};
Console.WriteLine($"Day: {dayName}");

// Switch with pattern matching < , > , <=, >=
double temperature;
while (true)
{
    Console.Write("Enter temperature: ");
    string tempInput = Console.ReadLine();
    if (double.TryParse(tempInput, out temperature))
    {
        break;
    }
    Console.WriteLine("Please enter valid format!");
}

string status = temperature switch
{
    <  0           => "It is freezing outside.",
    >= 0 and < 10  => "It's cold careful",
    >= 10 and < 20 => "Weather is okay",
    >= 20 and < 30 => "Simply lovely",
    >  30          => "It's like a hell!!",
    _              => "no data"
};
Console.WriteLine($"Status: {status}");

// For loops

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
for (int i = 10; i > 1; i--)
{
    Console.WriteLine(i);
}
for (int i = 0; i < 20; i += 2)
{
    Console.WriteLine(i);
}

// While loops

int number = 1;
while(number < 5)
{
    Console.WriteLine($"i = {i}");
    i++;
}

int validInput;
while (true)
{
    Console.Write("Enter a number(0-100): ");
    string input = Console.ReadLine();
    if(int.TryParse(input, out validInput) && validInput >= 0 && validInput <= 100)
    {
        break;
    }
    Console.WriteLine("Please enter a valid number!");
}
Console.WriteLine($"Number: {validInput}");

// do-While loop (it usually used for menu systems and game loops)

string answer;
do
{
    Console.Write("Do you want to continue?: ");
    answer = Console.ReadLine().ToLower();
}while(answer == 'y');
Console.WriteLine("Terminated.");

// foreach loop (it only reads the elements no indexing)

string[] fruits = {"apple", "pineapple", "banana", "peach"};
foreach(string fruit in fruits)
{
    Console.WriteLine($"Fruit: {fruit}");
}

string hello = "Hello !";
foreach(char character in hello)
{
    Console.WriteLine($"Char: {character}");
}