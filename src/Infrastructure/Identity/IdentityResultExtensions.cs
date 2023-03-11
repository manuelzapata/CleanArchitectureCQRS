using CleanArchitectureCQRS.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitectureCQRS.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
