class Edible : Plant {
    public bool Harvestable;

    public Edible(string theName) : base(theName) {
        Harvestable = false;
    }
}