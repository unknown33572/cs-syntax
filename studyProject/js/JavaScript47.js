function bubbleSort(arr) {
  let leng = arr.length;

  for(let i = 0; i < leng; i++) {
    for (let j = 0; j < leng - i - 1; j++) {
      if (arr[j] > arr[j + 1]) {
        let temp = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = temp;
      }
    }
    console.log(arr);
  }
}

let arr = [5, 3, 8, 4, 2];

//bubbleSort(arr);

function selectionSort(arr) {
  let n = arr.length;

  for (let i = 0; i < n - 1; i++) {
    let minIdx = i;
    for (let j = i + 1; j < n; j++) {
      if (arr[j] < arr[minIdx]) {
        minIdx = j;
      }
    }
    if (minIdx != i) {
      let temp = arr[minIdx];
      arr[minIdx] = arr[i];
      arr[i] = temp;
    }
    console.log(arr);
  }
}

let arr2 = [5, 3, 8, 4, 2];

//selectionSort(arr2);

function insertion(arr) {
  for (let i = 1; i < arr.length; i++) {
    let curr = arr[i];
    let j = i - 1;
    while (j >= 0 && arr[j] > curr) {
      arr[j + 1] = arr[j];
      j--;
    }
    arr[j + 1] = curr;
    console.log(arr);
  }
  return arr;
}

let arr3 = [5, 3, 8, 4, 2];
console.log(insertion(arr3));