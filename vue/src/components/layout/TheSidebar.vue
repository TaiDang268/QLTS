<template>
  <div :class="['sidebar', { expanded: isExpanded }]">
    <!-- logohome -->
    <div :class="['logo-home', { expanded: isExpanded }]">
      <img src="../../assets/icons/logo-home.svg" alt="" />
      <span v-if="isExpanded">MISA QLTS </span>
    </div>
    <!-- các button trong thanh sidebar -->
    <MISAButton
      v-for="(item, index) in items"
      :key="index"
      @click="selectIcon(index)"
      :class="{
        active: selectedItem === index,
        'item-sidebar': !isExpanded,
        'item-sidebar-expanded': isExpanded,
      }"
    >
      <div
        :style="`background-image: url(${item.url}); background-position: ${item.position}; width:24px; height:24px`"
      ></div>
      <span v-if="isExpanded">{{ item.name }}</span>
      <div v-if="isExpanded" :class="item.iconV"></div>
    </MISAButton>
    <div :class="{ divider: isExpanded }"></div>
    <MISAButton
      :class="{
        'toggle-sidebar-icon-expanded': !isExpanded,
        'toggle-sidebar-icon-not-expanded': isExpanded,
      }"
      @click="toggleSidebar"
    ></MISAButton>
  </div>
</template>
<script>
export default {
  name: "TheSidebar",
  props: {},
  data() {
    return {
      // mảng chứa các icon của thanh sidebar
      items: [
        {
          url: require("../../assets/images/qlts-icon.svg"),
          position: "-21px -153px",
          name: "Tổng quan ",
        },
        {
          url: require("../../assets/images/qlts-icon.svg"),
          position: "-65px -153px",
          name: "Tài sản ",
          iconV: "iconV",
        },
        {
          url: require("../../assets/images/qlts-icon.svg"),
          position: "-110px -153px",
          name: "Tài sản HT-DB",
          iconV: "iconV",
        },
        {
          url: require("../../assets/images/qlts-icon.svg"),
          position: "-153px -153px",
          name: "Công cụ dụng cụ ",
          iconV: "iconV",
        },
        {
          url: require("../../assets/images/qlts-icon.svg"),
          position: "-197px -155px",
          name: "Danh mục",
        },
        {
          url: require("../../assets/images/qlts-icon.svg"),
          position: "-241px -153px",
          name: "Tra cứu ",
          iconV: "iconV",
        },
        {
          url: require("../../assets/images/qlts-icon.svg"),
          position: "-329px -153px",
          name: "Báo cáo",
          iconV: "iconV",
        },
      ],
      selectedItem: null,
      isExpanded: false,
    };
  },
  methods: {
    selectIcon(index) {
      this.selectedItem = index;
    },
    toggleSidebar() {
      this.isExpanded = !this.isExpanded;
    },
  },
};
</script>
<style scoped>
@import url(../../css/layout/TheSidebar.css);
</style>
