var cartModule = angular.module('cart', ['common', 'ngAnimate', 'ui.bootstrap'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/cart', { templateUrl: '/App/Cart/Views/CartPersonalDetails.html', controller: 'cartPersonalDetailsVM' });
        $routeProvider.when('/cart/personal-details', { templateUrl: '/App/Cart/Views/CartPersonalDetails.html', controller: 'cartPersonalDetailsVM' });
        $routeProvider.when('/cart/address-details', { templateUrl: '/App/Cart/Views/cartAddressDetails.html', controller: 'cartAddressDetailsVM' });
        $routeProvider.when('/cart/purchase-details', { templateUrl: '/App/Cart/Views/cartPurchaseDetails.html', controller: 'cartPurchaseDetailsVM' });
        $routeProvider.otherwise({ redirectTo: '/cart' });
        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
    });

cartModule.factory('cartService', function ($rootScope, $http, $q, $location, viewModelHelper) { return MyApp.cartService($rootScope, $http, $q, $location, viewModelHelper); });

(function (myApp) {
    var cartService = function ($rootScope, $http, $q, $location, viewModelHelper) {

        var self = this;

        self.cartId = 0;
        self.cartState = {
          personalDetails: {},
          addressDetails: {},
          purchaseDetails: {}
        };

        self.storeCartState = function (modelState) {
          self.cartState = modelState;
        }

        self.getCartState = function () {
          return self.cartState;
        }

        return this;
    };
    myApp.cartService = cartService;
}(window.MyApp));
