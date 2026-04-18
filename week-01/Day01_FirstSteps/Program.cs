//======================
//== C# Variables and Types ==
//======================

using System.ComponentModel;

int yas = 21; // 32-bit
long numara = 0535000112233L; // 64-bit : "L" suffix'i önemli long'u belirtmek için
short bakiye = 1000; // 16-bit
byte zar = 6; // 8-bit (unsigned)


float sicaklik = 35.5f; // 32-bit : "f" suffix'i önemli float için
double pi = 3.14159265359; // 64-bit : varsayılan ondalık tipi
decimal metrekare = 176.95m; // 128-bit : "m" suffix'i önemli


bool isActive = true; 
char gender = 'F'; //tek karakter tek tırnak
string name = "Cafer"; // çift tırnak

Console.WriteLine($"Name: {name}, Age: {yas}, Gender: {gender}");
Console.WriteLine($"No: {numara}, Balance: {bakiye}, Chance: {zar}");
Console.WriteLine($"PI: {pi}, Active?: {isActive}, Flat: {metrekare}, Temperature: {sicaklik}");


int a = 7;
int b = 3;
float c = 11.0f;
float d = 4.0f;

Console.WriteLine($"{a} / {b} = " + a/b);
Console.WriteLine($"a/b={a/b}");
Console.WriteLine($"{c} / {d} = " + c/d);
Console.WriteLine($"c/d={c/d}");


//======================
//== "var" type usage ==
//======================

var city = "Eskisehir"; // string
var population = 81_000_000; // int (underscore for more readability)
var point = 9.8; // double
var isCapital = false; // boolean

Console.WriteLine($"City:{city}, Population:{population:N0}, Point:{point}, Capital?: {isCapital}");
// population:N0 make is readable.
// "var" should be used when the data type is specified such as "var number = 253
// if type is can not understandable such as "var data = GetData()" it shouldn't be used

var message = "Otobotlara selam olsun";
Console.WriteLine(message.GetType().Name); // type is string.


//======================
//======= String =======
//======================

string ad = "Taha";
string soyad = "Aktaş";
int dateOfBirth = 2004;

// String concatenate
string wellcome = "Wellcome " + ad + ", how are you?";
string fullName = $"{ad} {soyad}";
Console.WriteLine(fullName);

//String methods
Console.WriteLine(ad.ToUpper()); // Taha becomes TAHA
Console.WriteLine(ad.ToLower()); // Taha becomes taha
Console.WriteLine(fullName.Length); // returns int number of character
Console.WriteLine(fullName.Contains("taha")); // Case sensitive, returns boolean
Console.WriteLine(fullName.Replace("Taha", "Mustafa"));

var currentYear = 2026;
Console.WriteLine($"{ad}, is {currentYear - dateOfBirth} years old right now!");

//Format specifier
double fiyat = 159.55679;
Console.WriteLine($"Fiyat: {fiyat:F2} TL"); // F2 ile noktadan sonraki 2 basamağı aldık
Console.WriteLine($"fiyat: {fiyat:C}"); // currency format

// Multi-line string
string address = @"Hürriyet mahallesi
Esenköy bulvarı
Şanzelize,
Alamanya.";
Console.WriteLine($"Your adress is: {address}");