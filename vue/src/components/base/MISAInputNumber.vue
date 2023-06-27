<template>
  <div class="input-number">
    <input type="text" v-model="value" @input="validateInput" />
    <div class="buttons">
      <button @click="increment" class="btn-inc-icon"></button>
      <button @click="decrement" class="btn-dec-icon"></button>
    </div>
  </div>
</template>

<script>
export default {
  props: {
    decimalAllowed: {
      type: Boolean,
      default: false,
    },
    step: {
      type: Number,
      default: 1,
    },
  },
  data() {
    return {
      value: 0,
    };
  },

  methods: {
    validateInput() {
      const regex = this.decimalAllowed ? /^-?\d*\.?\d*$/ : /^-?\d*$/;

      if (!regex.test(this.inputValue)) {
        // Loại bỏ tất cả các ký tự không hợp lệ
        this.inputValue = this.value.replace(regex, "");
      }
    },
    increment() {
      this.value += this.step;
    },
    decrement() {
      if (this.value > 0) {
        this.value -= this.step;
      }
    },
  },
};
</script>

<style scoped>
@import url(../../css/base/MISAInputNumber.css);
</style>
