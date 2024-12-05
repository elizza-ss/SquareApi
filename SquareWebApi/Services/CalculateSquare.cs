using SquareWebApi.Const;
using SquareWebApi.Models;

namespace SquareWebApi.Services
{
    public class CalculateSquare
    {
        /// <summary>
        /// функция возращает ответ
        /// </summary>
        /// <param name="type">ТТип фигуры</param>
        /// <param name="request">Модель запроса</param>
        /// <returns></returns>
        public static SquareResponse Calculate(ShapeType type, BaseSquareRequest request)
        {
            double value = 0;
            switch (type)
            {
                case ShapeType.Rectangle:
                    value = ((RectangleSquareRequest)request).A * ((RectangleSquareRequest)request).B;
                    break;
                case ShapeType.Triangle:
                    value = (((TriangleSquareRequest)request).A * ((TriangleSquareRequest)request).H) * 0.5;
                    break;
                case ShapeType.Circle:
                    value = Math.Pow(((CircleSquareRequest)request).R, 2) *Math.PI;
                    break;
            }
            return GetResponseByType(request, value, type);
        }

        private static SquareResponse GetResponseByType(BaseSquareRequest request, double value, ShapeType type)
        {
            var input = request.InputUnit.ToLower();
            var output = request.OutputUnit.ToLower();

            if (input == output)
            {
                return new SquareResponse()
                {
                    Value = value,
                    ShapeType = type.ToString(),
                    Unit = $"{input}²"
                };
            }

            if (input == UnitConstants.Centimeters)
            {
                return output switch
                {
                    UnitConstants.Millimeters => new SquareResponse() { Value = value * 100, Unit = UnitConstants.SquareMillimeters, ShapeType = type.ToString() },
                    UnitConstants.Meters => new SquareResponse() { Value = value / 10000, Unit = UnitConstants.SquareMeters, ShapeType = type.ToString() },
                    _ => throw new ArgumentException(UnitConstants.InvalidUnitMessage)
                };
            }

            if (input == UnitConstants.Millimeters)
            {
                return output switch
                {
                    UnitConstants.Centimeters => new SquareResponse() { Value = value / 100, Unit = UnitConstants.SquareCentimeters, ShapeType = type.ToString() },
                    UnitConstants.Meters => new SquareResponse() { Value = value / 1_000_000, Unit = UnitConstants.SquareMeters, ShapeType = type.ToString() },
                    _ => throw new ArgumentException(UnitConstants.InvalidUnitMessage)
                };
            }

            if (input == UnitConstants.Meters)
            {
                return output switch
                {
                    UnitConstants.Centimeters => new SquareResponse() { Value = value * 10_000, Unit = UnitConstants.SquareCentimeters, ShapeType = type.ToString() },
                    UnitConstants.Millimeters => new SquareResponse() { Value = value * 1_000_000, Unit = UnitConstants.SquareMillimeters, ShapeType = type.ToString() },
                    _ => throw new ArgumentException(UnitConstants.InvalidUnitMessage)
                };
            }

            throw new ArgumentException(UnitConstants.InvalidInputUnitMessage);
        }




    }
}
