using System.ComponentModel.DataAnnotations;

namespace Cook.ViewModel;

    public class LoginVm
    {
        [Display(Name ="Email ou Nome do Usuário", Prompt ="Informe seu Email ou Nome de Usuário")]
        [Required(ErrorMessage ="Por favor, Informe seu email ou nome")]
        public string Email { get; set; }

        [Display(Name ="Senha de Acesso", Prompt ="*******")]
        [Required(ErrorMessage ="Por favor, informe sua senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name ="Manter Conectado?")]
        public bool Lembrar { get; set; } = false;

        public string UrlRetorno { get; set; }   
    }
