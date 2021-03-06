class Calculator {
    constructor() {
        this.power = (n, p) => {
            try {
                if (n < 0 || p < 0) {
                    throw 'n and p should be non-negative'
                }
                else {
                    return Math.pow(n, p);
                }
            } catch (error) {
                return error
            }
        }
    }
}