using HomeWork01102020_2.Common;
using HomeWork01102020_2.Common.AbstractHandler;
using HomeWork01102020_2.Common.ConcreteHandler;
using System;

namespace HomeWork01102020_2.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BanknoteHandler TwoHundred = new TwoHundredBanknote();
            BanknoteHandler Hundred = new HundredBanknote();
            BanknoteHandler Fifty = new FiftyBanknote();
            BanknoteHandler Twenty = new TwentyBanknote();
            BanknoteHandler Ten = new TenBanknote();
            BanknoteHandler Five = new FiveBanknote();
            BanknoteHandler One = new OneBanknote();
            BanknoteHandler PennyFifty = new FiftyPenny();
            BanknoteHandler PennyTwentyFive = new TwentyFivePenny();
            BanknoteHandler PennyTen = new TenPenny();
            BanknoteHandler PennyFive = new FivePenny();
            BanknoteHandler PennyOne = new OnePenny();

            TwoHundred.AssignNextChain(Hundred);
            Hundred.AssignNextChain(Fifty);
            Fifty.AssignNextChain(Twenty);
            Twenty.AssignNextChain(Ten);
            Ten.AssignNextChain(Five);
            Five.AssignNextChain(One);
            One.AssignNextChain(PennyFifty);
            PennyFifty.AssignNextChain(PennyTwentyFive);
            PennyTwentyFive.AssignNextChain(PennyTen);
            PennyTen.AssignNextChain(PennyFive);
            PennyFive.AssignNextChain(PennyOne);

            var Anapara = 300;

            var Money = new Money()
            {
                Amount = Anapara,
            };

            TwoHundred.Change(Money);

            Console.WriteLine($"Anapara........: {Anapara}");
            foreach (var banknote in Money.ChangedList)
            {
                Console.WriteLine($"{banknote.Piece}x{banknote.ValueOfBanknote}");
            }

            Console.ReadLine();
        }
    }
}