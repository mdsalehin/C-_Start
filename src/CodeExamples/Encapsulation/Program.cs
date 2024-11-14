

//Object Declare
WatterBottle objectName = new WatterBottle("red", 100);


//Another object declare
WatterBottle objectAnother = new WatterBottle("black", 150);



//Mathod Calling
objectName.AddWater(30);
objectAnother.AddWater(50);
objectAnother.AddWater(30);


//accessing property 
Console.WriteLine(objectName.PropertyDeclare);
Console.WriteLine(objectAnother.PropertyDeclare);

Console.WriteLine(objectName.GetingCapacityProperty);
Console.WriteLine(objectName.GetingColorProperty);

Console.WriteLine(objectAnother.GetingColorProperty);
Console.WriteLine(objectAnother.GetingCapacityProperty);