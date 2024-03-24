<template>
    <div class="navbar">
        <div id="nav">
            <router-link to="/cadastro">
                <div class="logo">
                    <img src="../assets/images/logo.png" alt="Logo" class="logo"> 
                </div>
            </router-link>
        </div>
    </div>
  </template>
  <script>
  export default {
      name: "NavBar",
  }
  </script>
  <style scoped>
  #nav{
      background-color: #4fcb9e;
      display: grid;
      justify-content: left;
      align-content: normal;
  }
  
  .logo {
    display: flex;
    justify-content: center;
  }
  
  .logo img {
    margin: 20px;
    width: 150px;
    height: fit-content;
    justify-items: center;
  } 
  .navbar{
    background-color:  #4fcb9e;
    display: grid;
    justify-content: start;
    align-content: normal;
  }
  
  a, router-link {
    text-decoration: none;
    }
  
  @media (max-width: 800px) {
    .navbar{
      grid-area: n;
      height: 80px;
      display: flex;
      justify-content: center;
      position: absolute;
      bottom: 0;
      width: 100%;
    }
  
    .logo img{
      display: none;
    }
  }
  </style>