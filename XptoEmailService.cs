using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDependencia1 {
   class XptoEmailService {

      public void SendMail(string email, string titulo, string mensagem) {
         Console.WriteLine($"Xpto.SendMail to {email}");
         Console.WriteLine($"Xpto.Título: {titulo}");
         Console.WriteLine($"Xpto.Mensagem: {mensagem}");
      }
   }
}
