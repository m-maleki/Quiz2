#region Question 1 
// Correct option : 3

int dayOfWeek = 4;
switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Saturday");
        break;
    case 2:
        Console.WriteLine("Sunday");
        break;
    case 3:
        Console.WriteLine("Monday");
        break;
    case 4:
        Console.WriteLine("Tuesday");
        break;
    case 5:
        Console.WriteLine("Wednesday");
        break;
    case 6:
        Console.WriteLine("Thursday");
        break;
    case 7:
        Console.WriteLine("Friday");
        break;

    default:
        Console.WriteLine("Friday");
        break;
}

#endregion
#region Question 2
// Correct option : 4

while (!true)
{
    // It  never be executed
}

while (!(1 != 0))
{
    // It  never be executed
}

// while() // syntax error

#endregion
#region Question 3
// Correct option : 3

string exp = "program";
var option1Q3 = exp[6];  // output : m
var option2Q3 = exp.IndexOf('m'); // output : 6
var option3Q3 = exp.Substring(7); // output : EmptyString

#endregion
#region Question 4
// Correct option : 4

var question4 = Math.Pow(3, 4); // output = 81

#endregion
#region Question 5
// Correct option : 4

string question5 = "your age is : 25 and you height is : 178";
int a = 25;
int b = 178;
var option1Q5 = string.Format("your age is : {0} and your height is : {1}", a, b); // output : "your age is : 25 and your height is : 178"
var option2Q5 = $"your age is : {a} and your height is : {b}";  // output : "your age is : 25 and your height is : 178"
var option3Q5 = "your age is : " + "a" + "and your height is : " + "b"; // output : "your age is : aand your height is : b"
var option4Q5 = string.Concat("your age is : ", a.ToString(), " and your height is : ", b.ToString());  // output : "your age is : 25 and your height is : 178"

#endregion
#region Question 6
// Correct option : 2

int[] numbersQ6 = new int[] { 122, 564, 221, 13, 270, 8 };
foreach (var number in numbersQ6)
{
    //Even Or Odd method (number)
}

#endregion
#region Question 7
// Correct option : 3

var question7 = 35 == 7 * 5 ? "Hello " : "GoodBuy "; // output : "Hello 

#endregion
#region Question 8
// Correct option : 3

Array.Sort(numbersQ6); // Sort Array
Array.Fill(numbersQ6, 6); // 6,6,6,6,6,6
//Array.Length(numbersQ5); syntax error

#endregion
#region Question 9
// Correct option : 3

double? num1 = 5.5;
var num3 = num1 ?? 3.14; // output : 5.5

#endregion
#region Question 10
// Correct option : 2

int[] Question10 = new int[5] { 8, 8, 4, 2, 7 };
var resultQ10 = Question10[1] + Question10[2] / Question10[3]; //  (8 / 4) + 8 = 10

#endregion
#region Question 11
// Correct option : 4

char[] mychars = new char[5] { 'd', 'h', 't', 'e', 'p' };
string myword = "tusday";
var resultQ11 = mychars.Length != myword.Length ? myword : "wrong"; // output : tusday

#endregion
#region Question 12
// Correct option : 4

int[] nums = new int[3] {10,50,16};
nums[2] = 40;

#endregion
#region Question 13
// Correct option : 1

bool? isValid = null;

#endregion
#region Question 14
// Correct option : 3
do
{

} while (false);

#endregion
#region Question 15
// Correct option : 2

string company = "MaKtAbShArIf";
string normalizeCompany = company.ToLower();

#endregion
#region Question 16
// Correct option : 1

while (2<10)
{
    // Infinite loop
}

#endregion
