using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTesting
{


    class Phone
    {
        public string number;
        public string model;
        public int weight;
        public string name;

        public Phone() {
            this.number = "";
            this.model = "";
            this.weight = 0;
        }

        public Phone(string number, string model) {
            this.number = number;
            this.model = model;
        }

        public Phone(string number, string model, int weight):this(number,model) {
            this.weight = weight;
        }

        public void dataNumber()
        {
            Console.WriteLine("number: {0}, model: {1}, weight: {2}", this.number, this.model, this.weight);
        }

        public void recieveCall(Phone userName) {
            Console.WriteLine($"Звонит {userName.name}");
        }
        public void recieveCall(string name, string number)
        {
            Console.WriteLine($"Звонит {name}, с номером: {number}");
        }

        public string getNumber(Phone userNumber) {
            return userNumber.number;
        }

        public void sendMessage(params string[] nums)
        {
            StringBuilder res = new StringBuilder();
            foreach (var item in nums)
            {
                res.Append(item + ", ");
            }
            res.Remove(res.Length-2, 1);

            Console.WriteLine($"Номер {this.number} отправляет сообщение номерам {res}");
        }
    }
}
