<script setup lang="ts">

import { ref } from 'vue';
import DriverCard from '../components/DriverCard.vue';
import { Driver } from '../Models/Driver';

 let driver = ref<Driver[]>([])
 const Responce = await fetch('https://localhost:7257/BusDriver');
 const result =await Responce.json();
driver.value = result;
console.log("list",driver.value);




</script>
<template>

  <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-y-4">
  <DriverCard  v-for="item in driver" :TypeOfBus="item.id"  >
  
  </DriverCard>


  </div>
</template>