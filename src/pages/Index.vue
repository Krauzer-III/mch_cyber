<template>
  <q-page>
    <div class="flex justify-between container q-pt-md">
      <div class="flex">
        <q-icon
          size="sm"
          name="swap_horiz"
          class="material-icons q-pr-sm"
          style="color: #cc2322"
        />
        <span>Фильтр</span>
      </div>
      <div class="flex">
        <router-link to="/map" class="router">
          <q-icon
            size="sm"
            name="place"
            class="material-icons q-pr-sm"
            style="color: #cc2322"
          />
          <span>Поиск на карте</span></router-link
        >
      </div>
    </div>
    <div class="search container q-pt-lg">
      <q-input debounce="500" placeholder="Поиск">
        <template v-slot:append>
          <q-icon name="search" />
        </template>
      </q-input>
    </div>

    <sort-event></sort-event>

    <carousel-event><template v-slot:title> Что нового? </template></carousel-event>
    <carousel-event class="q-pt-lg">
      <template v-slot:title> Рекомендации </template>
    </carousel-event>
    <carousel-event class="q-pt-lg"></carousel-event>
  </q-page>
</template>

<script>
import CarouselEvent from "src/components/CarouselEvent.vue";
import SortEvent from "src/components/SortEvent.vue";
import { defineComponent, ref, onMounted } from "vue";

export default defineComponent({
  components: { CarouselEvent, SortEvent },
  name: "PageIndex",
  setup() {
    return {
      model: ref(null),
      options: ["Google", "Facebook", "Twitter", "Apple", "Oracle"],
    };
  },
});
</script>

<style>
.search .q-field__native,
.q-field__input {
  padding: 0;
}

.search .q-field__control {
  border: 1px solid;
  border-radius: 10px;
}

.router {
  text-decoration: none;
  color: black;
}
</style>
