using Business;
using Business.DataSeedService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace App
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AdminAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // skip authorization if action is decorated with [AllowAnonymous] attribute
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous)
                return;

            // authorization
            var rawRoles = context.HttpContext.Items[AuthOptions.USER_ROLES_CLAIM] as string;

            if (rawRoles == null || !ValidateRoleAdmin(rawRoles))
                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
        }

        private bool ValidateRoleAdmin(string rawRoles)
        {
            var roles = rawRoles.Split(',').ToList();
            if (roles.Contains(RoleDataSeedService.AdminRole.Name))
                return true;

            return false;
        }
    }
}
