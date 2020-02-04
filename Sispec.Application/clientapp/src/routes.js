import Home from './components/helloworld/HelloWorld.vue';
import Cadastro from './components/cadastro/Cadastro.vue';
import ListarEvento from './components/evento/ListarEvento.vue'

export const routes = [
    { path: '', component: Home },
    { path: '/cadastro', component: Cadastro },
    { path: '/listarevento', component: ListarEvento}
];