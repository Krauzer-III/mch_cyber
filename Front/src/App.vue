<template>
  <component :is="layout + '-layout'" v-if="layout" />
</template>
<script>
import { defineComponent, computed, onMounted } from "vue";
import { useRoute } from "vue-router";
import MainLayout from "./layouts/MainLayout.vue";
import AuthLayout from "./layouts/AuthLayout.vue";
import service from "./service/service";

export default defineComponent({
  name: "App",
  setup() {
    const route = useRoute();

    onMounted(() => {
      service
        .getData()
        .then((data) => {
          console.log(data);
        })
        .catch((error) => {
          console.log(error);
        });
    });

    return {
      layout: computed(() => route.meta.layout),
    };
  },

  components: { MainLayout, AuthLayout },
});
</script>
<style>
main {
  margin-bottom: 80px;
}
</style>
