function solution(myString, pat) {
  let answer = 0;
  myString = myString.toString();

  let y = myString.split('').join('');
  let k = "";

  for (let i = 0; i < myString.length; i++) {
    if (y[i] === 'A') {
      k += 'B';
    } else if (y[i] === 'B') {
      k += 'A'
    } else {
      return;
    }
  }

  if (k.includes(pat)) {
    answer = 1;
  } else {
    answer = 0;
  }

  return answer;
}

console.log(solution('ABBAA', 'AAAB'));
