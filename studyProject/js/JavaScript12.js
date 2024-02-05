function solution(str_list, ex) {
  let answer = '';
  let result = '';
  let arr = [];
  for (let x of str_list) {
    if (!x.includes(ex)) {
      arr.push(x);
    }
    result = arr.join(',')
  }
  answer = result.split(',').join('');
  return answer;
}

console.log(solution(['longlong', 'long', 'longlonglong', 'longlonglonglong'], 'long'));