namespace SinglyLinkedList
{
    public class ListSingle
    {
        private ListMemberSingle _firstElement;

        public void AddNewElement(int value)
        {
            var newElement = new ListMemberSingle { Value = value };
            if (_firstElement == null)
                _firstElement = newElement;
            else
            {
                var lastElement = _firstElement;
                while (lastElement.Next != null)
                {
                    lastElement = lastElement.Next;
                }
                lastElement.Next = newElement;

            }
        }

        public void DeleteSomeElement(int value)
        {
          while (_firstElement != null && _firstElement.Value == value)
            {
                _firstElement = _firstElement.Next;
            }
          var listElement = _firstElement;
            while (listElement != null && listElement.Next != null)
            {
                if (listElement.Next.Value == value)
                    listElement.Next = listElement.Next.Next;
                else
                    listElement = listElement.Next;
            }
        }

        public string ForString()
        {
            var listElement = _firstElement;
            var printElement = "";
            while (listElement != null)
            {
                printElement = printElement + listElement.Value;
                if (listElement.Next != null)
                    printElement = printElement + ", ";
                listElement = listElement.Next;
            }
            return printElement;
        }
    }
}