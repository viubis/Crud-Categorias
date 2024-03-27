import { createApp } from "vue";
import axios from "axios";
import VueAxios from "vue-axios";
import { API_URL } from "../config/config";

const app = createApp();
app.use(VueAxios, axios);

const ApiService = {
    init() {
        app.axios.defaults.baseURL = API_URL;
        app.axios.defaults.headers = {
        }
    },
    get(resource, params){
        this.init();
        return app.axios.get(`${resource}/${params}`).then((data) => {
            return data;
        })
        .catch((error) => {
            return error.data;
        })
    },
    list(resource){
        this.init();
        return app.axios.get(`${resource}`).then((data) => {
            return data;
        })
        .catch((error) => {
            return error.data;
        })
    },
    post(resource, info){
        console.log(resource, info);
        this.init();
        return app.axios.post(`${resource}`, info).then((data) => {
            return data;
        })
        .catch((error) => {
            return error.data;
        })
    },
    put(resource, info){
        this.init();
        return app.axios.put(`${resource}`, info).then((data) => {
            return data;
        })
        .catch((error) => {
            return error.data;
        })
    },
    delete(resource, params){
        this.init();
        return app.axios.delete(`${resource}/${params}`).then((data) => {
            return data;
        })
        .catch((error) => {
            return error.data;
        })
    }
}
export default ApiService;
