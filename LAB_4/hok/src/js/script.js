function TheSmallestEven(arr, i) 
{
    let min = arr[i];
    for(i; i <=arr.length;i+=2)
    {
        if(arr[i] <= min)
        min = arr[i];
    }
    return min;
}
function TheBiggestEven(arr, i) 
{
    let max = arr[i];
    for(i ; i <=arr.length;i+=2)
    {
        if(arr[i] >= max)
        max = arr[i];
    }
    return max;
}

function GenerateRandomArray(n)
{
    var arr = [];
    for ( i = 0; i < n; i++ ) 
    {
        var a = Math.round( Math.random() * 100 );
        arr.push(a);
    }
    return arr;
}

function SelectionSort(origin_array)
{
    var arr = origin_array.slice();
    for (let i = 0, l = arr.length, k = l - 1; i < k; i++) {
        let indexMax = i;
        for (let j = i + 1; j < l; j++) {
            if (arr[indexMax] < arr[j]) {
                indexMax = j;
            }
        }
        if (indexMax !== i) {
            [arr[i], arr[indexMax]] = [arr[indexMax], arr[i]];
        }
    }
    return arr;
}

var amount = prompt("Введіть кількість елементів в масиві: ", 15);
let arr = GenerateRandomArray(amount);

let minimal_even = TheSmallestEven(arr,1);
let maximal_even = TheBiggestEven(arr,1);
let minimal_odd = TheSmallestEven(arr,0);
let maximal_odd = TheBiggestEven(arr,0);

let arr2 = SelectionSort(arr);



