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