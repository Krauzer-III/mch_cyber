<template>
  <div class="q-pa-md row justify-center">
    <div style="width: 100%; max-width: 400px">
      <q-chat-message
        name="Вы"
        avatar="https://cdn.quasar.dev/img/avatar3.jpg"
        :text="['Привет, как дела?']"
        stamp="7 минут назад"
        sent
        bg-color="amber-7"
      />
      <q-chat-message
        name="Анна"
        avatar="https://cdn.quasar.dev/img/avatar5.jpg"
        :text="['Здравствуйте! Отлично, вы как?', 'Отлично, вы как?']"
        size="6"
        stamp="4 минут назад"
        text-color="white"
        bg-color="green"
      />
      <q-chat-message
        name="Анна"
        avatar="https://cdn.quasar.dev/img/avatar5.jpg"
        :text="['Вам нужна какая-то помощь?']"
        stamp="1 минут назад"
        size="8"
        text-color="white"
        bg-color="green"
      />
    </div>
  </div>
</template>

<script>
export default {};
</script>

<style></style>
