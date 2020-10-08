using HomeWork01102020_2.Common.AbstractHandler;

namespace HomeWork01102020_2.Common.ConcreteHandler
{
    public class TwoHundredBanknote : BanknoteHandler, IBanknote
    {
        public decimal ValueOfBanknote { get; } = 200;

        public int Piece { get; set; }

        public override void Change(Money money)
        {
            BanknoteController(money, this);
        }
    }

    public class HundredBanknote : BanknoteHandler, IBanknote
    {
        public decimal ValueOfBanknote { get; } = 100;

        public int Piece { get; set; }

        public override void Change(Money money)
        {
            BanknoteController(money, this);
        }
    }

    public class FiftyBanknote : BanknoteHandler, IBanknote
    {
        public decimal ValueOfBanknote { get; } = 50;

        public int Piece { get; set; }

        public override void Change(Money money)
        {
            BanknoteController(money, this);
        }
    }

    public class TwentyBanknote : BanknoteHandler, IBanknote
    {
        public decimal ValueOfBanknote { get; } = 20;

        public int Piece { get; set; }

        public override void Change(Money money)
        {
            BanknoteController(money, this);
        }
    }

    public class TenBanknote : BanknoteHandler, IBanknote
    {
        public decimal ValueOfBanknote { get; } = 10;

        public int Piece { get; set; }

        public override void Change(Money money)
        {
            BanknoteController(money, this);
        }
    }

    public class FiveBanknote : BanknoteHandler, IBanknote
    {
        public decimal ValueOfBanknote { get; } = 5;

        public int Piece { get; set; }

        public override void Change(Money money)
        {
            BanknoteController(money, this);
        }
    }

    public class OneBanknote : BanknoteHandler, IBanknote
    {
        public decimal ValueOfBanknote { get; } = 1;

        public int Piece { get; set; }

        public override void Change(Money money)
        {
            BanknoteController(money, this);
        }
    }

    public class FiftyPenny : BanknoteHandler, IBanknote
    {
        public decimal ValueOfBanknote { get; } = 0.50M;

        public int Piece { get; set; }

        public override void Change(Money money)
        {
            BanknoteController(money, this);
        }
    }

    public class TwentyFivePenny : BanknoteHandler, IBanknote
    {
        public decimal ValueOfBanknote { get; } = 0.25M;

        public int Piece { get; set; }

        public override void Change(Money money)
        {
            BanknoteController(money, this);
        }
    }

    public class TenPenny : BanknoteHandler, IBanknote
    {
        public decimal ValueOfBanknote { get; } = 0.10M;

        public int Piece { get; set; }

        public override void Change(Money money)
        {
            BanknoteController(money, this);
        }
    }

    public class FivePenny : BanknoteHandler, IBanknote
    {
        public decimal ValueOfBanknote { get; } = 0.05M;

        public int Piece { get; set; }

        public override void Change(Money money)
        {
            BanknoteController(money, this);
        }
    }

    public class OnePenny : BanknoteHandler, IBanknote
    {
        public decimal ValueOfBanknote { get; } = 0.01M;

        public int Piece { get; set; }

        public override void Change(Money money)
        {
            BanknoteController(money, this);
        }
    }
}