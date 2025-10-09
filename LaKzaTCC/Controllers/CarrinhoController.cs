using LaKzaTCC.Models;
using LaKzaTCC.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace LaKzaTCC.Controllers
{
    public class CarrinhoController : Controller
    {
        private const string CarrinhoSessionKey = "Carrinho";

        // Exibe o carrinho
        public IActionResult Index()
        {
            var carrinho = HttpContext.Session.GetObjectFromJson<List<CarrinhoItem>>(CarrinhoSessionKey) ?? new List<CarrinhoItem>();
            return View(carrinho);
        }

        // Adiciona um produto ao carrinho
        [HttpPost]
        public IActionResult Adicionar(int produtoId, string nome, decimal valor, string? foto)
        {
            var carrinho = HttpContext.Session.GetObjectFromJson<List<CarrinhoItem>>(CarrinhoSessionKey) ?? new List<CarrinhoItem>();

            var item = carrinho.FirstOrDefault(p => p.ProdutoId == produtoId);
            if (item != null)
                item.Quantidade++;
            else
                carrinho.Add(new CarrinhoItem { ProdutoId = produtoId, Nome = nome, ValorUnitario = valor, Foto = foto });

            HttpContext.Session.SetObjectAsJson(CarrinhoSessionKey, carrinho);
            return Json(new { sucesso = true, mensagem = $"{nome} adicionado ao carrinho!" });
        }

        // Remove um produto
        [HttpPost]
        public IActionResult Remover(int produtoId)
        {
            var carrinho = HttpContext.Session.GetObjectFromJson<List<CarrinhoItem>>(CarrinhoSessionKey) ?? new List<CarrinhoItem>();

            carrinho.RemoveAll(p => p.ProdutoId == produtoId);
            HttpContext.Session.SetObjectAsJson(CarrinhoSessionKey, carrinho);
            return RedirectToAction("Index");
        }

        // Limpa o carrinho
        public IActionResult Limpar()
        {
            HttpContext.Session.Remove(CarrinhoSessionKey);
            return RedirectToAction("Index");
        }
    }
}
