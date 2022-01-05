app.controller("registration",function($scope,$http,$location){
       
    $scope.registration=function(){
      
         //ajax.post("api/login",$scope.data,function(resp){},function(err){});
         $http.post("https://localhost:44360/api/ShopOwner/Insert",$scope.data)
         .then(function(resp){
          $location.path("/");
           
             
         },function(err){
             console.log(err);
         });
     };
   });