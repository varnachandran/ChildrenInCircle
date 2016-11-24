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
        //Order of complexity for adding to the end of the queue is O(1)
        //Order of complexity for removing from the beginning of the queue is O(1)
        //Order of complexity of finding the position to be removed is O(n), O(_eliminateIndex) here
        //the loop runs n times, so the complexity of outer loop is O(n)
        //The total complexity is O(n^2)
        //If a linked list is used to store data, it is easier to delete elements in between
        //but it takes more time to traverse through the list. More memory is also consumed because 
        //it has to store references 


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
