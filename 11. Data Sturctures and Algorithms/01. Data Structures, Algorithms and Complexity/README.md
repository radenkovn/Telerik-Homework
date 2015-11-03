## Data Structures, Algorithms and Complexity Homework

1. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the array's size is `n`.

  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i=0; i<arr.Length; i++)
      {
          int start = 0, end = arr.Length-1;
          while (start < end)
              if (arr[start] < arr[end])
                  { start++; count++; }
              else 
                  end--;
      }
      return count;
  }
  ```
  
  
Answer
--------
It should be should be N from ```cs for (int i=0; i<arr.Length; i++) ``` and then n + n-1 + n-2 + n-3 + .... + 1 = n(2*n + (n-1)*-1)/2 = n/2 * (n+1), So if we add the first for loop it's (n*n/2 + n/2) + n which is o(n^2)

2. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```
  
Answer
--------
It is o(n*m) in the worst case scenario - there will be exactly m cols loops for every n row

3. **(*) What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }
  
  Console.WriteLine(CalcSum(matrix, 0));
  ```

Answer
--------
We assume that row = 0 for the worst case scenario. 
In that case
if (row + 1 < matrix.GetLength(1)) will be true n times for every row, or n-1 (doesnt matter)
so for (int col = 0; col < matrix.GetLength(0); col++) which is m times will be executed m more times for each n
so the answer should be o(m^n)