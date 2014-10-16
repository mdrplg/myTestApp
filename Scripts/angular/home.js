angular.module("homeApp", []).controller("homeController", ['$scope','$http','$sce', function ($scope,$http,$sce) {
    $scope.myHtml = '';
    $scope.showResults = false;
    $scope.states = [
        'Alaska', 'Alabama', 'Arizona', 'California', 'Connecticut', 'Kansas','Ohio','Oregon','Washington'
    ];
    $scope.style = ['one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten', 'eleven', 'twelve'];
    $scope.doPost = function () {
        var tval = JSON.stringify($scope.Person);
        
        $http.post("/home/saveMe", { person: tval }).success(function(d, s, h, c) {
            //alert(d);
            $scope.showResults = true;
            $scope.Person = d.newPerson;
        }).error(function(d, s, g, c) {
            alert(s);
        });
    }
    
}]);