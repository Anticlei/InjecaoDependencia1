namespace InjecaoDependencia1 {
   class MyXyzEmailService : IServicoEmail {
      public void EnviaEmail(string email, string titulo, string mensagem) {
         var xpto = new XyzEmailService();
         xpto.SendMail(email, titulo, mensagem);
      }
   }  
}
