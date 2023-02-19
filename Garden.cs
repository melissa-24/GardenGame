class Garden {
    public string GardenName;
    public string GardenType;
    public int GardenSize;
    public int GardenTypeInt; // This is so help with logic later
    public List<Plant> GardenPlants;

    public Garden(string theName, string theType, int theSize, int typeInt) {
        GardenName = theName;
        GardenType = theType;
        GardenSize = theSize;
        GardenTypeInt = typeInt;
        GardenPlants = new List<Plant>();
    }

    public void PrintGarden() {
        if(GardenPlants.Count == 0) {
            Console.WriteLine($"Garden Name: {GardenName}, Garden Type: {GardenType}.  You currently have no plants however you have room for: {GardenSize} plants");
        }
        else {
            Console.WriteLine($"Garden Name: {GardenName}, Garden Type: {GardenType}.  You currently have room for: {GardenSize} more plants");
        }
    }
    public void ExpandGarden(int amount) {
        int initSize = this.GardenSize;
        this.GardenSize += amount;
        Console.WriteLine($"you have just increase your garden size from");
    }
}