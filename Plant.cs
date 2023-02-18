class Plant {
    public string PlantName;
    public int PlantSpace;
    public bool WaterNeeded;
    public int PlantHealth;

    public Plant(string theName) {
        PlantName = theName;
        PlantSpace = 1;
        WaterNeeded = false;
        PlantHealth = 50;
    }
}