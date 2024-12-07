#!/bin/bash

output_file="benchmark_results.csv"

echo "iterations,dotnet,nodejs,python" > $output_file

echo "Executing"

# Loop for iterations in steps of 500 from 10000 to 100000
for ITERATIONS in {10000..100000..10000}
do
    # Execute 10 times for each iteration count
    for i in {1..10}
    do
        echo -n "."
        # Execute the command and measure the time
        dotnet=$(cd PairProgrammingNET && dotnet run -- $ITERATIONS)
        echo -n "."
        nodejs=$(cd NodeJs && node main.js $ITERATIONS)
        echo -n "."
        python=$(cd python && python3 main.py $ITERATIONS)
        
        echo "$ITERATIONS,$dotnet,$nodejs" >> $output_file
    done
done