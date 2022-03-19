<script setup lang="ts">
defineProps<{ name: string, TypeOfBus: string , DriverLiceince:string}>();
</script>

<template>
	<div class="mx-8 mt-2 mb-12 md:max-w-lg md:my-12 bg-cyan-50 rounded-lg shadow-lg shadow-cyan-300/50">
		<div class=" md:px-2 py-1">
			<slot>
				<img
					class="shadow-md rounded-lg object-cover transition duration-300 hover:scale-90"
					src="../sahal.jpg"
				/>
			</slot>
		</div>

		<div class="flex flex-col">
			<span class="font-semibold text-2xl px-8"> Bus No :{{TypeOfBus}}</span>
			<span class="font-semibold text-2xl px-8">{{DriverLiceince}}</span>
			<span
				class="block text-gray-500 text-sm px-8 mt-2"
			>{{ name }}</span>
		</div>
		<div class="text-center py-10">
			<button name="button" class="bg-blue-700 px-6 py-2 rounded-lg ">Dalbo</button>
		</div>
	</div>
</template>