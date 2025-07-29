using LaKzaTCC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LaKzaTCC.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        List<Categoria> categorias = new() {
            new Categoria { Id = 1, Nome = "Kit" },
            new Categoria { Id = 2, Nome = "Difusor de Aroma" },
            new Categoria { Id = 3, Nome = "Essência" },
            new Categoria { Id = 4, Nome = "Vela" },
            new Categoria { Id = 5, Nome = "Aromatizador" },
            new Categoria { Id = 6, Nome = "Spray Car" },
        };
        builder.Entity<Categoria>().HasData(categorias);

        List<Produto> produtos = new List<Produto>
        {
            // Kit
            new Produto { Id = 1, CategoriaId = 1, Nome = "KIT ALMOFADA BABY ", ValorCusto = 4500.00m, ValorVenda = 118.00m, QtdeEstoque = 10, Destaque = true },
            new Produto { Id = 2, CategoriaId = 1, Nome = "KIT PRESENTE", ValorCusto = 4000.00m, ValorVenda = 68.00m, QtdeEstoque = 15, Destaque = true },
            new Produto { Id = 3, CategoriaId = 1, Nome = "KIT ALMOFADA TRUSS",  ValorCusto = 3500.00m, ValorVenda = 118.00m, QtdeEstoque = 20 },
            

            // Difusor
            new Produto { Id = 6, CategoriaId = 2, Nome = "MacBook Pro M2", ValorCusto = 8000.00m, ValorVenda = 11999.00m, QtdeEstoque = 5, Destaque = true },
            new Produto { Id = 7, CategoriaId = 2, Nome = "Dell XPS 15", ValorCusto = 7000.00m, ValorVenda = 9999.00m, QtdeEstoque = 7 },
            new Produto { Id = 8, CategoriaId = 2, Nome = "Asus ROG Strix G15", ValorCusto = 7500.00m, ValorVenda = 10999.00m, QtdeEstoque = 6 },
            new Produto { Id = 9, CategoriaId = 2, Nome = "Lenovo ThinkPad X1", ValorCusto = 5000.00m, ValorVenda = 7999.00m, QtdeEstoque = 10 },
            new Produto { Id = 10, CategoriaId = 2, Nome = "HP Spectre x360", ValorCusto = 7200.00m, ValorVenda = 10499.00m, QtdeEstoque = 8 },

            // Smartwatches
            new Produto { Id = 11, CategoriaId = 3, Nome = "Apple Watch Series 8", ValorCusto = 2500.00m, ValorVenda = 3999.00m, QtdeEstoque = 10, Destaque = true },
            new Produto { Id = 12, CategoriaId = 3, Nome = "Samsung Galaxy Watch 5", ValorCusto = 1500.00m, ValorVenda = 2499.00m, QtdeEstoque = 15 },
            new Produto { Id = 13, CategoriaId = 3, Nome = "Garmin Fenix 7",  ValorCusto = 3500.00m, ValorVenda = 4999.00m, QtdeEstoque = 5 },
            new Produto { Id = 14, CategoriaId = 3, Nome = "Xiaomi Mi Watch",  ValorCusto = 800.00m, ValorVenda = 1499.00m, QtdeEstoque = 20 },
            new Produto { Id = 15, CategoriaId = 3, Nome = "Fitbit Sense 2", ValorCusto = 1200.00m, ValorVenda = 2099.00m, QtdeEstoque = 12 },

            // Fones de Ouvido
            new Produto { Id = 16, CategoriaId = 4, Nome = "AirPods Pro", ValorCusto = 900.00m, ValorVenda = 1499.00m, QtdeEstoque = 12, Destaque = true },
            new Produto { Id = 17, CategoriaId = 4, Nome = "Sony WH-1000XM5",  ValorCusto = 1400.00m, ValorVenda = 2199.00m, QtdeEstoque = 10 },
            new Produto { Id = 18, CategoriaId = 4, Nome = "JBL Live 660NC",  ValorCusto = 600.00m, ValorVenda = 999.00m, QtdeEstoque = 20 },
            new Produto { Id = 19, CategoriaId = 4, Nome = "Beats Studio Buds", ValorCusto = 800.00m, ValorVenda = 1299.00m, QtdeEstoque = 15 },
            new Produto { Id = 20, CategoriaId = 4, Nome = "Razer Kraken X",  ValorCusto = 400.00m, ValorVenda = 699.00m, QtdeEstoque = 25 },

            // Monitores
            new Produto { Id = 21, CategoriaId = 5, Nome = "LG Ultragear 27\"",  ValorCusto = 1200.00m, ValorVenda = 1899.00m, QtdeEstoque = 8, Destaque = true },
            new Produto { Id = 22, CategoriaId = 5, Nome = "Samsung Odyssey G5", ValorCusto = 1400.00m, ValorVenda = 2399.00m, QtdeEstoque = 10 },
            new Produto { Id = 23, CategoriaId = 5, Nome = "AOC Hero 24\"",  ValorCusto = 900.00m, ValorVenda = 1499.00m, QtdeEstoque = 15 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "Dell P2723QE", ValorCusto = 2000.00m, ValorVenda = 3299.00m, QtdeEstoque = 5 },
            new Produto { Id = 25, CategoriaId = 5, Nome = "BenQ Zowie XL2546",  ValorCusto = 2500.00m, ValorVenda = 3999.00m, QtdeEstoque = 6 },

            // Teclados e Mouses
            new Produto { Id = 26, CategoriaId = 6, Nome = "Logitech G Pro X",  ValorCusto = 700.00m, ValorVenda = 1099.00m, QtdeEstoque = 20, Destaque = true },
            new Produto { Id = 27, CategoriaId = 6, Nome = "Razer Huntsman Mini",  ValorCusto = 800.00m, ValorVenda = 1299.00m, QtdeEstoque = 12 },
            new Produto { Id = 28, CategoriaId = 6, Nome = "HyperX Alloy FPS",  ValorCusto = 600.00m, ValorVenda = 999.00m, QtdeEstoque = 18 },
            new Produto { Id = 29, CategoriaId = 6, Nome = "Logitech G502 Hero", ValorCusto = 300.00m, ValorVenda = 599.00m, QtdeEstoque = 25 },
            new Produto { Id = 30, CategoriaId = 6, Nome = "Razer DeathAdder V2",  ValorCusto = 400.00m, ValorVenda = 699.00m, QtdeEstoque = 20 },

        };
        builder.Entity<Produto>().HasData(produtos);

        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole() {
               Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
               Id = "bec71b05-8f3d-4849-88bb-0e8d518d2de8",
               Name = "Funcionário",
               NormalizedName = "FUNCIONÁRIO"
            },
            new IdentityRole() {
               Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
               Name = "Cliente",
               NormalizedName = "CLIENTE"
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate Usuário
        List<Usuario> usuarios = new() {
            new Usuario(){
                Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                Email = "gallojunior@gmail.com",
                NormalizedEmail = "GALLOJUNIOR@GMAIL.COM",
                UserName = "GalloJunior",
                NormalizedUserName = "GALLOJUNIOR",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Nome = "José Antonio Gallo Junior",
            }
        };
        foreach (var user in usuarios)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "123456");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}