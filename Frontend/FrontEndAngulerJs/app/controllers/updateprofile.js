app.controller("updateprofile",function($scope,$http,$location){
       
    $scope.updateprofile=function(){
      
         //ajax.post("api/login",$scope.data,function(resp){},function(err){});
       
        
          $location.path("/shopowner/Home");
           
             
         
     
    };
});