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

console.log(solution2(['r','r','r','r']));