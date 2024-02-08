function solution(number) {
  let answer = 0;
  let temp = number.split('');
  for(let i = 0; i < temp.length; i++) {
    answer += parseInt(temp[i]);
  }
  return answer % 9;
}