using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProgrammaticFiltering.Data;
using ProgrammaticFiltering.Models;

namespace ProgrammaticFiltering.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private IPasswordHasher<ApplicationUser> _passwordHasher;
        private IPasswordValidator<ApplicationUser> _passwordValidator;
        private IUserValidator<ApplicationUser> _userValidator;
        private ApplicationDbContext _dbContext;

        public AdminController(UserManager<ApplicationUser> usrMgr, ApplicationDbContext ctx, RoleManager<IdentityRole> roleMgr, IPasswordHasher<ApplicationUser> passwordHash, IPasswordValidator<ApplicationUser> passwordVal, IUserValidator<ApplicationUser> userValid)
        {
            _userManager = usrMgr;
            _roleManager = roleMgr;
            _passwordHasher = passwordHash;
            _dbContext = ctx;
            _passwordValidator = passwordVal;
            _userValidator = userValid;
        }

        public IActionResult Index()
        {            
            return View(_userManager.Users);
        }

        public IActionResult Create()
        {
            var roles = _roleManager.Roles.AsQueryable().Where(m => m.Name != "admin");
            var list = roles.Select(m => new SelectListItem() { Text = m.Name, Value = m.Name });
            ViewBag.Roles = list;
            var clients = _dbContext.Clients.ToList();
            var clientsList = clients.Select(m => new SelectListItem() { Text = m.client_name, Value = m.client_id.ToString() });
            ViewBag.Clients = clientsList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser ApplicationUser = new ApplicationUser
                {
                    UserName = user.Name,
                    Email = user.Email,
                    ClientId = user.ClientID,
                    EmailConfirmed = true
                };

                IdentityResult result = await _userManager.CreateAsync(ApplicationUser, user.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(ApplicationUser, user.RoleID);
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(user);
        }

        /*[HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser ApplicationUser = new ApplicationUser
                {
                    UserName = user.Name,
                    Email = user.Email,
                    Country = user.Country,
                    Age = user.Age,
                    Salary = user.Salary
                };

                IdentityResult result = await _userManager.CreateAsync(ApplicationUser, user.Password);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(user);
        }*/

        public async Task<IActionResult> Update(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
                return View(user);
            else
                return RedirectToAction("Index");
        }

        /*[HttpPost]
        public async Task<IActionResult> Update(string id, string email, string password)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                if (!string.IsNullOrEmpty(email))
                    user.Email = email;
                else
                    ModelState.AddModelError("", "Email cannot be empty");

                if (!string.IsNullOrEmpty(password))
                    user.PasswordHash = _passwordHasher.HashPassword(user, password);
                else
                    ModelState.AddModelError("", "Password cannot be empty");

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View(user);
        }*/

        [HttpPost]
        public async Task<IActionResult> Disable(string id, bool lockUser = false)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                if (lockUser)
                {
                    await _userManager.SetLockoutEnabledAsync(user, true);
                    await _userManager.SetLockoutEndDateAsync(user, DateTime.Today.AddYears(10));
                }
                else
                {
                    await _userManager.SetLockoutEndDateAsync(user, DateTime.Today.AddYears(-10));
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(string id, string email, string password, bool lockUser = false)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult validEmail = null;
                if (!string.IsNullOrEmpty(email))
                {
                    validEmail = await _userValidator.ValidateAsync(_userManager, user);
                    if (validEmail.Succeeded)
                        user.Email = email;
                    else
                        Errors(validEmail);
                }
                else
                    ModelState.AddModelError("", "Email cannot be empty");

                IdentityResult validPass = null;
                if (!string.IsNullOrEmpty(password))
                {
                    validPass = await _passwordValidator.ValidateAsync(_userManager, user, password);
                    if (validPass.Succeeded)
                        user.PasswordHash = _passwordHasher.HashPassword(user, password);
                    else
                        Errors(validPass);
                }
                else
                    ModelState.AddModelError("", "Password cannot be empty");

                if (validEmail != null && validPass != null && validEmail.Succeeded && validPass.Succeeded)
                {
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");

            return View(user);
        }

        /*[HttpPost]
        public async Task<IActionResult> Update(string id, string email, string password, int age, string country, string salary)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult validEmail = null;
                if (!string.IsNullOrEmpty(email))
                {
                    validEmail = await _userValidator.ValidateAsync(_userManager, user);
                    if (validEmail.Succeeded)
                        user.Email = email;
                    else
                        Errors(validEmail);
                }
                else
                    ModelState.AddModelError("", "Email cannot be empty");

                IdentityResult validPass = null;
                if (!string.IsNullOrEmpty(password))
                {
                    validPass = await _passwordValidator.ValidateAsync(_userManager, user, password);
                    if (validPass.Succeeded)
                        user.PasswordHash = _passwordHasher.HashPassword(user, password);
                    else
                        Errors(validPass);
                }
                else
                    ModelState.AddModelError("", "Password cannot be empty");

                user.Age = age;

                Country myCountry;
                Enum.TryParse(country, out myCountry);
                user.Country = myCountry;

                if (!string.IsNullOrEmpty(salary))
                    user.Salary = salary;
                else
                    ModelState.AddModelError("", "Salary cannot be empty");

                if (validEmail != null && validPass != null && validEmail.Succeeded && validPass.Succeeded && !string.IsNullOrEmpty(salary))
                {
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");

            return View(user);
        }*/

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View("Index", _userManager.Users);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}
