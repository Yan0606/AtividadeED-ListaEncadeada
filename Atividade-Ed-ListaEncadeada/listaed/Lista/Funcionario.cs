class Funcionario{
    public NoFuncionario inicio;
    public NoFuncionario fim;



    public Funcionario() {
        this.inicio = null;
        this.fim = null;
    }



        public void inserirInicio(string nome, int idade, string telefone, double salario){
        NoFuncionario novoNo = new NoFuncionario(nome, idade, telefone, salario);


        if(this.inicio == null && this.fim == null){
            this.inicio = novoNo;
            this.fim = novoNo;
            System.Console.WriteLine("Insira a posição: " + this.inicio.nome);
        }
        else if(this.inicio != null){
            novoNo.noProx = this.inicio;
            this.inicio = novoNo;
            System.Console.WriteLine("Insira a posição: " + this.inicio.nome);
        }
    }

    public void inserirFim(string nome, int idade, string telefone, double salario){
        NoFuncionario no = new NoFuncionario(nome, idade, telefone, salario);

        if(this.inicio == null && this.fim == null){
            this.inicio = no;
            this.fim = no;
            System.Console.WriteLine("Insira  posição: " + this.fim.nome);
        }else{
            this.fim.noProx = no;
            this.fim = no;
            System.Console.WriteLine("Insira posição: " + this.fim.nome);

        }
    }

    public void percurso(){
        
        NoFuncionario noAux = this.inicio;
        System.Console.Write("\n[ Lista: ");
        while(noAux != null){
            Console.Write(noAux.nome);
            if(noAux.noProx != null){
                Console.Write(" > ");
            }
            noAux = noAux.noProx;            
        }
        System.Console.Write(" ]\n\n");
    }


    public Boolean consulta(string nome, ref NoFuncionario noAtual, ref NoFuncionario noAnterior){ 
        noAtual = this.inicio;
        noAnterior = null;

        while(noAtual != null){
            if(noAtual.nome == nome){ 
                return(true);
            }
            noAnterior = noAtual;
            noAtual = noAtual.noProx;
        }
    
        return(false);
    }

    public void consultaNome(string nome, Funcionario lista){
        NoFuncionario? noAtual = null;
        NoFuncionario? noAnterior = null;

        Boolean encontrou = lista.consulta(nome, ref noAtual, ref noAnterior);
        if (encontrou)
        {
            Console.WriteLine("Valor Encontrado: " + noAtual.nome);
        }
        else
        {
            Console.WriteLine("Nó não encontrado!");
        }
    }

    public void removerInicio(){
       if(this.inicio == null && this.fim == null){
        System.Console.WriteLine("Lista vazia");
       }else if(this.inicio != null){
            System.Console.WriteLine("Remover posição: " + this.inicio.nome);
            this.inicio = this.inicio.noProx;

       }
    }

    public void removerFim(){
        NoFuncionario noAux = this.inicio;
        if(this.inicio == null && this.fim == null){
            System.Console.WriteLine("lista");
        }else if(this.inicio != null){
            while(noAux != null){
                if(noAux.noProx == this.fim){
                    System.Console.WriteLine("Remover posição: " + noAux.noProx.nome);
                    this.fim = noAux.noProx;
                    noAux.noProx = null;

                }
                noAux = noAux.noProx;            
            }
       }
    }

    public void impressao(){
        
        NoFuncionario noAux = this.inicio;
        System.Console.Write("Lista");
        while(noAux != null){
            System.Console.WriteLine("\nNome: "+noAux.nome);
            System.Console.WriteLine("Idade: "+noAux.idade);
            System.Console.WriteLine("Telefone: "+noAux.telefone);
            System.Console.WriteLine("Salario: "+noAux.salario);
            noAux = noAux.noProx;            
        }
    }
}