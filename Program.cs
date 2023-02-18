Player computer = new Player("Queen Bee");

bool playing = true;

while(playing) {
    Console.WriteLine($"Oh Hello there, I am {computer.Name}!");
    Console.WriteLine("Welcome to the Beta Test of Garden Game, I am so glad  you chose to join me");
    Console.WriteLine("Would you be so kind as you introduce yourself to me?");
    Player user = new Player(Console.ReadLine());
    Console.WriteLine($"Welcome {user.Name}, shall we get started on your adventure?");
    string answer = Console.ReadLine();
    if(answer == "yes" || answer == "Yes" || answer == "y" || answer == "Y") {
        Console.WriteLine($"Wonderful {user.Name} lets go!");
    }
    else {
        Console.WriteLine($"No hard feelings {user.Name}, thank you for at least stopping by");
        playing = false;
    }
    Console.WriteLine("In order to begin lets create a garden.");
    Console.WriteLine("What would you like to name your garden?");
    string tempName = Console.ReadLine();
    Console.WriteLine($"{tempName}, nice {user.Name}.  Now lets figure out what type of garden you want");
    Console.WriteLine("Please chose from the following types: 1. Edible Garden, 2. Decorative Garden, or 3. Ground Cover Garden");
    int newAnswer = Convert.ToInt32(Console.ReadLine());
    if(newAnswer == 1) {
        Garden newGarden = new Garden(tempName, "Edible", 5);
        Console.WriteLine($"Congrats {user.Name} here is the information on your new Garden");
        newGarden.PrintGarden();
    }
    else if(newAnswer == 2) {
        Garden newGarden = new Garden(tempName, "Decorative", 15);
        Console.WriteLine($"Congrats {user.Name} here is the information on your new Garden");
        newGarden.PrintGarden();
    }
    else if(newAnswer == 3) {
        Garden newGarden = new Garden(tempName, "Ground Cover", 10);
        Console.WriteLine($"Congrats {user.Name} here is the information on your new Garden");
        newGarden.PrintGarden();
    }
    else {
        Console.WriteLine($"Sorry {user.Name}, that entry was not an option for now I {computer.Name} will have to say goodbye, please to come back later");
    }
    playing = false;
}