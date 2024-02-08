function solution(myString) {
  let answer = [];
  let temp = myString.split('x').sort();
  for (let i = 0; i < temp.length; i++) {
    if(temp[i] !== '') answer.push(temp[i])
  }

  return answer;
}