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

//var x = solution2([[5, 192, 33], [192, 72, 95], [33, 95, 999]]);

function solution3(board, k) {
  var answer = 0;
  for (let i = 0; i < board.length; i++) {
    for (let j = 0; j < board[i].length; j++) {
      if (i + j <= k) {
        answer += board[i][j];
        console.log(board[i][j]);
      }
    }
  }
  return answer;
}

var x = solution3(
  [
    [0, 1, 2], [1, 2, 3], [2, 3, 4], [3, 4, 5]
  ],
  2
);

//console.log(x);

function solution4(arr) {
  var answer = [];
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] == 2) {
      for(let j = i; j < arr.length; j++) {
        if (arr[j + 1] != 2) {
          answer.push(j);
        }
        else {
          break;
        }
      }
    }
  }
  return answer;
}

console.log(solution4([1, 2, 1, 4, 5, 2, 9]));