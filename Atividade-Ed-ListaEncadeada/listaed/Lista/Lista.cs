public class Lista{
    public No inicio;
    public No fim;


    public Lista(){
        this.inicio = null;
        this.fim = null;
    }


    public void inserirInicio(int value){
        No novoNo = new(value);


        if(this.inicio == null && this.fim == null){
            this.inicio = novoNo;
            this.fim = novoNo;
            System.Console.WriteLine("Insira a posição: " + this.inicio.valor);
        }

        else if(this.inicio != null){
            novoNo.noProx = this.inicio;
            this.inicio = novoNo;
            System.Console.WriteLine("Insira a posição: " + this.inicio.valor);
        }
    }

    public void inserirFim(int value){
        No no = new No(value);

        if(this.inicio == null && this.fim == null){
            this.inicio = no;
            this.fim = no;
            System.Console.WriteLine("Insira a posição: " + this.fim.valor);
        }else{
            this.fim.noProx = no;
            this.fim = no;
            System.Console.WriteLine("Insira a posição: " + this.fim.valor);

        }
    }

    public void removerInicio(){
       if(this.inicio == null && this.fim == null){
        System.Console.WriteLine("lista");
       }else if(this.inicio != null){
            System.Console.WriteLine("Remove a posição: " + this.inicio.valor);
            this.inicio = this.inicio.noProx;

       }
    }

    public void removerFim(){
        No noAux = this.inicio;
       if(this.inicio == null && this.fim == null)
       {
        System.Console.WriteLine("lista");
       }
       else if(this.inicio != null){

            while(noAux != null){
                if(noAux.noProx == this.fim){
                    System.Console.WriteLine("Remove a posição: " + noAux.noProx.valor);
                    this.fim = noAux.noProx;
                    noAux.noProx = null;

                }
                noAux = noAux.noProx;            
            }
       }
    }

    public Boolean consulta(int Valor, ref No noAtual, ref No noAnterior){ 
        
        noAtual = this.inicio;
        noAnterior = null;

        while(noAtual != null){

            if(noAtual.valor == Valor){ 
                return(true);
            }
            noAnterior = noAtual;
            noAtual = noAtual.noProx;
        }
    
        return(false);
    }

    public void percurso(){
        
        No noAux = this.inicio;
        System.Console.Write("\n[ Lista: ");
        while(noAux != null){
            Console.Write(noAux.valor);
            if(noAux.noProx != null){
                Console.Write(" > ");
            }
            noAux = noAux.noProx;            
        }
        System.Console.Write(" ]\n\n");
    }
}