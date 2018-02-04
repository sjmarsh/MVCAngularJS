cartModule.controller("cartPurchaseDetailsVM", function ($scope, cartService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    $scope.cartService = cartService;


    var initialize = function () {
        $scope.theMessage = "purchase details vm is working";
   }


    initialize();
});
