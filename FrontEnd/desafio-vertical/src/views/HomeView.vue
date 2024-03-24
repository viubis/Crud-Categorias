<template>
  <v-app>
    <nav-bar></nav-bar>
    <v-container>
      <v-btn color="red">Botão Vuetify</v-btn>
    </v-container>
  </v-app>
</template>

<script>
import { defineComponent } from "vue";
import { VBtn } from "vuetify/lib/components/VBtn";
import NavBar from "../components/NavBar.vue";

export default defineComponent({
  name: "HomeView",
  components: {
    VBtn,
    NavBar,
  },
});
</script>
