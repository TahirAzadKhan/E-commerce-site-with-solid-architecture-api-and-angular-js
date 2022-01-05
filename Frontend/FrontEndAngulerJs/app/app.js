var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider){

  $routeProvider

  //public route
  .when("/",{
    templateUrl:"views/pages/home.html",
    // controller:''
  })
  .when("/Products",{
    templateUrl:"views/pages/products.html",
    // controller:''
  })
  .when("/Shoplists",{
    templateUrl:"views/pages/shoplists.html",
    // controller:''
  })
  .when("/Contact",{
    templateUrl:"views/pages/contact.html",
    // controller:''
  })


  // Admin route
  .when("/shopowner",{
    templateUrl:"views/pages/shopowner/login.html",
    controller:'login'
  })
  
  .when("/shopowner/Home",{
    templateUrl:"views/pages/shopowner/home.html",
     controller:'hprofile'
  })
  .when("/shopowner/Profile",{
    templateUrl:"views/pages/shopowner/profile.html",
    controller:'sprofile'
  })
  .when("/shopowner/User/Info",{
    templateUrl:"views/pages/shopowner/userinfo.html",
     //controller:''
  })
  .when("/shopowner/allproduct",{
    templateUrl:"views/pages/shopowner/allproduct.html",
    controller:'allproduct'
  })
  .when("/Login/createnewaccount",{
    templateUrl:"views/pages/shopowner/registration.html",
    controller:'registration'
  })
  .when("/shopowner/addproduct",{
    templateUrl:"views/pages/shopowner/addproduct.html",
    controller:'addproduct'
  })
  .when("/shopowner/Delete/:id",{
    templateUrl:"views/pages/shopowner/allproduct.html",
    controller:'deleteproduct'
  })
  .when("/shopowner/delivery",{
    templateUrl:"views/pages/shopowner/delivery.html",
    //controller:'deleteproduct'
  })
  .when("/shopowner/Update",{
    templateUrl:"views/pages/shopowner/update.html",
    controller:'updateprofile'
  })






  // Shop owner route
  //.when("/ShopownerLogin",{
    //templateUrl:"",
    // controller:''
  //})



  //All logout
  .when("/Logout",{
    templateUrl:"views/pages/home.html",
    controller:'logout'
  })
 // All other case
  .otherwise({
    redirectTo:"/"
});

  
}]);
app.config(function($httpProvider){
  $httpProvider.interceptors.push('interCeptor');
})