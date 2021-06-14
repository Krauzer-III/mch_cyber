<template>
  <q-layout view="lHh Lpr lFf">
    <q-header>
      <q-toolbar-title
        ><div class="header flex q-pa-sm items-center justify-between">
          <div class="logo flex">
            <q-btn
              flat
              @click="drawer = !drawer"
              round
              dense
              icon="menu"
              class="q-mr-md"
            />
            <svg
              xmlns="http://www.w3.org/2000/svg"
              width="20"
              height="36"
              fill="currentColor"
              class="bi bi-chat-square q-mr-xs"
              viewBox="0 0 16 16"
            >
              <path
                d="M14 1a1 1 0 0 1 1 1v8a1 1 0 0 1-1 1h-2.5a2 2 0 0 0-1.6.8L8 14.333 6.1 11.8a2 2 0 0 0-1.6-.8H2a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1h12zM2 0a2 2 0 0 0-2 2v8a2 2 0 0 0 2 2h2.5a1 1 0 0 1 .8.4l1.9 2.533a1 1 0 0 0 1.6 0l1.9-2.533a1 1 0 0 1 .8-.4H14a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2z"
              /></svg
            >mos.ru
          </div>

          <div class="avatar">
            <div>
              <q-icon size="sm" name="o_notifications" class="material-icons q-pr-sm" />
              <q-icon size="sm" name="message" />
              <q-avatar size="40px" class="q-ml-md">
                <img src="https://cdn.quasar.dev/img/avatar.png" />
              </q-avatar>
            </div>
          </div></div
      ></q-toolbar-title>
    </q-header>

    <q-drawer
      v-model="drawer"
      :width="200"
      :breakpoint="500"
      overlay
      bordered
      class="bg-grey-3"
    >
      <q-scroll-area class="fit">
        <q-list>
          <template v-for="(menuItem, index) in menuList" :key="index">
            <q-item clickable :active="menuItem.label === 'Outbox'" v-ripple>
              <q-item-section avatar>
                <q-icon :name="menuItem.icon" />
              </q-item-section>
              <q-item-section>
                {{ menuItem.label }}
              </q-item-section>
            </q-item>
            <q-separator :key="'sep' + index" v-if="menuItem.separator" />
          </template>
        </q-list>
      </q-scroll-area>
    </q-drawer>

    <q-footer>
      <q-tabs class="q-py-xs routf">
        <q-route-tab to="/">
          <q-icon size="22px" name="home" class="material-icons" />
          Главная
        </q-route-tab>
        <q-route-tab to="/your/your">
          <q-icon size="22px" name="o_request_quote" class="material-icons" />
          Акции
        </q-route-tab>
        <q-route-tab to="/your/your">
          <q-icon size="22px" name="work" class="material-icons" />
          Мой досуг
        </q-route-tab>
        <q-route-tab to="/your/your">
          <q-icon size="22px" name="credit_score" class="material-icons" />
          Платежи
        </q-route-tab>
        <q-route-tab to="/your/your">
          <q-icon size="22px" name="account_circle" class="material-icons" />
          Кабинет
        </q-route-tab>
      </q-tabs>
    </q-footer>

    <q-page-container>
      <router-view />
    </q-page-container>
  </q-layout>
</template>

<script>
import { defineComponent, ref } from "vue";
import { useRouter } from "vue-router";

const menuList = [
  {
    icon: "inbox",
    label: "Сообщения",
    separator: true,
  },
  {
    icon: "send",
    label: "Последние",
    separator: false,
  },
  {
    icon: "settings",
    label: "Настройки",
    separator: false,
  },
  {
    icon: "help",
    iconColor: "primary",
    label: "Помощь",
    separator: false,
  },
];

export default defineComponent({
  name: "MainLayout",

  components: {},

  setup() {
    const router = useRouter();
    return {
      pushAuth() {
        router.push("/auth");
      },
      drawer: ref(),
      menuList,
    };
  },
});
</script>

<style>
.q-page-container {
  padding-top: 30px !important;
  padding-bottom: 3px !important;
}
.q-tab {
  padding: 0;
}

.q-tab__content {
  font-size: 10px;
}

.header .q-toolbar {
  width: 30px;
}

.routf {
  text-decoration: none;
}

.q-tab--active .q-tab__indicator {
  opacity: 0;
}
</style>
