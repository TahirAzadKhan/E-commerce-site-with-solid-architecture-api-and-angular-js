app.controller("deleteproduct",function($scope,$http,$location,$routeParams){
  
  
    $http.delete("https://localhost:44360/api/Shop_Product/Delete"+$routeParams.id)
    .then(function(resp){
      
      $location.path("/shopowner/allproduct");    
      alert("Delete complete");  
    },function(err){
      alert("Product is not deleted");
        console.log(err);
    });
  
  })