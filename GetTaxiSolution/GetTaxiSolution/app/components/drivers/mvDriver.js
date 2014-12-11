angular.module('app').factory('mvDriver',
    function ($resource) {

        var DriverResource = $resource('/api/drivers/:driverID', { id: '@driverID' });

        return DriverResource;
    });