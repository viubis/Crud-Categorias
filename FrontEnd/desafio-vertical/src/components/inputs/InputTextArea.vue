<template>
    <div>
        <div class="field">
            <label for="label">{{label}}</label>
            <textarea type="text" v-model="content" @input="input" :class="validateInput"> </textarea>  
            <small v-if="state == false">Preencha o campo {{ label }}.</small>
        </div>
   </div>
</template>
<script>
export default {
  name: "InputTextArea",
  props: {
    label: String,
    value: { type: [String,Number], default: null},
    required: { type: Boolean, default: false },
    valueInput: { type: [String,Number]}
  }, 
  computed: {
    validateInput(){
      if (this.state === false) return "field-error";
      return null;
    }
  },
  watch: {
    value(){
      this.content = this.value;
    }
  },
  data() {
    return {
      content: '',
      state: null,
    }
  },
  methods: {
    input() {
      this.$emit("update:modelValue", this.content);
    },
    validation(){
      if(this.required && this.content.length == 0){
        this.state = false;
        return false;
      }
      this.state = true;
      return true;
    }
  }
}
</script>
<style scoped>
  .field{
    display: flex;
    flex-direction: column;
  }
  
  .field label{
    color: #7B828D;
  }
  
  textarea{
    width: calc(100vw / 2);
    border: 1px solid #E5EBF1;
    border-radius: 4px;
    height: 100px;
  }

  .field-success {
    border: 3px solid #4ECA64;
  }
  
  .field-error {
    border: 3px solid #DB5A5A;
  }
  
  .field small{
    color: #DB5A5A;
  }
</style>