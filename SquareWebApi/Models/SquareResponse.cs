namespace SquareWebApi.Models
{
    /// <summary>
    /// Модель ответа
    /// </summary>
    public class SquareResponse
    {
        /// <summary>
        /// Значение площади
        /// </summary>
        public double Value { get; set; }
        /// <summary>
        /// Единицы измерения
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public string ShapeType { get; set; }
    }
}
