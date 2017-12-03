cartModule.service('addressService', ['$http', function ($http) {

  var baseUrl = 'http://localhost:57847/api/address/';

  this.search = function (searchTerm) {
    return $http.get(baseUrl + searchTerm);
  };

  this.get = function (addressId) {
    return $http.get(baseUrl + addressId);
  };

}])