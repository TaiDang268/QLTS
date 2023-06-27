<template>
  <div class="toast-message" v-if="isOpen">
    <div
      class="icon"
      :class="{
        'icon-toast-message': error == false,
        'icon-toast-message-error': error == true,
      }"
    ></div>
    {{ message }}
  </div>
</template>
<script>
export default {
  data() {
    return {
      isOpen: false, // hiển thị
      message: { default: null, type: String }, // đoạn thông báo
      error: false, // hiện lỗi
    };
  },
  mounted() {
    this.emitter.on("openToastMessage", async (message) => {
      this.error = false;
      this.isOpen = true;
      this.message = message;
      await setTimeout(() => {
        this.isOpen = false;
      }, 3000);
    });
    this.emitter.on("openToastMessageError", async (message) => {
      this.error = true;
      this.isOpen = true;
      this.message = message;
      await setTimeout(() => {
        this.isOpen = false;
      }, 3000);
    });
  },
};
</script>
<style>
@import url(../../css/base/MISAToastMessage.css);

.toast-message {
  position: fixed;
  bottom: 20px;
  right: 20px;
  width: 250px;

  background-color: #fff;
  border-radius: 4px;
  font-size: 14px;
  color: #000000;
  box-shadow: 0 2px 6px rgba(0, 0, 0, 0.16);

  align-items: center;
  padding: 15px;
  display: flex;
  flex-direction: row;
  justify-content: flex-start;
  column-gap: 20px;
  z-index: 3;
}
.icon-toast-message {
  background: url(../../assets/images/qlts-icon.svg) no-repeat -111px -594px;
  width: 18px;
  height: 20px;
}
.icon-toast-message-error {
  background: url(../../assets/images/qlts-icon.svg) no-repeat -67px -594px;
  width: 18px;
  height: 20px;
}
</style>
