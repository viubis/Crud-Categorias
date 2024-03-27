<template>
  <div class="content">
    <main>
      <div class="header">        
        <div class="header-header">
          <h2 v-if="!this.id">Adicionar Categorias</h2>
          <h2 v-else>Editar Categorias</h2>
          <router-link to="/"><button class="button-back">Voltar</button></router-link>
        </div>
      </div>
      <div class="form">
        <form class="form" id="form">
          <div class="field">
            <input-number label="Código" v-model="codigo" :value="codigo" ref="codigo" required />
          </div>
          <div class="field">
            <input-text label="Título" required v-model="titulo" ref="titulo" :value="titulo"/>
          </div>
          <div class="field">
            <input-text-area label="Descrição" required v-model="descricao" ref="descricao" :value="descricao"/>
          </div>
          <button-save type="submit" @click.prevent="addCategorias()" />
        </form>
      </div>
    </main>
  </div>
</template>

<script>
import InputTextArea from '@/components/inputs/InputTextArea.vue';
import InputText from '@/components/inputs/InputText.vue';
import { ButtonSave } from '@/components/buttons';
import CategoriasService from '@/common/service/categorias.service';
import InputNumber from '../components/inputs/InputNumber.vue';

export default {
  name: 'AdicionarCategorias',
  components: {
    InputTextArea,
    InputText,
    ButtonSave,
    InputNumber
  },
   data() {
      return {
        codigo: '',
        titulo: '',
        descricao: '',
        id: null,
        editar: ''
      }
    },methods: {
      validateForm(){
        let validate = [];
        validate.push(this.$refs.titulo.validation());
        validate.push(this.$refs.codigo.validation());
        validate.push(this.$refs.descricao.validation());
        return validate.filter((element) => element==false).length == 0;
      },
      addCategorias(){
        console.log(this.id);
        if(this.validateForm()){
          if(this.id == undefined || this.id == null){
            const body = {
              codigo: this.codigo,
              titulo: this.titulo,
              descricao: this.descricao
            }
            CategoriasService.adicionar(body);
            this.$router.push('/');
            return;
          } else{
            const body = {
              id: this.id,
              codigo: this.codigo,
              titulo: this.titulo,
              descricao: this.descricao
            }

            CategoriasService.atualizar(body);
            this.$router.push('/');
            return
          }
        }
        alert('Valide o formulario');
      }
    },
    async mounted(){
      this.id = this.$route.query.id;
      this.editar = this.$route.query.editar;
      if(this.id !== undefined && this.id !== null){
        let response = await CategoriasService.obter(this.id);
        this.titulo = response.data.data.titulo;
        this.codigo = response.data.data.codigo;
        this.descricao = response.data.data.descricao;
      }else{
        return;
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
