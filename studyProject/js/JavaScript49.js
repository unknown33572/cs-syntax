function solution(arr) {
  var stk = [];
  var i = 0;
  while (i < arr.length) {
    if (stk.length === 0 || stk[stk.length - 1] < arr[i]) {
      stk.push(arr[i]);
      i++;
    }
    if (stk[stk.length - 1] >= arr[i]) {
      stk.pop();
    }
  }
    return stk;
}

//[1,4,2,5,3]
console.log(solution([1, 4, 2, 5, 3]));

function solution2(arr) {
  var stk = [];
  var i = 0;
  while (i < arr.length) {
    if (stk.length === 0 || stk[stk.length - 1] != arr[i]) {
      stk.push(arr[i]);
      i++;
    } else if (stk[stk.length - 1] == arr[i]) {
      stk.pop();
      i++;
    }
  }
  if (stk.length === 0) 
    return stk = [-1];
    return stk;
}