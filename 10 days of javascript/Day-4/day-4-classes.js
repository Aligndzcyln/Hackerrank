class Polygon {
    constructor(arr) {
        this.arr = arr;
    }
    perimeter() {
        return this.arr.reduce((prev, next) => prev + next);
    }
}