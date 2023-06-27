<template>
  <div class="app">
    <TheSidebar />
    <div class="main">
      <TheHeader />
      <MISAToastMessage />
      <Content />
    </div>
  </div>
</template>

<script>
import TheSidebar from "./components/layout/TheSidebar.vue";
import TheHeader from "./components/layout/TheHeader.vue";
import Content from "./components/ContentPage.vue";
import MISAToastMessage from "./components/base/MISAToastMessage.vue";

export default {
  name: "App",
  /* eslint-disable */
  components: {
    TheSidebar,
    TheHeader,
    Content,
    MISAToastMessage,
  },
};
</script>

<style>
@import url(css/constant/global.css);
.app {
  width: 100vw;
  height: 100vh;
  display: flex;
}
.sidebar {
  width: 66px;
  height: 100%;
  background-color: #1c3048;
  box-shadow: 0 3px 6px rgba(0, 0, 0, 0.16);
}
.main {
  width: calc(100% - 66px);
  height: 100vh;
  display: flex;
  flex-direction: column;
}
.header {
  width: 100%;
  height: 56px;
  background-color: #ffffff;
}
</style>
