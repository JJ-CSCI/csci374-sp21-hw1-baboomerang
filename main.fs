module Assignment

// Problem 1
let rec tribn n =
    // write your code here
    if n <= 0    //passes test(-1) and test(0)
    then 0
    elif n = 1   //passes test(3)
    then 1
    elif n = 2
    then 1
    else tribn (n - 1) + tribn (n - 2) + tribn (n - 3)

    //3 - 1 = 2 //this should also be 1 in tribonacci
    //3 - 2 = 1 //this should be 1 in tribonacci
    //3 - 3 = 0
    //

// Problem 2
let tribn2 n =
    // write your code here
    // wait, isnt tribonacci supposed to be 3 numbers?
    // why are we supposed to sum 4 integers?
    //let rec add3 (x:int) (lst:int list) =
    //   if x = 3    //0, 1, 2, 3 (4 calls total; 3 elements + 0)
    //   then 0
    //   else List.head lst + add3 (x + 1) (List.tail lst)
    //Example call:  add4 0 lst :: lst
    0

// Problem 3
let rec last lst =
    // write your code here
    if List.tail lst = []
    then List.head lst
    else last (List.tail lst)

// Problem 4
let fourth (lst:int list) =
    // write your code here
    0

// Problem 5
let everyfourth (lst:int list) =
    // write your code here
    []

// Problem 6
let rec take n (lst:int list) =
    // write your code here
    []

// Problem 7
let rec drop n (lst:int list) =
    // write your code here
    []
