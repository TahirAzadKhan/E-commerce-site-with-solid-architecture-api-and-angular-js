app.controller("allproduct",function($scope,$http,$location){
  
  
    //ajax.post("api/login",$scope.data,function(resp){},function(err){});
    $http.get("https://localhost:44360/api/Shop_Product/GetAll")
    .then(function(resp){
      $scope.allproduct = resp.data;
      console.log(resp.data);        
    },function(err){
        console.log(err);
    });
  
  });