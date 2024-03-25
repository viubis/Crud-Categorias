<template>
  <div class="header">
    <div class="back">                 
      <router-link :to="addButtonRouter"><button class="button-add">Adicionar</button></router-link>
    </div>
  </div>
</template>
<script>
export default {
  name: "HeaderList",
  props: {
    addButtonRouter: String
  },
  data(){
    return{
      name:''
    }
  }
}
</script>
<style scoped>
  .header{
    background: #F8F8F8;
    height: 150px;
    border-bottom: 2px solid #E5EBF1;
    display: flex;
    align-items: center;
    justify-content: space-between;
    height: 150px;
  }

  .button-add{
    background-color: #03C874;
    display: flex;
    align-items: center;
    justify-content: center;
    border: 2px solid #03C874;
    color: white;
    border-radius: 5px;
    font-size: 20px;
    width: 155px;
    height: 50px;
    margin: 10px;
  }

  a, router-link {
    text-decoration: none;
    }

@media (max-width: 800px) {
  .button-add{
    display: none;
  }
}
</style>