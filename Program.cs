int day;
Console.WriteLine("Please enter a number between 1 and 7: ");
//The Try Catch stops your program from breaking and outputting an error when the user inputs something wrong, that the code doesn't like
try
{


    day = Convert.ToInt32(Console.ReadLine());
    //The variable in the "switch()" is where the program looks when it runs the case
    switch (day)
    { //case is like an if / else if, the character after the "case" is what the code is looking for 
        case 1:
            Console.WriteLine("Monday");
            break;

        case 2:
            Console.WriteLine("Tuesday");
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
            Console.WriteLine("Saturday");
            break;

        case 7:
            Console.WriteLine("Sunday");
            break;
        //default acts as the "else" in this scenario, catching any other input
        default:
            Console.WriteLine("That is not between 1 and 7");
            break;
    }
}
catch
{
    Console.WriteLine("Incorrect Input");
}

//Small note, F1 and typing in Format document, indents everything for you
//Small While Do loop
char choice;
do
{
    Console.WriteLine("Hello");
    Console.WriteLine("Would you like to continue?");
    choice = Convert.ToChar(Console.ReadLine());
}
while(choice != 'N');
//"While the choice variable is not N, repeat the above print statements 

Console.ReadLine();
