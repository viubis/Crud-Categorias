import { createRouter, createWebHistory } from 'vue-router'
import ListaCategoria from '../views/ListaCategorias.vue'

const routes = [
  {
    path: '/',
    name: '',
    component: ListaCategoria
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
