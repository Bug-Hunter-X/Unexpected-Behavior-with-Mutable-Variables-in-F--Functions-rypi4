let mutable x = 10
let mutable y = 20
let mutable z = 30

let add x y = x + y

let mutable sum = add x y

printfn "%d" sum

//Modifying x in the main scope after calling add function
x <- 100

//This will not affect the sum value.
printfn "%d" sum