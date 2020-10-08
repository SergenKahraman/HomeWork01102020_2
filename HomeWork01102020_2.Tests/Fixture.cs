using System;
using System.Text;
using HomeWork01102020_2.Common;
using HomeWork01102020_2.Common.AbstractHandler;
using HomeWork01102020_2.Common.ConcreteHandler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork01102020_2.Tests
{
    [TestClass]
    public class Fixture
    {
        [TestMethod]
        public void CanIChangeMyMoney()
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

            var AnaPara = 146.5M;
            var Money = new Money() { Amount = AnaPara };
            TwoHundred.Change(Money);


            var stringBuilder = new StringBuilder();
            foreach (var item in Money.ChangedList)
            {
                stringBuilder.Append($"{item.Piece}x{item.ValueOfBanknote} ");
            }

            var Expected = "1x100 2x20 1x5 1x1 1x0,50 ";
            Assert.AreEqual(Expected, stringBuilder.ToString());
        }
    }
}
