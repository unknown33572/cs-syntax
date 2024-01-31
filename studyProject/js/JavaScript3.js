function solution(arr, delete_list) {
  var answer = [];
  for (let i = 0; i < arr.length; i++) {
    let flag = false;
    for (let j = 0; j < delete_list.length; j++) {
      if (arr[i] === delete_list[j]) {
        flag = true;
        break;
      }
    }
    if (!flag) {
      answer.push(arr[i]);
    }
  }
  return answer;
}

console.log(solution([123, 456, 789], [123, 789]));