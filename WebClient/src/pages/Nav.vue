<script setup lang="ts">
import { ref } from '@vue/reactivity';
import {RouterLink} from 'vue-router';


let isMenuHidden=ref(true);
</script>


<template>
	<div
		v-if="isMenuHidden === false"
		@click="isMenuHidden = !isMenuHidden"
		class="bg-gray-200 h-screen w-screen fixed md:hidden bg-opacity-25"
	></div>
	<div class="fixed w-full ">
		<nav class="w-full mx-auto bg-gray-100 shadow-md shadow-cyan-200 h-14">
			<div class="flex justify-between items-center px-4 md:pb-6 ">
				<div class="flex space-x-8">
					<div>
<RouterLink to="./Home">
 <span class="block text-transparent bg-gradient-to-r mt-2  from-pink-700 to-amber-500 bg-clip-text font-bold font-serif text-2xl px-2">Koobsade Bus</span>
</RouterLink>
</div>
<ul class="hidden md:flex md:ml-36 mt-4  justify-between space-x-4 ">
<li><RouterLink to="/Home" class="navs text-center">Home</RouterLink>  </li>
  <li><RouterLink to="/Busses" class="navs ">Busses  </RouterLink></li>  
    <li><RouterLink to="/ContactUs" class="navs ">ContactUs  </RouterLink></li>  
</ul>

<div class="hidden md:flex  space-x-2 float-right  mt-2  ">
      <RouterLink to="/" class="btn ml-96">Login</RouterLink>
      <RouterLink to="/" class="btnsign">SignUp</RouterLink>
</div>
<button class="md:hidden text-gray-600 mt-2 " @click="isMenuHidden = !isMenuHidden">
					<svg
						xmlns="http://www.w3.org/2000/svg"
						class="h-6 w-6 ml-52"
						fill="none"
						viewBox="0 0 24 24"
						stroke="currentColor"
					>
						<path
							stroke-linecap="round"
							stroke-linejoin="round"
							stroke-width="2"
							d="M4 6h16M4 12h16M4 18h16"
						/>
					</svg>
				</button>
			</div>
			<div
				class="bg-blue-100 w-64 transform fixed md:hidden left-0 top-0 h-screen transition-transform flex flex-col space-y-10 items-center justify-center"
				:class="{ '-translate-x-64': isMenuHidden }">
			
			
			<RouterLink to="/">
 <span class="block text-transparent bg-gradient-to-r  from-pink-700 to-amber-500 bg-clip-text font-bold font-serif text-2xl px-6">Koobsade Bus</span>
</RouterLink>
		<ul class=" w-64 text-center space-y-7 font-semibold">
    <li ><RouterLink to="/Home" class="navs tracking-widest " @click="isMenuHidden=!isMenuHidden">Home  </RouterLink></li>  
    <li><RouterLink to="/" class="navs " @click="isMenuHidden=!isMenuHidden">Busses  </RouterLink></li>  
    <li><RouterLink to="/" class="navs " @click="isMenuHidden=!isMenuHidden">ContactUs  </RouterLink></li>  
</ul>
<div class=" md:flex space-x-2 items-center">
      <RouterLink to="/" class="btn">Login</RouterLink>
      <RouterLink to="/" class="btnsign">SignUp</RouterLink>
</div>	
			
			</div>

</div>

      </nav>
</div>





</template>