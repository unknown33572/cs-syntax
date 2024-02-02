function solution(n) {
  let answer = [n];

  function helper(x) {
    if(x === 1) {
      return;
    }
    if (x % 2 === 0) {
      x /= 2;
    } else {
      x = (3 * x) + 1;
    }
    answer.push(x);
    helper(x);
  }
  //helper(n);
  //return answer;
  if (n === 1) {
    return answer;
  } else {
    helper(n);
    return answer;
  }
}

/*
function solution(n, arr = []) {
    arr.push(n)
    if (n === 1) return arr
    if (n % 2 === 0) return solution(n / 2, arr)
    return solution(3 * n + 1, arr)
}
*/