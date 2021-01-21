using System;

namespace InjecaoDependencia1 {
   class Cliente {

      public string Nome { get; set; }
      public string Email { get; set; }

      private IServicoEmail _servicoEmail;

      public Cliente(string nome, string email, IServicoEmail servicoEmail) {
         Nome = nome;
         Email = email;
         _servicoEmail = servicoEmail;
      }

      public void EnviarEmail(string titulo, string mensagem) {
         Console.WriteLine($"ClienteConstructor {Nome} enviando e-mail:");
         _servicoEmail.EnviaEmail(Email, titulo, mensagem);
      }
   }
}
