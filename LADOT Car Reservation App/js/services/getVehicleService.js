app.factory('getVehicleService',['$http',function($http){
        var apiPath = "https://raw.githubusercontent.com/BaReinhard/LADOT/master/jsonObjects/vehicle_list_not_checkedout.json";
        return $http.get(apiPath);
}]);
