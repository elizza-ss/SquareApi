using SquareWebApi.Const;
using SquareWebApi.Models;

namespace SquareWebApi.Services
{
    public class Validation
    {
        public static bool IsValid(BaseSquareRequest? request, out string? errorMessage)
        {
            errorMessage = null;

            if (request == null)
            {
                errorMessage = "Запрос не должен быть пустым.";
                return false;
            }

            if (request.InputUnit == null || request.OutputUnit == null)
            {
                errorMessage = "Единицы измерения (InputUnit и OutputUnit) обязательны.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(request.InputUnit) || string.IsNullOrWhiteSpace(request.OutputUnit))
            {
                errorMessage = "Единицы измерения (InputUnit и OutputUnit) обязательны.";
                return false;
            }

            if (!UnitConstants.ValidUnits.Contains(request.InputUnit.ToLower()) || !UnitConstants.ValidUnits.Contains(request.OutputUnit.ToLower()))
            {
                errorMessage = $"Единицы измерения должны быть одними из следующих: {string.Join(", ", UnitConstants.ValidUnits)}.";
                return false;
            }

            switch (request)
            {
                case TriangleSquareRequest triangleRequest:
                    if (triangleRequest.A <= 0 || triangleRequest.H <= 0)
                    {
                        errorMessage = "Основание (A) и высота (H) треугольника должны быть положительными числами.";
                        return false;
                    }
                    break;

                case RectangleSquareRequest rectangleRequest:
                    if (rectangleRequest.A <= 0 || rectangleRequest.B <= 0)
                    {
                        errorMessage = "Стороны прямоугольника (A и B) должны быть положительными числами.";
                        return false;
                    }
                    break;

                case CircleSquareRequest circleRequest:
                    if (circleRequest.R <= 0)
                    {
                        errorMessage = "Радиус круга (R) должен быть положительным числом.";
                        return false;
                    }
                    break;

                default:
                    errorMessage = "Некорректный тип запроса.";
                    return false;
            }

            return true;
        }
    }
}
