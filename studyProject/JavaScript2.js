function solution(my_strings, parts) {
  var answer = '';

  for (let i = 0; i < my_strings.length; i++) {
    let part = my_strings[i].substring(parts[i][0], parts[i][1] + 1);
    answer += part;
  }

  return answer;
}o", "gram", "mers"], [[0,2],[0,3],[0,3]]);