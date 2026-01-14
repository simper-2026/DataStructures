

```c
function selectionSort(array, n)
    for index from 0 to n - 1
        minIndex = findMinIndex(array, index, n)
        exchange(array, index, minIndex)

function findMinIndex(array, start, n)
    minIndex = start
    for i from start + 1 to n - 1
        if array[i] < array[minIndex]
            minIndex = i
    return minIndex

function exchange(array, i, j)
    temp = array[i]
    array[i] = array[j]
    array[j] = temp
```

//function selectionSort(array, n)
//    for index from 0 to n - 1
//        minIndex = findMinIndex(array, index, n)
//        exchange(array, index, minIndex)
//
//function findMinIndex(array, start, n)
//    minIndex = start
//    for i from start + 1 to n - 1
//        if array[i] < array[minIndex]
//            minIndex = i
//    return minIndex
//
//function exchange(array, i, j)
//    temp = array[i]
//    array[i] = array[j]
//    array[j] = temp
