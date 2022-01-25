
var app = angular.module('studentsTable', ['angularUtils.directives.dirPagination']);

app.controller('HomeCtrl', function ($scope, $http) {
 
    $scope.students = []; //declare an empty array

    $http.get("/Home/getStudents").then(function (response) {
        $scope.students = response.data;
    });
  


    $scope.sort = function (keyname) {
        $scope.sortKey = keyname;   //set the sortKey to the param passed
        $scope.reverse = !$scope.reverse; //if true make it false and vice versa
    }
});



