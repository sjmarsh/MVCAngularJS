cartModule.controller("rootViewModel", function ($scope, cartService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    // This is the parent controller/viewmodel for 'cartModule' and its $scope is accesible
    // down controllers set by the routing engine. This controller is bound to the Cart.cshtml in the
    // Home view-folder.

    $scope.viewModelHelper = viewModelHelper;
    $scope.cartService = cartService;
    
    $scope.menuItems = [
        { title: 'Personal Details', position: 1, isActive: true, action: function () { return $scope.personalDetails() }, path: 'cart/personal-details' },
        { title: 'Address Details', position: 2, isActive: false, action: function () { return $scope.addressDetails() }, path: 'cart/address-details' },
        { title: 'Purchase Details', position: 3, isActive: false, action: function () { return $scope.purchaseDetails() }, path: 'cart/purchase-details' },
    ]
      
    var initialize = function () {
        $scope.pageHeading = "Shopping Cart";
    }
    
    $scope.personalDetails = function () {

        // TODO: Do this in it's own function.  Also need to call based on url navigation'
        $scope.menuItems[0].isActive = true;
        $scope.menuItems[1].isActive = false;
        $scope.menuItems[2].isActive = false;

        viewModelHelper.navigateTo($scope.menuItems[0].path);
    }

    $scope.addressDetails = function () {
        // todo validate before navigating

        $scope.menuItems[0].isActive = false;
        $scope.menuItems[1].isActive = true;
        $scope.menuItems[2].isActive = false;

        viewModelHelper.navigateTo($scope.menuItems[1].path);
    }

    $scope.purchaseDetails = function () {

        // todo validate before navigating

        $scope.menuItems[0].isActive = false;
        $scope.menuItems[1].isActive = false;
        $scope.menuItems[2].isActive = true;

        viewModelHelper.navigateTo($scope.menuItems[2].path);
    }

    function navigateTo(index) {
      var menuItemToNavigateTo = $scope.menuItems.find(function (item) { return item.position == index; });
      setAllItemsToInactive();
      menuItemToNavigateTo.isActive = true;

      viewModelHelper.navigateTo(menuItemToNavigateTo.path);
    }
    
    function setAllItemsToInactive() {
      $scope.menuItems.forEach(function (item) {
        item.isActive = false;
      });
    }

    function activeMenuItem() {
      return $scope.menuItems.find(function (item) { return item.isActive == true; });
    }

    $scope.goToNext = function () {
      var activeMenu = activeMenuItem();
      navigateTo(activeMenu.position + 1);
    }

    $scope.canGoNext = function () {
      var activeMenu = activeMenuItem();
      return activeMenu.position !== $scope.menuItems.length;
    }

    $scope.goToPrevious = function () {
      var activeMenu = activeMenuItem();
      navigateTo(activeMenu.position - 1);
    }
    
    $scope.canGoPrevious = function () {
      var activeMenu = activeMenuItem();
      return activeMenu.position !== 1;
    }

    initialize();
});
