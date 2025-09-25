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
    public IActionResult Sobre()
{
    return View();
}

public IActionResult Contatos()
{
    return View();
}

   public IActionResult Index()
{
    List<Produto> produtos = _db.Produtos
        .ToList();

    return View(produtos);
}
    public IActionResult Produto(int id)
    {
        Produto produto = _db.Produtos
            .Where(p => p.Id == id)
            .Include(p => p.Categoria)
            .SingleOrDefault();
        
        List<Produto> semelhantes = _db.Produtos
            .Where(p => p.Id != id && p.CategoriaId == produto.CategoriaId)
            .Include(p => p.Categoria)
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
    public IActionResult Confirmacao(int id)
{
    var pedido = _db.Pedidos
        .Include(p => p.Itens)
        .ThenInclude(i => i.Produto)
        .FirstOrDefault(p => p.Id == id);

    if (pedido == null)
        return NotFound();

    return View(pedido);
}

    [HttpPost]
public IActionResult Comprar(int id)
{
    var produto = _db.Produtos.Find(id);
    if (produto == null || produto.QtdeEstoque <= 0)
    {
        return NotFound("Produto indisponível.");
    }

    // Atualiza estoque
    produto.QtdeEstoque -= 1;

    // Cria o pedido
    var pedido = new Pedido();
    var item = new PedidoItem
    {
        ProdutoId = produto.Id,
        Quantidade = 1,
        ValorUnitario = produto.ValorVenda
    };

    pedido.Itens.Add(item);

    _db.Pedidos.Add(pedido);
    _db.SaveChanges();

    return RedirectToAction("Confirmacao", new { id = pedido.Id });
}

}