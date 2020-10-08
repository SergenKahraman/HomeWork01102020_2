namespace HomeWork01102020_2.Common.AbstractHandler
{
    public abstract class BanknoteHandler
    {
        protected BanknoteHandler NextBanknote;

        public void AssignNextChain(BanknoteHandler nextBanknote)
        {
            NextBanknote = nextBanknote;
        }

        public abstract void Change(Money money);

        protected void BanknoteController(Money money, IBanknote banknote)
        {
            if (money.Amount >= banknote.ValueOfBanknote)
            {
                banknote.Piece = (int)(money.Amount / banknote.ValueOfBanknote);
                money.Amount = money.Amount % banknote.ValueOfBanknote;
                money.ChangedList.Add(banknote);
                NextBanknote.Change(money);
            }
            else if (NextBanknote != null)
            {
                NextBanknote.Change(money);
            }
        }
    }
}