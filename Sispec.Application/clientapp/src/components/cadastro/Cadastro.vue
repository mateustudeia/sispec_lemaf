<template>
<div id="primeiroApp">

   Contador: {{ contador }}

   <button v-on:click="toggle">{{ acaoContador() }}</button>

</div>
1
2
3
4
5
6
7
<div id="primeiroApp">
 
   Contador: {{ contador }}
 
   <button v-on:click="toggle">{{ acaoContador() }}</button>
 
</div>
</template>
<script>
    var primeiroApp= new Vue({
 
  el: '#primeiroApp',
 
  data: {
 
    contador: 0,
 
    timer: null
 
  },
 
  methods: {
 
    toggle: function toggle() {
 
      if (this.timer) {
 
        clearInterval(this.timer);
 
        this.timer = null;
 
      } else {
 
        this.timer = setInterval(function() {
 
          primeiroApp.contador += 1;
 
        }, 1000);
 
      }
 
    },
 
    acaoContador: function acaoContador() {
 
      if (this.timer) {
 
        return 'parar';
 
      } else {
 
        return 'começar';
 
      }
 
    }
 
  }
 
});
</script>
<style>
#primeiroApp {
 
  display: inline-block;
 
  padding: 10px;
 
  font-size: 36px;
 
  font-family: 'Helvetica Neue', 'Open Sans', sans-serif;
 
}
 
#primeiroApp button {
 
  background: #4c82ff;
 
  border: 0;
 
  color: #FFF;
 
  font-size: 16px;
 
  margin-top: 6px;
 
  padding: 5px 10px;
 
  border-radius: 3px;
 
  display: block;
 
  width: 100%;
 
}
</style>