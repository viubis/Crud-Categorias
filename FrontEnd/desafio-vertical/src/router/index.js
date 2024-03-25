import { createRouter, createWebHistory } from 'vue-router'
import ListaCategoria from '../views/ListaCategorias.vue'
import AdicionarCategoria from '../views/AdicionarCategorias.vue'

const routes = [
  {
    path: '/',
    name: 'Lista-Categoria',
    component: ListaCategoria,
  },
  {
    path: '/adicionar',
    name: 'Adicionar-Categoria',
    component: AdicionarCategoria,
  },
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
