public class No{

    public int valor;
    public No noProx;

    public No(int Valor){
        this.valor = Valor;
        this.noProx = null;
    }

    public void imprimir(){
            Console.WriteLine("Valor: " + this.valor);
    }

}