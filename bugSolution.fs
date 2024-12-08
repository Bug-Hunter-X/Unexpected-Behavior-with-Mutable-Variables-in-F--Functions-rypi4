let mutable x = 10
let mutable y = 20
let mutable z = 30

let add x y = x + y

let mutable sum = add x y

printfn "%d" sum // Output: 30

x <- 100

//To update sum, you need to explicitly recalculate it.
sum <- add x y

printfn "%d" sum // Output: 120