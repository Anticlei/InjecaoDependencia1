using System;

namespace InjecaoDependencia1 {
   class XyzEmailService {

      public void SendMail(string email, string titulo, string mensagem) {
         Console.WriteLine($"Xyz.SendMail to {email}");
         Console.WriteLine($"Xyz.Título: {titulo}");
         Console.WriteLine($"Xyz.Mensagem: {mensagem}");
      }
   }
}
