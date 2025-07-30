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
            new Categoria { Id = 3, Nome = "Sabonetes" },
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
            new Produto { Id = 6, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS ALECRIM 250ML", ValorCusto = 8000.00m, ValorVenda = 238.00m, QtdeEstoque = 5, Destaque = true },
            new Produto { Id = 7, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS BABY 300ML", ValorCusto = 7000.00m, ValorVenda = 238.00m, QtdeEstoque = 7 },
            new Produto { Id = 8, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS ? 250ML", ValorCusto = 7500.00m, ValorVenda = 238.00m, QtdeEstoque = 6 },
            new Produto { Id = 9, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS TRUSS 250ML", ValorCusto = 5000.00m, ValorVenda = 238.00m, QtdeEstoque = 10 },
            new Produto { Id = 10, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS BOUQUET 250ML", ValorCusto = 7200.00m, ValorVenda = 238.00m, QtdeEstoque = 8 },
            new Produto { Id = 10, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS LIFE 250ML", ValorCusto = 7200.00m, ValorVenda = 168.00m, QtdeEstoque = 4 },
            new Produto { Id = 10, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS CITRUS 250ML", ValorCusto = 7200.00m, ValorVenda = 238.00m, QtdeEstoque = 8 },
            new Produto { Id = 10, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS FIGO MADEIRA 250ML", ValorCusto = 7200.00m, ValorVenda = 168.00m, QtdeEstoque = 10 },
            new Produto { Id = 10, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS MAGNOLIA 250ML", ValorCusto = 7200.00m, ValorVenda = 168.00m, QtdeEstoque = 9 },
            new Produto { Id = 10, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS MANDARINA 250ML", ValorCusto = 7200.00m, ValorVenda = 168.00m, QtdeEstoque = 8 },
            new Produto { Id = 10, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS VANILLA-PACHOULLI 250ML", ValorCusto = 7200.00m, ValorVenda = 168.00m, QtdeEstoque = 12 },
            new Produto { Id = 10, CategoriaId = 2, Nome = "DIFUSOR DE AROMAS BAMBOO 250ML", ValorCusto = 7200.00m, ValorVenda = 238.00m, QtdeEstoque = 8 },

            // Sabonetes
            new Produto { Id = 11, CategoriaId = 3, Nome = "SABONETE LÍQUIDO BABY 350ML", ValorCusto = 2500.00m, ValorVenda = 128.00m, QtdeEstoque = 10, Destaque = true },
            new Produto { Id = 12, CategoriaId = 3, Nome = "SABONETE LÍQUIDO ? 350ML", ValorCusto = 1500.00m, ValorVenda = 128.00m, QtdeEstoque = 15 },
            new Produto { Id = 13, CategoriaId = 3, Nome = "SABONETE LÍQUIDO TRUSS 350ML",  ValorCusto = 3500.00m, ValorVenda = 128.00m, QtdeEstoque = 5 },
            new Produto { Id = 14, CategoriaId = 3, Nome = "SABONETE LÍQUIDO PRAIA 350ML",  ValorCusto = 800.00m, ValorVenda = 128.00m, QtdeEstoque = 20 },
            new Produto { Id = 15, CategoriaId = 3, Nome = "SABONETE LÍQUIDO LIFE 350ML", ValorCusto = 1200.00m, ValorVenda = 128.00m, QtdeEstoque = 12 },
            new Produto { Id = 15, CategoriaId = 3, Nome = "SABONETE LÍQUIDO BAMBOO 350ML", ValorCusto = 1200.00m, ValorVenda = 128.00m, QtdeEstoque = 12 },
            new Produto { Id = 15, CategoriaId = 3, Nome = "SABONETE LÍQUIDO ALECRIM 350ML", ValorCusto = 1200.00m, ValorVenda = 128.00m, QtdeEstoque = 12 },
            new Produto { Id = 15, CategoriaId = 3, Nome = "SABONETE MOUSSE VANILLA-PACHOULLI 300ML", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12 },
            new Produto { Id = 15, CategoriaId = 3, Nome = "SABONETE MOUSSE MANDARINA 300ML ", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12 },
            new Produto { Id = 15, CategoriaId = 3, Nome = "SABONETE MOUSSE MAGNÓLIA 300ML", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12 },
            new Produto { Id = 15, CategoriaId = 3, Nome = "SABONETE MOUSSE LAVANDA 300ML", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12 },
            new Produto { Id = 15, CategoriaId = 3, Nome = "SABONETE MOUSSE FIGO-MADEIRA 300ML", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12 },
            new Produto { Id = 15, CategoriaId = 3, Nome = "SABONETE MOUSSE CITRUS 300ML", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12 },
            new Produto { Id = 15, CategoriaId = 3, Nome = "SABONETE MOUSSE BOUQUET DE VERÃO 300ML", ValorCusto = 1200.00m, ValorVenda = 78.00m, QtdeEstoque = 12 },

            // Vela
            new Produto { Id = 16, CategoriaId = 4, Nome = "VELA DECORATIVA TRUSS", ValorCusto = 900.00m, ValorVenda = 168.00m, QtdeEstoque = 12, Destaque = true },
            new Produto { Id = 17, CategoriaId = 4, Nome = "VELA AROMÁTICA VANILLA-PACHOULLI",  ValorCusto = 1400.00m, ValorVenda = 92.00m, QtdeEstoque = 10 },
            new Produto { Id = 18, CategoriaId = 4, Nome = "VELA AROMÁTICA BOUQUET",  ValorCusto = 600.00m, ValorVenda = 92.00m, QtdeEstoque = 20 },
            new Produto { Id = 19, CategoriaId = 4, Nome = "VELA AROMÁTICA CITRUS", ValorCusto = 800.00m, ValorVenda = 92.00m, QtdeEstoque = 15 },
            new Produto { Id = 20, CategoriaId = 4, Nome = "VELA AROMÁTICA FIGO-MADEIRA",  ValorCusto = 400.00m, ValorVenda = 92.00m, QtdeEstoque = 25 },
            new Produto { Id = 20, CategoriaId = 4, Nome = "VELA AROMÁTICA LAVANDA",  ValorCusto = 400.00m, ValorVenda = 92.00m, QtdeEstoque = 25 },
            new Produto { Id = 20, CategoriaId = 4, Nome = "VELA AROMÁTICA MAGNÓLIA",  ValorCusto = 400.00m, ValorVenda = 92.00m, QtdeEstoque = 25 },
            new Produto { Id = 20, CategoriaId = 4, Nome = "VELA AROMÁTICA MANDARINA",  ValorCusto = 400.00m, ValorVenda = 92.00m, QtdeEstoque = 25 },
           
            // Aromatizador
            new Produto { Id = 21, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES ? 500ML",  ValorCusto = 1200.00m, ValorVenda = 208.00m, QtdeEstoque = 8, Destaque = true },
            new Produto { Id = 22, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES TRUSS 500ML", ValorCusto = 1400.00m, ValorVenda = 208.00m, QtdeEstoque = 10 },
            new Produto { Id = 23, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES PRAIA 500ML",  ValorCusto = 900.00m, ValorVenda = 208.00m, QtdeEstoque = 15 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES LIFE 500ML", ValorCusto = 2000.00m, ValorVenda = 208.00m, QtdeEstoque = 5 },
            new Produto { Id = 25, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES BAMBOO 500ML",  ValorCusto = 2500.00m, ValorVenda = 208.00m, QtdeEstoque = 6 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES BABY 500ML", ValorCusto = 2000.00m, ValorVenda = 208.00m, QtdeEstoque = 5 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES ALECRIM 500ML", ValorCusto = 2000.00m, ValorVenda = 208.00m, QtdeEstoque = 5 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES BABY 200ML", ValorCusto = 2000.00m, ValorVenda = 208.00m, QtdeEstoque = 5 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES PRAIA 120ML", ValorCusto = 2000.00m, ValorVenda = 128.00m, QtdeEstoque = 5 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES ? 120ML", ValorCusto = 2000.00m, ValorVenda = 128.00m, QtdeEstoque = 5 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES TRUSS 120ML", ValorCusto = 2000.00m, ValorVenda = 128.00m, QtdeEstoque = 5 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES LIFE 120ML", ValorCusto = 2000.00m, ValorVenda = 128.00m, QtdeEstoque = 5 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES BAMBOO 120ML", ValorCusto = 2000.00m, ValorVenda = 128.00m, QtdeEstoque = 5 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES ALECRIM 120ML", ValorCusto = 2000.00m, ValorVenda = 128.00m, QtdeEstoque = 5 },
            new Produto { Id = 24, CategoriaId = 5, Nome = "AROMATIZADOR DE AMBIENTES BOUQUET DE VERÃO 200ML", ValorCusto = 2000.00m, ValorVenda = 88.00m, QtdeEstoque = 5 },


            //Spray car
            new Produto { Id = 26, CategoriaId = 6, Nome = "SPRAY CAR TRUSS 60ML",  ValorCusto = 700.00m, ValorVenda = 58.00m, QtdeEstoque = 20, Destaque = true },
            new Produto { Id = 27, CategoriaId = 6, Nome = "SPRAY CAR BAMBOO 60ML",  ValorCusto = 800.00m, ValorVenda = 58.00m, QtdeEstoque = 12 },
    

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