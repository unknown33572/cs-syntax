function solution(binomial) {
  var answer = 0;
  var arr = binomial.split(' ');
  if (arr[1] === '+') {
    answer = parseInt(arr[0]) + parseInt(arr[2]);
  }
  if (arr[1] === '-') {
      answer = parseInt(arr[0]) - parseInt(arr[2]);
  }
  if(arr[1] === '*') {
    answer = parseInt(arr[0]) * parseInt(arr[2]);
  }
  if(arr[1] === '/') {
      answer = parseInt(arr[0]) / parseInt(arr[2]);
  }
  return answer;
}

const ops = {
  '+': (a, b) => a + b,
  '-': (a, b) => a - b,
  '*': (a, b) => a * b,
};

function solution(binomial) {
  const [a, op, b] = binomial.split(' ');
  return ops[op](+a, +b);
}