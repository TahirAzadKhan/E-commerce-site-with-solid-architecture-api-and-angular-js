app.controller("login",function($scope,$http,$location){
  $scope.login=function(){
      //ajax.post("api/login",$scope.data,function(resp){},function(err){});
      $http.post("https://localhost:44360/api/Shop/Login",$scope.data)
      .then(function(resp){
          console.log(resp.data);
          localStorage.setItem("token",resp.data.AccessToken);
          localStorage.setItem("User_Id",resp.data.User_Id);
          
          
          $location.path("/shopowner/Home");
      },function(err){
          console.log(err);
      });
  };
});