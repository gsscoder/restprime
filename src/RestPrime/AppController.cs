using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestPrime.Models;

namespace RestPrime;

public abstract class AppController : ControllerBase
{
    #region Results helpers
    protected static IActionResult BadRequest(string message, string? detail = null) =>
        new ObjectResult(new ErrorResult
        {
            Type = ErrorResult.Error400BadRequest,
            Title = message,
            Status = StatusCodes.Status400BadRequest,
            Detail = detail,
        })
        {
            StatusCode = StatusCodes.Status400BadRequest
        };

    protected static IActionResult Unauthorized(string message) =>
        new ObjectResult(new ErrorResult
        {
            Type = ErrorResult.Error401Unauthorized,
            Title = "Unauthorized",
            Status = StatusCodes.Status401Unauthorized,
            Detail = message,
        })
        {
            StatusCode = StatusCodes.Status401Unauthorized
        };
    #endregion
}
