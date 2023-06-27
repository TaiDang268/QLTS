<template>
  <div
    class="context-menu"
    :style="style"
    ref="context"
    v-if="show"
    @blur="close"
    v-click-outside="close"
  >
    <div class="context-menu-option">
      <div class="icon icon-add" style="margin: 8px"></div>
      Thêm tài sản
    </div>
    <div class="context-menu-option">
      <div class="icon icon-pen" style="margin: 8px"></div>
      Sửa tài sản
    </div>
    <div class="context-menu-option" @click="handlDelete">
      <div class="icon icon-trash-black" style="margin: 8px"></div>
      Xóa tài sản
    </div>
    <div class="context-menu-option">
      <div class="icon icon-copy" style="margin: 8px"></div>
      Nhân bản tài sản
    </div>
  </div>
</template>
<script>
export default {
  props: { display: Boolean },
  data() {
    return {
      left: 0, // left position
      top: 0, // top position
      show: false,
    };
  },
  computed: {
    style() {
      return {
        top: this.top + "px",
        left: this.left + "px",
      };
    },
  },
  methods: {
    close() {
      this.show = false;
      this.left = 0;
      this.top = 0;
    },
    open(evt) {
      this.emitter.emit("closeOrtherContextMenu");
      this.left = evt.pageX || evt.clientX;
      this.top = evt.pageY || evt.clientY;

      this.show = true;
    },
  },
  mounted() {
    this.emitter.on("closeOrtherContextMenu", () => {
      this.close();
    });
  },
};
</script>
<style>
.context-menu {
  position: fixed;
  background: white;
  z-index: 999;
  outline: none;
  width: 150px;
  display: flex;
  flex-direction: column;
  border-radius: 3.5px;
  box-shadow: 0 2px 6px rgba(0, 0, 0, 0.16);
  padding: 3px;
}
.context-menu-option {
  height: 35px;
  align-items: center;
  display: flex;
  flex-direction: row;
  cursor: pointer;
  font-size: 14px;
  font-family: "Roboto", sans-serif;
}
.context-menu-option:hover {
  background-color: rgba(26, 164, 200, 0.2);
}
.icon-pen {
  background: url(../../assets/images/qlts-icon.svg) no-repeat -156px -68px;
  width: 16px;
  height: 16px;
}
.icon-add {
  background: url(../../assets/images/qlts-icon.svg) no-repeat -375px -419px;
  width: 18px;
  height: 18px;
}
.icon-copy {
  background: url(../../assets/images/qlts-icon.svg) no-repeat -244px -112px;
  width: 16px;
  height: 16px;
}
.icon-trash-black {
  background: url(../../assets/images/qlts-icon.svg) no-repeat -419px -111px;
  width: 18px;
  height: 18px;
}
</style>
