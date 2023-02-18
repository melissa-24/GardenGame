class Garden {
    public string GardenName;
    public string GardenType;
    public int GardenSize;
    public List<Plant> GardenPlants;

    public Garden(string theName, string theType, int theSize) {
        GardenName = theName;
        GardenType = theType;
        GardenSize = theSize;
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
}