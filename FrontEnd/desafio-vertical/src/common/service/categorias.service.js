import ApiService from "../api/api.service";

const CategoriasService = {
    async listarPaginado (limitPag , offset){
        let {data} = await ApiService.list(`Categoria/listar?Limit=${limitPag}&Offset=${offset}`);
        return data;
    },
    async listar (){
        let {data} = await ApiService.list(`Categoria/listar`);
        return data;
    },
    async remover(id){
        let response = await ApiService.delete('Categoria/remover', id);
        return response;
    },

    async adicionar(body){
        let response = await ApiService.post('Categoria/adicionar', body);
        return response;
    },
    async obter(id){
        let response = await ApiService.get('Categoria/obter', id);
        return response;
    },
    async atualizar(body){
        let response = await ApiService.put('Categoria/atualizar', body);
        return response;
    },
}

export default CategoriasService;