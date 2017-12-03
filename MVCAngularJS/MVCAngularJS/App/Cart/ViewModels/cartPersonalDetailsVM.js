cartModule.controller("cartPersonalDetailsVM", function ($scope, cartService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    $scope.cartService = cartService;

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
    }

    initialize();
});
