using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
// To Test Any Task Remove "//" but not "//-"<=comment!
// Done Test All Tasks In 3 Different Parameters.
class Progem {
static void Main()
{
    
   //Task1(); //-Grade calculator

   //Task2(); //-DAY OF WEEK (1-7) | Using Classic Switch

   //Task2e(); //-DAY OF WEEK (1-7) | Using Switch Expression

   //Task3(); //-Multiplication table

   //Task4(); //-Sum until zero

    /*
    string[] students = { "Ali", "Sara", "Omar", "Laila", "Mona" }; // Input Task5
    Task5(students); //-Student names
    */

    //-Task6 - Helper Methods
    /* 
    //Console.WriteLine(IsEven(222504));
    //Console.WriteLine(Max(-1,2));
    //PrintLine("moha");
    */

    //Task7(); //-Calculator 

    //Task8(taxRate:0.14, showTax:false, customer:"ali", amount:100.00); //-Invoice | (customer(string), amount(double), taxRate(double), showTax(bool)) - dif. order of params.
    
    //-Task9 : Area(Overloading) - ToString("F2") => 2 deciaml places
     /*
    Console.WriteLine($"circle: {Area (3).ToString("F2")}"); //Circle
    Console.WriteLine($"rectangle: {Area (4, 5).ToStrping("F2")}"); //Rectangle
    Console.WriteLine($"rectangle: {Area (3, 4, 5).ToString("F2")}"); //Triangle
    */
    
    // Console.WriteLine(Sum (3)); //-Task(10): Find the bugs

    //Guess(); //-Bonus Task(1) - Guess The Number (1-100)
    //FizzBuzz();  //-Bonus Task(2) - (Fizz=> mul. of 3, Buzz=> mul. of 5)


}




// Task1 -  Grade calculator
static void Task1()
{
    Console.Write("Enter Score : ");
    int.TryParse(Console.ReadLine(),out int grad); //needed : delete the parmeter + int grad;
    

    if (grad >= 90 && grad <=100)
        {
            Console.WriteLine("Grad: A");
        }
    else if (grad >= 80 && grad <= 89)
        {
            Console.WriteLine("Grad: B");
        }
    else if (grad >= 70 && grad <= 79)
        {
            Console.WriteLine("Grad: C");
        }
    else if (grad > 0 && grad < 70)
        {
            Console.WriteLine("Grad: Try Again");
        }
        else // > 100 OR < 0
        {
            Console.WriteLine("Grad: INVALID SCORE");
        }
    
}
//------------------------------------------------------------------TASK1 - END 



// Task2 - DAY OF WEEK (1-7) | Using Classic Switch
static void Task2()

    {
        Console.Write("Enter Day Number: ");
        int Day ;
        int.TryParse(Console.ReadLine(),out Day);

        switch (Day)
        {
            case 1 :
            Console.WriteLine("Saturday");
            break;

            case 2 :
            Console.WriteLine("Sunday");
            break;

            case 3 :
            Console.WriteLine("Monday");
            break;

            case 4 :
            Console.WriteLine("Tuesday");
            break;

            case 5 :
            Console.WriteLine("Wedensday");
            break;

            case 6 :
            Console.WriteLine("Thursday");
            break;

            case 7 :
            Console.WriteLine("Friday (Weekend)");
            break;

            default :
            Console.WriteLine("Not A Day! Enter in Range (1-7)");
            break;
        }
    }



    // Task2e - DAY OF WEEK (1-7) | Using Switch Expression

    static void Task2e() 
    {

        Console.Write("Enter Day Number:: ");

        int day2;
        int.TryParse(Console.ReadLine(),out day2);

        var type = day2 switch // type of output + output var name = parameter of switch + switch
        {
            1 => "Saturday",
            2 => "Sunday",
            3 => "Monday",
            4 => "Tuesday",
            5 => "Wedensday",
            6 => "Thursday",
            7 => "Friday (Weekend)",
            _ => "Not A Day! Enter in Range (1-7)"
            
        };
        Console.WriteLine(type);// The Command Will Process after check in switch;
    }

//------------------------------------------------------------------TASK2 - END 





// Task3 - Multiplication table 
static void Task3()
    {   
        
        Console.Write("Enter Number: ");
        bool errorParse = int.TryParse(Console.ReadLine(),out int num);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {i*num}");
        }
    }
//------------------------------------------------------------------TASK3 - END




// Task 4 - Sum until zero
static void Task4()
    {
        int count = 0;
        Console.Write("Enter a Number (0 to stop): ");
        bool isTrueNum = int.TryParse(Console.ReadLine(),out int inNum);
        if(isTrueNum == false){
                Console.WriteLine("Not A Number, Try Again"); 
               isTrueNum = int.TryParse(Console.ReadLine(),out inNum);
                }
       // else {count = count +1;} //add 1 to count if inNum is number, if i want to add '0' as the count;

        int sum = inNum;

        while (inNum != 0)
        {  
            Console.Write("Enter a Number (0 to stop): ");
            isTrueNum = int.TryParse(Console.ReadLine(),out inNum); //inNum here is Locally on While loop;

            if(isTrueNum == false){
                Console.WriteLine("Not A Number, Try Again"); 
                isTrueNum = int.TryParse(Console.ReadLine(),out inNum);
                }

             else {count = count +1;} // add 1 to count if inNum is number;

            sum = sum + inNum;
        }
        Console.Write($"Sum: {sum}, Count = {count}");
    }
    //------------------------------------------------------------------TASK4 - END 



// Task 5 - Student names
static void Task5(string[] students)
    {
        Console.WriteLine("string[] names =");
        foreach (string student in students)
        {
            if (student == "Sara") continue;
            if (student == "Laila") break;
            
            Console.WriteLine(student);

        }
        
    }
//------------------------------------------------------------------TASK5 - END 




// Task6 - Helper Methods :

    static void PrintLine(string s)

    {
       // string s = Console.ReadLine(); //If i Want to take s from input[delete param];
        int Slength = s.Length;

        Console.WriteLine(s);

        for (int i = 0; i < Slength ; i++)
        {
            Console.Write('-');
        }
    }

    static int Max(int a, int b)
    {
        if(a > b) return a;
        else if (b > a ) return b;
        else return -1; // a == b
    }

    static bool IsEven (int n)
    {
        if (n%2 == 0){return true;}
        else return false;
    }
//------------------------------------------------------------------TASK6 - END 




// Task7 - Calculator | Inputs:(double a, double b,char op)
    static void Task7() 
    {
        double a;
        double b;
        char op;
        Console.Write("Enter First Number: ");
        bool is1DNumTrue = double.TryParse(Console.ReadLine(),out a);

        Console.Write("Enter Second Number: ");
        bool is2DNumTrue = double.TryParse(Console.ReadLine(),out b);

        Console.Write("Enter Operator (+ - * /): ");
        bool isCharTrue = char.TryParse(Console.ReadLine(),out op);

        double res;
        if (is1DNumTrue == true && is2DNumTrue == true && isCharTrue == true){
        switch (op)
    {
            case '+' :
            res = a + b;
            Console.WriteLine($"Result: {res}");
            break;

            case '-' :
            res = a - b;
            Console.WriteLine($"Result: {res}");
            break;

            case '*' :
            res = a * b;
            Console.WriteLine($"Result: {res}");
            break;
            
            case '/' :
            if (b == 0)
                {
                    Console.WriteLine("ERROR***[ Can't Divided by 0]***ERROR");
                }

                else
                {
                    res = a / b;
                    Console.WriteLine($"Result: {res}");
                }
            break;

            default:
            Console.WriteLine("RE-ENTER THE OPERATOR"); break;

        }}
        else {Console.WriteLine("RE-ENTER THE NUMBERS");}
        
    }
//------------------------------------------------------------------TASK7 - END 





// Task8 - Invoice | PrintInvoice();
   static void Task8(string customer, double amount, double taxRate = 0.14, bool showTax = true)
    {
        double total = amount;
        string taxShow;

        if (showTax == false)
        {
         taxShow = "";
         
        }
        else { taxShow = $"|  Tax(14%): {taxRate}  |"; total = (amount*taxRate) + amount;}

        Console.WriteLine($"Customer:  {customer}  ||  Amount: {amount}  |{taxShow}|  Total: {total}"  );
    }
//------------------------------------------------------------------TASK8 - END



//Task 9 (Overloading)- Overloading "should be outside of Main" ,ToString("F2") => 2 deciaml places
static double Area (double redius) //circle 
        {
           double pi =  Math.PI;
           double res =  pi * redius*redius;
           return res;

        }

    static double Area (double width, double height) //rectangle
        {

           double res =  width * height;

           return res;
        }

    static double Area (double a, double b, double c) //Triangle
        {
           double s = (a+b+c)/2;
           double res =   Math.Sqrt(s * (s- a)*(s-b)*(s-c));

           return res;
        }

//------------------------------------------------------------------TASK9 - END




//Task(10): Find the bugs
static int Sum(int max) 
{
int total = 0;
for (int i = 1; i <= max; i++) //1- to include max to the sum (EDITED '=')
{
total += i; //2- +=> +i to total then total = total +1 (EDITED '+=')
}
return total; //3- No Return Statment (ADDED)
}
//------------------------------------------------------------------TASK10 - END







// Bonus Task(1) - Guess The Number (1-100)
static void Guess()
    {
        int c;
        Console.WriteLine("**Guess Number Between [1 - 101]**");
        bool errors = int.TryParse(Console.ReadLine(),out c);

        if(c > 1 && c < 100){
    
        int Rnum = new Random().Next(1, 101);

        int attempt = 1;

        while (c > Rnum)
    
        {
            Console.WriteLine("Too High");
            attempt +=1;

            bool errorC = int.TryParse(Console.ReadLine(),out c);

        }
        while (c < Rnum)
        {

            Console.WriteLine("Too Low");
            attempt +=1;

            bool errorC = int.TryParse(Console.ReadLine(),out c);

        }
        if (c == Rnum) Console.WriteLine($"CORRECT! Number is: {c} : Real {Rnum} ,Number of Attempts: {attempt}");
        }
        else {Console.WriteLine($"ERROR! NUMBER {c} NOT IN THE RANGE");}

       
        
    }

// Bonus Task(2)- (Fizz=> mul. of 3, Buzz=> mul. of 5)
static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i%3 == 0 && i%5 == 0) Console.WriteLine("FizzBuzz");
            else if (i%3 == 0)Console.WriteLine("Fizz");
            else if (i%5 == 0)Console.WriteLine("Buzz");
            
        }
    }
//------------------------------------------------------------------BONUS TASK - END




}

