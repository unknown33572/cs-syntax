function solution(ineq, eq, n, m) {
  var answer = 0;
  if ('>' == ineq && '=' == eq) {
    if (n >= m) {
      answer = 1;
    }
  }
  if ('<' == ineq && '=' == eq) {
    if (n <= m) {
      answer = 1;
    }
  }
  if ('>' == ineq && '!' == eq) {
    if (n > m) {
      answer = 1;
    }
  }
  if ('<' == ineq && '!' == eq) {
    if (n < m) {
      answer = 1;
    }
  }
  return answer;
}

console.log(('b' + 'a' + +'a' + 'a').toLowerCase());

let arr = [1, 4, 21, 30, 100000];
console.log(arr.sort());

function solution2(str_list) {
  var answer = [];
  const findLidx = str_list.findIndex((str) => str === 'l');
  const findRidx = str_list.findIndex((str) => str === 'r');

  if (findLidx !== -1 && (findLidx < findRidx || findRidx === -1)) {
    for (var i = 0; i < findLidx; i++) {
      answer.push(str_list[i]);
    }
  } else if (findRidx !== -1) {
    for (var i = findRidx + 1; i < str_list.length; i++) {
      answer.push(str_list[i]);
    }
  }

  return answer;
}

console.log(solution2(['r', 'r', 'r', 'r']));


function solution3(arr, queries) {
  var answer = [];
  for (var i = 0; i < queries.length; i++) {
    var oneQuery = queries[i][0];
    var twoQuery = queries[i][1];
    var threeQuery = queries[i][2];
    var temp = [];
    for (var j = oneQuery; j <= twoQuery; j++) {
      if (arr[j] > threeQuery) {
        temp.push(arr[j]);
      }
    }
    if (temp.length > 0) {
      answer.push(Math.min(...temp));
    } else {
      answer.push(-1);
    }
  }
  return answer;
}

console.log(solution3([0, 1, 2, 4, 3], [[0, 4, 2], [0, 3, 2], [0, 2, 2]]));

console.log(solution3([7, 8, 9], [[0, 2, 10], [0, 2, 3]]));

function solution4(picture, k) {
  var answer = [];
  var temp = [];


  for (var i = 0; i < picture.length; i++) {
    var str = picture[i];
    var finalArr = [];
    for (var j = 0; j < picture[i].length; j++) {
      temp = str.split('');
    }
    for (var n = 0; n < temp.length; n++) {
      //for (var m = 0; m < k; m++) {
      //  answer.push(temp[n]);
      //}
      var widthCount = k;
      while (widthCount > 0) {
        finalArr.push(temp[n]);
        widthCount--;
      }
    }
    var heightCount = k;
    while (heightCount > 0) {
      answer.push(finalArr.join(''));
      heightCount--;
    }
  }
  return answer;
}

console.log(solution4([".xx...xx.", "x..x.x..x", "x...x...x", ".x.....x.", "..x...x..", "...x.x...", "....x...."], 2));