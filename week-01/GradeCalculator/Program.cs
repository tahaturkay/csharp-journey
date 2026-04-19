// Note Calculator

int courseCount;
while (true)
{
    Console.Write("How many courses do you have?: ");
    string input = Console.ReadLine();
    if(int.TryParse(input, out courseCount) && courseCount > 0)
    {
        break;
    }
    Console.WriteLine("Enter valid number of courses!");
}

string[] courseNames = new string[courseCount];
int[] midtermGrades = new int[courseCount];
int[] finalGrades = new int[courseCount];
double[] averages = new double[courseCount];

for(int i=0; i < courseCount; i++) // Array fillers
{   
    // Course names initializer
    Console.Write("Enter course name: "); 
    string courseName = Console.ReadLine();
    courseNames[i] = courseName;

    // Midterm grades initializer
    while (true)
    {
        Console.Write("Enter your midterm note: ");
        string midtermInput = Console.ReadLine();
        if(int.TryParse(midtermInput, out int midtermGrade) && midtermGrade <= 100 && midtermGrade >= 0)
        {
            midtermGrades[i] = midtermGrade;
            break;
        }
        Console.WriteLine("Enter a valid grade!");
    }

    // Final grades initializer
    while (true)
    {
        Console.Write("Enter your final note: ");
        string finalInput = Console.ReadLine();
        if(int.TryParse(finalInput, out int finalGrade) && finalGrade <= 100 && finalGrade >= 0)
        {
            finalGrades[i] = finalGrade;
            break;
        }
        Console.WriteLine("Enter a valid grade!");
    }

    // Averages initializer
    averages[i] = (midtermGrades[i]*0.4) + (finalGrades[i]*0.6);
}

for (int i = 0; i < courseCount; i++)
{
    string letterGrade = averages[i] switch
    {
        >= 90 => "AA",
        >= 85 => "BA",
        >= 80 => "BB",
        >= 75 => "CB",
        >= 70 => "CC",
        >= 65 => "DC",
        >= 60 => "DD",
        _ => "FF"
    };
    
    Console.WriteLine($"{courseNames[i]}: {averages[i]:F2} -> {letterGrade}");
}