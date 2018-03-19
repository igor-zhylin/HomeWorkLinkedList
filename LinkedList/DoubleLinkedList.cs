namespace LinkedList
{
    using System;

    public class DoubleLinkedList
    {
        private LinkedListItem Head;
        private LinkedListItem Tail;
        public int Length { get; set; }

        public DoubleLinkedList() { }

        public void Add(object Data)
        {
            LinkedListItem current = new LinkedListItem(Data);

            if (Head == null)
            {
                Head = current;
            }
            else
            {
                Tail.Next = current;
                current.Previous = Tail;
            }

            Tail = current;
            Length++;
        }
        public void AddFirst(object Data)
        {
            LinkedListItem current = new LinkedListItem(Data);
            LinkedListItem temp = this.Head;

            current.Next = temp;
            this.Head = current;

            if (this.Length == 0)
            {
                this.Tail = this.Head;
            }
            else
            {
                temp.Previous = current;
            }

            Length++;
        }

        public void Remove(object Data)
        {
            LinkedListItem current = this.Head;

            ///Search Item
            while (current != null)
            {
                if (current.Data.Equals(Data))
                {
                    break;
                }
                current = current.Next;
            }

            if (current != null)
            {
                ///If item not last 
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                ///if item last DO 
                else
                {
                    this.Tail = current.Previous;
                }
                ///If item Not First
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                ///if first reallocate Head
                else
                {
                    this.Head = current.Next;
                }
                Length--;
            } 
        }


        #region Helpers

        public bool Contains(object Data)
        {
            LinkedListItem current= this.Head;
            while (current!=null)
            {
                if (current.Data.Equals(Data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Clear()
        {
            this.Head = null;
            this.Tail = null;
            this.Length = 0;
        }

        public void PrintListItems()
        {
            LinkedListItem node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }

        #endregion
    }
}
