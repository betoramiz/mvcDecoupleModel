var app = angular.module('appEmp', []).
controller('controllerEmp', ['$scope', 'factoryEmp', function ($scope, factoryEmp) {
    factoryEmp.Employees().then(function (result) {
        //console.log(result);
        $scope.employees = result;
    });
}]).
factory('factoryEmp',['$http', '$q', function ($http, $q) {
    var method = {};
    
    method.Employees = function () {
        var deferred = $q.defer();
        $http.get('api/employee').success(function (result) {
            deferred.resolve(result);
        });
        return deferred.promise;
    }
    return method;
}]);