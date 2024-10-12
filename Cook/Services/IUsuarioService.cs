using Cook.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.Win32;

namespace Cook.Services;

    public interface IUsuarioService
    {
        Task<UsuarioVM> GetUsuarioLogado();
        Task<SignInResult> LoginUsuario(LoginVm login);
        Task LogoffUsuario();
        Task<List<string>> RegistrarUsuario(RegistroVm registro);
        Task<bool> ConfirmarEmail(string userId, string code);
    }
