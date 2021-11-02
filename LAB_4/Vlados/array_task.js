function getRandomInt(max) {
    return Math.floor(Math.random() * max);
  }


let quantityOfElements = prompt('Введіть кількість елементів масиву!', '')
let array = []
for (let index = 0; index < quantityOfElements; index++) {
    array[index] = getRandomInt(20)
}

document.write("Згенерований масив: " + array)

let array_buffer = Array.from(array)

let min = Math.min.apply(null, array_buffer)
let indexMin = array_buffer.indexOf(min)
array_buffer.splice(indexMin, 1)
array_buffer.unshift(min)

document.write("Після зміщення елементів: " + array_buffer)


for (let i = 0, l = array_buffer.length, k = l - 1; i < k; i++) {
    let indexMax = i;
    for (let j = i + 1; j < l; j++) {
        if (array_buffer[indexMax] < array_buffer[j]) {
            indexMax = j;
        }
    }
    if (indexMax !== i) {
        [array_buffer[i], array_buffer[indexMax]] = [array_buffer[indexMax], array_buffer[i]];
    }
}

document.write("  Після сортування елементів: " + array_buffer)
