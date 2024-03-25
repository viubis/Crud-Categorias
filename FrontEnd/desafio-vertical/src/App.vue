<template>
  <div class="container">
    <nav-bar/>
  </div>
  <router-view/>
</template>
<script>
import NavBar from '@/components/NavBar.vue';

export default {
  components: {
    NavBar
  }
}
</script>

<style>
* {
  margin: 0;
  padding: 0;
}
.container {
  font-family: 'Jost', sans-serif;
}
@media (min-width: 800px)  {
  .container {
    font-family: 'Jost', sans-serif;
    gap: 10px;
  }
}
</style>
