const validate = {
  formatMoney(money) {
    const formattedValue = money.replace(/\D/g, "");//loại bỏ ký tự không phải số
    return new Intl.NumberFormat("vi-VN", {
      style: "currency",
      currency: "VND",
      currencyDisplay: "symbol",
    })
      .format(formattedValue)
      .replace("₫", "");
  },
};
export default validate;
