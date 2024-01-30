function solution(n_str) {
  var answer = '';
  let k = n_str.split('');
  for (let i = 0; i < n_str.length; i++) {
    if (k[i] === '0') {
      k.shift();
      i--;
    } else {
      break;
    }
  }
  return k.join('').toString();
}