# Hashing-in-Separate-Chaining

Hashing in Separate Chaining

January 12, 2020

The file HashInt.txt
(in a separate file) contains 100,000 integers all randomly chosen
between 1 and 1,000,000 (there might be some repetitions).
This is considered as an array of integers where the ith row of the file gives you the ith entry of the array.
Given below are 9 "target sums", in
increasing order:
231552, 234756, 596873, 648219, 726312, 981237, 988331, 1277361, 1283379.
You are required to implement the hash table-based algorithm and determine,
for each of the 9 target sums x, whether or not x can be formed as the sum of two entries in the given array.

Your answer should be in the form of a 9-bit string,
with a 1 indicating "yes" for the corresponding target
sum and 0 indicating "no". For example, if you discover that all of the target sums except for the
5th and the 7th one (i.e., except for 726312 and 988331) can be formed from pairs from the
input file, then your answer should be "111101011" (without the quotes).

The answer should be in the same order as the target sums listed above (i.e., in increasing order of the target).



Solution to the above problem

According to our solution we used Separate Chaining concept to implement the hash table.
Because in Open addressing methods that have primary clustering and secondary clustering scenarios.
And also separate chaining not critical to make the table size a prime number,
as it is with the quadratic probes and double hashing. When we use the open addressing concept,
the exception is the plenty of memory is available and size should not expand after the table is created.
Hash Table consists of 10000 slots which each has its own list to keep data.
Each line read from the text file and gets the hash value to select the corresponding slot in the Hash Table for data.

We used 10000 slots, because of its help to constant time (O (1)) to access the corresponding slot for each data.
In this implementation duplicates are allowed. All items with the same hash key should be inserted in the same list.
So if we want to discover those elements we must search the entire list in both successful search and unsuccessful searches.

In our implementation we included the sorted list which not speeds up the successful search,
but it could reduce the time of unsuccessful search. There insertion time gets increase,
because the new item can’t just be inserted at the beginning of the list.
But if the list gets too short the increase of the insertion time may not be important.
That’s another reason for I selected the Hash Table size to 10000 slots.

According to the problem we must have to search the target sums inside the Hash table.
As a result searching method uses frequently to find the sums in the Hash Table.
To get the solution for that we reduce the each data from the text with
target sums and find remaining element in the Hash Table. There should be happened successful searches and
unsuccessful searches (element not at the list). In successful search that hashes to the appropriate list
which associates with a slot in Hash table. And searches along the list for the element.
In average time half the elements must be examined before the correct one is located (time: 1+loadfactor/2).
This is guaranteed whether the lists are sorted or not. In an unsuccessful search,
if the lists are unsorted all elements must be searched (time: 1+loadfactor).
But in sorted list half the element must be examined in an unsuccessful search.
That’s the reason for that we choose the sorted list structure.

Implementation in C#
