using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LaKzaTCC.Models;
using LaKzaTCC.Data;
using Microsoft.EntityFrameworkCore;
using LaKzaTCC.ViewModels;

namespace LaKzaTCC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        List<Produto> produtos = _db.Produtos
            .Where(p => p.Destaque)
            .ToList();
        return View(produtos);
    }

    public IActionResult Produto(int id)
    {
        Produto produto = _db.Produtos
            .Where(p => p.Id == id)
            .Include(p => p.Categoria)
            .Include(p => p.ArquivoFoto)
            .SingleOrDefault();
        
        List<Produto> semelhantes = _db.Produtos
            .Where(p => p.Id != id && p.CategoriaId == produto.CategoriaId)
            .Include(p => p.Categoria)
            .Include(p => p.ArquivoFoto)
            .Take(4)
            .ToList();
        
        ProdutoVM produtoVM = new() {
            Produto = produto,
            Semelhantes = semelhantes
        };
        
        return View(produtoVM);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}