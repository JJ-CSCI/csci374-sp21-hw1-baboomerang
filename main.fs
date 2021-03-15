module Assignment

// Problem 1
let rec tribn n =
    // write your code here
    if n = 0   //case 1
    then 0
    elif n = 1 //case 2
    then 1
    elif n = 2 //case 3
    then 1
    else tribn (n - 1) + tribn (n - 2) + tribn (n - 3)

// Problem 2
let tribn2 n =
    // write your code here
    0

// Problem 3
let rec last lst =
    // write your code here
    0

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
