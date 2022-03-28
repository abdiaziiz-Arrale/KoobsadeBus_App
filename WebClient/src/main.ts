import { createApp } from 'vue'

import { createRouter, createWebHistory } from 'vue-router';
import App from './App.vue'

import Home from './pages/Home.vue'
import Bus from './pages/Busses.vue'
import ContactUs from './pages/ContactUs.vue'
import login from './pages/login.vue'
import singup from'./pages/Singup.vue'
// import GAuth from 'vue-google-oauth2'

import './assets/style.css'
const router= createRouter({
      routes:[
            { path: '/Home', component: Home},
            { path: '/Busses', component: Bus},
            { path: '/ContactUs', component: ContactUs},
            { path: '/login', component: login},
            { path: '/signup', component: singup},
      ],
      history:createWebHistory()
});
// const gauthOption = {
//       clientId: '610558866435-in4r64h2cpmdln32pgqudabcum3qr3mk.apps.googleusercontent.com',
//       scope: 'profile email',
//       prompt: 'consent',
//       fetch_basic_profile: false
//     }
    
    const app = createApp(App);
    
//   app.use(GAuthh)
// Tell the application to use the router.
app.use(router);
app.mount('#app');
