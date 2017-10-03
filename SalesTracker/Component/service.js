/// <reference path="../Assets/Script/angular.js" />
/// <reference path="../Assets/Script/angular-route.js" />
/// <reference path="module.js" />

angular.module('mainApp')
.service('appService', function ($http) {
    var service = this;
    service.getlead = getlead;
    function getlead()
    {
        return $http.get("http://localhost:18889/api/SalesApi/getBuyer");
    }

});
