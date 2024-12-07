#!/bin/bash

output_file="benchmark_results.csv"

echo "Iterations,Time" > $output_file

ITERATIONS=10000

echo "Executing"
# Loop for 1000 iterations
for i in {1..5000}
do
    echo -n "."
    # Execute the command and measure the time
    dotnet run -- $ITERATIONS >> $output_file
done