using Microsoft.AspNetCore.Mvc;

namespace YourCarSlot.Api.Models;

internal sealed class CustomValidationProblemDetails : ProblemDetails
{
    public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
}