# Queen-s-Attack-II

You will be given a square chess board with one queen and a number of obstacles placed on it. Determine how many squares the queen can attack.

A queen is standing on an **n x n** chessboard. The chess board's rows are numbered from **1** to **n**, going from bottom to top. Its columns are numbered from **1** to **n**, going from left to right. Each square is referenced by a tuple, **(r,c)**, describing the row, **r**, and column, **c**, where the square is located.

The queen is standing at position **q(r,c)**. In a single move, she can attack any square in any of the eight directions (left, right, up, down, and the four diagonals). In the diagram below, the green circles denote all the cells the queen can attack from **(4,4)**

![image1](image1.png)

There are obstacles on the chessboard, each preventing the queen from attacking any square beyond it on that path. For example, an obstacle at location **(3,5)** in the diagram above prevents the queen from attacking cells **(3,5)**, **(2,6)**, and **(1,7)**:

![image2](image2.png)

Given the queen's position and the locations of all the obstacles, find and print the number of squares the queen can attack from her position at **q(r,c)**. In the board above, there are **24** such squares.

## Function Description

queensAttack has the following parameters:
- int n: the number of rows and columns in the board
- nt k: the number of obstacles on the board
- int r_q: the row number of the queen's position
- int c_q: the column number of the queen's position
- int obstacles[k][2]: each element is an array of 2 integers, the row and column of an obstacle

## Returns
- int: the number of squares the queen can attack

## Constraints

A single cell may contain more than one obstacle.
There will never be an obstacle at the position where the queen is located.

## Sample Input 0

```
n = 4
k = 0
r_q = 4
c_q = 4
obstacles = []
```

## Sample Output 0

 ```
9
```

## Explanation 0

The queen is standing at position **(4, 4)** on a **4 x 4** chessboard with no obstacles:

![image3](image3.png)

## Sample Input 1

```
n = 5
k = 3
r_q = 4
c_q = 3
obstacles = [[5,5], [4,2], [2,3]]
```

## Sample Output 1

```
10
```
## Explanation 1

The queen is standing at position **(4,3)** on a **5 x 5** chessboard with **k=3** obstacles:

![image4](image4.png)

The number of squares she can attack from that position is **10**.

## Sample Input 2

```
n = 1
k = 0
r_q = 1
c_q = 1
obstacles = []
```

## Sample Output 2

```
0
```

## Explanation 2

Since there is only one square, and the queen is on it, the queen can move 0 squares.


## Sample Input 3

```
n = 100000
k = 0
r_q = 4187
c_q = 5068
obstacles = []
```

## Sample Output 3

```
308369
```