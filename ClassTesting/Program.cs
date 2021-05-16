using System;

namespace ClassTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone iphone = new Phone();
            iphone.number = "8-800-555-55-35";
            iphone.model = "iphone XR";
            iphone.weight = 520;
            iphone.dataNumber();

            Phone google = new Phone();
            google.number = "8-777-777-55-35";
            google.model = "google pixel 4";
            google.weight = 570;
            google.dataNumber();

            Phone xiaomi = new Phone();
            xiaomi.number = "8-333-543-87-98";
            xiaomi.model = "readmi 9";
            xiaomi.weight = 490;
            xiaomi.dataNumber();

            iphone.name = "Bob";
            google.name = "Jill";
            xiaomi.name = "Alex";

            iphone.recieveCall(iphone);
            google.recieveCall(google);
            xiaomi.recieveCall(xiaomi);

            Console.WriteLine(iphone.getNumber(iphone));
            Console.WriteLine(google.getNumber(google));
            Console.WriteLine(xiaomi.getNumber(xiaomi));

            Phone sumsung = new Phone("9-888-999-88-99", "sumsung s20");
            sumsung.dataNumber();

            Phone meizu = new Phone("9-999-999-99-99", "meizu 9 pro", 460);
            meizu.dataNumber();

            Phone oppo = new Phone("8-777-888-54-33", "oppo zenFone", 625);
            oppo.dataNumber();

            iphone.recieveCall(iphone.name, iphone.number);

            sumsung.sendMessage(meizu.number, iphone.number, oppo.number);

            Console.ReadKey();
        }
    }
}
