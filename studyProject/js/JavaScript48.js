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
        //console.log(board[i][j]);
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

function mergeSort(arr) {
  if (arr.length <= 1) return arr;

  const mid = Math.floor(arr.length / 2);
  const left = mergeSort(arr.slice(0, mid));
  const right = mergeSort(arr.slice(mid));

  return merge(left, right);
}

function merge(left, right) {
  let result = [];
  let leftIndex = 0;
  let rightIndex = 0;

  while (leftIndex < left.legnth && rightIndex < right.length) {
    if (left[leftIndex] < right[rightIndex]) {
      result.push(left[leftIndex]);
      leftIndex++;
    } else {
      result.push(right[rightIndex]);
      rightIndex++;
    }
  }
}

function solution4(order) {
  var answer = 0;
  for (let i = 0; i < order.length; i++) {
    if (order[i] == 'americano' || order[i] == 'iceamericano' || order[i] == 'americanoice' || order[i] == 'hotamericano' || order[i] == 'americanohot') {
      answer += 4500;
    } else if (order[i] == 'cafelatte' || order[i] == 'icecafelatte' || order[i] == 'cafelatteice' || order[i] == 'hotcafelatte' || order[i] == 'cafelattehot') {
      answer += 5000;
    } else {
      answer += 4500;
    }
    //console.log(answer);
  }
  return answer;
}

//console.log(solution4(["cafelatte", "americanoice", "hotcafelatte", "anything"]));


function solution6(arr, queries) {
  var answer = [];
  let temp = [];
  for (let i = 0; i < queries.length; i++) {
    for (let j = 1; j < queries[i].length; j++) {
      let prev = queries[i][j - 1];
      let next = queries[i][j];
      temp.push(arr[prev]);
      arr[prev] = arr[next];
      arr[next] = temp[0];
      answer = arr;
    }
    temp = [];
  }
  return answer;
}

//console.log(solution6([0, 1, 2, 3, 4], [[0, 3], [1, 2], [1, 4]]));
//[0, 1, 2, 3, 4]

//[[0, 3],
// [1, 2],
// [1, 4]]

//[3, 4, 1, 0, 2]

function solution7(arr, queries) {
  var answer = [];
  for (let i = 0; i < queries.length; i++) {
    let s = queries[i][0];
    let e = queries[i][1];
    let k = queries[i][2];
    for (let j = s; j <= e; j++) {
      if (j % k == 0) {
        arr[j]++;
      }
    }
    answer = arr;
  }
  return answer;
}

console.log(solution7([0, 1, 2, 4, 3],[[0, 4, 1], [0, 3, 2], [0, 3, 3]]));