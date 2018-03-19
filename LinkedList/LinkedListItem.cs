namespace LinkedList
{
    public class LinkedListItem
    {
        internal LinkedListItem Next { get; set; }
        internal LinkedListItem Previous { get; set; }
        internal object Data { get; set; }

        public LinkedListItem(){}

        public LinkedListItem(object Data)
        {
            this.Data = Data;
        }
    }
}
