using System;

namespace Trabalho1.Handlers
{
    public static class PlaceHolderHandler
    {
        public static int InputNumber(string value, string messageInput)
        {

            int resultValue;
            while (!int.TryParse(value, out resultValue))
            {
                Console.WriteLine(messageInput);
                value = Console.ReadLine();
            }
            return resultValue;
        }

        public static decimal InputDecimal(string value, decimal min, decimal max, string messageInput)
        {
            decimal resultValue;
            while ((!decimal.TryParse(value, out resultValue)) && resultValue <= -100000000000 || 100000000000 <= resultValue)
            {
                Console.WriteLine(messageInput);
                value = (Console.ReadLine());
            }
            return resultValue;
        }
    }
}
