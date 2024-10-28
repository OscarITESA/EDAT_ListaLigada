namespace ListaLigada.Logica
{
    public class SingleList <T>
    {
        private SingleNode<T>? _first;

        public SingleList()
        { 
            _first = null;
        }

        public bool isEmpty => _first == null;

        public void Add(T item)
        {
            var node = new SingleNode<T>(item);
            if (isEmpty)
            {
                _first = node;
            }
            else
            {
                var pointer = _first;

                while (pointer!.Next != null)
                { 
                    pointer = pointer.Next;
                }

                pointer!.Next = node;
            }
        }

        public override string ToString()
        {
            var cadenaLista = string.Empty;
            var pointer = _first;

            while (pointer != null)
            {
                cadenaLista += $"{pointer.Data}\n";
                pointer = pointer.Next;
            }

            return cadenaLista;
        }
    }
}
