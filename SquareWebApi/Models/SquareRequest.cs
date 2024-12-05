namespace SquareWebApi.Models
{
    /// <summary>
    /// Модель прямоугольника
    /// </summary>
    public class RectangleSquareRequest : BaseSquareRequest
    {
        /// <summary>
        /// Длина
        /// </summary>
        /// <example>10</example>
        public double A { get; set; }
        /// <summary>
        /// Ширина
        /// </summary>
        /// <example>10</example>
        public double B { get; set; }

    }
    /// <summary>
    /// Модель круга
    /// </summary>
    public class CircleSquareRequest : BaseSquareRequest
    {
        /// <summary>
        /// Радиус
        /// </summary>
        /// <example>10</example>
        public double R { get; set; }

    }
    /// <summary>
    /// Модель треугольника
    /// </summary>
    public class TriangleSquareRequest : BaseSquareRequest
    {
        /// <summary>
        /// Основание
        /// </summary>
        /// <example>10</example>
        public double  A{ get; set; }
        /// <summary>
        /// Высота
        /// </summary>
        /// <example>10</example>
        public double  H{ get; set; }
    }
}

