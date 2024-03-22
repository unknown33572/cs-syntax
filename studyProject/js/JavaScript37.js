//const validator = {
//  message: '는 유효하지 않습니다.',
//  setInvalidMessage(field) {
//    return `${field}${this.message}`;
//  }
//};

const validator = {
  message: '는 유효하지 않습니다.',
  setInvalidMessage(...fields) {
    return fields.map(e => `${e}${this.message}`);
  }
};

console.log(validator.setInvalidMessage('도시'));

class Coupon {
  constructor(price, expiration) {
    this.price = price;
    this.expiration = expiration || '2주';
  }
  getPriceText = () => `$ ${this.price}`;
  getExpirationMessage = () => `이 쿠폰은 ${this.expiration} 후에 만료됩니다.`;
  isRewardsEligible = user => user.rewardsEligible && user.active;
  getRewars = user => this.isRewardsEligible(user) ? this.price * 0.9 : this.price;
}

//const coupon = new Coupon(5);

//console.log(coupon.getPriceText());

//const arrowFunction = () => {
//  this.p = 1;
//  console.log(this);
//};
//arrowFunction();

exports.Coupon = Coupon;