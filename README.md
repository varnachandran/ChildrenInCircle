# ChildrenInCircle
Children In Circle Game
Consider the following children’s game: 
• n children stand around a circle. • Starting with a given child and working clockwise, each child gets a sequential number, which we will refer to as its id. 
• Then starting with the first child, they count out from 1 until k. The k’th child is now out and leaves the circle. The count starts again with the child immediately next to the eliminated one.
• Children are so removed from the circle one by one. The winner is the last child left standing.
Aim is to write some code which, when given n and k, calculates: 
• the sequence of children as they are eliminated, and • the id of the winning child.

Assumptions: 
The input form does not take values of n<2 and k<1, so even if the user enters values which are not practical, the system resets n to 2 and k to 1
For the Elimination index data, List datatype is used		
List<T> is implemented as an array internally. Complexity for adding an element to a list is O(1), and n-1 elements are added to the List
so complexity is O(n-1) for generating the elimination list.

For representing the children present in the Game currently, a Queue is used.
The Queue<T>.Enumerator structure enumerates the elements of a Queue<T>. Queue<T> class implements a general queue as
a circular array.Queue is useful we need to discard an element after getting its value.

Complexity for adding an element to end of queue is O(1).
Complexity for removing an element from beginning of queue is O(1)
Complexity for finding element at an index k is O(k) and this has to be repeated for n-1 elements, the complexity is O((k)(n-1))

A LinkedList is implemented as a doubly linked list and complexity of finding an element at an index k is O(k).
LinkedList needs memory for all the next/previous references too.

I have limited the maximum values of n and k as 10000 to prevent overflow.
