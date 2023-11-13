

Console.Write("What is your first name? ");
string? firstName = Console.ReadLine();

Console.Write("What is your last name? ");
string? lastName = Console.ReadLine();

if (firstName.ToLower() == "justin" &&
    lastName.ToLower() == "spencer")
{
    Console.WriteLine("Hello, learner.");
}
else if (firstName.ToLower() == "justin" ||
    lastName.ToLower() == "spencer")
{
    Console.WriteLine("You have a great first or last name.");
}

Console.WriteLine("Hello, student.");

//if (firstName.ToLower() == "justin" && lastName.ToLower() == "spencer")
//{
//    Console.WriteLine("Hello, Mr. Spencer.");
//}
//else if (firstName.ToLower() == "justin")
//{
//    Console.WriteLine("Hello, I like your first name.");
//}
//else if (lastName.ToLower() == "spencer")
//{
//    Console.WriteLine("You have a great last name.");
//}
//else
//{
//    Console.WriteLine("Sorry you don't have a cooler name!");
//}

//if (firstName.ToLower() == "justin")
//{
//    Console.WriteLine("You have a cool first name.");
//}

//if (lastName.ToLower() == "spencer")
//{
//    Console.WriteLine("You have a great last name.");
//}
//else
//{
//    Console.WriteLine("Sorry your name isn't cooler.");
//}

int? age = 40;

////==, >, >=, <, <=, !=

if ((age >= 40 && age < 50) ||
    (age >= 70 && age < 80))
{
    Console.WriteLine("You are in your 40's or 70's");
}
