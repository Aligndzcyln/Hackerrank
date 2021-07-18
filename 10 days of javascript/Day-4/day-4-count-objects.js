function getCount(objects) {
    let counts = 0;
    objects.map(item => {
        if (item.x === item.y) {
            counts++;
        }
        return item;
    })
    return counts;
}