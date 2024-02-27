function solution(my_string, s, e) {
  var answer = '';
  stringArr = my_string.split('');
  var temp = stringArr.slice(s, e + 1).reverse();
  for (var i = s; i <= e; i++) {
    stringArr[i] = temp[i - s];
    answer = stringArr.join('');
  }
  return answer;
}