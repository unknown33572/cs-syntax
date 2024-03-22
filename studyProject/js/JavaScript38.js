const Coupon = require('./JavaScript37.js').Coupon;

class FlashCoupon extends Coupon {
  constructor(price, expiration) {
    super(price);
    this.expiration = expiration || '2시간';
  }

  getExpirationMessage = () => `이 쿠폰은 깜짝 쿠폰이며 ${this.expiration} 후에 만료됩니다.`;
  isRewardsEligible(user) {
    return super.isRewardsEligible(user) && this.price > 20;
  }
  getReward(user) {
    if (this.isRewardsEligible(user)) {
      this.price = this.price * 0.8;
    }
  }
}

const flash = new FlashCoupon(25, '3시간');

console.log(flash.getPriceText());
const verification = { rewardsEligible: true, active: true };
console.log(flash.getExpirationMessage());
console.log(verification);
flash.getReward(verification);
console.log(`보상 받은 가격: ${flash.getPriceText()}`);