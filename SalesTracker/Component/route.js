
/// <reference path="../Assets/Script/angular.js" />
/// <reference path="../Assets/Script/angular-route.js" />

/// <reference path="module.js" />
/// <reference path="route.js" />


angular.module('mainApp')
.config(function ($routeProvider) {
    $routeProvider
.when('/', { templateUrl: 'Home/home.html', controller: 'homeCtrl as home' })
.when('/AddBuyer', { templateUrl: './Component/AddBuyer/Buyer.html', controller: 'buyerCtrl as buyer' })
.when('/AddProduct', { templateUrl: './Component/AddProduct/Product.html', controller: 'productCtrl as product' })
.when('/AddSource', { templateUrl: './Component/AddSource/Source.html', controller: 'sourceCtrl as source' })
.when('/AddStatus', { templateUrl: './Component/AddStatus/Status.html', controller: 'statusctrl as status' })
.when('/AddWebsite', { templateUrl: './Component/AddWebsite/Website.html', controller: 'websiteCtrl as website' });
});




