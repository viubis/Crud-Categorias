<template>
  <div class="content">
      <main>
          <div class="table">        
              <div class="table-header">
                <h2>Lista de Categorias</h2>
                <router-link to="/adicionar"><button class="button-add">Adicionar</button></router-link>
              </div>

              <div class="table-table">
                
                  <table class="content-table">       
                      <thead>
                          <tr>
                              <th>Código</th>
                              <th>Título</th>
                              <th>Descrição</th>
                          </tr>
                      </thead>
          
                      <tbody id="table-body">
                          <tr v-for="(item, index) in listaCategorias" :key="index">
                           
                            <td>{{ item.codigo }}</td>
                            <td>{{ item.titulo }}</td>
                            <td>{{ item.descricao }}</td>
                            <td class="action-buttons"> 
                              <button-edit @click="editar(item.id)"/> 
                              <button-delete  @click="remover(item.id)"/>
                            </td>
                          </tr>
                      </tbody>
          
                  </table>
      
              </div>
          </div>
      </main>
  </div>
</template>
<script>
import CategoriasService from '../common/service/categorias.service.js';
import {ButtonEdit, ButtonDelete} from '@/components/buttons';

export default {
  data() {
    return {
      listaCategorias: [],
      offset: 0,
      total: 0,
      limit: 5,
      isVisible: false,
    }
  },
  components: {
      ButtonEdit, 
      ButtonDelete,
    },
  async mounted(){
    this.listarCategorias();
  },
  methods: { 
    async listarCategorias() {
      const response= await CategoriasService.listar();
      this.listaCategorias = response.data;
      console.log(this.listaCategorias);
      console.log(response);
    },
    reloadPage() {
      window.location.reload();
    },
    async remover(id){
      const confirmDelete = window.confirm("Deseja realmente excluir a Categoria?");
      if(confirmDelete){
        CategoriasService.remover(id);
        this.reloadPage();
      }
    },
    edit(id){
      this.$router.push({
        name: "AdicionarCategorias",
        query: {id,editar: true}
      });
    }
  },
}
</script>
<style scoped>
.table {
  display: flex;
  width: 100%;
  flex-direction: column;
}

.table-table{
  overflow-x: hidden;
  overflow-y: scroll; 
}

.detail{
  display: none;
}

.table-header{
  display: flex;
  align-items: center;
  justify-content: space-between;
  margin-left: 20px;
}

.button-add-responsive{
  display: none;
}

.table-header h2,h3,h4{
  color: #26324B;
}

.content-table {
  margin-left: 10px;
  height: 72vh;
  width: 98%;
  -webkit-border-vertical-spacing: 10px;
  -webkit-border-horizontal-spacing: 0;
}

.content-table thead tr {
  border: 1px solid #d4d7df;
  text-align: left;
}

.content-table th{
  align-items: center;
  font-size: 16px;
  padding: 15px;
  border: none;
  color: #7B828D;
}

.content-table tbody tr {
  height: 5px;
  background-color: #FFFFFF;
  border-radius: 5px;
}

.content-table > tbody > tr > td > div {
  display: flex;
  align-items: center;
  margin: auto;
}

.content-table td{
  padding: 20px;
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

a, router-link {
  text-decoration: none;
  }

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

</style>