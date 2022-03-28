<script setup lang="ts">
</script>
<template>
  <div class="mt-20 flex gap-x-6">
    <img src="../components/images/sbtbsimg.png" alt="" class="max-w-3xl" />
    <div class="w-full">
      <form
        class="
          border-2 border-cyan-300
          shadow-md shadow-cyan-500
          space-y-8
          px-1
        "
      >
        <h1 class="font-3xl text-center font-bold">Booking Form</h1>
        <div class="mt-4">
          <p>
            FullName
            <input
              type="text"
              class="w-96 h-7 ring-2 focus:ring-2 focus:border-cyan-700"
              placeholder="Enter you FullName"
            />
          </p>
        </div>
        <div class="">
          <p>
            phone
            <input
              type="number"
              class="ml-4 w-96 h-7 ring-2 focus:ring-2 focus:border-cyan-700"
              placeholder="Enter you FullName"
            />
          </p>
        </div>
        <div class="px-14">
          <select
            class="py-2 w-full outline-none ring-2 focus:ring-2 rounded-sm h-10"
          >
            <option selected>Dooro Magaalada aad ka baxayso</option>
            <option value="Hargeisa">hargeisa</option>
            <option value="Gabilay">Gabilay</option>
            <option value="Borama">Borama</option>
            <option value="berbera">berbera</option>
            <option value="Burao">Burao</option>
            <option value="Lascanood">Lascanood</option>
            <option value="Ceerigaabo">Ceerigaabo</option>
          </select>
        </div>
        <div class="px-14">
          <select
            class="py-2 w-full outline-none ring-2 focus:ring-2 rounded-sm h-10"
          >
            <option selected>Dooro Magaalada Aad tagayso</option>
            <option value="Hargeisa">hargeisa</option>
            <option value="Gabilay">Gabilay</option>
            <option value="Borama">Borama</option>
            <option value="berbera">berbera</option>
            <option value="Burao">Burao</option>
            <option value="Lascanood">Lascanood</option>
            <option value="Ceerigaabo">Ceerigaabo</option>
          </select>
        </div>
        <div class="px-14">
          <p class="font-1xl">
            Taarikhda Safarka
            <input
              type="datetime-local"
              class="w-96 h-7 ring-2 focus:ring-2 focus:border-cyan-700"
              placeholder="Xiliga aad baxayso"
            />
          </p>
        </div>
        <div class="mt-4"></div>
        <div class="px-20">
          <button class="btnbook">Book</button>
        </div>
      </form>
    </div>
  </div>
  
</template>