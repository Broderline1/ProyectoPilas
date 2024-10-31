namespace ProyectoPila
{
    internal class Nodo
    {
        public int Valor { get; set; }
        public Nodo Sig { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Sig = null;
        }
    }
}