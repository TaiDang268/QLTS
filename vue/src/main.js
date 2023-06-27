import { createApp } from "vue";
import App from "./App.vue";
import store from "./store/store.js";

import ElementPlus from "element-plus";
import "element-plus/dist/index.css";

import mitt from "mitt";

import vClickOutside from "click-outside-vue3";

import MISAPagination from "../src/components/base/MISAPagination.vue";
import MISAPopup from "../src/components/base/MISAPopup.vue";
import MISATable from "../src/components/base/MISATable.vue";
import MISACombobox from "../src/components/base/MISACombobox.vue";
import MISAButtonEdit from "../src/components/base/MISAButtonEdit.vue";
import MISAButton from "../src/components/base/MISAButton.vue";
import MISAInputNumber from "../src/components/base/MISAInputNumber.vue";
import MISADatePicker from "../src/components/base/MISADatePicker.vue";
import MISAContextMenu from "../src/components/base/MISAContextMenu.vue";
import MISAToastMessage from "../src/components/base/MISAToastMessage.vue";
import MISARow from "../src/components/base/MISARow.vue";

const emitter = mitt();
const app = createApp(App);

app.config.globalProperties.emitter = emitter;
app.component("MISAPagination", MISAPagination);
app.component("MISAPopup", MISAPopup);
app.component("MISATable", MISATable);
app.component("MISACombobox", MISACombobox);
app.component("MISAButtonEdit", MISAButtonEdit);
app.component("MISAButton", MISAButton);
app.component("MISAInputNumber", MISAInputNumber);
app.component("MISADatePicker", MISADatePicker);
app.component("MISAContextMenu", MISAContextMenu);
app.component("MISAToastMessage", MISAToastMessage);
app.component("MISARow", MISARow);

app.use(store);

app.use(ElementPlus);
app.use(vClickOutside);
app.mount("#app");
