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

        self.baseUrl = 'http://localhost:57847/api/cart/';

        self.submitCart = function () {
            return $http.post(self.baseUrl, self.cartState);
        }

        return this;
    };
    myApp.cartService = cartService;
}(window.MyApp));