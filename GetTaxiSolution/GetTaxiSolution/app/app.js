angular.module('app', ['ngRoute', 'ngResource']);

angular.module('app').config(['$routeProvider', '$locationProvider',
    function ($routeProvider, $locationProvider) {

        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });

        var rootPath = '/app/components';

        $routeProvider.
            when('/drivers', {
                templateUrl: rootPath + '/drivers/driver-list.html',
                controller: 'mvDriversCtrl'
            }).
            when('/lala', {
                templateUrl: rootPath + '/drivers/driver-list.html',
                controller: 'mvDriversCtrl'
            })
    }]);