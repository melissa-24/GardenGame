class Player : IMethods {
    public string Name;
    public int Health;
    public List<Garden> PlayerGardens;
    public List<Plant> PlayerPlants;

    public Player(string playerName) {
        Name = playerName;
        Health = 100;
        PlayerGardens = new List<Garden>();
        PlayerPlants = new List<Plant>();
    }

    public void PrintInfo() {
        Console.WriteLine($"Player Name: {Name}, Players Health: {Health}");
    }
    public void HealthIncrease(int num) {
        int change = num * 5;
        int initHealth = Health;
        if(initHealth >= 95) {
            Console.WriteLine($"Good news your health is already nearly perfect.  After resting {num} hours, your health remains at {initHealth}");
        }
        else if(initHealth >= 25 && initHealth < 95) {
            Health = Health + change;
            if(Health > 99) {
                Health = 100;
            }
            Console.WriteLine($"After resting {num} hours, your health has changed from {initHealth} to {Health}");
        } 
        else if(initHealth < 25 && num < 5) {
            Health = Health + change;
            Console.WriteLine($"Good news, after resting {num} hours, your health has increase from {initHealth} to {Health}.  However you require more rest");
        }
        else if(initHealth < 25 && num > 5) {
            Health = Health + change;
            if(Health > 99) {
                Health = 100;
            }
            Console.WriteLine($"Good news, after resting {num} hours, your health has increase from {initHealth} to {Health}.");
        }
        else {
            Health = Health + change;
            if(Health > 99) {
                Health = 100;
            }
            Console.WriteLine($"Good news, after resting {num} hours, your health has increase from {initHealth} to {Health}.");
        }
    }
    public void HealthDecrease(int num) {
        int change = num * 5;
        int initHealth = Health;
        if(initHealth >= 25 && num < 5) {
            Health = Health - change;
            Console.WriteLine($"After working for {num} hours your health has changed from {initHealth} to {Health}");
        }
        else {
            Health = Health - change;
            if(Health <= 5) {
                Health = 0;
            }
            Console.WriteLine($"After working for {num} hours your health has changed from {initHealth} to {Health}");
        }
    }
}