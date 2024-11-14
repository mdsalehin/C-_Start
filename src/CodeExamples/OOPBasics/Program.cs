

//Object Declare
//class  + variablename =  new classname
WatterBottle objectName = new WatterBottle();

//Accessing Inside Class Property.
objectName.capacity = 100;
objectName.color = "red";



//Another object declare
WatterBottle objectAnother  = new WatterBottle();

//Accessing Inside Class Property.
objectAnother.capacity = 150;
objectAnother.color = "black";



//Mathod Calling
objectName.AddWater(30);

objectAnother.AddWater(50);
objectAnother.AddWater(30);

//objectName.waterAmount = 300;
Console.WriteLine(objectName.waterAmount);
Console.WriteLine(objectAnother.waterAmount);


//But the Problem is Ami mathod use nah kore  varibale gulo value bosite parbo.ayta to hote pare nah
// objectName.waterAmount = 300; //Like this ayta to asole kisu hoilo nah.capacity o par kore gase wateramount.


/*  ay problem amra avoid korar jno Property feature use kore thkai  */
