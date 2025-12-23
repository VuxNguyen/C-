// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");


// fraudulentOrderIDs[0] = "F000";
// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

////////////////////////////////////

// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }
//////////////////////////////////
// using System.Runtime.CompilerServices;

// int[] inventory = {14, 15,5123,312,132,423,67,23,423,4,62,3423,4,2,352,6,6,2,4,23,4,234,23,62,34,23,4,23,22};
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin ++;
//         Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");

// }

// Console.WriteLine($"We have {sum} items in inventory.");

//////////////////


// string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
// foreach ( string orderID in orderIDs)
// {

// if (orderID.StartsWith("B"))
// {
//     Console.WriteLine(orderID);
// }
// }

////////////////////////

// Random dice = new Random();
// int roll = dice.Next(1,10);
// Console.WriteLine(roll);
///////////////////////////

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50,101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"First roll: {roll2}");
// Console.WriteLine($"First roll: {roll3}");


///////////////////////////////

// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
// largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);



////////////////////
/// 
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");



// if (total > 14)
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }