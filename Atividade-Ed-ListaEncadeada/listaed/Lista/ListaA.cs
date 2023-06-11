public class ListaA {
    public NoA inicio;
    public NoA fim;

    public ListaA() {
        this.inicio = null;
        this.fim = null;
    }

    public void inserirInicio(string nome, int periodo, int cargaHoraria, string professor){
        NoA novoNo = new NoA(nome, periodo, cargaHoraria, professor);

        if(this.inicio == null && this.fim == null){
            this.inicio = novoNo;
            this.fim = novoNo;
            System.Console.WriteLine("Inserir nó : " + this.inicio.nome);
        }
        else if(this.inicio != null){
            novoNo.noProx = this.inicio;
            this.inicio = novoNo;
            System.Console.WriteLine("Inserir nó: " + this.inicio.nome);
        }
    }

    public void impressao(){
        
        NoA noAux = this.inicio;
        System.Console.Write("Lista");
        while(noAux != null){
            System.Console.WriteLine("\nNome: "+noAux.nome);
            System.Console.WriteLine("Período: "+noAux.periodo);
            System.Console.WriteLine("Carga Horaria: "+noAux.cargaHoraria);
            System.Console.WriteLine("Professor: "+noAux.professor);
            noAux = noAux.noProx;            
        }
    }

    public Boolean consulta(string nome, ref NoA noAtual, ref NoA noAnterior){ 
        
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

    public void consultaNome(string nome, ListaA lista){
        NoA? noAtual = null;
        NoA? noAnterior = null;

        Boolean encontrou = lista.consulta(nome, ref noAtual, ref noAnterior);
        if (encontrou)
        {
            Console.WriteLine("Nó encontrado: " + noAtual.nome);
        }
        else
        {
            Console.WriteLine("Nó não encontrado!");
        }
    }
}