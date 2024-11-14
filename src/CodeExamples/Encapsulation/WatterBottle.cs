class WatterBottle
{
    private double capacity;
    private string color;
    private double waterAmount;


    public string GetingColorProperty
    {
        get
        {
            return color;
        }
    }

    public double GetingCapacityProperty
    {
        get
        {
            return capacity;
        }
    }
    public double PropertyDeclare
    {
        get
        {
            return waterAmount;
        }
       private set
        {   

            if (value <= capacity)
            {
                waterAmount = value;
            }
          
        }
    }


    //constuctor  =  always calss ar name onujai e hoye thake
    public WatterBottle(string constructorColor, double capacity)
    {
        color = constructorColor;
        this.capacity = capacity; //same name use korle this use kore thaki.
    }


    public void AddWater(double amount)
    {
        if (PropertyDeclare + amount <= capacity)
        {
            PropertyDeclare = PropertyDeclare + amount;
        }
    }
    public void ReleaseWater(double amount)
    {
        if (PropertyDeclare < amount)
        {
            PropertyDeclare = 0;
        }
        else
        {
            PropertyDeclare -= amount;
        }

    }
}


