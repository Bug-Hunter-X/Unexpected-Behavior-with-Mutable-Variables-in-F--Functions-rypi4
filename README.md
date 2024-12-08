# F# Mutable Variable Behavior

This example demonstrates a potential point of confusion regarding mutable variables in F# when used within functions.  The core issue lies in understanding how changes to mutable variables *after* a function call impacts the function's results.  The original code doesn't update `sum` after `x` is modified.

## Solution
The solution clarifies the issue and shows how to correctly update the `sum` if needed after modifying `x`.