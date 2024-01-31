function solution(num_list) {
  var answer = 0;
  var odd = 0;
  var even = 0;
  for (let i = 0; i < num_list.length; i++) {
    if (i % 2 == 0) {
      console.log(num_list[i]);
      even += num_list[i];
    } else {
      //console.log(num_list[i]);
      odd += num_list[i];
    }
  }
  if (odd > even) {
    answer = odd;
  } else {
    answer = even;
  }
  return answer;
}

console.log(solution([4,2,6,1,7,6]));