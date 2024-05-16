function solution(n) {
  var answer = [[]];
  for (let i = 0; i < n; i++) {
    answer[i] = [];
    for (let j = 0; j < n; j++) {
      if (i == j) {
        answer[i][j] = 1;
      } else {
        answer[i][j] = 0;
      }
    }
  }
  return answer;
}

//console.log(solution(3));

function solution2(arr) {
  var answer = 0;
  for (let i = 0; i < arr.length; i++) {
    for (let j = 0; j < arr[i].length; j++) {
      if (arr[i][j] == arr[j][i]) {
        answer = 1;
      } else {
        answer = 0;
        break;
      }
    }
  }
  return answer;
}

var x = solution2([[5, 192, 33], [192, 72, 95], [33, 95, 999]]);

