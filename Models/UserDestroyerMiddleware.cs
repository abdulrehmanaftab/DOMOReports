﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammaticFiltering.Models
{
    public class UserDestroyerMiddleware
    {
        private readonly RequestDelegate _next;

        public UserDestroyerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            //var user1 = await userManager.GetUserAsync(httpContext.User);

            if (!string.IsNullOrEmpty(httpContext.User.Identity.Name))
            {
                var user = await userManager.FindByNameAsync(httpContext.User.Identity.Name);

                if (user.LockoutEnd > DateTimeOffset.Now)
                {
                    //Log the user out and redirect back to homepage
                    await signInManager.SignOutAsync();
                    httpContext.Response.StatusCode = 401;

                    httpContext.Response.ContentType = "application/json";

                    await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(new
                    {
                        Message = "Custom Response Message"

                    }));
                }
            }
            await _next(httpContext);
        }
    }

    public static class UserDestroyerMiddlewareExtensions
    {
        public static IApplicationBuilder UseUserDestroyer(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UserDestroyerMiddleware>();
        }
    }
}
