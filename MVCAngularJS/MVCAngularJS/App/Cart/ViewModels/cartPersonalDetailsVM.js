cartModule.controller("cartPersonalDetailsVM", function ($scope, cartService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    $scope.cartService = cartService;
    $scope.cartState = {};

    $scope.personalDetails = {
        title: "",
        firstName: "",
        lastName: "",
        dateOfBith: ""
    };

    $scope.titlesData = [];

    var initialize = function () {
        $scope.theMessage = "personal details vm is working";
        $scope.titlesData = titles;
        $scope.personalDetails.title = $scope.titlesData[0];

      // todo: investigate converting to AngularUI router for better state management
        $scope.cartState = cartService.getCartState();
        $scope.personalDetails = $scope.cartState.personalDetails;
    }
    
    $scope.$on("$destroy", function () {
      // maintain state between pages
      $scope.cartState.personalDetails = $scope.personalDetails;
      cartService.storeCartState($scope.cartState);
    });
    
    initialize();
});
