app.controller("addproduct",function($scope,$http,$location){
       
    $scope.addproduct=function(){
      
         //ajax.post("api/login",$scope.data,function(resp){},function(err){});
         $http.post("https://localhost:44360/api/Shop_Product/Insert",$scope.data)
         .then(function(resp){
          $location.path("/shopowner/Home");
           
             
         },function(err){
             console.log(err);
         });
     };
   });