using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBreakfast
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("Coffee is ready");
            var eggsTask = FryEggAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var allTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (allTasks.Any())
            {
                Task finished = await Task.WhenAny(allTasks);
                if (finished == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finished == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finished == toastTask)
                {
                    Console.WriteLine("toast is ready");
                }
                allTasks.Remove(finished);
            }
            Juice Oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        static Juice PourOJ()
        {
            throw new NotImplementedException();
        }

        static Task FryBaconAsync(int v)
        {
            throw new NotImplementedException();
        }

        static Task FryEggAsync(int v)
        {
            throw new NotImplementedException();
        }

        static Coffee PourCoffee()
        {
            throw new NotImplementedException();
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);
            return toast;
        }

        static Task<Toast> ToastBreadAsync(int number)
        {
            throw new NotImplementedException();
        }

        static void ApplyJam(object toast)
        {
            throw new NotImplementedException();
        }

        static void ApplyButter(object toast)
        {
            throw new NotImplementedException();
        }
    }

    public class Juice
    {
    }

    public class Coffee 
    {
    }
}
