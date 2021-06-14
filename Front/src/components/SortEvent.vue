<template>
  <div class="tab">
    <q-tabs inline-label class="events q-mt-md bg-primary">
      <q-tab>
        <div class="sortevent">
          <div class="q-pa-sm q-px-md">Музыка</div>
        </div>
        <div class="sortevent">
          <div class="q-pa-sm q-px-md">Спорт</div>
        </div>
        <div class="sortevent">
          <div class="q-pa-sm q-px-md">Театр</div>
        </div>
        <div class="sortevent">
          <div class="q-pa-sm q-px-md">Концерты</div>
        </div>
        <div class="sortevent">
          <div class="q-pa-sm q-px-md">Выставки</div>
        </div>
        <div class="sortevent">
          <div class="q-pa-sm q-px-md">Кино</div>
        </div>
      </q-tab>
    </q-tabs>
  </div>
</template>

<script>
import { ref, onMounted } from "vue";
import axios from "axios";

export default {};
</script>

<style>
.events .q-tab {
  padding: 0 10px;
}

.sortevent {
  background: rgb(219, 219, 219);
  color: black;
  font-size: 12px;
  border-radius: 30px;
  margin-right: 10px;
}

.tab .q-tabs {
  background: none !important;
}
</style>
