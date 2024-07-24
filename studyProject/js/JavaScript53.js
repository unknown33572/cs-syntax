//function solution(arr) {
//  var answer = [[]];
//  for (var i = 0; i < arr.length; i++) {
//    for (var j = 0; j < arr[i].length; j++) {
//      if (arr.length > arr[i].length) {
//        arr[i].push(0);
//      }
//    }
//    if (arr.length != arr[i].length) {
//      var newArr = [];
//      for (var k = 0; k < arr[i].length; k++) {
//        newArr.push(0);
//      }
//      arr.push(newArr);
//    }
//  }
//  answer = arr;
//  return answer;
//}

//console.log(solution([[1, 1], [1, 1], [1, 1], [1, 1]]));

function solution(my_string, queries) {
  var answer = '';
  var arr = my_string.split('');

  for (var i = 0; i < queries.length; i++) {
      var first = queries[i][0];
      var last = queries[i][queries[i].length - 1];

    while (first < last) {
      var temp = arr[first];
      arr[first] = arr[last];
      arr[last] = temp;

      first++;
      last--;
    }
  }

  answer = arr.join('');
  return answer;
}

console.log(solution('rermgorpsam', [[2, 3], [0, 7], [5, 9], [6, 10]]));