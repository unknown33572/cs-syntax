function solution(rank, attendance) {
  var answer = 0;

  var map = new Map();

  for (var i = 0; i < rank.length; i++) {
    map.set(rank[i], attendance[i]);
  }

  var firstIdx = 0;
  var secondIdx = 0;
  var thirdIdx = 0;
  var firstSmallest = Infinity;
  var secondSmallest = Infinity;
  var thirdSmallest = Infinity;

  for (let i = 0; i < rank.length; i++) {
    if (map.get(rank[i]) && rank[i] < firstSmallest) {
      firstSmallest = rank[i];
      firstIdx = i;
    }
  }

  for (let i = 0; i < rank.length; i++) {
    if (map.get(rank[i]) && rank[i] < secondSmallest && rank[i] != firstSmallest) {
      secondSmallest = rank[i];
      secondIdx = i;
    }
  }

  for (let i = 0; i < rank.length; i++) {
    if (map.get(rank[i]) && rank[i] < thirdSmallest && rank[i] != secondSmallest && rank[i] != firstSmallest) {
      thirdSmallest = rank[i];
      thirdIdx = i;
    }
  }

  answer = 10000 * firstIdx + 100 * secondIdx + thirdIdx;

  return answer;
}

solution([1, 2, 3], [true, true, true]);