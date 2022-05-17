<script setup lang="ts">
defineProps<{ name: string, TypeOfBus: string , numberOfseats:string}>();
</script>

<template>
	<div class="mx-8 mt-2 mb-12 md:max-w-lg md:my-12 bg-cyan-500 rounded-lg shadow-lg shadow-cyan-300/50">
		<div class=" md:px-2 py-1">
			<slot>
				<img
					class="shadow-md rounded-lg object-cover transition duration-300 hover:scale-90"
					src="../sahal.jpg"
				/>
			</slot>
		</div>

		<div class="flex flex-col">
			<span class="text-lg text-white px-8"> Darawalka :<span class="text-black font-serif font-bold ml-2">{{name}}</span></span>
			<span class=" text-lg px-8 text-white"> Nooca Gadiidka:<span class="text-black font-serif font-bold ml-2">{{TypeOfBus}}</span></span>
			<span
				class="block text-white font-bold text-sm px-8 mt-2"
			>Kuraasidiisa:<span class="text-black font-serif font-bold ml-2">{{numberOfseats}}</span></span>
		</div>
		<div class="text-center py-10">
			<button name="button" class="bg-blue-800 px-6 py-2 rounded-lg text-white ">Dalbo</button>
		</div>
	</div>
	
</template>