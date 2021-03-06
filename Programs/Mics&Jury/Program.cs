using System;

/*
The jury consists of M teams of people. Size of each team is given in array teams[]. The jury collectively has N mics that must be shared by everyone. Find a way to break the teams into N groups such that each group can have its own mic and the size of the largest group is minimised. 
 

Example 1:

Input:
N = 3, M = 2
teams[] = {10, 30}
Output: 15
Explanation: We split 2nd team into 2 
groups {15,15}, so we get {10,15,15}. 
Here maximum group size is 15.
 

Example 2:

Input:
N = 4, M = 2
teams[] = {2, 1}
Output: 1
Explanation:
Here we need 4 groups, so we will split
first team into 2 groups of size 1 and
last group will remain empty.
Group sizes = {1,1,1,0}
Therefore maximum group size is 1.

Your Task:  
You don't need to read input or print anything. Your task is to complete the function micsandjury() which takes N, M, array teams[] as input parameter and returns the maximum size of the group.


Expected Time Complexity: O(M log (max(team[i])))
Expected Auxiliary Space: O(1)

 

Constraints:
1 ≤ M ≤ 105
1 ≤ teams[i] ≤ 103
M ≤ N ≤ 106
*/
namespace Mics_Jury
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
