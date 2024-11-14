/*
     1) Encapsulation.
     2) Inheritance.
     3) Polymorphism.
     4) Abstraction.
 */
// This Encapsulation

// "Encapsulation =  Class + AccesModifier"
class WatterBottle
{
    public double capacity;
    public string color;
    private double waterAmount;

    // deaclearing Property
    public double PropertyDeclare
    {
        get
        {
            return waterAmount;
        }
        set
        {   //but ayta jdi value set kre dai tahole bahire thakao set kora jabe.but now intro to set and get 
           

            if (value <= capacity)
            {
                waterAmount = value;
            }
            // objectName.PropertyDeclare = 300;akn kintu ayta kaj krbe nah beacuse of this  ==  value <= capacity
        }
    }

    public void AddWater(double amount)
    {
        if (waterAmount + amount <= capacity)
        {
            waterAmount = waterAmount + amount;
        }
    }
    public void ReleaseWater(double amount)
    {
        if (waterAmount < amount)
        {
            waterAmount = 0;
        }
        else
        {
            waterAmount -= amount;
        }

    }
}


/*
 * Private , Protected, Internal , Public = This 4 things Are Called As AccesModifier.
 */

/*
    SO jdi kisu declear kora nah thake tahole
   *** Mathod + varibale = by defalut Private dhore naya hoi.
                  && 
 Class shamnao jdi kisu declear kora nah thake Tahole 
 ***** Class Internal hisabe dhore naya hobe.
 */
