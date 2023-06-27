import { createMemoryHistory, createRouter } from "vue-router";
import ContentPage from "@/components/ContentPage";
const routers = [
  {
    path: "/",
    name: "ContentPageRouter",
    component: ContentPage,
  },
];
const vueRouter = createRouter({
  mode: createMemoryHistory(),
  routes: routers,
});
export default vueRouter;
