using System;

namespace BudgetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ПРОГРАМА КОЯТО ЩЕ ПОКАЖЕ ПО ПРОЦЕНТИ ЗА КАКВО СИ ХАЧРИШ ПАРИТЕ НАЙ-МНОГО В ДАДЕНИЯ МЕСЕЦ

            //INPUT
            Console.Write("Put your salary: "); double salary = double.Parse(Console.ReadLine());

            Console.Write("Money for Internet and TV: "); double TV = double.Parse(Console.ReadLine());

            Console.Write("Money for food: "); double food = double.Parse(Console.ReadLine());

            Console.Write("Money for go out: "); double goOut = double.Parse(Console.ReadLine());

            Console.Write("Money for home stuf: "); double homeStuf = double.Parse(Console.ReadLine());

            Console.Write("Money for clothes: "); double clothes = double.Parse(Console.ReadLine());

            Console.Write("Money for gas: "); double gas = double.Parse(Console.ReadLine());

            Console.Write("Money for dad: "); double dad = double.Parse(Console.ReadLine());

            Console.Write("Money for hobby: "); double hobby = double.Parse(Console.ReadLine());

            Console.Write("Money for car: "); double car = double.Parse(Console.ReadLine());

            Console.Write("Money for cat: "); double cat = double.Parse(Console.ReadLine());

            Console.Write("Money for electricity and water: "); double electricity = double.Parse(Console.ReadLine());

            Console.Write("Money for cinema: "); double cinema = double.Parse(Console.ReadLine());

            Console.Write("Money for cut hair: "); double cutHair = double.Parse(Console.ReadLine());

            Console.Write("Money for games: "); double games = double.Parse(Console.ReadLine());

            Console.Write("Money for your future: "); double future = double.Parse(Console.ReadLine());


            //LOGIC
            double forCar = gas + car;
            double forGames = games;
            double forHome = TV + homeStuf + dad + cat + electricity;
            double forFood = food;
            double forClothes = clothes + cutHair;
            double forFun = goOut + cinema;
            double forHobby = hobby;
            double forFuture = future;
            double sum = forCar + forGames + forHome + forFood + forClothes + forFun + forHobby + forFuture;

            double forNeeds = forCar + forHome + forFood + forClothes;
            double forInvestment = forFuture;
            double forWant = forGames + forFun + forHobby;

            double percentConverterForCar = GiveMeProcent(salary, forCar);
            double percentConverterForGames = GiveMeProcent(salary, forGames); ;
            double percentConverterForHome = GiveMeProcent(salary, forHome);
            double percentConverterForFood = GiveMeProcent(salary, forFood);
            double percentConverterForClothes = GiveMeProcent(salary, forClothes);
            double percentConverterForFun = GiveMeProcent(salary, forFun);
            double percentConverterForHobby = GiveMeProcent(salary, forHobby);
            double percentConverterForFuture = GiveMeProcent(salary, forFuture);
            double percentConverterForNeeds = GiveMeProcent(salary, forNeeds);
            double percentConverterForInvestment = GiveMeProcent(salary, forInvestment);
            double percentConverterForWant = GiveMeProcent(salary, forWant);
            double residue = salary - sum;

            //OUTPUT
            Console.WriteLine();

            Console.WriteLine($"Rule : 50/40/10 \n50% ({(salary/2):f2} лв.) for needs (food, house, transport, debt) \n40% ({(salary*0.40):f2} лв.) for investment (emergency fund, self-education, stocks/ETFs, rental, properties) \n10% ({(salary*0.10):f2} лв.) for wants (restaurants, entertainment, vacations, luxuary items, electronics)");

            Console.WriteLine($"Money for car:{percentConverterForCar:f2}% ");

            Console.WriteLine($"Money for games:{percentConverterForGames:f2}% ");

            Console.WriteLine($"Money for home:{percentConverterForHome:f2}% ");

            Console.WriteLine($"Money for food:{percentConverterForFood:f2}% ");

            Console.WriteLine($"Money for clothes:{percentConverterForClothes:f2}% ");

            Console.WriteLine($"Money for fun:{percentConverterForFun:f2}% ");

            Console.WriteLine($"Money for hobby: {percentConverterForHobby:f2}% ");

            Console.WriteLine($"Money for your future:{percentConverterForFuture:f2}% ");

            Console.WriteLine($"Residue: {residue}лв.");

            Console.WriteLine($"Result:");

            Console.WriteLine($"Needs: {percentConverterForNeeds:f2}%({(percentConverterForNeeds / 100 * salary):f2}лв.) Investment: {percentConverterForInvestment:f2}%({(percentConverterForInvestment / 100 * salary):f2}лв.) Wants: {percentConverterForWant:f2}&({(percentConverterForWant / 100 * salary):f2}лв.)");
        }

        private static double GiveMeProcent(double salary, double expenditure)
        {
            double procent = expenditure / salary * 100;
            return procent;
        }
    }

}
