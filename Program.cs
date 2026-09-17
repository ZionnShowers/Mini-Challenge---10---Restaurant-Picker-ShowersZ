//Zionn Showers
//9-17-2026
//Mini Challenge # 10 - Restaurant Picker
/*The program starts by asking the user of the type of restaurant they want to choose. Afterwards, the program chooses a random number, which will
decide what restaurant will be chosen from the list of 10 items from each restuarant. For some reason, I found myself struggling a bit to get this
 working correctly. I tried to mainly focus on arrays as I felt like it would make the code simpler, but it would in return cause me to add a lot
 more code than I anticipated.*/
//Peer Review: 
/*Review:*/

Console.Clear();

string playAgain;
do
{

Console.WriteLine("");
Console.WriteLine("Choose a restaurant type: ");
Console.WriteLine("1. Fast Food");
Console.WriteLine("2. Casual Dining");
Console.WriteLine("3. Sit Down");

string input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int restType);
while (isNumber == false || restType >= 4 || restType <= 0)
{
    Console.Write("Error: ");
    Console.WriteLine("Please input a valid number: ");
    input = Console.ReadLine();
    isNumber = int.TryParse(input, out restType);
}

string restTypeName = "";

if (restType == 1)
{
    restTypeName = "Fast Food";
}
else if (restType == 2)
{
    restTypeName = "Casual Dining";
}
else if (restType == 3)
{
    restTypeName = "Sit Down";
}



Random rnd = new Random();
int restTest = rnd.Next(0, 10);

string[] restName = new string[10];

// Random rnd = new Random();
// restName = rnd.Next(0, 11);

if (restType == 1)
{
    restName[0] = "McDonald's";
    restName[1] = "In-N-Out";
    restName[2] = "KFC";
    restName[3] = "Raising Cane's Chicken";
    restName[4] = "Panda Express";
    restName[5] = "Taco Bell";
    restName[6] = "Burger King";
    restName[7] = "Wendy's";
    restName[8] = "El Pollo Loco";
    restName[9] = "Dell Taco";
}
else if (restType == 2)
{
    restName[0] = "West Coast Sourdough";
    restName[1] = "Pizza Hut";
    restName[2] = "Roundtable";
    restName[3] = "Mountain Mikes";
    restName[4] = "Sourdough & Co.";
    restName[5] = "La Estrella";
    restName[6] = "Mr. Pickles";
    restName[7] = "Straw Hat Pizza";
    restName[8] = "Feronis";
    restName[9] = "Subway";
}
else if (restType == 3)
{
    restName[0] = "Texas Roadhouse";
    restName[1] = "Applebees";
    restName[2] = "Olive Garden";
    restName[3] = "BJ's";
    restName[4] = "Chili's";
    restName[5] = "Las Casuelas";
    restName[6] = "DJ's Restaurant";
    restName[7] = "Tap House";
    restName[8] = "Bistro 120";
    restName[9] = "The Boathouse";
}

Console.WriteLine("");
Console.WriteLine($"Your {restTypeName} restaurant is {restName[restTest]}.");



//play again?
Console.WriteLine ("Would you like to play again? y/n");
playAgain = Console.ReadLine().ToLower();

while(playAgain != "y" && playAgain != "n")
{
    Console.WriteLine("Error! Try Again!");
    playAgain = Console.ReadLine().ToLower();
}
}while(playAgain == "y");