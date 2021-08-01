function main() {
    const n = parseInt(readLine().trim(), 10);
    for (let i = 1; i < 11; i++) {
        console.log(`${n} x ${i} = ${n * i}`)
    }
}