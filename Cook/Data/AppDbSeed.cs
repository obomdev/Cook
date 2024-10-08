using Cook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Cook.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Categorias
        List<Categoria> categorias = new()
        {
            new Categoria() {
                Id = 1,
                Nome = "Acompanhamentos",
                Foto = "/img/categorias/1.jpg",
                ExibirHome = true
            },
            new Categoria() {
                Id = 2,
                Nome = "Bebidas",
                Foto = "/img/categorias/2.jpg"
            },
            new Categoria() {
                Id = 3,
                Nome = "Bolos",
                Foto = "/img/categorias/3.jpg",
                ExibirHome = true
            },
            new Categoria() {
                Id = 4,
                Nome = "Carnes",
                Foto = "/img/categorias/4.jpg",
                ExibirHome = true
            },
            new Categoria() {
                Id = 5,
                Nome = "Frango",
                Foto = "/img/categorias/5.jpg",
                ExibirHome = true
            },
            new Categoria() {
                Id = 6,
                Nome = "Lanches",
                Foto = "/img/categorias/6.jpg"
            },
            new Categoria() {
                Id = 7,
                Nome = "Massas",
                Foto = "/img/categorias/7.jpg"
            },
            new Categoria() {
                Id = 8,
                Nome = "Molhos",
                Foto = "/img/categorias/8.jpg"
            },
            new Categoria() {
                Id = 9,
                Nome = "Pratos Principais",
                Foto = "/img/categorias/9.jpg",
                ExibirHome = true
            },
            new Categoria() {
                Id = 10,
                Nome = "Peixes",
                Foto = "/img/categorias/10.jpg"
            },
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion

        #region Populate Ingredientes
        List<Ingrediente> ingredientes = new() {
            new Ingrediente() {
                Id = 1,
                Nome = "Carne Moída"
            },
            new Ingrediente() {
                Id = 2,
                Nome = "Pimentão Verde"
            },
            new Ingrediente() {
                Id = 3,
                Nome = "Pimentão Vermelho"
            },
            new Ingrediente() {
                Id = 4,
                Nome = "Pimentão Amarelo"
            },
            new Ingrediente() {
                Id = 5,
                Nome = "Cebola"
            },
            new Ingrediente() {
                Id = 6,
                Nome = "Curry"
            },
            new Ingrediente() {
                Id = 7,
                Nome = "Pimenta Calabresa"
            },
            new Ingrediente() {
                Id = 8,
                Nome = "Páprica Picante"
            },
            new Ingrediente() {
                Id = 9,
                Nome = "Sal"
            },
            new Ingrediente() {
                Id = 10,
                Nome = "Orégano"
            },
            new Ingrediente() {
                Id = 11,
                Nome = "Pão Sirio"
            },
            new Ingrediente() {
                Id = 12,
                Nome = "Cream Cheese"
            },
            new Ingrediente() {
                Id = 13,
                Nome = "Cheddar"
            },
            new Ingrediente() {
                Id = 14,
                Nome = "Azeite"
            }
        };
        builder.Entity<Ingrediente>().HasData(ingredientes);
        #endregion

        #region Populate Receita
        List<Receita> receitas = new() {
            new Receita() {
                Id = 1,
                Nome = "Carne Moída Mexicana",
                Descricao = "Prato perfeito para um lanche rápido ou mesmo uma refeição picante. Carne moída, pimentões, temperos e muito queijooooo",
                CategoriaId = 4,
                Dificuldade = Dificuldade.Facil,
                Rendimento = 3,
                TempoPreparo = "20 minutos",
                Foto = "/img/receitas/1.jpg",
                Preparo = "Comece pela preparação dos ingredientes, pique os pimentões e a cebola em pequenos cubos, se preferir você também pode usar um processador de alimentos."
                        + "Coloque a carne moída para fritar em uma panela com um pouco de azeite."
                        + "Quando a carne moída já não estiver mais crua, adicione os pimentões e a cebola, mexendo bem para misturar todos os ingredientes."
                        + "Aguarde alguns instante e adicione os temperos, mexendo novamente para misturar."
                        + "Frite por mais alguns minutos a carne com os demais ingredientes."
                        + "Adicione o Cream Cheese e o Queijo Cheddar, mexendo bem para evitar que queime o fundo e ajudar os queijos a derreterem."
                        + "Quando os queijos já estiverem bem derretidos e misturados com os demais ingredientes, sirva acompanhado do Pão Sirio ou de Doritos."
            }
        };
        builder.Entity<Receita>().HasData(receitas);
        #endregion

        #region Populate ReceitaIngrediente
        List<ReceitaIngrediente> receitaIngredientes = new() {
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 1,
                Quantidade = "500g"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 3,
                Quantidade = "1 pequeno"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 4,
                Quantidade = "1 pequeno"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 5,
                Quantidade = "1 pequeno"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 6,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 7,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 8,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 9,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 10,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 11,
                Quantidade = "A vontade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 12,
                Quantidade = "200g"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 13,
                Quantidade = "200g"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 14,
                Quantidade = "Um pouco"
            }
        };
        builder.Entity<ReceitaIngrediente>().HasData(receitaIngredientes);
        #endregion

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
               Name = "Usuário",
               NormalizedName = "USUÁRIO"
            },
            new IdentityRole() {
               Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
               Name = "Moderador",
               NormalizedName = "MODERADOR"
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new() {
            new IdentityUser(){
                Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                Email = "admin@gcook.com",
                NormalizedEmail = "ADMIN@GCOOK.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "Abner da Silva Santos",
                DataNascimento = DateTime.Parse("05/08/1981")
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}