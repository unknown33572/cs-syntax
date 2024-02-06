function solution(myString) {
  let answer = '';
  let regex = /[a-k]/g;
  if (myString.match(regex)) {
    answer = myString.replace(/[a-k]/g, 'l');
  }
  return answer;
}

/*
function solution(myString) {
  return [...myString].reduce((acc, cur) => {
    if (cur < 'l') {
      acc += 'l';
    }
    else {
      acc += cur;
    }

    return acc;
  }, '');
}
*/