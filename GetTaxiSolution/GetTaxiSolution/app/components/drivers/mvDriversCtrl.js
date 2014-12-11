angular.module('app').controller('mvDriversCtrl',
    function ($scope, mvDriver) {

        mvDriver.query(function (collection) {
            $scope.drivers = collection;
        });

        $scope.isOverEighteen = function (driver) {
            if (driver.age < 18) {
                return false;
            }

            return true;
        }


    });