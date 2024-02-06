function solution(my_string) {
  var answer = [];
  var len = my_string.length;
  for (var i = len; i > 0; i--) {
      let substring = my_string.slice(i - 1);
      answer.push(substring);
  }
  answer.sort();
  return answer;
}

console.log(solution('banana'));

function solution(my_string) {
  return [...my_string].reduce((acc, cur, idx, arr) => {
    const original = arr.join('');

    acc = [...acc, original.slice(idx)].sort();

    return acc;
  }, []);
}