<template>
  <q-page>
    <div>
      <img
        src="https://www.google.com/maps/d/thumbnail?mid=1T5gUV24ivHeTt1RYoKNbbnbPvxg&hl=ru"
      />
    </div>
    <div class="q-pa-md">
      <div class="title-map">Хотите хорошо провести время?</div>
      <div class="desc-desc">
        Начните вбивать название мероприятия и мы найдем его и похожие рядом с вами
      </div>
      <div class="search container">
        <q-input debounce="500" placeholder="Поиск">
          <template v-slot:append>
            <q-icon name="search" />
          </template>
        </q-input>
      </div>
    </div>
  </q-page>
</template>

<script>
import { defineComponent } from "vue";

export default defineComponent({
  setup() {
    return {};
  },
});
</script>

<style>
.title-map {
  font-size: 20px;
  font-weight: 600;
}
</style>
