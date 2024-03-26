<template>
  <div class="content">
    <main>
      <div class="header">        
        <div class="header-header">
          <h2>Adicionar Categorias</h2>
          <router-link to="/"><button class="button-back">Voltar</button></router-link>
        </div>
      </div>
      <div class="form">
        <form class="form" id="form">
          <div class="field">
            <input-text label="Código" v-model="codigo" :value="codigo" ref="codigo" required />
          </div>
          <div class="field">
            <input-text label="Título" required v-model="titulo" ref="titulo" :value="titulo"/>
          </div>
          <div class="field">
            <input-text-area label="Descrição" required v-model="descricao" ref="descricao" :value="descricao"/>
          </div>
          <button-save type="submit" @click.prevent="addCustomer()" />
        </form>
      </div>
    </main>
  </div>
</template>

<script>
import InputTextArea from '@/components/inputs/InputTextArea.vue';
import InputText from '@/components/inputs/InputText.vue';
import { ButtonSave } from '@/components/buttons';

export default {
  name: 'AdicionarCategorias',
  components: {
    InputTextArea,
    InputText,
    ButtonSave
  },
   data() {
      return {
        codigo: '',
        titulo: '',
        descricao: '',
        id: '',
        editar: ''
      }
    },
}
</script>
<style scoped>
.header {
  display: flex;
  width: 100%;
  flex-direction: column;
}

.header-header {
  display: flex;
  justify-content: space-between;
  width: 98%;
  -webkit-border-vertical-spacing: 10px;
  -webkit-border-horizontal-spacing: 0;
  align-items: center;
  margin-left: 20px;
}

label{
  display: flex;
}

main {
  align-items: flex-start;
  justify-content: center;
}

.content{
  background: #F8F8F8;
}

.button-back{
  background-color: #BFBFBF;
  border: none;
  color: white;
  height: 50px;
  width: 147px;
  font-size: 20px;
  border-radius: 4px;
  margin: 10px;
}

form{
  display:flex;
  align-items: center;
  flex-direction: column;
  padding: 20px; 
  height: 70vh;
}

.field{
  margin: 10px;
}
</style>
