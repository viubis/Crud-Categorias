/* eslint-disable */
<template>
  <v-app-bar :elevation="0">
    <template v-slot:prepend>
      <v-app-bar-nav-icon></v-app-bar-nav-icon>
    </template>
    <v-app-bar-title>Vertical TI</v-app-bar-title>
  </v-app-bar>
</template>

<script>
import { VAppBar, VAppBarNavIcon } from "vuetify/lib/components/VAppBar";
export default {
  name: "NavBar",
  components: {
    VAppBar,
    VAppBarNavIcon,
  },
};
</script>

<style></style>
