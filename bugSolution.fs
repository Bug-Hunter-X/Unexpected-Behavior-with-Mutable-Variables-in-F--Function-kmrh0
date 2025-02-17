let x = 10
let y = 20

let add x y = 
    let sum = x + y
    (x + sum, y + sum)

let newX, newY = add x y
printf "%d %d %d %d" x y newX newY