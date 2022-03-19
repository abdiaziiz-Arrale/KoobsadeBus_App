
<script setup lang="ts">
import Nav from "./pages/Nav.vue";
import { RouterLink,RouterView } from "vue-router";
import { ref } from '@vue/reactivity';

</script>

<template>
<Nav/>
<div class="py-10"></div>
<Suspense>  
<RouterView />

</Suspense>
</template>



