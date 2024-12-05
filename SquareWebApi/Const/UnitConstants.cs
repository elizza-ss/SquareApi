namespace SquareWebApi.Const
{
    public class UnitConstants
    {
        public const string SquareMillimeters = "мм²";
        public const string SquareCentimeters = "см²";
        public const string SquareMeters = "м²";
        public const string Millimeters = "мм";
        public const string Centimeters = "см";
        public const string Meters = "м";
        public const string InvalidUnitMessage = "Некорректная единица вывода.";
        public const string InvalidInputUnitMessage = "Некорректная единица ввода.";

        public static readonly HashSet<string> ValidUnits = new() { Millimeters, Meters, Centimeters };
           
    }
}
