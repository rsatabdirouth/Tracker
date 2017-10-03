/// <reference path="../../Assets/Script/angular.js" />
/// <reference path="../../Assets/Script/angular-route.js" />
/// <reference path="../module.js" />
/// <reference path="../service.js" />

angular.module('mainApp')
.controller('homeCtrl', function (appService) {
    var vm = this;
    vm.Title = "Buyer";
    vm.Salesdata = [];
   
    alert("test");
   

    function activate() {

        appService.getlead().then(function (res) {
            vm.Salesdata = res.data;
            console.log("data", vm.Salesdata);
            

          
        });

    }
    activate();
});
