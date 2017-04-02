using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OptimizeBankSystem
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }

    public class OptimizeBankSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resultList = new List<BankAccount>();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var bank = tokens[0];
                var name = tokens[1];
                var balance = decimal.Parse(tokens[2]);

                var result = new BankAccount();
                result.Bank = bank;
                result.Name = name;             
                result.Balance = balance;

                resultList.Add(result);

                input = Console.ReadLine();
            }

         var  finalResult = resultList.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length).ToList();

            foreach (var kvp in finalResult)
            {
                Console.WriteLine($"{kvp.Name} -> {kvp.Balance} ({kvp.Bank})");
            }
        }
    }
}
