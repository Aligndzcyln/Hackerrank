'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}


/*
 * Complete the 'lilysHomework' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts INTEGER_ARRAY arr as parameter.
 */

function calculateDown(arr){
    var sorted_arr = arr.slice().sort(function(a,b){return a-b});
    sorted_arr.reverse();
    var indexes = {};
    for(let [index,value] of arr.entries()){
        indexes[value] = index;
    }
    var swaps = 0;
    for(let [right_index,current_val] of arr.entries()){
        var right_val = sorted_arr[right_index];
        var this_index = indexes[right_val]
        if(this_index !== right_index){
            arr[this_index] = current_val;
            arr[right_index] = right_val;
            indexes[current_val] = this_index;
            swaps++;
        }
             
    }
    return swaps;
}

function calculateUp(arr){
    var sorted_arr = arr.slice().sort(function(a,b){return a-b});
    var indexes = {};
    for(let [index,value] of arr.entries()){
        indexes[value] = index;
    }
    var swaps = 0;
    for(let [right_index,current_val] of arr.entries()){
        var right_val = sorted_arr[right_index];
        var this_index = indexes[right_val]
        if(this_index !== right_index){
            arr[this_index] = current_val;
            arr[right_index] = right_val;
            indexes[current_val] = this_index;
            swaps++;
        }
             
    }
    return swaps;
}

function lilysHomework(arr) {
    // Write your code here
    var arr2 = arr.slice();
    var down = calculateDown(arr);
    var up = calculateUp(arr2);
    return Math.min(down,up);

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine().trim(), 10);

    const arr = readLine().replace(/\s+$/g, '').split(' ').map(arrTemp => parseInt(arrTemp, 10));

    const result = lilysHomework(arr);

    ws.write(result + '\n');

    ws.end();
}
