function linearScanClosestNeighbor(arr, targer, dist) {
  let N = arr.length;
  if (N === 0) {
    return null;
  }

  let candidate = arr[0];
  let closestDistance = dist(target, candidate);

  for (let i = 1; i < N; i++) {
    let currentDistance = dist(target, arr[i]);
    if(currentDistance < closestDistance) {
      candidate = arr[i];
      closestDistance = currentDistance;
    }
  }
  return candidate;
}

function dist(a, b) {
  return Math.abs(a - b);
}

let arr = [1, 2, 3, 4, 5];

console.log(linearScanClosestNeighbor(arr, 3.5, dist)); // 4