function solution(myString) {
  var answer = [];
  answer = myString.split('x');
  for(var i=0; i<answer.length; i++) {
    answer[i] = answer[i].length;
  }
  return answer;
}

console.log(solution('oxooxoxxox'));

function solution(myString) {
  return myString.split('x').map(v => v.length);
}

const solution = (myString) => {
  const arr = myString.split('x');
  return arr.reduce((a, c) => [...a, c.length], []);
}