using IdentityAndUserManagement.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IdentityAndUserManagement.Controllers
{
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var rolesResult = await _roleManager.Roles.ToListAsync();
            return View(rolesResult);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(RoleFormViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View("Index", await _roleManager.Roles.ToListAsync());
            }
            var roleExist = await _roleManager.RoleExistsAsync(model.Name);
            if (roleExist)
            {
                ModelState.AddModelError("Name","Role is exist!");
                return View("Index", await _roleManager.Roles.ToListAsync());
            }
            await _roleManager.CreateAsync(new IdentityRole(model.Name));
            return RedirectToAction(nameof(Index));
        }
    }
}
