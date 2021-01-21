using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDependencia1 {
   class ClienteGeterSeter {
      public string Nome { get; set; }
      public string Email { get; set; }
      public IServicoEmail ServicoEmail { get; set; }

      public ClienteGeterSeter(string nome, string email) {
         Nome = nome;
         Email = email;
      }

      public void EnviarEmail(string titulo, string mensagem) {
         Console.WriteLine($"ClienteSetter {Nome} enviando e-mail:");
         ServicoEmail.EnviaEmail(Email, titulo, mensagem);
      }
   }
}
