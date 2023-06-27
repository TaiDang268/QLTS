<template>
  <div class="header">
    <div class="container">
      <div class="header-title">
        <p style="font-family: RobotoBold">Danh sách tài sản</p>
      </div>
      <div class="header-right">
        <p class="header-right-title">Sở tài chính</p>
        <div class="header-right-date"></div>
        <div class="header-right-group-icon">
          <el-tooltip content="Thông báo " effect="dark">
            <div class="header-right-group-icon-item bell-icon"></div>
          </el-tooltip>
          <el-tooltip content="Hệ thống " effect="dark">
            <div class="header-right-group-icon-item four-scare-icon"></div>
          </el-tooltip>

          <el-tooltip content="Trợ giúp " effect="dark">
            <div class="header-right-group-icon-item question-mark-con"></div>
          </el-tooltip>
          <el-tooltip content="Cá nhân " effect="dark">
            <div class="header-right-group-icon-item user-icon"></div>
          </el-tooltip>
          <div class="header-right-group-icon-item arrow-item">
            <img src="" alt="" />
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "TheHeader",
  props: {},
};
</script>
<style scoped>
@import url(../../css/layout/TheHeader.css);
</style>
