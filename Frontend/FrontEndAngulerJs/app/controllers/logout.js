app.controller("logout",function($http){
  //localStorage.removeItem('token');
  //include ajax in dependency
  //ajax.get("api/logout",function(resp){},function(err){});
  
  $http.get("https://localhost:44360/api/Logout")
  .then(function(rsp){
      localStorage.removeItem("token");
      $location.path("/Home");
  },function(err){
      console.log(err);
  });

});