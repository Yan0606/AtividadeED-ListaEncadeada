namespace listaed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            Lista lista = new();
            lista.inserirInicio(22);
            lista.inserirInicio(12);
            lista.inserirInicio(7);
            lista.inserirFim(2); // cabeça (primeiro nó)
            
            //7->12->22
            lista.percurso();

            lista.removerInicio();
            lista.removerFim();
            

            //
            lista.percurso();
           
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("");


            //Exercício 2

            Funcionario lista2 = new Funcionario();
            lista2.inserirInicio("Neyma Jr", 10, "888888", 10000.0);
            lista2.inserirInicio("Yan Andrade", 7, "11111111", 5500.00);
            lista2.inserirInicio("Maria Clara", 9, "777777", 6500.00);
            lista2.inserirFim("Pelé", 99, "999999", 99999.0);
            lista2.inserirFim("Fabiana", 18, "8181811", 3600.0);

            lista2.percurso();
            lista2.consultaNome("Yan Andrade", lista2);

            lista2.removerFim();
            lista2.removerInicio();
            lista2.percurso();

            lista2.impressao();


            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("");


            //Exercício 3

            ListaA lista3 = new ListaA();

            lista3.inserirInicio("Mestre", 1, 100, "Bruno");
            lista3.inserirInicio("Jogador", 1, 100, "Ronaldo");
            lista3.inserirInicio("Programador", 1, 150, "Yan");
            lista3.inserirInicio("Juiz", 1, 200, "Fabinho");
            lista3.inserirInicio("Médico", 1, 200, "Andreia");
            lista3.impressao();
            lista3.consultaNome("Professor", lista3);

            
            


        }
    }
}
