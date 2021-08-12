function decToBin(n) {
    return n.toString(2);
}

function consecutiveCount(binary) {
    let ones = 0;
    let max = 0;

    for (let i = 0; i < binary.length; i++) {
        if (binary[i] == 1) {
            ones++;
        } else if (binary[i] == 0) {
            if (ones > max) max = ones;
            ones = 0;
        }
    }
    if (ones > max) max = ones;

    return max;
}

function main() {
    const n = parseInt(readLine().trim(), 10);
    let binNumber = decToBin(n);
    console.log(consecutiveCount(binNumber));
}