static void GetStarted(string answer, Player user, bool playing) {
    if(answer == "yes" || answer == "Yes" || answer == "y" || answer == "Y") {
        Console.WriteLine($"Wonderful {user.Name} lets go!");
    }
    else {
        Console.WriteLine($"No hard feelings {user.Name}, thank you for at least stopping by");
        playing = false;
    }
}
static string NewGarden(int newAnswer) {
    string userGardenType = "";
    if(newAnswer == 1) {
        userGardenType = "Edible";
    }
    else if(newAnswer == 2) {
        userGardenType = "Decorative";
    }
    else if(newAnswer == 3) {
        userGardenType = "Ground Cover";
    }
    else {
        userGardenType = "bad";
    }
    return userGardenType;
}

static int TheName() {
    Random randName = new Random();
    int id = randName.Next(1,50);
    return id;
}

Player computer = new Player("Queen Bee");

bool playing = true;

while(playing) {
    Console.WriteLine($"Oh Hello there, I am {computer.Name}!");
    Console.WriteLine("Welcome to the Beta Test of Garden Game, I am so glad  you chose to join me");
    Console.WriteLine("Would you be so kind as you introduce yourself to me?");
    Player user = new Player(Console.ReadLine());
    Console.WriteLine($"Welcome {user.Name}, shall we get started on your adventure?");
    string answer = Console.ReadLine();
    GetStarted(answer, user, playing);
    Console.WriteLine("In order to begin lets create a garden.");
    Console.WriteLine("What would you like to name your garden?");
    string tempName = Console.ReadLine();
    Console.WriteLine($"{tempName}, nice {user.Name}.  Now lets figure out what type of garden you want");
    Console.WriteLine("Please chose from the following types: 1. Edible Garden, 2. Decorative Garden, or 3. Ground Cover Garden");
    int newAnswer = Convert.ToInt32(Console.ReadLine());
    string type = NewGarden(newAnswer);
    if(type == "bad") {
        Console.WriteLine($"I am sorry {user.Name} but that was not an option at this time I must end the game");
        playing = false;
    }
    Garden userGarden = new Garden(tempName, type, newAnswer*5, newAnswer);
    userGarden.PrintGarden();
    Console.WriteLine($"Now that you have a garden you should add some plants.  So since your garden is a {type}, lets at your first {type} plant please give us the name of the {type} plant");
    string newPlant = Console.ReadLine();
    
    if(newAnswer == 1) {

    }




    playing = false;
}