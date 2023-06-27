<template>
  <VueDatePicker
    class="custom-datepicker"
    ref="myDatePicker"
    v-model="modelValue"
    format="dd/MM/yyyy"
    auto-apply
    text-input
  ></VueDatePicker>
</template>

<script scoped>
import VueDatePicker from "@vuepic/vue-datepicker";
import "@vuepic/vue-datepicker/dist/main.css";
export default {
  name: "MISADatepicker",
  props: {},
  data() {
    return {
      modelValue: new Date().toLocaleDateString(),
    };
  },
  components: {
    VueDatePicker,
  },
  watch: {},
  methods: {},
};
</script>

<style scoped>
@import url(../base/MISADatePicker.vue);
</style>
