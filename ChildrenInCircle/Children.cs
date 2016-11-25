using System;
using System.Collections.Generic;
using System.Linq;


namespace ChildrenInCircle
{
    public class Children
    {
        //Properties of the Children Class
        private int _eliminateIndex;
        private Queue<int> _childrenQueue;
       
        public List<int> _eliminatedList;
        

        public Children(int numberofchildren, int eliminateposition)
        {
            try
            {
                //Assign _childrenQueue to values from 1 to numberofchildren
                _childrenQueue = new Queue<int>(Enumerable.Range(1, numberofchildren));

                _eliminateIndex = eliminateposition;

                _eliminatedList=new List<int>();
               
            }
            catch (Exception exception)
            {
               Console.WriteLine(exception.Message);
                
            }
            

          }
//For the Elimination index list, List datatype is used		
//List<T> is implemented as an array internally. Complexity for adding an element to a list is O(1), and n-1 elements are added to the List
//so complexity is O(n-1) for generating the elimination list.

//For representing the children present in the Game currently, a Queue is used.
//The Queue<T>.Enumerator structure enumerates the elements of a Queue<T>. Queue<T> class implements a general queue as
//a circular array.Queue is useful we need to discard an element after getting its value.

//Complexity for adding an element to end of queue is O(1).
//Complexity for removing an element from beginning of queue is O(1)
//Complexity for finding element at an index k is O(k) and this has to be repeated for n-1 elements, the complexity is O((k)(n-1))

//A LinkedList is implemented as a doubly linked list and complexity of finding an element at an index k is O(k).
//LinkedList needs memory for all the next/previous references


        public int FindWinner()
        {
       //Execute the loop until Count of the number of children becomes 0
            //This is to eliminate every kth child

            while (_childrenQueue.Count >1)
            {
              //Enque adds an item to the Queue and Deque removes and item, also returning it
                for (var index = 1; index < _eliminateIndex; index++)
                {
                    _childrenQueue.Enqueue(_childrenQueue.Dequeue());
                }
                //the _eliminatedList is now constructed with the removed element
                _eliminatedList.Add(_childrenQueue.Dequeue());
            }
            //If count becomes 1, then the child who is left out is the winner
            
            return _childrenQueue.Dequeue();
        }

    }
}
