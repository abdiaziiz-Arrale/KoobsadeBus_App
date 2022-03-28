
<script setup lang="ts">
import Nav from "./pages/Nav.vue";
import Footer from './pages/Footer.vue'
import { RouterLink,RouterView } from "vue-router";
import { ref } from '@vue/reactivity';

</script>

<template>
<Nav/>
<div class="py-10"></div>
<Suspense>  
<RouterView />

</Suspense>
<Footer />

</template>



