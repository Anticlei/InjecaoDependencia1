namespace InjecaoDependencia1 {
   class MyXptoEmailService: IServicoEmail {
      public void EnviaEmail(string email, string titulo, string mensagem) {
         var xpto = new XptoEmailService();
         xpto.SendMail(email, titulo, mensagem);
      }
   }
}
