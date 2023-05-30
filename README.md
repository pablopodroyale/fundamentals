# Fundamentals

This repository contains solutions and practices to the more common algorithms and challenges.

# Challenges
This section is destinated to the more common challenges ordered by complexity.
The source is [Leetcode](https://leetcode.com/)

# Beginner

 1. [Running Sum of 1d Array](https://leetcode.com/problems/running-sum-of-1d-array/description/)
 Given an array  `nums`. We define a running sum of an array as `runningSum[i] =     sum(nums[0]…nums[i])`.
2. [Richest Customer Wealth](https://leetcode.com/problems/richest-customer-wealth/)
You are given an  `m x n`  integer grid  `accounts`  where  `accounts[i][j]`  is the amount of money the  `i​​​​​​​​​​​th​​​​`  customer has in the  `j​​​​​​​​​​​th`​​​​ bank. Return _the  **wealth**  that the richest customer has._
A customer's  **wealth**  is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum  **wealth**.
Return the running sum of  `nums`.
3. [Fizz Buzz](https://leetcode.com/problems/fizz-buzz/)
	Given an integer  `n`, return  _a string array_ `answer` _(**1-indexed**) where_:

-   `answer[i] == "FizzBuzz"`  if  `i`  is divisible by  `3`  and  `5`.
-   `answer[i] == "Fizz"`  if  `i`  is divisible by  `3`.
-   `answer[i] == "Buzz"`  if  `i`  is divisible by  `5`.
-   `answer[i] == i`  (as a string) if none of the above conditions are true.
4.  [Number of Steps to Reduce a Number to Zero](https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/)
Given an integer  `num`, return  _the number of steps to reduce it to zero_.

	In one step, if the current number is even, you have to divide it by  `2`, otherwise, you have to subtract  `1`  from it.

	**Example 1:**

	**Input:** num = 14
	**Output:** 6
	**Explanation:** 
	Step 1) 14 is even; divide by 2 and obtain 7. 
	Step 2) 7 is odd; subtract 1 and obtain 6.
	Step 3) 6 is even; divide by 2 and obtain 3. 
	Step 4) 3 is odd; subtract 1 and obtain 2. 
	Step 5) 2 is even; divide by 2 and obtain 1. 
	Step 6) 1 is odd; subtract 1 and obtain 0.
5. Middle of the Linked List
		Given the  `head`  of a singly linked list, return  _the middle node of the linked list_.

	If there are two middle nodes, return  **the second middle**  node.

	**Example 1:**

	![](https://assets.leetcode.com/uploads/2021/07/23/lc-midlist1.jpg)

	**Input:** head = [1,2,3,4,5]
	**Output:** [3,4,5]
	**Explanation:** The middle node of the list is node 3.
6. Ransom Note
		Given two strings  `ransomNote`  and  `magazine`, return  `true` _if_ `ransomNote`  can be constructed by using the letters from `magazine` _and_ `false` _otherwise_.

	Each letter in  `magazine`  can only be used once in  `ransomNote`.

	**Example 1:**

	**Input:** ransomNote = "a", magazine = "b"
	**Output:** false

# Arrays and hashing

 1. [ContainsDuplicates](https://leetcode.com/problems/contains-duplicate/description/)
Given an integer array `nums`, return `true` if any value appears **at least twice** in the array, and return `false` if every element is distinct.


