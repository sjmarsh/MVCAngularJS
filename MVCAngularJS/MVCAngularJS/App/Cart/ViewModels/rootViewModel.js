cartModule.controller("rootViewModel", function ($scope, cartService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    // This is the parent controller/viewmodel for 'cartModule' and its $scope is accesible
    // down controllers set by the routing engine. This controller is bound to the Cart.cshtml in the
    // Home view-folder.

    $scope.viewModelHelper = viewModelHelper;
    $scope.cartService = cartService;
    
    $scope.menuItems = [
        { title: 'Personal Details', position: 1, isActive: true, action: function () { return $scope.personalDetails() } },
        { title: 'Address Details', position: 2, isActive: false, action: function () { return $scope.addressDetails() } },
        { title: 'Purchase Details', position: 3, isActive: false, action: function () { return $scope.purchaseDetails() } },
    ]

    //$scope.flags = { shownFromList: false };

    var initialize = function () {
        $scope.pageHeading = "Shopping Cart";
    }
    
    $scope.personalDetails = function () {

        // TODO: Do this in it's own function.  Also need to call based on url navigation'
        $scope.menuItems[0].isActive = true;
        $scope.menuItems[1].isActive = false;
        $scope.menuItems[2].isActive = false;

        viewModelHelper.navigateTo('cart/personal-details');
    }

    $scope.addressDetails = function () {
        // todo validate before navigating

        $scope.menuItems[0].isActive = false;
        $scope.menuItems[1].isActive = true;
        $scope.menuItems[2].isActive = false;

        viewModelHelper.navigateTo('cart/address-details');
    }

    $scope.purchaseDetails = function () {

        // todo validate before navigating

        $scope.menuItems[0].isActive = false;
        $scope.menuItems[1].isActive = false;
        $scope.menuItems[2].isActive = true;

        viewModelHelper.navigateTo('cart/purchase-details');
    }

    /*
    $scope.showProduct = function () {
        if (productService.productId != 0) {
            $scope.flags.shownFromList = false;
            viewModelHelper.navigateTo('product/show/' + productService.productId);
        }
    }
    */
    initialize();
});
