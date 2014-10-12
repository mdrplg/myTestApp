angular.module("homeApp", []).controller("homeController", ['$scope', function ($scope) {
    $scope.person = { name: 'Jeffrey Charles Bryant', address: '6229 SW Erickson', city: 'Beaverton', state: 'Oregon', zip: '97008', phones: { home: '503-430-5984', cell: '971-645-6207' } };
    $scope.states = [
        'Alaska', 'Alabama', 'Arizona', 'California', 'Connecticut', 'Kansas','Ohio','Oregon','Washington'
    ];
    $scope.style = ['one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten', 'eleven', 'twelve'];
}]);