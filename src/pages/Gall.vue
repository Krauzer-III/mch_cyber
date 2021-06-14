<template>
  <q-page>
    <div class="container card-more">
      <div class="back flex q-mt-md">
        <router-link to="/event" class="chatrout">
          <q-icon
            size="sm"
            name="arrow_back"
            class="material-icons q-pr-sm"
            style="color: black"
        /></router-link>
        <span>Галерея мероприятия</span>
      </div>

      <div class="q-mt-md text-h6">
        <span>Лето в Москве</span>
      </div>

      <q-card class="q-mt-md">
        <q-tabs
          v-model="tab"
          dense
          class="text-grey"
          active-color="primary"
          indicator-color="primary"
          align="justify"
          narrow-indicator
        >
          <q-tab name="mails" label="Видео" />
          <q-tab name="alarms" label="Фото" />
          <q-tab name="movies" label="Музыка" />
        </q-tabs>

        <q-separator />

        <q-tab-panels v-model="tab" animated>
          <q-tab-panel name="mails">
            <div class="text-h6 text-center">Пусто</div>
          </q-tab-panel>

          <q-tab-panel name="alarms">
            <div class="text-h6 text-center">Пусто</div>
          </q-tab-panel>

          <q-tab-panel name="movies">
            <div class="text-h6 text-center">Пусто</div>
          </q-tab-panel>
        </q-tab-panels>
      </q-card>
    </div>
  </q-page>
</template>

<script>
import { ref } from "vue";

export default {
  setup() {
    return {
      tab: ref("mails"),
    };
  },
};
</script>

<style></style>
