using Client.Base;
using Client.Models;
using Client.Repositories.Data;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers;

public class ShoppingCartController : BaseController<ShoppingCart,ShoppingCartRepository,int>
{
    private readonly ShoppingCartRepository _shoppingcartrepository;

    public ShoppingCartController(ShoppingCartRepository repository) : base(repository)
    {
        this._shoppingcartrepository = repository;
    }

    // Index
    //[Authorize(Roles = "Admin")]
    public async Task<IActionResult> Index()
    {
        var result = await _shoppingcartrepository.Get();
        var shoppingcarts = new List<ShoppingCart>();

        if (result.Data != null)
        {
            shoppingcarts = result.Data.ToList();
        }

        return View(shoppingcarts);
    }

    // Details
    public async Task<IActionResult> Details(int id)
    {
        var result = await _shoppingcartrepository.Get(id);
        return View(result.Data);
    }

    // Create - GET
    [HttpGet]
    public async Task<IActionResult> Create()
    {
        return View();
    }

    // Create - POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ShoppingCart shoppingcart)
    {
        if (ModelState.IsValid)
        {
            var result = await _shoppingcartrepository.Post(shoppingcart);
            if (result.StatusCode == "200")
            {
                TempData["Success"] = "Data berhasil masuk";
                return RedirectToAction(nameof(Index));
            }
            else if (result.StatusCode == "409")
            {
                ModelState.AddModelError(string.Empty, result.Message);
                return View();
            }
        }
        return View();
    }

    // Edit - GET
    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _shoppingcartrepository.Get(id);
        return View(result.Data);
    }

    // Edit - POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(ShoppingCart shoppingcart, int id)
    {
        if (ModelState.IsValid)
        {
            var result = await _shoppingcartrepository.Put(shoppingcart, id);
            if (result.StatusCode == "200")
            {
                TempData["Success"] = "Data berhasil diedit";
                return RedirectToAction(nameof(Index));
            }
            else if (result.StatusCode == "409")
            {
                ModelState.AddModelError(string.Empty, result.Message);
                return View();
            }
        }
        return View();
    }

    // Delete - GET
    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _shoppingcartrepository.Get(id);
        return View(result.Data);
    }

    // Delete - POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Remove(int id)
    {
        if (ModelState.IsValid)
        {
            var result = await _shoppingcartrepository.Delete(id);
            if (result.StatusCode == "200")
            {
                TempData["Success"] = "Data berhasil dihapus";
                return RedirectToAction(nameof(Index));
            }
            else if (result.StatusCode == "409")
            {
                ModelState.AddModelError(string.Empty, result.Message);
                return View();
            }
        }
        return View();

    }
}
