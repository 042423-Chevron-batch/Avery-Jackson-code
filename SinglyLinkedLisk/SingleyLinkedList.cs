using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleyLinkedListNamespace
{
    public class SingleyLinkedList
    {
        public SingleyLinkedListNode? First { get; set; } = null;
        public SingleyLinkedListNode? Last { get; set; } = null;
        public SingleyLinkedListNode? Current { get; set; } = null;
        public int ListLength { get; set; } = 0;

        public SingleyLinkedList() { }

        // add to the front
        public void AddToFront(string fname, string lname)
        {
            
            Person p = new Person(fname, lname);// create a new person
            SingleyLinkedListNode n = new SingleyLinkedListNode(p);//create a new node and add the person to the node
            if (this.First == null)
            {
                this.First = n;
                this.Last = n;
            }
            else
            {
            n.Next = this.First;
            this.First = n;
            }
            this.ListLength++;
            
        }
            
        public void AddToTheBack(string fname, string lname)
        {
            Person p = new Person(fname, lname);
            SingleyLinkedListNode n = new SingleyLinkedListNode(p);
            // if nothing is in the list the new node(n) becomes first
            if (this.First == null)
            {
                this.First = n;
                this.Last = n;
            }
            //if something is in the node add the new node(n) last or at the end 
            else
            {
                this.Last.Next = n;
                this.Last = n;
            }
            this.ListLength++;
        }

        // print the nodes forward
        public List<Person> GetPeopleInOrder()
        {
            List<Person> l = new List<Person>();
            this.Current = this.First;
            for (int i = 0; i < this.ListLength; i++)
            {
                l.Add(this.Current.Person);
                this.Current = this.Current.Next;
            }
            return l;
        }

        

        //delete the First

        //delete the last

        // Assignment add the AddToTheBack method.
        //add to the back

        //delete by fname

        // delete by Lname

    }
}