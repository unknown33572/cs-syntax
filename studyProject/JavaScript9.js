function solution(arr, idx) {
  var answer = 0;
  for (idx; idx < arr.length; idx++) {
    if (arr[idx] === 1) {
      answer = idx;
      break;
    } else {
      answer = -1;
    }
  }
  return answer;
}