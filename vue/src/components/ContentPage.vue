<template>
  <div class="content">
    <div class="filter-action-control">
      <div class="wrapper-filter">
        <div class="wrapper-search">
          <input
            class="search-input"
            type="text"
            placeholder="Tìm kiếm tài sản"
          />
          <div class="search-icon"></div>
        </div>
        <MISACombobox
          class="filter-type"
          :items="listTypeProperty"
          v-model:value="inputTypeProperty"
          :placeholder="'Loại tài sản'"
          :icon="'select'"
        />
        <MISACombobox
          class="filter-department"
          :items="listDepartment"
          v-model:value="inputDepartment"
          :placeholder="'Bộ phận sử dụng'"
          :icon="'select'"
        />
      </div>
      <div class="action">
        <MISAButton class="add-btn">
          <p style="font-family: RobotoBold">+ Thêm tài sản</p>
        </MISAButton>
        <el-tooltip content="Xuất Excel " effect="dark">
          <MISAButton class="export-exel-btn">
            <div class="export-exel-icon"></div
          ></MISAButton>
        </el-tooltip>
        <el-tooltip content="Xóa " effect="dark">
          <MISAButton
            class="delete-btn"
            @click.stop="$emit(deleteSelectedItem)"
          >
            <div class="delete-icon"></div
          ></MISAButton>
        </el-tooltip>
      </div>
    </div>
    <MISAPopup v-if="isPopupVisible" :popupTitle="popupTitle" />
    <MISATable />
  </div>
</template>

<script>
export default {
  name: "TheContent",
  props: {},

  data() {
    return {
      inputDepartment: "",
      inputTypeProperty: "",
    };
  },
  computed: {},
  methods: {},
};
</script>

<style scoped>
@import url(../css/ContentPage.css);
</style>
