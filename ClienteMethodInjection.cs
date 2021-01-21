using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDependencia1 {
   class ClienteMethodInjection {
      public string Nome { get; set; }
      public string Email { get; set; }

      public ClienteMethodInjection(string nome, string email) {
         Nome = nome;
         Email = email;
      }

      public void EnviarEmail(string titulo, string mensagem, IServicoEmail servicoEmail) {
         Console.WriteLine($"ClienteMethod {Nome} enviando e-mail:");
         servicoEmail.EnviaEmail(Email, titulo, mensagem);
      }
   }
}
