function Coupon(price, expiration) {
  this.price = price;
  this.expiration = expiration || '2주';
}

const coupon = new Coupon(5);
console.log(coupon.price);
console.log(coupon.expiration);

Coupon.prototype.getExpirationMessage = function () {
  return `이 쿠폰은 ${this.expiration} 후에 만료됩니다.`;
}

console.log(coupon.getExpirationMessage());


function solution(myString, pat) {
  var answer = 0;
  for(var i = 0; i < myString.length; i++) {
    if(myString[i] === pat[0]) {
      var temp = myString.slice(i, i + pat.length);
      if(temp === pat) {
        answer++;
      }
    }
  }
  return answer;
}