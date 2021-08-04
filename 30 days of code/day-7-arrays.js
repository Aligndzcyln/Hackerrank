
// Alternative solution

// const arr1 = [];
// for(let i = 0; i < n ;i++){
//     arr1.push(arr.pop());
// }
// console.log(arr1.join(' '))


for (let i = arr.length - 1; i >= 0; i--) {
    process.stdout.write(`${arr[i] + ' '}`);
}