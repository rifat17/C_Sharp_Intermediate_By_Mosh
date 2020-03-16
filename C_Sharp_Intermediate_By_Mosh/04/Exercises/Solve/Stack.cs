using System;
using System.Collections;
namespace C_Sharp_Intermediate_By_Mosh.Exercises.Solve
{
    public class Stack
    {
        private ArrayList list;

        public Stack()
        {
            list = new ArrayList();
        }

        public void Push(object item)
        {
            if (item == null)
                throw new InvalidOperationException("Cannot push NULL");
            list.Add(item);
        }

        public object Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Stack is empty");
            int listSize = list.Count;
            object obj = list[listSize - 1];
            list.Remove(obj);
            return obj;
        }

        public void Clear()
        {
            list = new ArrayList();
        }
    }
}
