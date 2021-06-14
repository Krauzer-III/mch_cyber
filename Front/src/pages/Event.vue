<template>
  <q-page>
    <div class="container card-more">
      <div class="back flex q-mt-md">
        <router-link to="/" class="chatrout">
          <q-icon
            size="sm"
            name="arrow_back"
            class="material-icons q-pr-sm"
            style="color: black"
        /></router-link>
        <span>Карточка мероприятия</span>
      </div>
      <q-card class="my-card q-mt-md">
        <img src="https://cdn.quasar.dev/img/mountains.jpg" />

        <q-card-section>
          <div class="flex justify-between q-pb-sm">
            <div class="text-h6">Название карточки</div>
            <q-btn flat round color="primary" icon="share" />
            <div>
              <q-rating size="18px" :max="5" color="primary" class="text-black" />
              <span class="text-caption text-grey q-ml-sm">4.2 (551)</span>
            </div>
          </div>
          <q-btn
            class="text-white"
            label="# Ищу с кем пойти"
            style="width: 160px; background: #cc2322; font-size: 12px"
          />
          <div></div>
        </q-card-section>
      </q-card>
      <div class="card-desc q-pt-md">
        <div class="desc-title">Описание</div>
        <div class="text-caption text-grey">
          Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
          incididunt ut labore et dolore magna aliqua.
        </div>
      </div>

      <div class="q-pt-md">
        <q-list>
          <q-item clickable>
            <q-item-section avatar>
              <q-icon color="red" name="event" class="local_movies" />
            </q-item-section>

            <q-item-section>
              <q-item-label>Время проведения</q-item-label>
              <q-item-label caption class="text-green">08:00 - 17:00</q-item-label>
            </q-item-section>
          </q-item>

          <q-item clickable>
            <q-item-section avatar>
              <q-icon color="red" name="phone" />
            </q-item-section>

            <q-item-section>
              <q-item-label>+7 (928) 371 - 43 - 56</q-item-label>
              <q-item-label caption>samsad35@gmail.com</q-item-label>
            </q-item-section>
          </q-item>

          <q-item clickable>
            <q-item-section avatar>
              <q-icon color="red" name="place" class="local_movies" />
            </q-item-section>

            <q-item-section>
              <q-item-label>ул. Ленина 23. оф. 5</q-item-label>
              <q-item-label caption>Москва, Станция метро</q-item-label>
            </q-item-section>
          </q-item>
        </q-list>
      </div>

      <div class="card-desc q-pt-md">
        <div class="desc-title">Подробно о мероприятии</div>
        <div class="text-caption">
          Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
          incididunt ut labore et dolore magna aliqua.
        </div>
      </div>

      <div class="category q-pt-md">
        <div class="flex justify-start justify-between">
          <div class="text-caption text-grey">Категория</div>
          <div class="q-mr-sm">Музей</div>
        </div>
        <div class="flex justify-start justify-between q-mt-xs">
          <div class="text-caption text-grey">Тип мероприятия</div>
          <div class="q-mr-sm">Разовый</div>
        </div>
      </div>

      <div class="card-desc q-pt-md">
        <div class="desc-title">Организатор</div>
        <q-item clickable v-ripple>
          <q-item-section side>
            <q-avatar size="48px">
              <img src="https://cdn.quasar.dev/img/avatar.png" />
            </q-avatar>
          </q-item-section>
          <q-item-section>
            <q-item-label class="q-pb-sm">Анна</q-item-label>
            <div class="flex">
              <q-rating size="18px" :max="1" color="primary" class="text-black" />
              <span class="text-caption text-grey q-ml-sm">4.8 (1.451)</span>
            </div>
          </q-item-section>
          <q-item-section side>
            <div>
              <q-icon size="36px" color="red" name="videocam" class="local_movies" />
              <router-link to="/chat" class="chatrout">
                <q-icon
                  size="28px"
                  color="red"
                  name="message"
                  class="local_movies q-pl-xs"
              /></router-link>
            </div>
          </q-item-section>
        </q-item>
      </div>

      <div class="card-desc q-pt-md">
        <div class="desc-title q-mb-xs">Вы можете:</div>
        <q-list>
          <router-link to="/gallery" style="text-decoration: none">
            <q-item clickable class="more q-mb-xs">
              <q-item-section avatar>
                <q-icon size="32px" color="blue" name="collections" />
              </q-item-section>

              <q-item-section>
                <q-item-label style="color: black">Посмотреть галерею</q-item-label>
                <q-item-label caption
                  >Перед посещением, можно
                  <br />
                  посмотреть фото и видео</q-item-label
                >
              </q-item-section>
            </q-item></router-link
          >

          <q-item clickable class="more">
            <q-item-section avatar>
              <q-icon size="32px" color="green" name="sms" />
            </q-item-section>

            <q-item-section>
              <q-item-label>Написать в чат мероприятия</q-item-label>
              <q-item-label caption
                >Вы можете зайти в общий чат <br />мероприятия для обсуждения
                деталей</q-item-label
              >
            </q-item-section>
          </q-item>

          <q-item clickable class="more">
            <q-item-section avatar>
              <q-icon size="32px" color="orange" name="emoji_events" />
            </q-item-section>

            <q-item-section>
              <q-item-label>Быть активным</q-item-label>
              <q-item-label caption
                >На мероприятии могут вручать <br />
                грамоты и сертефикаты за участие</q-item-label
              >
            </q-item-section>
          </q-item>

          <q-item clickable class="more">
            <q-item-section avatar>
              <q-icon size="32px" color="brown" name="local_parking" />
            </q-item-section>

            <q-item-section>
              <q-item-label>Припарковать автомобиль</q-item-label>
              <q-item-label caption
                >Рядом с местом проведения <br />
                мероприятия есть парковки</q-item-label
              >
            </q-item-section>
          </q-item>
        </q-list>
      </div>

      <div class="card-desc q-pt-md">
        <div class="flex justify-between">
          <div class="desc-title">Отзывы</div>
          <div class="text-red">Смотреть все отзывы</div>
        </div>
        <q-item clickable v-ripple>
          <q-item-section side>
            <q-avatar size="48px">
              <img src="https://cdn.quasar.dev/img/avatar.png" />
            </q-avatar>
          </q-item-section>
          <q-item-section>
            <q-item-label class="q-pb-sm">Анна</q-item-label>
            <div>
              <q-item-label caption
                >Рядом с местом проведения <br />
                мероприятия есть парковки</q-item-label
              >
            </div>

            <div class="flex">
              <q-rating size="18px" :max="1" color="primary" class="text-black" />
              <span class="text-caption text-grey q-ml-sm">4.8</span>
            </div>
          </q-item-section>
        </q-item>
        <q-item clickable v-ripple>
          <q-item-section side>
            <q-avatar size="48px">
              <img src="https://cdn.quasar.dev/img/avatar.png" />
            </q-avatar>
          </q-item-section>
          <q-item-section>
            <q-item-label class="q-pb-sm">Анна</q-item-label>
            <div>
              <q-item-label caption
                >Рядом с местом проведения <br />
                мероприятия есть парковки</q-item-label
              >
            </div>

            <div class="flex">
              <q-rating size="18px" :max="1" color="primary" class="text-black" />
              <span class="text-caption text-grey q-ml-sm">4.8</span>
            </div>
          </q-item-section>
        </q-item>

        <q-item clickable v-ripple>
          <q-item-section side>
            <q-avatar size="48px">
              <img src="https://cdn.quasar.dev/img/avatar.png" />
            </q-avatar>
          </q-item-section>
          <q-item-section>
            <q-item-label class="q-pb-sm">Катя</q-item-label>
            <div>
              <q-item-label caption
                >Рядом с местом проведения <br />
                мероприятия есть парковки</q-item-label
              >
            </div>

            <div class="flex">
              <q-rating size="18px" :max="1" color="primary" class="text-black" />
              <span class="text-caption text-grey q-ml-sm">4.5</span>
            </div>
          </q-item-section>
        </q-item>
      </div>
    </div>
  </q-page>
</template>

<script>
import { defineComponent, ref } from "vue";

export default defineComponent({
  name: "PageIndex",
  setup() {
    return {};
  },
});
</script>

<style>
.back span {
  font-size: 18px;
}

.container .q-card {
  box-shadow: none;
}

.card-more .q-card__section--vert {
  padding: 14px 0;
}

.desc-title {
  font-size: 18px;
}

.more {
  background: rgb(247, 243, 243);
  border-radius: 10px;
}

.chatrout {
  text-decoration: none;
}
</style>
