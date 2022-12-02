using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGenericsPractice
{
     class LLNodeMaker<T>
    {
        public T ValueProperty { get; set; }
        public LLNodeMaker<T> NextNode { get; internal set; }
        public LLNodeMaker<T> PreviousNode { get; internal set; }

        public LLNodeMaker(T value)
        {
            this.ValueProperty = value;
        }//end ctor
    }//end LinkedListNode<T>
}//end namespace
