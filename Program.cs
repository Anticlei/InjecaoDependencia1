using System;

namespace InjecaoDependencia1 {
   class Program {
      static void Main(string[] args) {
         // usando a classe Cliente com o método Constructor Injection
         Console.WriteLine("Testando Constructor Injection");
         Console.WriteLine("****************************************************");
         Console.WriteLine("");
         Console.WriteLine("Testando XptoEmailService Constructor Injection");
         Console.WriteLine("");
         Cliente cliente = new Cliente("Fulano", "fulano@empresa.com.br", new MyXptoEmailService());
         cliente.EnviarEmail("MyXpto Title", "MyXpto Message");
         Console.WriteLine("");
         Console.WriteLine("****************************************************");
         Console.WriteLine("");
         Console.WriteLine("Testando XyzEmailService Constructor Injection");
         Console.WriteLine("");
         Cliente cliente2 = new Cliente("Ciclano", "ciclano@gmail.com", new MyXyzEmailService());
         cliente2.EnviarEmail("MyXyz Title", "MyXyz Message");
         Console.WriteLine("");
         Console.WriteLine("****************************************************");

         // usando a classe ClienteGeterSeter com o método Setter Injection
         MyXptoEmailService myXpto = new MyXptoEmailService();
         MyXyzEmailService myXyz = new MyXyzEmailService();

         Console.WriteLine("");
         Console.WriteLine("Testando Setter Injection");
         Console.WriteLine("****************************************************");
         Console.WriteLine("");
         Console.WriteLine("Testando XptoEmailService Setter Injection");
         Console.WriteLine("");
         ClienteGeterSeter clienteGeterSeter = new ClienteGeterSeter("Fulano", "fulano@empresa.com.br");
         clienteGeterSeter.ServicoEmail = myXpto;
         clienteGeterSeter.EnviarEmail("MyXpto Title", "MyXpto Message");
         Console.WriteLine("");
         Console.WriteLine("****************************************************");
         Console.WriteLine("");
         Console.WriteLine("Testando XyzEmailService Setter Injection");
         Console.WriteLine("");
         clienteGeterSeter.ServicoEmail = myXyz;
         clienteGeterSeter.EnviarEmail("MyXyz Title", "MyXyz Message");
         Console.WriteLine("");
         Console.WriteLine("****************************************************");

         // usando a classe ClienteMehodInjection com o método Method Injection
         Console.WriteLine("");
         Console.WriteLine("Testando Method Injection");
         Console.WriteLine("****************************************************");
         Console.WriteLine("");
         Console.WriteLine("Testando XptoEmailService Method Injection");
         Console.WriteLine("");
         ClienteMethodInjection clienteMethod = new ClienteMethodInjection("Fulano", "fulano@empresa.com.br");
         clienteMethod.EnviarEmail("MyXpto Title", "MyXpto Message",myXpto);
         Console.WriteLine("");
         Console.WriteLine("****************************************************");
         Console.WriteLine("");
         Console.WriteLine("Testando XyzEmailService Method Injection");
         Console.WriteLine("");
         clienteMethod.EnviarEmail("MyXyz Title", "MyXyz Message",myXyz);
         Console.WriteLine("");
         Console.WriteLine("****************************************************");
      }
   }
}
