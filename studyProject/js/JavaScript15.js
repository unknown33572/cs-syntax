﻿function solution(strArr) {
  var answer = [];

  for (var i = 0; i < strArr.length; i++) {
    if (!strArr[i].includes('ad')) {
      answer.push(strArr[i]);
    }
  }

  return answer;
}

function solution(strArr) {
  var answer = [];
  answer = strArr.filter(v => !v.includes('ad'));
}