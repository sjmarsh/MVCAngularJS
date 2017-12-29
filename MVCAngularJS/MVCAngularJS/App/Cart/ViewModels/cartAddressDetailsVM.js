cartModule.controller('cartAddressDetailsVM', ['$scope', 'cartService', 'addressService', 'viewModelHelper', function ($scope, cartService, addressService, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    $scope.cartService = cartService;
  
    $scope.address = {
        addressLine1: "",
        addressLine2: "",
        addressLine3: "",
        location: "",
        state: "",
        postcode: ""
    }

    $scope.addressSearchResult = [];

    var initialize = function () {
        $scope.theMessage = "address details vm is working";
        $scope.addressStatesData = addressStates;
        $scope.address.state = $scope.addressStatesData[0];
    }

  //http://angular-ui.github.io/bootstrap/versioned-docs/1.3.3/

    $scope.searchForAddress = function (searchTerm) {
      $scope.theMessage = "searching for address";
      return addressService.search(searchTerm).then(function success(response) {
        $scope.addressSearchResult = response.data;
        return response.data;
      }, function error(response) {
        $scope.theMessage = "failed to get search results. " + JSON.stringify(response);
      });
    };
    
    
    $scope.onSelect = function ($item, $model, $label) {
      $scope.$item = $item;
      //$scope.$model = $model;
      //$scope.$label = $label;

      getAddress();

    };

    function getAddress(addressId) {
      
      $scope.theMessage = "getting address";

      var storedAddress = $scope.addressSearchResult.find(a => a.AddressId === addressId);

      if (storedAddress) {
        $scope.address.addressLine1 = storedAddress.line1;
        $scope.address.addressLine2 = storedAddress.line2;
        $scope.address.addressLine3 = storedAddress.line3;
        $scope.address.location = storedAddress.location;
        $scope.address.state = storedAddress.state;
        $scope.address.postcode = storedAddress.postcode;
        $scope.theMessage = "using stored address from search result";
      }
      else {
        addressService.get(addressId).then(function success(response) {
          var address = response.data;
          $scope.address.addressLine1 = address.line1;
          $scope.address.addressLine2 = address.line2;
          $scope.address.addressLine3 = address.line3;
          $scope.address.location = address.location;
          $scope.address.state = address.state;
          $scope.address.postcode = address.postcode;
          $scope.theMessage = "looking up address from server";
        }, function error(response) {
          $scope.theMessage = "failed to get address. " + JSON.stringify(response);
        });
      }
    }

    initialize();
}]);
