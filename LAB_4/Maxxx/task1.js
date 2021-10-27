function randomInteger(min, max) 
{
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function printArray(array)
{
    for (num of array)
    {
        document.write(num + " ")
    }    
    document.writeln()
}

function getIndexOfMaxVal(array)
{
    let maxValue = array[0]
    let indexOfMax = 0;

    for (let i = 1; i < arrayLength; i++)
    {
        if(array[i] > maxValue)
        {
            indexOfMax = i
            maxValue = array[i]
        }
    }
    return indexOfMax
}

function getIndexOfMinVal(array)
{
    let minValue = array[0]
    let indexOfMin = 0;

    for (let i = 1; i < arrayLength; i++)
    {
        if(array[i] < minValue)
        {
            indexOfMin = i
            minValue = array[i]
        }
    }
    return indexOfMin
}

function quickSort(array) {
    if (array.length < 2) return array;
    let pivot = array[0];
    const left = [];
    const right = [];
      
    for (let i = 1; i < array.length; i++) {
      if (pivot > array[i]) {
        left.push(array[i]);
      } else {
        right.push(array[i]);
      }
    }
    return quickSort(left).concat(pivot, quickSort(right));
  }

const minNumber = 1;
const arrayLength = prompt("Enter the length of array: ", 10)


let array = [];
for (let i = 0; i < arrayLength; i++)
{
    array[i] = {}
    let num = randomInteger(minNumber, arrayLength)
    if(array.indexOf(num) == -1)
    {
        array[i] = num
    }
    else{i--}
}
document.writeln("Початковий масив: ")
printArray(array)
document.write("<br><br>")

let sum = 0;

let indexOfMin = getIndexOfMinVal(array)
let indexOfMax = getIndexOfMaxVal(array)

let first = indexOfMin
let last = indexOfMax

if(indexOfMin > indexOfMax)
{
    last = indexOfMin
    first = indexOfMax
}


for (let i = first; i <= last; i++)
{
    sum += array[i];
}

document.writeln("\nСума чисел = " + sum)
document.writeln("<br><br>" + "Відсортований масив: ")
printArray(quickSort(array))
