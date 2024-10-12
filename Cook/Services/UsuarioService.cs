using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Cook.Data;
using Cook.ViewModel;
using Microsoft.EntityFrameworkCore;
using Cook.Helpers;
using Cook.Models;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Encodings.Web;

namespace Cook.Services;

public class UsuarioService : IUsuarioService
{
    private readonly AppDbContext _contexto;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IUserStore<IdentityUser> _userStore;
    private readonly IUserEmailStore<IdentityUser> _emailStore;
    private readonly IWebHostEnvironment _hostEnvironment;
    private readonly IEmailSender _emailSender;
    private readonly ILogger<UsuarioService> _logger;

    public UsuarioService(
        AppDbContext contexto,
        SignInManager<IdentityUser> signInManager,
        UserManager<IdentityUser> userManager,
        IHttpContextAccessor httpContextAccessor,
        IUserStore<IdentityUser> userStore,
        IWebHostEnvironment hostEnvironment,
        IEmailSender emailSender,
        ILogger<UsuarioService> logger

    )
    {
        _contexto = contexto;
        _signInManager = signInManager;
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
        _userStore = userStore;
        _emailStore = (IUserEmailStore<IdentityUser>)_userStore;

    }



    public Task<bool> ConfirmarEmail(string userId, string code)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioVM> GetUsuarioLogado()
    {
        throw new NotImplementedException();
    }

    public Task<SignInResult> LoginUsuario(LoginVm login)
    {
        throw new NotImplementedException();
    }

    public Task LogoffUsuario()
    {
        throw new NotImplementedException();
    }

    public Task<List<string>> RegistrarUsuario(RegistroVm registro)
    {
        throw new NotImplementedException();
    }
}
