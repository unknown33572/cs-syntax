//function solution(a, b, c) {
//  let answer = 0;
//  if (!(a == b || b == c || a == c)) {
//    answer = a + b + c;
//  } else if (a == b && b == c) {
//    answer = (a + b + c) * ((a ** 2) + (b ** 2) + (c ** 2)) * ((a ** 3) + (b ** 3) + (c ** 3));
//  } else {
//    answer = (a + b + c) * ((a ** 2) + (b ** 2) + (c ** 2));
//  }
//  return answer;
//}

//const solution = (a, b, c) => {
//  const set = new Set([a, b, c]);
//  switch ([...set].length) {
//    case 1: return calculate([a, b, c], 3);
//    case 2: return calculate([a, b, c], 2);
//    case 3: return calculate([a, b, c]);
//  }
//}

//const calculate = (inc, n = 1) => {
//  const [a, b, c] = inc;
//  let result = 1;
//  for (let i = 1; i <= n; i++) {
//    result *= Math.pow(a, i) + Math.pow(b, i) + Math.pow(c, i)
//  }

//  return result;
//}

function solution(my_string, m, c) {
  var answer = '';
  var twoDimArr = [];
  for (let i = 0; i < my_string.length; i++) {
    twoDimArr.push([my_string[i]]);
  }
  console.log(twoDimArr);
}

solution("ihrhbakrfpndopljhygc", 4, 2);