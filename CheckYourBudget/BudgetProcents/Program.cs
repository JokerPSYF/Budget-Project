using System;

namespace BudgetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ПРОГРАМА КОЯТО ЩЕ ПОКАЖЕ ПО ПРОЦЕНТИ ЗА КАКВО СИ ХАЧРИШ ПАРИТЕ НАЙ-МНОГО В ДАДЕНИЯ МЕСЕЦ

            //INPUT
            Console.Write("Put your salary: "); decimal salary = decimal.Parse(Console.ReadLine());

            Console.Write("Money for Internet and TV: "); decimal TV = decimal.Parse(Console.ReadLine());

            Console.Write("Money for food: "); decimal food = decimal.Parse(Console.ReadLine());

            Console.Write("Money for go out: "); decimal goOut = decimal.Parse(Console.ReadLine());

            Console.Write("Money for home stuf: "); decimal homeStuf = decimal.Parse(Console.ReadLine());

            Console.Write("Money for clothes: "); decimal clothes = decimal.Parse(Console.ReadLine());

            Console.Write("Money for gas: "); decimal gas = decimal.Parse(Console.ReadLine());

            Console.Write("Money for dad: "); decimal dad = decimal.Parse(Console.ReadLine());

            Console.Write("Money for hobby: "); decimal hobby = decimal.Parse(Console.ReadLine());

            Console.Write("Money for car: "); decimal car = decimal.Parse(Console.ReadLine());

            Console.Write("Money for cat: "); decimal cat = decimal.Parse(Console.ReadLine());

            Console.Write("Money for electricity and water: "); decimal electricity = decimal.Parse(Console.ReadLine());

            Console.Write("Money for cinema: "); decimal cinema = decimal.Parse(Console.ReadLine());

            Console.Write("Money for cut hair: "); decimal cutHair = decimal.Parse(Console.ReadLine());

            Console.Write("Money for games: "); decimal games = decimal.Parse(Console.ReadLine());

            Console.Write("Money for your future: "); decimal future = decimal.Parse(Console.ReadLine());

            Console.Write("Money for your health: "); decimal health = decimal.Parse(Console.ReadLine());


            //LOGIC
            decimal forCar = gas + car;
            decimal forGames = games;
            decimal forHome = TV + homeStuf + dad + cat + electricity;
            decimal forFood = food;
            decimal forClothes = clothes + cutHair;
            decimal forFun = goOut + cinema;
            decimal forHobby = hobby;
            decimal forFuture = future;
            decimal sum = forCar + forGames + forHome + forFood + forClothes + forFun + forHobby + forFuture + health;

            decimal forNeeds = forCar + forHome + forFood + forClothes + health;
            decimal forInvestment = forFuture;
            decimal forWant = forGames + forFun + forHobby;

            decimal percentConverterForCar = GiveMeProcent(salary, forCar);
            decimal percentConverterForGames = GiveMeProcent(salary, forGames); ;
            decimal percentConverterForHome = GiveMeProcent(salary, forHome);
            decimal percentConverterForFood = GiveMeProcent(salary, forFood);
            decimal percentConverterForClothes = GiveMeProcent(salary, forClothes);
            decimal percentConverterForFun = GiveMeProcent(salary, forFun);
            decimal percentConverterForHobby = GiveMeProcent(salary, forHobby);
            decimal percentConverterForFuture = GiveMeProcent(salary, forFuture);
            decimal percentConverterForNeeds = GiveMeProcent(salary, forNeeds);
            decimal percentConverterForInvestment = GiveMeProcent(salary, forInvestment);
            decimal percentConverterForWant = GiveMeProcent(salary, forWant);
            decimal residue = salary - sum;

            //OUTPUT
            Console.WriteLine();

            Console.WriteLine($"Rule : 50/40/10 \n50% ({(salary/2):f2} лв.) for needs (food, house, transport, debt) \n" +
                $"40% ({(salary*(decimal) 0.40):f2} лв.)for investment (emergency fund, self-education," +
                $" stocks/ETFs, rental, properties\n" +
                $"10% ({(salary*(decimal) 0.10f):f2} лв.) for wants " +
                $"(restaurants, entertainment, vacations, luxuary items, electronics)");

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

            Console.WriteLine($"Needs: {percentConverterForNeeds:f2}%({(percentConverterForNeeds / 100 * salary):f2}лв.)" +
                $" Investment:{percentConverterForInvestment:f2}%({(percentConverterForInvestment / 100 * salary):f2}лв.)" +
                $" Wants:{percentConverterForWant:f2}%({(percentConverterForWant / 100 * salary):f2}лв.)");
            Console.WriteLine();
        }

        private static decimal GiveMeProcent(decimal salary, decimal expenditure)
        {
            decimal procent = expenditure / salary * 100;
            return procent;
        }
    }

}
