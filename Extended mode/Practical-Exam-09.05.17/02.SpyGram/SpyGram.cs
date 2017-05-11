using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.SpyGram
{
    public class SpyGram
    {
        public static void Main()
        {
            var privateKey = Console.ReadLine();
            var unEncryptedMessage = Console.ReadLine();
            var resultList = new List<string>();
            var encryptedMessage = new StringBuilder();

            while (unEncryptedMessage != "END")
            {

                var tokens = unEncryptedMessage.Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] != "TO:" || tokens[2] != "MESSAGE:" || !tokens[1].EndsWith(";"))
                {
                    unEncryptedMessage = Console.ReadLine();
                    continue;
                }

                var nameRemoveEnd = tokens[1].Trim(';');
                var testName = nameRemoveEnd.ToUpper();

                if (nameRemoveEnd.Equals(testName) && nameRemoveEnd.All(Char.IsLetter))
                {
                    for (int i = 0; i < unEncryptedMessage.Length; i++)
                    {
                        while (true)
                        {
                            if (privateKey.Length >= i)
                            {
                                var keyToInt = int.Parse(privateKey[i].ToString());
                                var eachChar = (unEncryptedMessage[i]);
                                var incresedChar = (char)((int)eachChar + keyToInt);
                                encryptedMessage.Append(incresedChar);
                            }
                        }
                    }

                    resultList.Add(encryptedMessage.ToString());
                    encryptedMessage.Clear();
                }

                else
                {
                    unEncryptedMessage = Console.ReadLine();
                    continue;
                }

                unEncryptedMessage = Console.ReadLine();
            }

            resultList = resultList.OrderBy(x => x).ToList();

            foreach (var message in resultList)
            {
                Console.WriteLine(message);
            }
        }

    }
}
