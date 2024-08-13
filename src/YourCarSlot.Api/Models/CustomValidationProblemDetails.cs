using Microsoft.AspNetCore.Mvc;

namespace YourCarSlot.Api.Models;

public sealed class CustomValidationProblemDetails : ProblemDetails
{
    public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
}