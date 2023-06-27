<template>
  <tr
    @contextmenu.prevent
    @mousedown.right="openContextMenu"
    :class="{ selectRow: isSelected }"
  >
    <td class="table-text-align--center">
      <div
        :class="isSelected ? 'selected-icon' : 'icon-box'"
        @click="toggleSelection"
      ></div>
    </td>
    <td class="table-text-align--center" style="padding-right: 20px">
      {{ stt }}
    </td>
    <td>{{ item.assetCode }}</td>
    <td>{{ item.assetName }}</td>
    <td>{{ item.categoryName }}</td>
    <td>{{ item.departmentName }}</td>
    <td class="table-text-align--right">{{ item.quantity }}</td>
    <td class="table-text-align--right">{{ item.cost }}</td>
    <td class="table-text-align--right">{{}}</td>
    <td class="table-text-align--right">{{}}</td>
    <td class="table-text-align--center">
      <MISAButtonEdit />
    </td>
  </tr>
  <MISAContextMenu v-if="showContext" :display="showContextMenu" ref="menu" />
</template>
<script>
export default {
  data() {
    return {
      showContextMenu: false, // mở context menu
      isSelected: false, // dòng được chọn
    };
  },
  props: {
    item: {}, //tài sản
    stt: {}, //số thứ tự
    showContext: { default: true }, // mở context menu
  },

  methods: {
    //mở context menu
    openContextMenu(e) {
      this.$refs.menu.open(e);
    },
    toggleSelection() {
      this.isSelected = !this.isSelected;
      if (this.isSelected) {
        // Thêm dòng vào mảng selectList
        this.$emit("addItemSelectList", this.item);
      } else {
        // Xóa dòng khỏi mảng selectList
        this.$emit("removeItemSelectList", this.item);
      }
    },
  },
};
</script>
<style>
.icon-box {
  background: url(../../assets/images/qlts-icon.svg) no-repeat -113px -377px;
  width: 14px;
  height: 14px;
  margin-left: 10px;
}
.selectRow {
  background-color: rgba(26, 164, 200, 0.2);
}
.selected-icon {
  background: url(../../assets/images/qlts-icon.svg) no-repeat -157px -377px;
  width: 14px;
  height: 14px;
  margin-left: 10px;
}
</style>
