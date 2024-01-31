function solution(my_string) {
  const words = my_string.trim().split(' ').filter(word => word !== '');
  return words;
}

function solution2(my_string) {
  let words = [];
  let currentWord = '';

  for (let i = 0; i < my_string.length; i++) {
    if (my_string[i] !== ' ') {
      currentWord += my_string[i];
    } else if (currentWord !== '') {
      words.push(currentWord);
      currentWord = '';
    }
  }

  if (currentWord !== '') {
    words.push(currentWord);
  }

  return words;
}

console.log(solution2("i love you"));
console.log(solution2("  programmers "));