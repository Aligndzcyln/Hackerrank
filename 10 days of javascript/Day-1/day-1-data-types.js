function performOperation(secondInteger, secondDecimal, secondString) {

    const firstInteger = 4;
    const firstDecimal = 4.0;
    const firstString = 'HackerRank ';

    var o1 = parseInt(firstInteger) + parseInt(secondInteger)
    console.log(o1)
    var o2 = parseFloat(firstInteger) + parseFloat(secondDecimal)
    console.log(o2)

    console.log(firstString.concat(secondString))
}