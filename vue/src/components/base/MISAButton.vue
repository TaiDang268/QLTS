<template>
  <button class="button-primary">
    <slot></slot>
  </button>
</template>
<script>
export default {
  name: "MISAButton",
  props: {},
};
</script>
<style scoped>
@import url(../../css/constant/colors.css);
.button-primary {
  height: 36px;
  border-radius: 4px;
  border: 1px solid var(--border-color);
  cursor: pointer;
}
.button-primary:hover {
  border: 1px solid var(--hover-color);
}
</style>
