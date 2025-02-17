# F# Mutable Variable Bug

This repository demonstrates a common issue with mutable variables in F# functions.  The example shows how modifying mutable variables within a function can lead to unexpected results if not carefully considered. The solution shows how to refactor the code to avoid this issue.

## Bug

The `add` function uses mutable variables `x` and `y`. The mutation within the function leads to unexpected results when it comes to the values of the variables and the final output.

## Solution

The solution shows how to refactor the code using immutability and functional programming principles to achieve the correct result without the use of mutable variables.