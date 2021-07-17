function getSecondLargest(nums) {

    let firstLargest = 0;
    let secondLargest = 0;

    for (let i = 0; i < nums.length; i++) {
        if (nums[i] > firstLargest) {
            secondLargest = firstLargest;
            firstLargest = nums[i];
        }
        if (nums[i] > secondLargest && nums[i] < firstLargest) {
            secondLargest = nums[i];
        }
    }
    return secondLargest;
}