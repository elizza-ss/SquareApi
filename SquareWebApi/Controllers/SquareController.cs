using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SquareWebApi.Models;
using SquareWebApi.Services;

namespace SquareWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SquareController : ControllerBase
    {
        /// <summary>
        /// Рассчитать площадь треугольника.
        /// </summary>
        /// <remarks>
        /// Пример запроса:
        /// 
        ///     POST /Square/CalculateTriangle
        ///     {
        ///        "A": 10,
        ///        "H": 5,
        ///        "InputUnit": "м",
        ///        "OutputUnit": "м"
        ///     }
        /// </remarks>
        /// <param name="request">Данные для расчета площади треугольника: основание (A), высота (H), единицы ввода и вывода.</param>
        /// <response code="200">Запрос успешный, площадь рассчитана.</response>
        /// <response code="400">Ошибка валидации данных.</response>
        [HttpPost("CalculateTriangle")]
        public ActionResult<SquareResponse> CalculateArea([FromBody] TriangleSquareRequest request)
        {

            if (!Validation.IsValid(request, out string? errorMessage))
            {
                return BadRequest(errorMessage);
            }
            return Ok(CalculateSquare.Calculate(ShapeType.Triangle, request));
            

        }
        /// <summary>
        /// Рассчитать площадь круга.
        /// </summary>
        /// <remarks>
        /// Пример запроса:
        /// 
        ///     POST /Square/CalculateCircle
        ///     {
        ///        "R": 7,
        ///        "InputUnit": "м",
        ///        "OutputUnit": "м"
        ///     }
        /// </remarks>
        /// <param name="request">Данные для расчета площади круга: радиус (R), единицы ввода и вывода.</param>
        /// <response code="200">Запрос успешный, площадь рассчитана.</response>
        /// <response code="400">Ошибка валидации данных.</response>
        [HttpPost("CalculateCircle")]
        public ActionResult<SquareResponse> CalculateArea([FromBody] CircleSquareRequest request)
        {
            if (!Validation.IsValid(request, out string? errorMessage))
            {
                return BadRequest(errorMessage);
            }
            return Ok(CalculateSquare.Calculate(ShapeType.Circle, request));
            

        }
        /// <summary>
        /// Рассчитать площадь прямоугольника.
        /// </summary>
        /// <remarks>
        /// Пример запроса:
        /// 
        ///     POST /Square/CalculateRectangle
        ///     {
        ///        "A": 15,
        ///        "B": 10,
        ///        "InputUnit": "м",
        ///        "OutputUnit": "м"
        ///     }
        /// </remarks>
        /// <param name="request">Данные для расчета площади прямоугольника: длина (A), ширина (B), единицы ввода и вывода.</param>
        /// <response code="200">Запрос успешный, площадь рассчитана.</response>
        /// <response code="400">Ошибка валидации данных.</response>
        [HttpPost("CalculateRectangle")]
        public ActionResult<SquareResponse> CalculateArea([FromBody] RectangleSquareRequest request)
        {
            if (!Validation.IsValid(request, out string? errorMessage))
            {
                return BadRequest(errorMessage);
            }
            return Ok(CalculateSquare.Calculate(ShapeType.Rectangle, request));
            

        }


    }
}

