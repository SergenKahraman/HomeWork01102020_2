namespace HomeWork01102020_2.Common.AbstractHandler
{
    public interface IBanknote
    {
        decimal ValueOfBanknote { get; }
        int Piece { get; set; }
    }
}