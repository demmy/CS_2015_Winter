using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int k = 0;
            string t = "";
            Train[] UkrainianTrain = new Train[8];
            for (int i = 0; i < UkrainianTrain.Length; i++)
            {
                Console.WriteLine("----------------------------INSERT {0} TRAIN INFO", i + 1);
                Console.WriteLine("Insert destination");
                UkrainianTrain[i].destination = Console.ReadLine();
                Console.WriteLine("Insert number of the train");
                UkrainianTrain[i].trainNumber = Helper.InputValidationInt();
                Console.WriteLine("Insert time of departure");
                t = Console.ReadLine();
                try
                {
                    if (t.Length == 3)
                    {
                        UkrainianTrain[i].departure.hour = int.Parse(t[0].ToString());
                        UkrainianTrain[i].departure.minute = int.Parse(t[1].ToString()) * 10 + int.Parse(t[2].ToString());
                    }
                    else if (t.Length == 4)
                    {
                        UkrainianTrain[i].departure.hour = int.Parse(t[0].ToString()) * 10 + int.Parse(t[1].ToString());
                        UkrainianTrain[i].departure.minute = int.Parse(t[2].ToString()) * 10 + int.Parse(t[3].ToString());
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }

                }
                catch
                {
                    Console.WriteLine("You insert invalid Time");
                }

            }
            for (int i = 0; i < UkrainianTrain.Length - 1; i++)
            {
                for (int j = i + 1; j < UkrainianTrain.Length; j++)
                {
                    if (UkrainianTrain[j].trainNumber < UkrainianTrain[i].trainNumber)
                    {
                        int temp = UkrainianTrain[i].trainNumber;
                        TimeTrain temp2 = UkrainianTrain[i].departure;
                        string temp3 = UkrainianTrain[i].destination;
                        UkrainianTrain[i].trainNumber = UkrainianTrain[j].trainNumber;
                        UkrainianTrain[i].departure = UkrainianTrain[j].departure;
                        UkrainianTrain[i].destination = UkrainianTrain[j].destination;
                        UkrainianTrain[j].trainNumber = temp;
                        UkrainianTrain[j].departure = temp2;
                        UkrainianTrain[j].destination = temp3;
                    }
                }
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Enter the number of train");
            n = Helper.InputValidationInt();
            for (int i = 0; i < UkrainianTrain.Length; i++)
            {
                if (UkrainianTrain[i].trainNumber == n)
                {
                    k++;
                    Console.WriteLine("\n{0}\n{1}\n{2}:{3}", UkrainianTrain[i].trainNumber, UkrainianTrain[i].destination,
                        UkrainianTrain[i].departure.hour, UkrainianTrain[i].departure.minute);
                }
            }
            if (k == 0) { Console.WriteLine("This train is not"); }
            Console.ReadLine();
        }
    }
}
