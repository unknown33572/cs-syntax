function solution(my_string, indices) {
  var answer = '';
  for (var i = 0; i < my_string.length; i++) {
    if (indices.indexOf(i) === -1) {
      answer += my_string[i];
    }
  }
  return answer;
}

function solutionTwo(my_string, indices) {
  const stringArr = my_string.split('');
  const filteredArr = stringArr.filter((x, index) => !indices.includes(index));

  return filteredArr.join('');
}

console.log(solution('apporoograpemmemprs', [1, 16, 6, 15, 0, 10, 11, 3]));
console.log(solutionTwo('apporoograpemmemprs', [1, 16, 6, 15, 0, 10, 11, 3]));