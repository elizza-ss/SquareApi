namespace SquareWebApi.Models
{
    public class BaseSquareRequest
    {
        /// <summary>
        /// входящие единицы измерения
        /// </summary>
        /// <example>мм</example>
        public string InputUnit { get; set; } = null!;
        /// <summary>
        /// выходящие единицы измерения
        /// </summary>
        /// <example>мм</example>
        public string OutputUnit { get; set; } = null!;
    }
    /// <summary>
    /// тип фигуры
    /// </summary>
    public enum ShapeType
    {   
        Triangle,
        Rectangle,
        Circle
    }
}
