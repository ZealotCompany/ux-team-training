angular.module('app', ['ngRoute', 'ngResource']);

angular.module('app').config(['$routeProvider', '$locationProvider',
    function ($routeProvider, $locationProvider) {

        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });

        $routeProvider.
            when('/drivers', {
                templateUrl: '/app/components/drivers/driver-list.html',
                controller: 'mvDriversCtrl'
            })

    }]);