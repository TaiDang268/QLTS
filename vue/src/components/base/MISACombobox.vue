<template>
  <div
    class="combobox"
    @click="changeIsOpen"
    @keydown.down="setFocusDown()"
    @keydown.up="setFocusUp()"
    @keydown.enter="setValue(listItem[tmpIndex])"
    @keydown.tab="isOpen = false"
  >
    <div class="box-input" :class="{ 'box-input-select': isOpen }">
      <div :class="[icon ? 'icon-' + icon : '']"></div>
      <input
        type="text"
        class="input-box"
        :value="value"
        :placeholder="placeholder"
        @input="
          isOpen = true;
          $emit('update:value', $event.target.value);
        "
        ref="input"
        style="cursor: pointer"
        @keydown="handleKeyDown"
      />
      <div class="icon-mini-down"></div>
    </div>
    <div class="box-item" :class="{ 'box-item-display': isOpen }" ref="boxItem">
      <div
        class="item-box"
        v-for="item of listItem"
        :key="item.id"
        v-on:click.stop="setValue(item)"
        :class="{ highlight: index == tmpIndex || item.name == value }"
      >
        <div class="item-name">{{ item.name }}</div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      isOpen: false, // hiển thị lựa chọn
      listItem: [], // danh sách hiển thị
      tmpIndex: 0, // vị trí focus
      heightItem: 35, // chiều cao
    };
  },
  props: {
    placeholder: { type: String }, // placeholder
    value: { type: String }, // giá trị input nnhận
    items: { type: Array }, // danh sách option nhận
    id: { default: null, type: String }, // ID
    icon: { type: String },
  },
  computed: {},

  methods: {
    // Thay đổi trạng thái isOpen của combobox
    handleKeyDown(event) {
      if (event.key === "ArrowDown") {
        this.setFocusDown();
      } else if (event.key === "ArrowUp") {
        this.setFocusUp();
      }
    },
    setFocusDown() {
      if (this.tmpIndex < this.listItem.length - 1) {
        this.tmpIndex++;
      }
    },
    setFocusUp() {
      if (this.tmpIndex > 0) {
        this.tmpIndex--;
      }
    },

    changeIsOpen() {
      this.isOpen = !this.isOpen;
      if (this.isOpen == true) {
        this.$refs.input.focus();
      }
    },
    setValue(item) {
      if (this.isOpen == true) {
        this.$emit("update:value", item.name);
        this.isOpen = false;
      }
    },

    checkInput() {
      this.listItem = [];
      if (this.value == null || this.value == "") {
        this.listItem = this.items;
      } else if (this.value) {
        this.items.forEach((element) => {
          if (element.name.toLowerCase().includes(this.value.toLowerCase())) {
            this.listItem.push(element);
          }
        });
      }
      this.tmpIndex = 0;
    },
  },
  watch: {
    value() {
      this.checkInput();
    },
    items() {
      this.checkInput();
    },
  },
  mounted() {
    this.listItem = this.items;
  },
};
</script>
<style scoped>
@import url(../../css/base/MISACombobox.css);
</style>
