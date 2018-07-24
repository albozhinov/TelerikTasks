using System;

namespace MobilePhone
{
    class Startup
    {
        static void Main(string[] args)
        {

            //var model = Console.ReadLine();

            //var manufacturer = Console.ReadLine();

            //var price = decimal.Parse(Console.ReadLine());

            //var owner = Console.ReadLine();

            //GSM myGSM = new GSM(model, manufacturer, price, owner);

            //myGSM.MyBattery.Model = Console.ReadLine();

            //BatteryType type;
            //string inputType = Console.ReadLine();
            //var parsedType = Enum.TryParse(inputType, out type);

            //myGSM.MyBattery.Type = type;

            //Console.WriteLine(myGSM);
            GSMTest currTest = new GSMTest();
            Console.WriteLine(currTest.ToString());

            var model = Console.ReadLine();
            var manu = Console.ReadLine();
            GSM currGSM = new GSM(model, manu);
            currGSM.AddCall()


        }
    }
}
