using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OrderedBankingSystem
{
    public class OrderedBankingSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resultDict = new Dictionary<string, Dictionary<string, decimal>>();

            while (input != "end")
            {
                var toknes = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var bank = toknes[0];
                var account = toknes[1];
                var balance = decimal.Parse(toknes[2]);

                if (!resultDict.ContainsKey(bank))
                {
                    resultDict[bank] = new Dictionary<string, decimal>();
                }

                if (!resultDict[bank].ContainsKey(account))
                {
                    resultDict[bank][account] = 0;
                }

                resultDict[bank][account] += balance;
               

                input = Console.ReadLine();          
            }
          
            foreach (var bank in resultDict.OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value)))
            {
                foreach (var account in bank.Value.OrderByDescending(account => account.Value))
                {
                    Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})");
                }
            } 
        }
    }
}
