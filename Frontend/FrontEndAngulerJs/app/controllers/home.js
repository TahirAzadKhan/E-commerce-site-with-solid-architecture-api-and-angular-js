app.controller("hprofile",function($scope,$http,$location){
  
    var id = localStorage.getItem("User_Id")
    //ajax.post("api/login",$scope.data,function(resp){},function(err){});
    $http.get("https://localhost:44360/api/ShopOwner/Get/" + id)
    .then(function(resp){
      $scope.hprofile = resp.data;        
    },function(err){
        console.log(err);
    });

});